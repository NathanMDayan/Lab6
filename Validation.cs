using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Validationlibrary
    {
        // Validating to make sure user puts in correct info and minimalizing the mistake user might make
        public static bool State1(string temp)
        {

            bool result = false;

            if (temp.Length == 2)
            {
                result = true;
            }

            return result;


        }

        public static bool Zip1(string temp)
        {

            bool result = false;

            if (temp.Length == 5)
            {
                result = true;
            }

            return result;
        }

        public static bool Email1(string temp)
        {

            bool result = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2)
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;

        
        }

        public static bool Phone1(string temp)
        {

            bool result = false;

            if (temp.Length == 12)
            {
                result = true;
            }

            return result;
        }

        public static bool Phone2(string temp)
        {

            bool result = false;

            if (temp.Length == 12)
            {
                result = true;
            }

            return result;
        }

        public static bool BadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA", "poop", "caca", "homework" };

            foreach (string strBw in strBadWords)
            {

                if (temp.Contains(strBw))
                {
                    result = true;
                }

                
            }

            return result;

        }






    }
}
