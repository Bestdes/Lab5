using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the text that is to be tested:");
            string input = Console.ReadLine();*/

            Console.WriteLine(ValidatesName("Shawn"));
            Console.WriteLine(ValidatesEmail("deshawn@gmail.com"));
            Console.WriteLine(ValidatesPhoneNum("616-929-0077"));
            Console.WriteLine(ValidatesDate("09/11/2013"));
            Console.WriteLine(ValidatesHtmlTag("<html></html>"));
        }

        public static Boolean ValidatesName(string nameString)
        {
            Boolean isName = false;

            if (Regex.IsMatch(nameString, "(^[A-z]{1,30}$)"))
            {
                /*Console.WriteLine(nameString);*/
                isName = true;
                return isName;
            }
            else
            {
                if (nameString.Length > 30)
                {
                    Console.WriteLine("The input is too long must be 30 or less characters");
                    isName = false;
                    return isName;
                }
                else
                {

                    Console.WriteLine("This is not a name is contains character that are not letters");
                    isName = false;
                    return isName;
                }
            }
        }

        public static Boolean ValidatesEmail(string testingEmail)
        {
            Boolean isEmail = false;

            if (Regex.IsMatch(testingEmail, @"(^\w{5,30}@\w{5,10}.\w{2,3}$)"))
            {
                /*Console.WriteLine(testingEmail);*/
                isEmail = true;
                return isEmail;
            }
            else
            {
                if (testingEmail.Length > 30 || testingEmail.Length < 5)
                {
                    Console.WriteLine("The input is too long must be greater than 5 or less than 30 characters");
                    isEmail = false;
                    return isEmail;
                }
                else
                {

                    Console.WriteLine("This is not an email as it is not in the correct format");
                    isEmail = false;
                    return isEmail;
                }
            }
        }

        public static Boolean ValidatesPhoneNum(string testingPhoneNum)
        {
            Boolean isPhoneNum = false;

            if (Regex.IsMatch(testingPhoneNum, @"(^\d{3}-\d{3}-\d{4}$)"))
            {
                /*Console.WriteLine(testingPhoneNum);*/
                isPhoneNum = true;
                return isPhoneNum;
            }
            else
            {
                Console.WriteLine("This is not an valid phone number as it is not in the correct format of: xxx-xxx-xxxx");
                isPhoneNum = false;
                return isPhoneNum;
            }
        }

        public static Boolean ValidatesDate(string testingDate)
        {
            Boolean isDate = false;

            if (Regex.IsMatch(testingDate, @"(^\d{2}/\d{2}/\d{4}$)"))
            {
                /*Console.WriteLine(testingDate);*/
                isDate = true;
                return isDate;
            }
            else
            {
                Console.WriteLine("This is not an valid phone number as it is not in the correct format of: xxx-xxx-xxxx");
                isDate = false;
                return isDate;
            }
        }

        public static Boolean ValidatesHtmlTag(string testingHtml)
        {
            Boolean isHtml = false;

            if (Regex.IsMatch(testingHtml, @"(^<\w+></\w+>$)"))
            {
                /*Console.WriteLine(testingHtml);*/
                isHtml = true;
                return isHtml;
            }
            else
            {
                Console.WriteLine("This is not an valid html tag because it is not in the correct format. (Example: <p></p>)");
                isHtml = false;
                return isHtml;
            }
        }
    }
}
