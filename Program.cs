using System.Windows.Markup;

namespace ConsoleDrawer
{
    internal class Program
    {
        /*
         * TÍPUSOK
         * int: egész számok
         * string: karakterlánc
         * char: karakter
         * bool: logikai értékek (igaz, hamis)
         * double: nem egész számok
         */
        static void Operátorok()
        {
            /*
             * Logikai operátorok
             * ! negálás -> tagadás
             * && és
             * || vagy
             * == egyenlőség
             * != nem egyenlő
             * <
             * >
             * <=
             * >=
             * -----
             * + 
             * - 
             * *
             * /        5/2=2
             * % maradékos osztás -> 5%2=1
             * = értékadás
             */
        }
        /*
         * vezérlési szerkezetek:
         * - szekvencia: utasítások sorozata
         * - elágazás: 
         *      - if 
         *      - switch-case: 
         * - ciklus: ismételt végrehajtás valamilyen típusú feltétel szerint
         *      - while -> végrehajtani ha és amíg
         *      - do-while
         *      - for: számláló -> valahányszor végrehajtani
         *      - foreach: gyűjtemény bejárására
         */
        static void ElágazásMinta()
        {
            char e = 'a';

            if (e == 'a')
            {
                Console.WriteLine("A");
            }
            else if (e == 'b')
            {
                Console.WriteLine("B");
            }
            else if (e == '1' || e == '2')
            {
                Console.WriteLine(12);
            }
            else
            {
                Console.WriteLine();
            }

            switch (e)
            {
                case 'a': Console.WriteLine("A"); break;
                case 'b': Console.WriteLine("B"); break;
                case '1':
                case '2':
                    Console.WriteLine(12);
                    break;
                default: Console.WriteLine(); break;
            }
        }
        static void CiklusMinta()
        {



            do
            {

            } while (true);

            string[] args = new string[3];
            for (int i = 0; i < args.Length; i++)
            {
                //.... ciklusmag
            }


            while (true)
            {
                var result = Console.ReadKey();
                break;
            }
            //int i = 0;
            //while (i < args.Length)
            //{
            //    //.... ciklusmag
            //    i++;
            //}
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            char symbol = '█';
            do
            {
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop != 0)
                        {
                            Console.CursorTop -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop != Console.WindowHeight - 1)
                        {
                            Console.CursorTop += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft != 0)
                        {
                            Console.CursorLeft -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft != Console.WindowWidth - 1)
                        {
                            Console.CursorLeft += 1;
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        var position = Console.GetCursorPosition();
                        Console.Write(symbol);
                        Console.SetCursorPosition(position.Left, position.Top);
                        break;
                    case ConsoleKey.F1:
                        symbol = '█';
                        break;
                    case ConsoleKey.F2:
                        symbol = '▓';
                        break;
                    case ConsoleKey.F3:
                        symbol = '▒';
                        break;
                    case ConsoleKey.F4:
                        symbol = '░';
                        break;

                    case ConsoleKey.D1: Console.ForegroundColor = ConsoleColor.Red; break;
                }
            }
            while (input.Key != ConsoleKey.Escape);


        }
    }
}
