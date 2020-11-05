using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class AppleSolver
    {
        Cell [,] map;
        Cell [,] top;

        int w, h;

        List<Dirs> directions;

        struct MouseApple
        {
            public Place mouse;
            public Place apple;
        }

        public struct Brain
        {
            public Place mouse;
            public Place apple;
            public string path;

            public Brain(Place mouse, Place apple, string p)
            {
                this.mouse = mouse;
                this.apple = apple;
                path = p;
            }


        }

        struct Dirs
        {
            public int x;
            public int y;
            public string path;
            public Dirs(int x, int y, string path)
            {
                this.x = x;
                this.y = y;
                this.path = path;
            }
        }

        public AppleSolver(Cell [,] map, Cell [,] top)
        {
            this.map = map;
            this.top = top;

            w = map.GetLength(0);
            h = map.GetLength(1);
            directions = new List<Dirs>();
            directions.Add(new Dirs(0, 1, "2"));
            directions.Add(new Dirs(-1, 0, "4"));
            directions.Add(new Dirs(1, 0, "6"));
            directions.Add(new Dirs(0, -1, "8"));

        }

        public string MoveApple(Place mouse, Place start, Place finish)
        { // mouse - где находится мышка,
          // start - где находится яблоко, 
          // finish - куда поместить яблоко.

            if (start.x == finish.x && start.y == finish.y) return "";

            top[start.x, start.y] = Cell.none;

            bool[,,,] visited = new bool[w, h, w, h];

            Queue<Brain> queue = new Queue<Brain>(); // очередь для орг. алгоритма поиска вширь
            //Dictionary<MouseApple, bool> visited = new Dictionary<MouseApple, bool>(); // список положений мышки и яблока, где уже были

            queue.Clear();
            // visited.Clear();

            Brain brain;
            brain.mouse = mouse;
            brain.apple = start;
            brain.path = "";

            Place NewMouse;
            Place NewApple;

            queue.Enqueue(brain);

            while (queue.Count > 0)
            {
                brain = queue.Dequeue();
                foreach (Dirs side in directions)
                {
                    NewMouse.x = brain.mouse.x + side.x;
                    NewMouse.y = brain.mouse.y + side.y;

                    if (!InRange(NewMouse))
                        continue;

                    if (NewMouse.x == brain.apple.x &&
                        NewMouse.y == brain.apple.y)
                    {
                        NewApple.x = NewMouse.x + side.x;
                        NewApple.y = NewMouse.y + side.y;
                        if (!InRange(NewApple))
                            continue;
                    }
                    else
                        NewApple = brain.apple;

                    //  MouseApple ma;
                    //  ma.mouse = NewMouse;
                    //  ma.apple = NewApple;

                    if (visited[NewMouse.x, NewMouse.y, NewApple.x, NewApple.y])
                        continue;
                    visited[NewMouse.x, NewMouse.y, NewApple.x, NewApple.y] = true;

                    Brain step = new Brain(NewMouse, NewApple, brain.path + side.path);

                    if (NewApple.x == finish.x &&
                        NewApple.y == finish.y)
                    {
                        top[start.x, start.y] = Cell.abox;
                        return step.path;
                    }
                    queue.Enqueue(step);

                }
            }
            top[start.x, start.y] = Cell.abox;
            return "No";
        }

        bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w)
                return false;
            if (place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] == Cell.none &&
               (top[place.x, place.y] == Cell.none ||
                top[place.x, place.y] == Cell.user))
                return true;
            if (map[place.x, place.y] == Cell.here &&
               (top[place.x, place.y] == Cell.none ||
                top[place.x, place.y] == Cell.user))
                return true;
            return false;
        }
    }
}
