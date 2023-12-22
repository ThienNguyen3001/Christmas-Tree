using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static int left = 40, top = 7;
        static void SetMauXanhLa(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void SetMauDo(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void ConTro()
        {
            Console.CursorVisible = false;
        }
        static void GotoXY(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }
        static void Cay1()
        {
            GotoXY(left, top); SetMauXanhLa("/\\");

            GotoXY(left - 1, top + 1); SetMauXanhLa("/");
            GotoXY(left, top + 1); Console.WriteLine("*O"); // Mặc định màu trắng
            GotoXY(left + 2, top + 1); SetMauXanhLa("\\");

            GotoXY(left - 2, top + 2); SetMauXanhLa("/");
            GotoXY(left - 1, top + 2); SetMauDo("*o*o");
            GotoXY(left + 3, top + 2); SetMauXanhLa("\\");

            GotoXY(left - 3, top + 3); SetMauXanhLa("/");
            GotoXY(left - 2, top + 3); Console.WriteLine("*o*o*o");
            GotoXY(left + 4, top + 3); SetMauXanhLa("\\");

            GotoXY(left - 4, top + 4); SetMauXanhLa("/");
            GotoXY(left - 3, top + 4); SetMauDo("*o*o*o*o");
            GotoXY(left + 5, top + 4); SetMauXanhLa("\\");

            GotoXY(left - 5, top + 5); SetMauXanhLa("/");
            GotoXY(left - 4, top + 5); Console.WriteLine("*o*     *o");
            GotoXY(left - 1, top + 5); SetMauXanhLa("MARRY");
            GotoXY(left + 6, top + 5); SetMauXanhLa("\\");

            GotoXY(left - 6, top + 6); SetMauXanhLa("/");
            GotoXY(left - 5, top + 6); SetMauDo("*o*o*o*o*o*o");
            GotoXY(left + 7, top + 6); SetMauXanhLa("\\");

            GotoXY(left - 7, top + 7); SetMauXanhLa("/");
            GotoXY(left - 6, top + 7); Console.WriteLine("*o*         *o");
            GotoXY(left - 3, top + 7); SetMauXanhLa("CHRISTMAS");
            GotoXY(left + 8, top + 7); SetMauXanhLa("\\");

            GotoXY(left - 8, top + 8); SetMauXanhLa("/");
            GotoXY(left - 7, top + 8); SetMauDo("*o*o*o*o*o*o*o*o");
            GotoXY(left + 9, top + 8); SetMauXanhLa("\\");

            GotoXY(left - 9, top + 9); SetMauXanhLa("/");
            GotoXY(left - 8, top + 9); Console.WriteLine("*o*o*o*o*o*o*o*o*o");
            GotoXY(left + 10, top + 9); SetMauXanhLa("\\");

            GotoXY(left - 10, top + 10); SetMauXanhLa("/");
            GotoXY(left - 9, top + 10); SetMauDo("*o*o*o        *o*o*o");
            GotoXY(left + 11, top + 10); SetMauXanhLa("\\");

            // Vẽ rễ
            Console.ForegroundColor = ConsoleColor.Yellow;
            GotoXY(left-3, top + 10);
            Console.WriteLine("|      |");
            GotoXY(left - 3, top + 11);
            Console.WriteLine("|      |");
            GotoXY(left - 4, top + 12);
            Console.Write("_|      |_");
            Console.ResetColor();
        }
        static void Cay2()
        {
            GotoXY(left, top); SetMauXanhLa("/\\");

            GotoXY(left - 1, top + 1); SetMauXanhLa("/");
            GotoXY(left, top + 1); SetMauDo("*O"); // Mặc định màu trắng
            GotoXY(left + 2, top + 1); SetMauXanhLa("\\");

            GotoXY(left - 2, top + 2); SetMauXanhLa("/");
            GotoXY(left - 1, top + 2); Console.WriteLine("*o*o");
            GotoXY(left + 3, top + 2); SetMauXanhLa("\\");

            GotoXY(left - 3, top + 3); SetMauXanhLa("/");
            GotoXY(left - 2, top + 3); SetMauDo("*o*o*o");
            GotoXY(left + 4, top + 3); SetMauXanhLa("\\");

            GotoXY(left - 4, top + 4); SetMauXanhLa("/");
            GotoXY(left - 3, top + 4); Console.WriteLine("*o*o*o*o");
            GotoXY(left + 5, top + 4); SetMauXanhLa("\\");

            GotoXY(left - 5, top + 5); SetMauXanhLa("/");
            GotoXY(left - 4, top + 5); SetMauDo("*o*     *o");
            GotoXY(left - 1, top + 5); SetMauXanhLa("MARRY");
            GotoXY(left + 6, top + 5); SetMauXanhLa("\\");

            GotoXY(left - 6, top + 6); SetMauXanhLa("/");
            GotoXY(left - 5, top + 6); Console.WriteLine("*o*o*o*o*o*o");
            GotoXY(left + 7, top + 6); SetMauXanhLa("\\");

            GotoXY(left - 7, top + 7); SetMauXanhLa("/");
            GotoXY(left - 6, top + 7); SetMauDo("*o*         *o");
            GotoXY(left - 3, top + 7); SetMauXanhLa("CHRISTMAS");
            GotoXY(left + 8, top + 7); SetMauXanhLa("\\");

            GotoXY(left - 8, top + 8); SetMauXanhLa("/");
            GotoXY(left - 7, top + 8); Console.WriteLine("*o*o*o*o*o*o*o*o");
            GotoXY(left + 9, top + 8); SetMauXanhLa("\\");

            GotoXY(left - 9, top + 9); SetMauXanhLa("/");
            GotoXY(left - 8, top + 9); SetMauDo("*o*o*o*o*o*o*o*o*o");
            GotoXY(left + 10, top + 9); SetMauXanhLa("\\");

            GotoXY(left - 10, top + 10); SetMauXanhLa("/");
            GotoXY(left - 9, top + 10); Console.WriteLine("*o*o*o        *o*o*o");
            GotoXY(left + 11, top + 10); SetMauXanhLa("\\");

            // Vẽ rễ
            Console.ForegroundColor = ConsoleColor.Yellow;
            GotoXY(left - 3, top + 10);
            Console.WriteLine("|      |");
            GotoXY(left - 3, top + 11);
            Console.WriteLine("|      |");
            GotoXY(left - 4, top + 12);
            Console.Write("_|      |_");
            Console.ResetColor();
        }
        static void CayNoel()
        {
            int i = 15;
            while (i >0)
            {
                Cay1();
                Thread.Sleep(800);
                Cay2();
                Thread.Sleep(800);
                i--;
            }

        }
        static void Main(string[] args)
        {
            ConTro();
            Thread cay = new Thread(CayNoel);
            Thread nhac = new Thread(Nhac);
            nhac.Start();
            cay.Start();
        }
        static void BeepWithDelay(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }
        static double Nhan2So(double a , double b)
        {
            return a * b;
        }
        static void Nhac()
        {
            // We wish you... 1
            //Console.Write("We ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("wish ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("you ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("a ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("Mer");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("ry ");
            BeepWithDelay((int)(247 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("Christ");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 500);
            //Console.WriteLine("mas");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 700);

            // We wish you... 2
            //Console.Write("We ");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("wish ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("you ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("a ");
            BeepWithDelay((int)(330 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("Mer");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("ry ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("Christ");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 500);
            //Console.WriteLine("mas");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 700);

            // We wish you... 3
            //Console.Write("We ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("wish ");
            BeepWithDelay((int)(330 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("you ");
            BeepWithDelay((int)(330 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("a ");
            BeepWithDelay((int)(349 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("Mer");
            BeepWithDelay((int)(330 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("ry ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("Christ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 500);
            //Console.WriteLine("mas");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 700);

            // And a HPNY
            //Console.Write("And ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("a ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 400);
            //Console.Write("Hap");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("py ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("New ");
            BeepWithDelay((int)(247 * Nhan2So(2, 1.0595)), 500);
            //Console.WriteLine("Year");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 900);
            Thread.Sleep(300);

            // Good tidings to you
            //Console.Write("Good ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("ti");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 400);
            //Console.Write("dings ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 400);
            //Console.Write("to ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 400);
            //Console.WriteLine("you");
            BeepWithDelay((int)(247 * Nhan2So(2, 1.0595)), 900);
            Thread.Sleep(50);

            // Wherever you are
            //Console.Write("Wher");
            BeepWithDelay((int)(247 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("e");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("ver ");
            BeepWithDelay((int)(247 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("you ");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 500);
            //Console.WriteLine("are");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 900);
            Thread.Sleep(100);

            // Good tidings for X-max
            //Console.Write("Good ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("ti");
            BeepWithDelay((int)(330 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("dings ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 400);
            //Console.Write("for ");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 400);
            //Console.Write("Christ");
            BeepWithDelay((int)(392 * Nhan2So(2, 1.0595)), 400);
            //Console.WriteLine("mas");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 900);
            Thread.Sleep(100);

            // And a HPNY
            //Console.Write("And ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 300);
            //Console.Write("a ");
            BeepWithDelay((int)(196 * Nhan2So(2, 1.0595)), 400);
            //Console.Write("Hap");
            BeepWithDelay((int)(220 * Nhan2So(2, 1.0595)), 500);
            //Console.Write("py ");
            BeepWithDelay((int)(294 * Nhan2So(2, 1.0595)), 500);
           // Console.Write("New ");
            BeepWithDelay((int)(247 * Nhan2So(2, 1.0595)), 500);
            //Console.WriteLine("Year");
            BeepWithDelay((int)(262 * Nhan2So(2, 1.0595)), 900);
        }
    }
}