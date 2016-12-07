using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLaders
{
    public class Game
    {
        Node[] nodes;
        int boardSize;

        public Game(int boardSize)
        {
            this.boardSize = boardSize;
            nodes = new Node[boardSize];
        }

        public void Initialize()
        {
            for (var i = 0; i < boardSize; i++)
            {
                nodes[i] = new Node(i, boardSize);
            }
        }

        public void SetLadder(int start, int end)
        {
            nodes[start-1].SetLadder(end-1);
        }

        public void SetSnake(int start, int end)
        {
            nodes[start-1].SetSnake(end-1);
        }

        public void VisitNodes()
        {
            Queue<Node> items = new Queue<Node>();
            items.Enqueue(nodes[0]);

            while (items.Any())
            {
                Node current = items.Dequeue();

                foreach (var adjacent in current.Adjacents)
                {
                    if (adjacent > 0 && !nodes[adjacent].Visited)
                    {
                        nodes[adjacent].Visited = true;
                        nodes[adjacent].Parent = current;

                        if (nodes[adjacent].IsFinal)
                        {
                            nodes[boardSize - 1].Visited = true;
                            nodes[boardSize - 1].Parent = current;
                        }

                        items.Enqueue(nodes[adjacent]);
                    }
                }
            }
        }

        public int GetSolution()
        {
            int solution = 0;

            if (!nodes[boardSize - 1].Visited)
            {
                solution = -1;
            }
            else
            {
                var node = nodes[boardSize - 1];

                while (node.Parent != null)
                {
                    solution++;
                    node = node.Parent;
                }

                if (node.SquareValue != 1) solution = -1;
            }

            return solution;
        }
    }
}
