using System.Collections.Specialized;

class Program
{


    class Atm
    {


        public int Balance { get; set; }
        public string Pin { get; set; }
        public Atm(int balance, string pin)
        {
            Balance = balance;
            Pin = pin;
        }

        public void Choice()
        {
            Console.WriteLine("1.Show Balance");
            Console.WriteLine("2.Cash in");
            Console.WriteLine("3.Cash out");
            Console.WriteLine("4.Check Pin");
            Console.WriteLine("5.Exit");
        }
        public void ShowBalance()
        {
            Console.Write("Balance:");
            Console.WriteLine(Balance);
        }
        public void CheckPin()
        {
            Console.Write("Pin:");
            string userPin = Console.ReadLine();
            if (userPin == Pin)
            {
                Choice();
            }
            else
            {
                Console.WriteLine("Pin yanlisdir!!");
                Display();
            }

        }
        public void CashIn()
        {
            Console.Write("Meblegi daxil edin: ");
            string amount = Console.ReadLine();
            int amount1;
            if (int.TryParse(amount, out amount1))
            {
                Balance += amount1;
                Display();
            }

        }

        public void CashOut()
        {

            Console.Write("Meblegi daxil edin: ");
            string amount = Console.ReadLine();
            int amount1;
            if (int.TryParse(amount, out amount1))
            {
                Balance -= amount1;
                Display();
            }
            else
            {
                Console.WriteLine("Yeterli miqdar yoxdur.");
            }
        }
        public void ChangePin()
        {
            Console.Write("Yeni pin:");
            string pin1 = Console.ReadLine();
            int pin2;
            if (int.TryParse(pin1, out pin2))
            {
                Pin = pin1;
                Display();
            }
            else
            {
                Console.WriteLine("OldPin incorrrect!");
            }


        }
        public void Display()
        {
            CheckPin();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                ShowBalance();
            }
            else if (choice == "2")
            {
                CashIn();
            }
            else if (choice == "3")
            {
                CashOut();
            }
            else if (choice == "4")
            {
                ChangePin();
            }
            else if (choice == "5")
            {
                return;
            }

        }
  

    }
    static void Main(string[] args)
    {
        Atm a1 = new Atm(100, "1234");
        a1.Display();
    }
}