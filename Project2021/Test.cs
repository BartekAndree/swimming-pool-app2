using System;
using System.Collections.Generic;
using System.Text;

namespace Project2021
{
    class Test
    {
        public Test()
        {
            try
            {
                Test1();
                Test2();
                Test3();
                Test4();
                Test5();
                Test6();
                Test7();
                Test8();
                Test9();
                Test10();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());
                Tools.WriteLineRed("\n\n\nPrawdopodobnie jeden z testów wysypał program :(");
                Console.ReadKey();  
            }

        }
        public static void Test1()
        {
            // test dodawania rezerwacji - nie uwgledajac salda

            Program testProgram = new Program();


            int testGodzina = 12;
            int tor = 5;

            Console.Clear();
            Tools.WriteLineRed("Start test 1");

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc wolny");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());
            Tools.Dots(10, 50);

            Console.WriteLine($"Dodaje rezerwacje na tor {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(tor);
            Tools.Dots(10, 50);

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc zajety");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());

            Tools.WriteLineRed("Koniec test 1");
            Console.ReadKey();
        }

        public static void Test2()
        {
            // test usuwania rezerwacji - nie uwgledajac salda
            Program testProgram = new Program();

            int testGodzina = 12;
            int tor = 5;
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(5);

            Console.Clear();
            Tools.WriteLineRed("Start test 2");

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc zajety");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());
            Tools.Dots(10, 50);

            Console.WriteLine($"Usuwam rezerwacje z toru {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationDelete(tor);
            Tools.Dots(10, 50);

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc wolny");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());

            Tools.WriteLineRed("Koniec test 2");
            Console.ReadKey();
        }

        public static void Test3()
        {
            // test salda

            Program testProgram = new Program();

            Console.Clear();
            Tools.WriteLineRed("Start test 3");

            Console.WriteLine("Saldo obecnie wynosi: "+testProgram.User1.Amount);
            Tools.Dots(10, 50);

            testProgram.User1.Amount = 250;
            Console.WriteLine("Dodaje 250 zł do salda");
            Tools.Dots(10, 50);

            Console.WriteLine("Saldo obecnie wynosi: " + testProgram.User1.Amount);
            Tools.Dots(10, 50);

            Console.WriteLine("Rezerwuje tor");
            Tools.Dots(10, 50);
            testProgram.User1.Payment(testProgram.Price);

            Console.WriteLine("Saldo obecnie wynosi: " + testProgram.User1.Amount);
            Tools.Dots(10, 50);

            Console.WriteLine("Anuluje rezerwacje toru");
            Tools.Dots(10, 50);
            testProgram.User1.Refund(testProgram.Price);

            Console.WriteLine("Saldo obecnie wynosi: " + testProgram.User1.Amount);

            Tools.WriteLineRed("Koniec test 3");
            Console.ReadKey();
        }

        public static void Test4()
        {
            // test zmiany godziny

            Program testProgram = new Program();


            int testGodzina = 12;
            int tor = 5;

            Console.Clear();
            Tools.WriteLineRed("Start test 4");

            Console.WriteLine($"Dodaje rezerwacje na tor {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(tor);
            Tools.Dots(10, 50);

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc zajety");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());

            Console.WriteLine("Zmieniam godzinę na 13");
            testGodzina = 13;
            Tools.Dots(10, 50);

            Console.WriteLine($"Dodaje rezerwacje na tor {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(tor);
            Tools.Dots(10, 50);

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc zajety");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());

            Tools.WriteLineRed("Koniec test 4");
            Console.ReadKey();
        }

        public static void Test5()
        {
            // test odrzucenia rezerwacji z powodu zajętego toru

            Program testProgram = new Program();


            int testGodzina = 12;
            int tor = 5;

            Console.Clear();
            Tools.WriteLineRed("Start test 5");

            Console.WriteLine($"Dodaje rezerwacje na tor {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(tor);
            Tools.Dots(10, 50);

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc zajety");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());

            Console.WriteLine($"Dodaje rezerwacje na tor {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(tor);

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc niemozliwy do zarezerwowania");

            Tools.WriteLineRed("Koniec test 5");
            Console.ReadKey();
        }

        public static void Test6()
        {
            // test odrzucenia anulowania rezerwacji z powodu wolnego toru

            Program testProgram = new Program();


            int testGodzina = 12;
            int tor = 5;

            Console.Clear();
            Tools.WriteLineRed("Start test 6");

            Console.WriteLine($"Tor {tor} o godzina {testGodzina} powinnien byc wolny");
            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());
            Tools.Dots(10, 50);

            Console.WriteLine($"Usuwam rezerwacje na tor {tor} o godzina {testGodzina}");
            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationDelete(tor);
            Tools.Dots(10, 50);

            Tools.WriteLineRed("Koniec test 6");
            Console.ReadKey();
        }

        public static void Test7()
        {
            // test funkcji menu sprawdzania dostępności toru

            Program testProgram = new Program();

            Console.Clear();
            Tools.WriteLineRed("Start test 7");
            Tools.Dots(5, 50);

            testProgram.CheckTrackAvailability();

            
            Tools.WriteLineRed("Koniec test 7");
            Console.ReadKey();
        }

        public static void Test8()
        {
            // Test rezerwacji toru prosto z menu bez potrzebnych środków i z nimi

            Program testProgram = new Program();

            Console.Clear();
            Tools.WriteLineRed("Start test 8");

            Console.WriteLine("Próba rezerwacji toru bez środków na koncie: \n");
            testProgram.ReservationAdd();
            Tools.Dots(5, 500);

            Console.WriteLine("Próba rezerwacji toru z środkami na koncie: \n");
            testProgram.User1.Amount = 50;
            testProgram.ReservationAdd();

            testProgram.CheckTrackAvailability();


            Tools.WriteLineRed("Koniec test 8");
            Console.ReadKey();
        }

        public static void Test9()
        {
            // Test ununięcia rezerwacji toru prosto z menu 

            Program testProgram = new Program();

            int testGodzina = 12;
            int tor = 5;

            Console.Clear();
            Tools.WriteLineRed("Start test 9");

            testProgram.Monday.olympicSwimmingPool[testGodzina].TrackReservationAdd(tor);
            testProgram.CheckTrackAvailability();

            Console.WriteLine("Anulowanie toru");
            testProgram.ReservationRemove();

            Console.WriteLine(testProgram.Monday.olympicSwimmingPool[testGodzina].ToString());

            Tools.WriteLineRed("Koniec test 9");
            Console.ReadKey();
        }

        public static void Test10()
        {
            // Test próba rezerwacji całego dnia

            Program testProgram = new Program();

            Console.Clear();
            Tools.WriteLineRed("Start test 10");

            for (int i = 6; i <= 22; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    testProgram.Monday.olympicSwimmingPool[i].TrackReservationAdd(j);
                }
            }
            for (int i = 6; i <= 22; i++)
            {
                Console.WriteLine("Godzina: " + i);
                Console.WriteLine(testProgram.Monday.olympicSwimmingPool[i].ToString());
            }

            Tools.WriteLineRed("Koniec test 10");
            Console.ReadKey();
        }
    }
}
