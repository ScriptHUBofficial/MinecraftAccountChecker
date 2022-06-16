using System;
using System.Drawing;

namespace Minecraft_Checker
{
    class Logo
    {
        //Birinci bölüm renkleri
        static Color _color1 = Color.FromArgb(91, 35, 113);

        //ikinci bölüm renkleri
        static Color _color2 = Color.FromArgb(249, 249, 249);

        //üçüncü bölüm renkleri
        static Color _color3 = Color.FromArgb(74, 127, 41);


        public static void _Show()
        {
            Console.Clear();
            string line = "\t";
            Console.Write("\n\n");
            Colorful.Console.Write(@"       ░░░░░░░░░░░░░░░░░░░░░░░░ Minecraft Checker V1.0 ░░░░░░░░░░░░░░░░░░░░░░░░" + "\n", _color2);
            Colorful.Console.Write(@"                                                                               " + "\n", _color2);
            Colorful.Console.Write(@"       ███╗   ███╗██╗███╗  ██╗███████╗ █████╗ ██████╗  █████╗ ███████╗████████╗" + "\n", _color3);
            Colorful.Console.Write(@"       ████╗ ████║██║████╗ ██║██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝" + "\n", _color3);
            Colorful.Console.Write(@"       ██╔████╔██║██║██╔██╗██║█████╗  ██║  ╚═╝██████╔╝███████║█████╗     ██║   " + "\n", _color3);
            Colorful.Console.Write(@"       ██║╚██╔╝██║██║██║╚████║██╔══╝  ██║  ██╗██╔══██╗██╔══██║██╔══╝     ██║   " + "\n", _color3);
            Colorful.Console.Write(@"       ██║ ╚═╝ ██║██║██║ ╚███║███████╗╚█████╔╝██║  ██║██║  ██║██║        ██║   " + "\n", _color3);
            Colorful.Console.Write(@"       ╚═╝     ╚═╝╚═╝╚═╝  ╚══╝╚══════╝ ╚════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝        ╚═╝   " + "\n", _color3);
            Colorful.Console.Write(@"                                                                               " + "\n", _color2);
            Colorful.Console.Write(@"       ░░░░░░░░░░░░░░░░░░░░░░░░░░░░ $criptHub @Astatin ░░░░░░░░░░░░░░░░░░░░░░░░" + "\n", _color2);


        }
    }
}
