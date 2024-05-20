using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class AccountManger
    {
        public void ATM(BankAccount account)
        {
            static void Main(string[] args)
            {
                var account = new BankAccount();
                Console.WriteLine("Banking App\n");
                Console.WriteLine("----------------\n");


                while (true)
                {
                    Console.WriteLine("Please Select on option:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Check Balance");
                    Console.WriteLine("3. Exit");

                    int option;
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Nope! Do Better with your life");
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("How much homie?");
                            double amount;
                            if (!double.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine("Thats dumb its money stupid.... try again.");
                                continue;
                            }

                            account.Deposit(amount);
                            Console.WriteLine("OK you did it.");
                            break;

                        case 2:
                            Console.WriteLine($"Current balance is {account.GetBalance}");
                            break;

                        case 3:
                            Console.WriteLine("OK FINE BYE");
                            return;

                        default:
                            Console.WriteLine("Its pretty simple dude. Do better.");
                            break;

                    }

                }

            }
        }
    }
}
