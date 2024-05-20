namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var williamsAccount = new BankAccount();
            var macksAccount = new BankAccount();

            var manager = new AccountManger();

            manager.ATM(williamsAccount);
        }
       
    }
}
