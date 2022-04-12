using System;

namespace PRO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool minBool = true; //initierar bool för att kunna börja/avsluta loop
            string item0 = ""; //initierar 5 strings som ska vara föremålen i ryggsäcken
            string item1 = "";
            string item2 = "";
            string item3 = "";
            string item4 = "";


            while (minBool) //påbörjar själva loopen
            {
                Console.WriteLine("Välkommen till Ryggsäcken!");
                Console.WriteLine("[1] Lägg till ett föremål.");
                Console.WriteLine("[2] Visa innehållet.");
                Console.WriteLine("[3] Töm ryggsäcken.");
                Console.WriteLine("[4] Avsluta.");

                int input = Convert.ToInt32(Console.ReadLine()); //detta krasahar programmet om du skriver något annat än en siffra så gör inte det tack :<


                switch (input)
                {
                    case 1: //om input är 1 så gör if kontroller för att ontrollera om den stringen redan har ett värde. Om den inte har ett värde så ger vi den värde enligt input från använder
                            //om det redan finns ett värde så hoppar vi över det itemet och går till nästa
                            //efter ett item får värde så säger vi vad använderen la till och rensar konsolen vid input.
                        {
                            if (item0 == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Vilket föremål vill du lägga till? :");
                                item0 = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("Du har lagt till " + item0 + " i ryggsäcken");
                                Console.ReadKey();
                                Console.Clear();

                            }

                            else if (item1 == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Vilket föremål vill du lägga till? :");
                                item1 = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("Du har lagt till " + item1 + " i ryggsäcken");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else if (item2 == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Vilket föremål vill du lägga till? :");
                                item2 = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("Du har lagt till " + item2 + " i ryggsäcken");
                                Console.ReadKey();
                                Console.Clear();

                            }

                            else if (item3 == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Vilket föremål vill du lägga till? :");
                                item3 = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("Du har lagt till " + item3 + " i ryggsäcken");
                                Console.ReadKey();
                                Console.Clear();

                            }

                            else if (item4 == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Vilket föremål vill du lägga till? :");
                                item4 = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("Du har lagt till " + item4 + " i ryggsäcken");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Ryggsäcken är redan full! ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        }
                    case 2:
                        //menyval 2. Rensar konsolen sedan listar alla items på ny rad. Väntar på inpuut från användern innan det tar bort det
                        Console.Clear();
                        Console.WriteLine("I din ryggsäck så har du: ");
                        Console.WriteLine(item0);
                        Console.WriteLine(item1);
                        Console.WriteLine(item2);
                        Console.WriteLine(item3);
                        Console.WriteLine(item4);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //menyval3 .  Rensar konsollen och gör om alla item till tomt
                        Console.Clear();
                        item0 = "";
                        item1 = "";
                        item2 = "";
                        item3 = "";
                        item4 = "";
                        break;
                    case 4:
                        //menyval 4. Rensar konsolen och avslutar loope
                        Console.Clear();
                        Console.WriteLine("Hejdå!"); //väntar på iput från användern
                        Console.ReadKey();


                        minBool = false;
                        break;
                    default:
                        //felmeddelande. Säger vad som var fel och väntar på någon input 
                        Console.Clear();
                        Console.WriteLine("Du måste välja mellan menyval 1-4");
                        Console.ReadKey();
                        break;



                }

            }
        }
    }
}