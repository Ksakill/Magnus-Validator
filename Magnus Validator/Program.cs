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
            string userPassword = GetUserInput("Indtast dit password: ");

            bool isValid = Controller(userPassword);

            if (isValid)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Grøn: Passwordet er OK");
            }
            else if (IsPasswordValid(userPassword))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Gul: Passwordet er OK, men betragtes som svagt");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Rød: Passwordet er ikke stærkt nok");
            }

            Console.ResetColor(); // Reset the console color to default
        }

        #region Controllers

        public static bool Controller(string Password)
        {
            if (!IsPasswordValid(Password))
            {
                return false;
            }

            if (HasRepeatingChars(Password) || HasSequentialDigits(Password))
            {
                return false;
            }

            return true;
        }

        #endregion

        #region Password Validation

        public static bool IsPasswordValid(string Password)
        {
            // The existing password validation logic

           
        }

        #endregion

        #region Repeating Characters and Sequential Digits

        public static bool HasRepeatingChars(string Password)
        {
            // the existing repeating characters logic

            
        }

        public static bool HasSequentialDigits(string Password)
        {
            // the existing sequential digits logic

            
        }

        #endregion

        #region Views

        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        #endregion
    }
}

// did really try to get this to work correctly but it didnt yet do what i wanted it to do. i can type text and can see what is wrong with the text. 
