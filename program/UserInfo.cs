using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_Michalev.program
{
    internal class Userinfo
    {
        public string login { get; set; }
        public string pass { get; set; }
        public bool isAdmin { get; set; }
        public bool isNewUser { get; set; }
        public bool isWorker { get; set; }
    }
}
