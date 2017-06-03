using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Model
{
    public class RenameRequest
    {
        public string path { get; set; }
        public string newname { get; set; }
    }
}
