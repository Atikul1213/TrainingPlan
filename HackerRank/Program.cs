namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32).ToList();
            int budget = Convert.ToInt32(Console.ReadLine());

            int count = 0, value, temp, len = prices.Count();
            for (int i = 0; i < prices.Count() - 1; i++)
            {
                value = budget - prices[i];
                temp = prices.BinarySearch(value);
                if (temp < 0)
                    temp = ~temp;

                if (temp == len)
                    count = count + (len - i);
                else
                {
                    count = count + (temp - i);
                }
                Console.WriteLine("temp: " + temp + " value: " + value);
            }

            Console.WriteLine("count: " + count);


        }
    }
}





/**
      

         var arrayInput = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int n1 = arrayInput[0];
            int n2 = arrayInput[1];
            int n3 = arrayInput[2];
            int sum1 = 0, sum2 = 0, sum3 = 0;

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack3 = new Stack<int>();

            var input1 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            var input2 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            var input3 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            var value = 0;
            for (int i = input1.Length - 1; i >= 0; i--)
            {
                value = input1[i];
                stack1.Push(value);
                sum1 += value;
            }

            for (int i = input2.Length - 1; i >= 0; i--)
            {
                value = input2[i];
                stack2.Push(value);
                sum2 += value;
            }

            for (int i = input3.Length - 1; i >= 0; i--)
            {
                value = input3[i];
                stack3.Push(value);
                sum3 += value;
            }


            while (true)
            {
                bool check = false;
                int Minsum = Math.Min(sum1, sum2);
                Minsum = Math.Min(Minsum, sum3);
                if (sum1 > Minsum && stack1.Count() > 0)
                {
                    value = stack1.Peek();
                    sum1 -= value;
                    check = true;
                    stack1.Pop();
                }

                if (sum2 > Minsum && stack2.Count() > 0)
                {
                    value = stack2.Peek();
                    sum2 -= value;
                    check = true;
                    stack2.Pop();
                }

                if (sum3 > Minsum && stack3.Count() > 0)
                {
                    value = stack3.Peek();
                    sum3 -= value;
                    check = true;
                    stack2.Pop();
                }

                if (sum1 == sum2 && sum2 == sum3)
                {
                    Console.WriteLine(Minsum);
                    break;
                }

            }




        var n = Convert.ToInt32(Console.ReadLine());
            string[] Matrix = new string[102];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                Matrix[i] = input;
            }

            var srcDesArray = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            bfs(n, Matrix, srcDesArray);

        public static void bfs(int n, string[] Grid, Int32[] srcDesArray)
        {
            int[] dx = new int[4] { 1, -1, 0, 0 };
            int[] dy = new int[4] { 0, 0, 1, -1 };

            int[][] dist = new int[103][];
            bool[][] visited = new bool[103][];
            for (int i = 0; i <= n; i++)
            {
                dist[i] = new int[103];
                visited[i] = new bool[103];
            }

            var queue = new Queue<KeyValuePair<Int32, Int32>>();
            var take = new KeyValuePair<Int32, Int32>();
            take = new KeyValuePair<Int32, Int32>(srcDesArray[0], srcDesArray[1]);
            dist[srcDesArray[0]][srcDesArray[1]] = 0;
            queue.Enqueue(take);

            while (queue.Any())
            {
                var u = queue.Dequeue();
                int x = u.Key, y = u.Value;
                if (x == srcDesArray[2] && y == srcDesArray[3])
                {
                    Console.WriteLine("Found the  ans: " + dist[x][y]);
                    return;
                }
                visited[x][y] = true;

                for (int i = 0; i < 4; i++)
                {
                    int xx = x + dx[i];
                    int yy = y + dy[i];

                    if (!isValid(xx, yy, n)) continue;
                    if (Grid[xx][yy] == 'X') continue;
                    if (visited[xx][yy]) continue;
                    dist[xx][yy] = dist[x][y] + 1;
                    take = new KeyValuePair<int, int>(xx, yy);
                    queue.Enqueue(take);
                }

            }

        }

        public static bool isValid(int x, int y, int n)
        {
            if (x >= 0 && x < n && y >= 0 && y < n)
                return true;
            return false;
        }
 */