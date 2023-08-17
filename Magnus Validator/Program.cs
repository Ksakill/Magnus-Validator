using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Magnus_Validator
{
    internal class Program
    {
        static void Main()
        {
            Controller();
        }

        public static void Controller() // the code is wtthin this part
        {
            string userPassword = GetUserInput("Indtast dit password: "); 
            bool isValid = IsPasswordValid(userPassword);
            bool isWeak = false;

            if (isValid)
            {
                isWeak = IsPasswordWeak(userPassword);
            }

            Views(isValid, isWeak);
        }

        public static void Views(bool isValid, bool isWeak)
        {
            if (isValid)
            {
                if (isWeak)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Gul: Passwordet er OK, men betragtes som svagt");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Grøn: Passwordet er OK");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Rød: Passwordet er ikke stærkt nok");
            }

            Console.ResetColor(); // Reset the console color to default
        }

        public static bool IsPasswordValid(string Password)
        {
            //  THe sword validation logic
           
        }

        public static bool IsPasswordWeak(string Password)
        {
            // the weak password criteria logic
            
        }

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}


// did really try to get this to work correctly but it didnt quite do what i wanted it to do. i can type text and it does tell me if a how strong the password is. did use a fair bit of online help.
    }
}

// did really try to get this to work correctly but it didnt yet do what i wanted it to do. i can type text and can see what is wrong with the text. 
