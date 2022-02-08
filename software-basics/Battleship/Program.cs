using System;

namespace Battleship
{
    class Program
    {
        private static int counter = 0, wins = 0;
        private static byte x = 127, y = 127;
        private static void MainMenu()
        {
            bool isNumber = false;
            byte selection = 127;
            
            if (counter == 0)
            {
                Console.WriteLine("Hei! Joko aloitetaan?");
                Console.WriteLine("\n0. Poistu pelistä");
                Console.WriteLine("1. Aloita peli");
                Console.Write("> ");
            }
            else if (counter > 5 && wins <= counter / 2)
            {
                Console.WriteLine("\n\nVieläkö uskallat haastaa?");
                Console.WriteLine("\n0. Poistu pelistä");
                Console.WriteLine("1. Aloita peli");
                Console.Write("> ");
            }
            else
            {
                Console.WriteLine("\n\nVieläkö pelataan?");
                Console.WriteLine("\n0. Poistu pelistä");
                Console.WriteLine("1. Aloita peli");
                Console.Write("> ");
            }

            while (!isNumber)
            {
                try
                {
                    selection = byte.Parse(Console.ReadLine());

                    if (selection >= 0 && selection < 2)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("\nValintaa ei löydy valikosta!");
                        Console.Write("> ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nAnna valinta NUMERONA!");
                    Console.Write("> ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nValintaa ei löydy valikosta!");
                    Console.Write("> ");
                }
            }

            if (selection == 0)
            {
                if (counter == 0)
                {
                    Console.WriteLine("\nNo höh. Heippa!");
                }
                else
                {
                    Console.WriteLine("\nKiitos peleistä!");
                }
                return;
            }
            else
            {
                Game();
            }
        }
        /// <summary>
        /// Creates a 5x5 playing board and handles ships and missiles
        /// </summary>
        private static void Game()
        {
            string[,] board = new string[5, 5];
            Random pool = new Random();
            bool isWinner = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = "WATER";
                }
            }

            board[pool.Next(5), pool.Next(5)] = "CPU";

            Console.WriteLine("\nPelilaudalla on koordinaatit A1-E5 (5x5), joihin asetetaan yhden koordinaatin kokoiset laivat.");
            Console.WriteLine("Mihin koordinaattiin haluat laivasi?");
            Console.Write("> ");

            CheckCoordinates();

            while (board[x, y] == "CPU")
            {
                board[x, y] = null;

                board[pool.Next(5), pool.Next(5)] = "CPU";
            }

            board[x, y] = "PLAYER";

            Console.WriteLine("\nSinun ja tietokoneen laivat ovat nyt pelilaudalla.");

            while (!isWinner)
            {
                int[] cpuMissile = new int[2];
                cpuMissile[0] = pool.Next(5);
                cpuMissile[1] = pool.Next(5);
                bool validTarget = false;
                
                Console.WriteLine("\nMihin koordinaattiin haluat ampua?");
                Console.Write("> ");

                CheckCoordinates();

                while (!validTarget)
                {
                    if (board[x, y] == "PLAYER")
                    {
                        Console.WriteLine("\nUpotit oman laivasi! Hävisit!");

                        counter++;

                        MainMenu();
                        return;
                    }
                    else if (board[x, y].Contains("PLAYER MISS"))
                    {
                        Console.WriteLine("\nOlet jo ampunut sinne! Valitse uusi kohde:");
                        Console.Write("> ");

                        CheckCoordinates();
                    }
                    else
                    {
                        validTarget = true;
                    }
                }

                validTarget = false;

                if (board[x, y] == "CPU")
                {
                    Console.WriteLine("\nOsui ja upposi! Olet voittanut!");

                    isWinner = true;

                    counter++;
                    wins++;

                    MainMenu();
                }
                else if (board[x, y].Contains("CPU MISS"))
                {
                    Console.WriteLine("\nEi osumaa.");

                    board[x, y] = board[x, y] + " + PLAYER MISS";
                }
                else
                {
                    Console.WriteLine("\nEi osumaa.");

                    board[x, y] = "PLAYER MISS";
                }

                Console.WriteLine("\nTietokone ampui ohjuksia!");

                while (!validTarget)
                {
                    if (board[cpuMissile[0], cpuMissile[1]] == "CPU")
                    {
                        cpuMissile[0] = pool.Next(5);
                        cpuMissile[1] = pool.Next(5);
                    }
                    else if (board[cpuMissile[0], cpuMissile[1]].Contains("CPU MISS"))
                    {
                        cpuMissile[0] = pool.Next(5);
                        cpuMissile[1] = pool.Next(5);
                    }
                    else
                    {
                        validTarget = true;
                    }
                }

                if (board[cpuMissile[0], cpuMissile[1]] == "PLAYER")
                {
                    Console.WriteLine("\nTietokoneen ohjus osui ja laivasi upposi. Tietokone voitti!");

                    isWinner = true;

                    counter++;

                    MainMenu();
                }
                else if (board[cpuMissile[0], cpuMissile[1]].Contains("PLAYER MISS"))
                {
                    Console.WriteLine("\nTietokoneen ohjus ei osunut.");

                    board[cpuMissile[0], cpuMissile[1]] = board[cpuMissile[0], cpuMissile[1]] + " + CPU MISS";
                }
                else
                {
                    Console.WriteLine("\nTietokoneen ohjus ei osunut.");

                    board[cpuMissile[0], cpuMissile[1]] = "CPU MISS";
                }
            }
        }
        /// <summary>
        /// Checks if the user's coordinates can be found on the board
        /// </summary>
        private static void CheckCoordinates()
        {
            bool xIsOnBoard = false, yIsOnBoard = false, coordinateIsOnBoard = false;

            while (!coordinateIsOnBoard)
            {
                string playerShip = Console.ReadLine();

                try
                {
                    if (playerShip.Length < 3)
                    {
                        switch (playerShip[0])
                        {
                            case 'A':
                                x = 0;
                                xIsOnBoard = true;
                                break;
                            case 'B':
                                x = 1;
                                xIsOnBoard = true;
                                break;
                            case 'C':
                                x = 2;
                                xIsOnBoard = true;
                                break;
                            case 'D':
                                x = 3;
                                xIsOnBoard = true;
                                break;
                            case 'E':
                                x = 4;
                                xIsOnBoard = true;
                                break;
                            default:
                                Console.WriteLine("\nAntamaasi koordinaattia ei löydy pelilaudalta! Yritä uudelleen:");
                                Console.Write("> ");
                                break;
                        }

                        if (xIsOnBoard)
                        {
                            switch (playerShip[1])
                            {
                                case '1':
                                    y = 0;
                                    yIsOnBoard = true;
                                    break;
                                case '2':
                                    y = 1;
                                    yIsOnBoard = true;
                                    break;
                                case '3':
                                    y = 2;
                                    yIsOnBoard = true;
                                    break;
                                case '4':
                                    y = 3;
                                    yIsOnBoard = true;
                                    break;
                                case '5':
                                    y = 4;
                                    yIsOnBoard = true;
                                    break;
                                default:
                                    xIsOnBoard = false;
                                    yIsOnBoard = false;
                                    Console.WriteLine("\nAntamaasi koordinaattia ei löydy pelilaudalta! Yritä uudelleen:");
                                    Console.Write("> ");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nAnnoit liikaa merkkejä! Yritä uudelleen:");
                        Console.Write("> ");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nAnnoit liian vähän merkkejä! Yritä uudelleen:");
                    Console.Write("> ");
                }

                if (xIsOnBoard && yIsOnBoard)
                {
                    coordinateIsOnBoard = true;
                }
            }
        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}