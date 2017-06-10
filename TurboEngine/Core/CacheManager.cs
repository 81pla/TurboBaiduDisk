using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboEngine.Core
{
    class CacheManager
    {
        public bool UseDiskCache { get; set; } = true;
        public long MinWriteSize { get; set; } = 1024 * 1024 * 8;
        public string FilePath { get; private set; }


        private string TEDFilePath => FilePath + ".ted";
        private string TEPFilePath => FilePath + ".tep";

        FileStream fs;
        FileStream pfs;
        BinaryWriter progressWriter;
        object writeLock;
        Dictionary<Chunk, byte[]> diskCache = new Dictionary<Chunk, byte[]>();
        public CacheManager(string absFilePath)
        {
            FilePath = absFilePath;
            if (File.Exists(FilePath))
                File.Delete(FilePath);

            fs = new FileStream(TEDFilePath, FileMode.OpenOrCreate);
            if(File.Exists(TEPFilePath))
            {
                if(new FileInfo(TEPFilePath).Length > 0)
                {
                    pfs = new FileStream(TEPFilePath, FileMode.OpenOrCreate);
                    progressWriter = new BinaryWriter(pfs);
                    progressWriter.Seek(0, SeekOrigin.End);
                }
                else
                {
                    pfs = new FileStream(TEPFilePath, FileMode.Create);
                    progressWriter = new BinaryWriter(pfs);
                    progressWriter.Write(ChunkManager.CHUNK_SIZE);
                }
            }
            else
            {
                pfs = new FileStream(TEPFilePath, FileMode.Create);
                progressWriter = new BinaryWriter(pfs);
                progressWriter.Write(ChunkManager.CHUNK_SIZE);
            }

            writeLock = new object();
        }

        public void FinishChunk(byte[] chunkData, Chunk chunk)
        {
            lock (writeLock)
            {
                if (UseDiskCache)
                {
                    diskCache.Add(chunk, chunkData);
                    long cachedLength = ChunkManager.CHUNK_SIZE * diskCache.Count;
                    if (cachedLength > MinWriteSize)
                        FlushCache();
                }
                else
                    WriteChunk(chunkData, chunk);
            }
        }
        private void WriteChunk(byte[] chunkData, Chunk chunk)
        {
            fs.Seek(chunk.Start, SeekOrigin.Begin);
            fs.Write(chunkData, 0, chunkData.Length);
            progressWriter.Write(chunk.Start);
        }
        private void FlushCache()
        {
            foreach(KeyValuePair<Chunk, byte[]> cacheItem in diskCache)
                WriteChunk(cacheItem.Value, cacheItem.Key);
            diskCache.Clear();
        }
        public void Finish()
        {
            lock (writeLock)
            {
                FlushCache();
                fs.Close();
                pfs.Close();
                //if (File.Exists(FilePath))
                //    File.Delete(FilePath); //bug fix "当文件已存在时，无法创建该文件。"
                File.Move(TEDFilePath, FilePath);
                File.Delete(TEPFilePath);
            }
        }
        public void Pause()
        {
            lock (writeLock)
            {
                FlushCache();
                fs.Close();
                pfs.Close();
            }
        }
        public void Cancel()
        {
            lock (writeLock)
            {
                fs.Close();
                pfs.Close();
                File.Delete(TEDFilePath);
                File.Delete(TEPFilePath);
            }
        }
    }
}
