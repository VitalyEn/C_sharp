using System;
using System.IO;

namespace SokobanTester
{
    class Program
    {
        string file_lab = "labirint.txt";
        string file_sol = "solution.txt";

        static void Main(string[] args)
        {
            Program program = new Program();
            if (program.Run())
                Console.WriteLine("Solution correct");
            else
                Console.WriteLine("Solution wrong");
            Console.ReadKey();
        }

        char[,] map;
        int w, h;
        int ax, ay;
        int ex, ey;
        int px, py;
        string solution;


        public bool Run()
        {
            LoadLabirint();
            LoadSolution();
            PrintLab();
            
            for (int j = 0; j < solution.Length; j++)
            {

                Console.ReadKey();
                switch (solution[j])
                {
                    case '4': if (!MoveMouse(-1, 0))
                            return false;
                        break;
                    case '6': if (!MoveMouse(1, 0))
                            return false;
                        break;
                    case '2': if (!MoveMouse(0, 1))
                            return false;
                        break;
                    case '8': if (!MoveMouse(0, -1))
                            return false;
                        break;
                    default: return false;

                }
                PrintLab();
            }
            return (px == ex && py == ey);
        }

        public bool MoveMouse(int sx, int sy)
        {
            if (ax + sx < 0 || ax + sx >= w)
                return false;
            if (ay + sy < 0 || ay + sy >= h)
                return false;
            if (map[ax + sx, ay + sy] == '#')
                return false;
            if (map[ax + sx, ay + sy] == ' ' ||
                map[ax + sx, ay + sy] == '.')
            {
                ax += sx;
                ay += sy;
                return true;
            }
            if (map[ax + sx, ay + sy] == 'o')
            {
                int bx, by;
                bx = ax + sx * 2;
                by = ay + sy * 2;
                if (bx < 0 || bx >= w)
                    return false;
                if (by < 0 || by >= h)
                    return false;
                if (map[bx, by] == '#')
                    return false;
                if (map[bx, by] == ' ')
                {
                    map[bx, by] = 'o';
                    map[ax + sx, ay + sy] = ' ';
                    ax += sx;
                    ay += sy;
                    px = bx;
                    py = by;
                    return true;
                }
                   
            }

            return true;
        }
        
        public void LoadLabirint()
        {
            map = new char[32, 32];
            string[] lines = File.ReadAllLines(file_lab);
            string[] wh = lines[0].Split();
            w = int.Parse(wh[0]);
            h = int.Parse(wh[1]);
            // Console.WriteLine(w.ToString() + " " + h.ToString());

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                {
                    map[x, y] = lines[y + 1][x];
                    if (map[x, y] == 'A')
                    {
                        ax = x;
                        ay = y;
                        map[x, y] = ' ';
                    } else
                    if (map[x, y] == '.')
                    {
                        ex = x;
                        ey = y;
                        map[x, y] = ' ';
                    }else
                        if(map[x,y] =='o')
                    {
                        px = x;
                        py = y;
                    }

                }
        }

        public void LoadSolution()
        {
            solution = File.ReadAllText(file_sol);
        }

        public void PrintLab()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                    Console.Write(map[x, y]);
                Console.WriteLine();
            }

            Console.SetCursorPosition(ax, ay);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('A');

            Console.SetCursorPosition(ex, ey);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write('.');

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, h + 1);
            Console.WriteLine(solution);
           
        }
    }
}
