using System;

namespace _12BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string FirstName = "Bai";
            string MiddleName = "Rambo";
            string LastName = "Silek";
            string HolderName = (FirstName + " " + MiddleName + " " + LastName);
            decimal AmountOfMoney = 25000m;
            string BankName = "Random Bank";   // za da izbegnem reklama :)
            string IBAN = "BG80 BNBG 9999 9999 9999 78";
            string CreditCard1 = "5555 5555 5555 5555"; 
            string CreditCard2 = "4444 4444 4444 4444"; 
            string CreditCard3 = "3333 3333 3333 3333"; 

            Console.WriteLine("Holder Name: {0}\nBalance: {1:C}\nBank Name: {2}", HolderName, AmountOfMoney, BankName);
            Console.WriteLine("IBAN: {0}\nFirst Credit Card Number: {1}\nSecond Credit Card Number: {2}",IBAN, CreditCard1, CreditCard2);
            Console.WriteLine("Third Credit Card Number: {0}", CreditCard3);
        }
    }
}
