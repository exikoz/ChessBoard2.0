/*
 * AI Tool: Claude (Anthropic)
 * 
 * Question: "How should I think about solving nested pattern problems?"
 * Answer: AI suggested thinking about row+column relationships
 * My modification: I already knew about nested loops and modulo,
 * but AI helped me realize the key insight: (row + col) % 2 determines the pattern
 * 
 */
namespace ChessBoard2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to support chess squares
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("=== Chessboard 2.0 ===");

            int n = ReadSize();

            RenderBoard(n);
        }

        ///<summary>
        /// Read and validates board n
        ///</summary>
        ///<returns>Valid board n</returns>
        ///
        static int ReadSize()
        {

            while (true)
            {
                Console.WriteLine("Ange storlek på schackbrädet (3-50): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int size))
                {
                    // valid range
                    if (size >= 3 && size <= 50)
                    {
                        return size;
                    }
                    Console.WriteLine("Siffran måste vara mellan 3 och 50.");
                }
                else
                {
                    Console.WriteLine("Ogiltlig inmatning. Ange en siffra.");
                }
            }
        }

        /// <summary>
        /// Renders N x N chessboard
        /// </summary>
        /// <param name="n">Board size</param>
        /// 

        static void RenderBoard(int n)
        {
            string black = "◼︎";
            string white = "◻︎";

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write(black);
                    }
                    else
                    {
                        Console.Write(white);
                    }
                }

                Console.WriteLine();
            }
        }

    }
}
