namespace PurePuzzles2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2-2:
             * for(int i = 4; i >= -4; i--)
            {
                if (i == 0) continue;
                for (int j = 1; j <= Math.Abs(i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (10 - 2 * Math.Abs(i)); k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();


            }*/

            
            int k = 1;
            
            for(int i = 4; i >= -4; i--)
            {        


                k = 5 - Math.Abs(i);
                int o = 1;
                if (i == 0) continue;

                for (int j = 7; j >= -7; j--)
                {
                    o = 8 - Math.Abs(j);
                    if (j == 0) continue;

                    if ((o >= k && o <= (k + o - 1) ) && !(o > (2 * k - 1)))
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(" ");

                    }
   
                }
                Console.WriteLine();

            }


        }
    }
}