using ConsoleApp10;

namespace AtmSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm atm = new Atm(1000, "1234");

            Console.WriteLine("PIN kodunuzu daxil edin:");
            string pin = Console.ReadLine();
            try
            {
                atm.EnteredPin(pin);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                Console.WriteLine("-----ATM-----:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Cash Out");
                Console.WriteLine("3. Cash Inn");
                Console.WriteLine("4. Change Pin");
                Console.WriteLine("5. Exit");
                Console.Write("Seçiminizi daxil edin: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            atm.CheckBalance();
                            break;
                        case "2":
                            Console.Write("Meblegi daxil edin: ");
                            decimal amountOut = Convert.ToDecimal(Console.ReadLine());
                            atm.cashOut(amountOut);
                            break;
                        case "3":
                            Console.Write("Meblegi daxil edin: ");
                            decimal amountIn = Convert.ToDecimal(Console.ReadLine());
                            atm.cashIn(amountIn);
                            break;
                        case "4":
                            Console.Write("Kohne pini daxil edin: ");
                            string oldPin = Console.ReadLine();
                            Console.Write("Yeni pini daxil edin: ");
                            string newPin = Console.ReadLine();
                            atm.ChangePin(oldPin, newPin);
                            break;
                        case "5":
                            Console.WriteLine("Exit");
                            return;
                        default:
                            Console.WriteLine("Yanlıs secim etdiniz!!!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}










