using System;
using System.Collections.Generic;
using System.Text;

namespace Auction
{
    class Program
    {
        private static ushort counter = 0;
        private static uint target = 0;
        private static List<string> itemNames = new List<string>();
        private static List<int> itemPrices = new List<int>();
        private static void MainMenu()
        {
            bool isNumber = false;
            byte selection = 127;

            if (counter == 0)
            {
                Console.WriteLine("Hei! Mitä haluat tehdä?");
            }
            else
            {
                Console.WriteLine("\n\nMitä seuraavaksi?");
            }

            Console.WriteLine("0. Lopeta ohjelma");
            Console.WriteLine("1. Aloita huutojen tallennus");
            Console.Write("> ");

            while (!isNumber)
            {
                try
                {
                    selection = byte.Parse(Console.ReadLine());

                    if (selection == 0 || selection == 1)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("\nValintaa ei löydy valikosta! Yritä uudelleen:");
                        Console.Write("> ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nAnna valinta NUMERONA:");
                    Console.Write("> ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nValintaa ei löydy valikosta! Yritä uudelleen:");
                    Console.Write("> ");
                }
            }

            if (selection == 0)
            {
                if (counter != 0)
                {
                    int highestPrice = 0, totalSales = 0;

                    for (int i = 0; i < itemPrices.Count; i++)
                    {
                        if (itemPrices[i] > highestPrice)
                        {
                            highestPrice = itemPrices[i];
                        }

                        totalSales += itemPrices[i];
                    }

                    Console.WriteLine("\n\nKalleimman myydyn artikkelin hinta oli {0}.", highestPrice);

                    if (totalSales < target)
                    {
                        Console.WriteLine("Tavoitetta ei saavutettu.");
                    }
                    else
                    {
                        Console.WriteLine("Tavoite saavutettiin.");
                    }
                }

                return;
            }

            isNumber = false;

            if (counter == 0)
            {
                Console.WriteLine("\nMikä summa asetetaan tavoitteeksi?");
                Console.Write("> ");

                while (!isNumber)
                {
                    try
                    {
                        target = uint.Parse(Console.ReadLine());

                        isNumber = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nAnna summa NUMEROINA:");
                        Console.Write("> ");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("\nJoko haluat menettää rahaa tai sinulla on varaa parempaan meklariohjelmaan.");
                        Console.Write("> ");
                    }
                }
            }

            if (selection == 1)
            {
                Bidding();
            }
        }
        private static void Bidding()
        {
            bool stopBidding = false;
            string input, price;
            uint bid = 0, bids = 0, items = 0;

            Console.WriteLine("\nAnna huudettavan artikkelin nimi:");
            Console.Write("> ");

            itemNames.Add(Console.ReadLine());

            while (!stopBidding)
            {
                if (bids == 0)
                {
                    Console.WriteLine("\nAnna lähtöhinta tai ensimmäinen huuto:");
                    Console.Write("> ");

                    try
                    {
                        bid = uint.Parse(Console.ReadLine());

                        itemPrices.Insert(counter, (int)bid);

                        bids++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nAnna lähtöhinta NUMEROINA!");
                        Console.Write("> ");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine
                            ("\nJoko häviät pian rahaa tai myyt niin kalliita tuotteita, " +
                            "että kannattaa vaihtaa meklariohjelmaa.");
                    }
                }
                else
                {
                    Console.WriteLine("\nSyötä seuraava huuto tai \"lopeta\", kun huuto jää voimaan.");
                    Console.Write("> ");

                    input = Console.ReadLine();

                    if (input.Contains("lopeta", StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (counter > 0)
                        {
                            int highestPrice = 0, salesTotal = 0;

                            for (int i = 0; i < itemPrices.Count; i++)
                            {
                                if (itemPrices[i] > highestPrice)
                                {
                                    highestPrice = itemPrices[i];
                                }

                                salesTotal += itemPrices[i];
                            }

                            if (bid < itemPrices[counter - 1])
                            {
                                price = "halvempi";
                            }
                            else
                            {
                                price = "kalliimpi";
                            }

                            if (salesTotal < target)
                            {
                                Console.WriteLine
                                ("\nTähän mennessä on myyty {0} artikkelia. " +
                                "Viimeisin artikkeli oli {1} kuin sitä edellinen. " +
                                "Korkein yhdestä artikkelista saatu hinta on ollut {2}€. " +
                                "Tavoitteeseen tarvitaan vielä {3}€.", 
                                itemNames.Count, price, highestPrice, target - salesTotal);
                            }
                            else
                            {
                                Console.WriteLine
                                ("\nTähän mennessä on myyty {0} artikkelia. " +
                                "Viimeisin artikkeli oli {1} kuin sitä edellinen. " +
                                "Korkein yhdestä artikkelista saatu hinta on ollut {2}€. " +
                                "Tavoite on jo saavutettu!", itemNames.Count, price, highestPrice);
                            }

                            items++;
                        }

                        stopBidding = true;
                        counter++;

                        MainMenu();
                    }
                    else
                    {
                        try
                        {
                            bid = uint.Parse(input);

                            itemPrices.RemoveAt(counter);
                            itemPrices.Insert(counter, (int)bid);

                            bids++;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnnoit jotain muuta kuin \"lopeta\" tai huudon numeroina.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine
                                ("\nJoko häviät pian rahaa tai myyt niin kalliita tuotteita, " +
                                "että kannattaa vaihtaa meklariohjelmaa.");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            MainMenu();
            
            Console.WriteLine("\nKiitos ohjelman käytöstä!");
        }
    }
}