using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class RegistrationClass
    {
        class Registration
        {
            private string _user;
            private int _pin;
            public Registration()
            {
                /*_user = user;
                _pin = pin;*/
                GetPin();
            }

            public void GetPin()
            {


                Console.WriteLine("enter your username");
                string username = Console.ReadLine();
                Console.WriteLine("enter your pin");
                int pin = Convert.ToInt32(Console.ReadLine());
                //after registration display some only interface then login to continue
                Console.WriteLine("enter yes to login or no to exit");
                string auth = Console.ReadLine().ToLower();
                Console.Clear();

                switch (auth)
                {
                    case "yes":
                        {
                            Console.WriteLine("{0}, enter your pin", _user);
                            int password = Convert.ToInt32(Console.ReadLine());
                            if (password == pin)
                            {
                                Console.WriteLine("login sucessful");
                            }
                            else
                            {
                                Console.WriteLine("invalid pin");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("logout successful");
                        break;
                }
            }
        }
    }
}
