using System;

namespace _02PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Enter the Company's name: ");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter the Company's address: ");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Enter the Company's phone number: ");
            string companyPhoneNr = Console.ReadLine();

            Console.WriteLine("Enter the Company's fax number: ");
            string companyFaxNr = Console.ReadLine();

            Console.WriteLine("Enter the Company's Web Site: ");
            string companySite = Console.ReadLine();

            Console.WriteLine("Enter the Manager's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the Manager's last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the Manager's age: ");
            string managerAge = Console.ReadLine();

            Console.WriteLine("Enter the Manager's phone number: ");
            string managerPhoneNr = Console.ReadLine();                       
            
            Console.WriteLine();
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}", companyName, companyAddress, companyPhoneNr);

            if (string.IsNullOrWhiteSpace(companyFaxNr))
            {
                Console.WriteLine("Fax: (no fax)");
            }
            Console.WriteLine("Web Site: {0}\nManager: {1} {2} (age: {3}, tel. {4})", companySite, firstName, 
                lastName, managerAge, managerPhoneNr); //ot two rows, so that it is better readable
        }
    }
}
