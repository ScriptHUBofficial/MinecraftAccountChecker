using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Checker
{
    static class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {
            Console.Title = "Minecraft Win. APİ Checker [>] @! AstatiN";
            Utils.Runner();
            Console.ReadKey();
        }


    }
}
