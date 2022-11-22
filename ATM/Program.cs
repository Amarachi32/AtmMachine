using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace ATM
{
     internal class Program
    {
        static void Main(string[] args)
        {

            MultiLanguage();
        }
        public static void MultiLanguage()
        {
            Console.WriteLine("select language of your Choice: \n if English press 1 \n if you want igbo press 2 \n if you want Chinese press 3 ");//checkmate their choice
            int languageselect = int.Parse(Console.ReadLine()); //.ConvertToInt32()

            switch (languageselect)
            {
                case 1:
                    English();
                    break;
                case 2:
                    Igbo();
                    break;
                case 3:
                    Chinese();
                    break;
                default:
                    MultiLanguage();
                    break;
            }
        }
        private static void English() {
            RegistrationClass register = new ();
            
            AtmClass.AtmMachine atm = new (50000);
            Console.WriteLine("your are our number ONE!");
            //var atm = new AtmMachine();
            Console.WriteLine("pls enter your name!");
            string userName = Console.ReadLine();
            //checked if it is InvalidCastException
            Console.WriteLine("Welcome {0}", userName);//call the user here



            bool session = true;
            while (session)
            {
                Console.WriteLine("select Option: \n press 1 for Withdrawal  \n press 2 for Transfer \n  press 3 for Balance check  \n press 4 for Airtime top up \n press 5 to change pin \n press 6 to deposit money");//checkmate their choice
                int ActivityOption = int.Parse(Console.ReadLine()); //.ConvertToInt32()
                                                                    //bool sucess = Int32.TryParse(Console.ReadLine(), out ActivityOption);
                switch (ActivityOption)
                {
                    case 1:
                        atm.Withdraw();
                        break;
                    case 2:
                        atm.Deposit();
                        break;
                    case 3:
                        atm.Balance();
                        break;
                    case 4:
                        atm.ChangePin();
                        break;
                    case 5:
                        atm.AirtimeTopUp();
                        break;
                    case 6:
                        atm.Transfer();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("press \"Y\" to continue");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }
        
        }
        private static void Igbo()
        {
            RegistrationClass register = new ();

            AtmClass.AtmMachine atm = new (50000);
            Console.WriteLine("Idi Anyi Mkpa!");
            //var atm = new AtmMachine();
            Console.WriteLine("Tinye Afa Gi!");
            Console.ReadLine();
            //checked if it is InvalidCastException
            Console.WriteLine("Daalu {0}");//call the user here



            bool session = true;
            while (session)
            {
                Console.WriteLine("horo ihe i choro ime: \n tinye 1 ka i were ego  \n tinye 2 itinye ego \n  tinye 3 i mata ego ole i nwere  \n press 4 for Airtime top up \n press 5 to change pin \n press 6 to deposit money");//checkmate their choice
                int ActivityOption = int.Parse(Console.ReadLine()); //.ConvertToInt32()
                                                                    //bool sucess = Int32.TryParse(Console.ReadLine(), out ActivityOption);
                switch (ActivityOption)
                {
                    case 1:
                        atm.Withdraw();
                        break;
                    case 2:
                        atm.Deposit();
                        break;
                    case 3:
                        atm.Balance();
                        break;
                    case 4:
                        atm.ChangePin();
                        break;
                    case 5:
                        atm.AirtimeTopUp();
                        break;
                    case 6:
                        atm.Transfer();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("press \"Y\" to continue");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }
        }
        private static void Chinese()
        {
            RegistrationClass register = new ();
            AtmClass.AtmMachine atm = new (50000);
            Console.WriteLine("nín shì wǒ men de hào mǎ");
            //var atm = new AtmMachine();
            Console.WriteLine("qǐng shū rù nín de míng zì！");
            Console.ReadLine();
            //checked if it is InvalidCastException
            Console.WriteLine("huān yíng  {0}");//call the user here



            bool session = true;
            while (session)
            {
                Console.WriteLine("xuǎn zé xuǎn xiàng: \n àn 1 tuì chū  \n àn 2 jìn xíng chuán shū \n  àn 3 jìn xíng yú é jiǎn chá  \n press 4 for Airtime top up \n press 5 to change pin \n press 6 to deposit money");//checkmate their choice
                int ActivityOption = int.Parse(Console.ReadLine()); //.ConvertToInt32()
                                                                    //bool sucess = Int32.TryParse(Console.ReadLine(), out ActivityOption);
                switch (ActivityOption)
                {
                    case 1:
                        atm.Withdraw();
                        break;
                    case 2:
                        atm.Transfer();
                        break;
                    case 3:
                        atm.Balance();
                        break;
                    case 4:
                        atm.ChangePin();
                        break;
                    case 5:
                        atm.AirtimeTopUp();
                        break;
                    case 6:
                        atm.Deposit();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("press \"Y\" to continue");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }
        }
    }

    
    
    
}