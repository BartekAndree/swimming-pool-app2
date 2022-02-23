using System;

namespace Project2021
{
    class Program
    {
        public Balance User1;
        public Day Monday { get; set; }
        public int Hour { get; set; }
        public int Price = 20;

        public Program()
        {
            Console.Title = "Pool reservation app | Bartek Andree";
            User1 = new Balance();
            Monday = new Day();
            Hour = 12;
        }
        public void Menu()
        {
            bool endProgram = false;
            TimeSelect();
            do
            {
                Console.Clear();
                ShowMenuOptions();
                int selectionMenu = Tools.LoadNumber("\nPlease select an operation: ", 1, 8);
                switch (selectionMenu)
                {
                    case 1:
                        endProgram = true;
                        break;
                    case 2:
                        TimeSelect();
                        break;
                    case 3:
                        CheckTrackAvailability();
                        break;
                    case 4:
                        ReservationAdd();
                        break;
                    case 5:
                        ReservationRemove();
                        break;
                    case 6:
                        BalanceCheck();
                        break;
                    case 7:
                        BalanceAdd();
                        break;
                    case 8:
                        Test test = new Test();
                        break;
                }
            }
            while (!endProgram);
            Console.Clear();
            Tools.WriteLineRed("\nThank you for using the app!");
        }
        public void ShowMenuOptions()
        {
            string[] menuOptions = new string[]
            {
                "Close",
                "Change the time",
                "Check track availability",
                "Add reservation",
                "Remove reservation",
                "Check the balance",
                "Add balance",
                "Run TEST",
            };
            Console.Clear();
            Console.WriteLine($"| Selected hour: {Hour} |\t| Your balance: {User1.Amount} $|\n\n");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine("\t" + (i + 1) + ". " + menuOptions[i]);
            }
        }

        public int TimeSelect()
        {
            Console.Clear();
            Hour = Tools.LoadNumber("Our swimming pool is open from 6.00 to 22.00. \n\nEnter the time you are interested in: ", 6, 22);
            return Hour;
        }

        public void CheckTrackAvailability()
        {
            Console.Clear();
            Console.WriteLine($"Track availability for: {Hour} o'clock\n\n");
            Console.WriteLine(Monday.olympicSwimmingPool[Hour].ToString());
            Tools.Dots(5, 650);
        }

        public void ReservationAdd()
        {
            if(User1.Amount >= Price)
            {
                Console.Clear();
                Console.WriteLine($"Book a track for: {Hour} o'clock\n\n");
                Console.WriteLine(Monday.olympicSwimmingPool[Hour].ToString());
                Monday.olympicSwimmingPool[Hour].TrackReservationAdd(Tools.LoadNumber("Which track do you want to book?: ", 1, 6));
                User1.Payment(Price);
            }
            else
            {
                Tools.WriteLineRed("Insufficient amount on the account, to reserve a track add balance");
                Tools.Dots(5, 700);
            }
            
        }

        public void ReservationRemove()
        {
            Console.Clear();
            Console.WriteLine($"Cancel your reservation for: {Hour} o'clock\n\n");
            Console.WriteLine(Monday.olympicSwimmingPool[Hour].ToString());
            if(Monday.olympicSwimmingPool[Hour].TrackReservationDelete(Tools.LoadNumber("From which track would you like to cancel the reservation? ", 1, 6)))
            {
                User1.Refund(Price);
            }
        }

        public void BalanceCheck()
        {
            Console.Clear();
            Console.WriteLine($"Your current account balance is: {User1.Amount} $\n\n");
            Tools.Dots(5, 1000);
        }

        public void BalanceAdd()
        {
            Console.Clear();
            Console.WriteLine($"Your current account balance is: {User1.Amount} $\n\n");
            Tools.WriteLineRed("Currently we do not accept payments over 1000 $.");
            User1.Amount = Tools.LoadNumber("Enter the amount you want to charge to your balance: ", 0, 1000);
            
        }

        static void Main(string[] args)
        {
            Program app = new Program();
            app.Menu();
        }
    }
}
