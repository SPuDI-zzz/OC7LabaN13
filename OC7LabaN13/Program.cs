using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OC7LabaN13
{
    internal class Program
    {
        Random random = new Random();
        protected static int origRow;
        protected static int origCol;
        const int col = 25, row = 25;
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        private void MoveCarp()

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart())
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;
            StringBuilder sb = new StringBuilder();
            int[,] Matrix = new int[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    WriteAt(Matrix[i, j].ToString(), j*2+1+65, i);
                }
            }

            sb.Insert(0,"1 действие\n");
            WriteAt(sb.ToString(), 0, 0);
            sb.Insert(0, "2 действие\n");
            WriteAt(sb.ToString(), 0, 0);
            Console.ReadLine();

        }
    }
}
