namespace ConsoleApp10
{
    public class Atm
    {
        private decimal balance;
        private string pin;
        private int pinAttempts;

        public Atm(decimal initialBalance, string initialPIN)
        {
            balance = initialBalance;
            pin = initialPIN;
            pinAttempts = 0;
        }

        public void EnteredPin(string enteredPIN)
        {
            if (pinAttempts >= 3)
            {
                throw new Exception("Hesabiniz bloklandi !!!");
            }

            if (enteredPIN == pin)
            {
                pinAttempts = 0;
                Console.WriteLine("Hesaba daxil olundu");
            }
            else
            {
                pinAttempts++;
                throw new Exception("Yalnis pin daxil etdiniz !!!");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Balansınız:{balance} AZN");
        }

        public void cashOut(decimal amount)
        {
            if (amount > balance)
            {
                throw new Exception("Kifayet qeder mebleg movcud deyil");
            }
            balance -= amount;
            Console.WriteLine($"Balance: {balance} AZN");
        }

        public void cashIn(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Balance: {balance} AZN");
        }
        public void ChangePin(string oldPIN, string newPIN)
        {
            if (oldPIN != pin)
            {
                throw new Exception("Pini duzgun daxil edin");
            }
            pin = newPIN;
            Console.WriteLine("Pin deyisdirildi");
        }
    }
}



