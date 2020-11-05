using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanSolver
{
    class AlfaSolver
    {
        char[,] map;
        int w, h;
        List<Brain> directions;

        public struct Brain
        {
            public int x;
            public int y;
            public string path;

            public Brain(int x, int y, string p)
            {
                this.x = x;
                this.y = y;
                path = p;
            }

            public Brain(Place place, string p)
            {
                this.x = place.x;
                this.y = place.y;
                path = p;
            }
        }

        public AlfaSolver(char[,] map)
        {
            this.map = map;
            w = map.GetLength(0);
            h = map.GetLength(1);
            directions = new List<Brain>();
            directions.Add(new Brain(-1, 0, "4"));
            directions.Add(new Brain(1, 0, "6"));
            directions.Add(new Brain(0, -1, "8"));
            directions.Add(new Brain(0, 1, "2"));
        }

        public string MoveAlfa( Place start, Place finish)
        {
            if (start.x == finish.x && start.y == finish.y) return "";
            Queue<Brain> queue = new Queue<Brain>(); // очередь для орг. алгоритма поиска вширь
            List<Place> visited = new List<Place>(); // список вершин, где уже были

            queue.Clear();
            visited.Clear();

            Brain brain;
            brain.x = start.x;
            brain.y = start.y;
            brain.path = "";

            Place place;
            queue.Enqueue(brain);

            while (queue.Count > 0)
            {
                brain = queue.Dequeue();
                foreach (Brain side in directions)
                {
                    place.x = brain.x + side.x;
                    place.y = brain.y + side.y;
                    if (!InRange(place))
                        continue;
                    if (visited.Contains(place))
                        continue;
                    visited.Add(place);

                    Brain step = new Brain(place, brain.path + side.path);

                    if (place.Equals(finish))
                        return step.path;

                    queue.Enqueue(step);

                }
            }
            return "-";
        }
        bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w)
                return false;
            if (place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] != ' ')
                return false;
            return true;
        }
    }
}
