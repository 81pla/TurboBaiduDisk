using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboEngine.Core
{
    class ChunkManager
    {
        public const int CHUNK_SIZE = 1024 * 256;

        private long fileLength;
        private object locker;
        private long chunkOffset;
        private List<long> tepDownloadedList = new List<long>();
        private List<long> giveupChunksList = new List<long>();

        public Dictionary<string, int> giveupMirrorsCount = new Dictionary<string, int>();
        public long TepSavedDownloadedSize => tepDownloadedList.Count * CHUNK_SIZE;

        public ChunkManager(long fileLength, string tepFilePath)
        {
            this.fileLength = fileLength;
            locker = new object();
            chunkOffset = 0;
            //load tep file
            try
            {
                if (File.Exists(tepFilePath))
                {
                    if (new FileInfo(tepFilePath).Length > 0)
                    {
                        BinaryReader reader = new BinaryReader(File.OpenRead(tepFilePath));
                        int chunk_size = reader.ReadInt32();
                        if (chunk_size == CHUNK_SIZE)
                        {
                            while (reader.BaseStream.Position < reader.BaseStream.Length)
                                tepDownloadedList.Add(reader.ReadInt64());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception)
            {
                tepDownloadedList.Clear();
            }
        }

        public bool GiveUpChunk(Chunk chunk, string mirror)
        {
            lock (locker)
            {
                giveupChunksList.Add(chunk.Start);

                if (giveupMirrorsCount.ContainsKey(mirror))
                    giveupMirrorsCount[mirror]++;
                else
                    giveupMirrorsCount.Add(mirror, 1);

                if (giveupMirrorsCount[mirror] >= 3)
                    return true;
                else
                    return false;
            }
        }

        public Chunk GetNextChunk()
        {
            lock (locker)
            {
                if (giveupChunksList.Count > 0)
                {
                    Chunk newChunk = new Chunk(giveupChunksList[0], giveupChunksList[0] + CHUNK_SIZE - 1);
                    giveupChunksList.RemoveAt(0);
                    return newChunk;
                }
                if (chunkOffset > fileLength)
                    return null;
                else
                {
                    Chunk result = new Chunk(chunkOffset, chunkOffset + CHUNK_SIZE - 1);
                    while (tepDownloadedList.Contains(chunkOffset += CHUNK_SIZE))
                        ;
                    return result;
                }
            }
        }
    }
    class Chunk
    {
        public Chunk(long start, long end)
        {
            Start = start;
            End = end;
        }
        public long Start { get; private set; }
        public long End { get; private set; }

    }
}
