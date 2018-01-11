using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi;
namespace TestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Champion.GetListAsync().Result;
        }
    }
}
