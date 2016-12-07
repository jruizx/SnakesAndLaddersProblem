namespace SnakesAndLaders
{
    public class Node
    {
        public int SquareValue { get; set; }
        public bool Visited { get; set; }
        public int[] Adjacents { get; set; }

        public Node Parent { get; set; }
        public int BoardSize { get; set; }

        public bool IsFinal { get; set; }

        public Node(int value, int boardSize)
        {
            if (value == boardSize - 1) IsFinal = true;

            SquareValue = value + 1;
            Adjacents = new int[6];
            BoardSize = boardSize;

            for (var i = 0; i < 6; i++)
            {
                var adjacent = value + 1 + i;

                if (adjacent > boardSize - 1) Adjacents[i] = -1;
                else Adjacents[i] = adjacent;
            }
        }

        public void SetLadder(int end)
        {
            if(end == BoardSize - 1)
            {
                IsFinal = true;
            } 

            for (var i = 0; i < 6; i++)
            {
                if(end == BoardSize - 1)
                {
                    Adjacents[i] = -1;
                }
                else
                {
                    var adjacent = end + i + 1;

                    if (adjacent > BoardSize - 1)
                    {
                        Adjacents[i] = -1;
                    }
                    else
                    {
                        Adjacents[i] = adjacent;
                    }
                }
            }
        }

        public void SetSnake(int end)
        {
            for (var i = 0; i < 6; i++)
            {
                int adjacent = end + i + 1;

                if (adjacent > BoardSize - 1)
                {
                    Adjacents[i] = -1;
                }
                else
                {
                    Adjacents[i] = adjacent;
                }
            }
        }
    }
}
