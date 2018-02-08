using System;

/*

    Problem - Find Pi to the Nth Digit, within a set limit 
    Solution - Determine the value of Pi, 
               Get Input from user to determine how many digits to display, up to 14 decimals.
               Validate input data
               Display appropriate value.
*/


namespace ValuePi
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = Math.PI;

            string value;

            //Get user input to determine decimals to display, ensure data is valid before proceeding.
            do
            {
                Console.WriteLine("Find Pi to the Nth Digit");
                Console.WriteLine("Enter value for how many decimals to display - Limit is 14");
                value = Console.ReadLine();
            } while (IsDigitsOnly(value) == false);

            //If the string value is greater than the limit (14), set the value in Math.Round to 14.
            //Otherwise Convert string value to integer as normal
            if (Convert.ToInt16(value) >= 15)
            {
                Console.WriteLine(Math.Round(Pi, 14));
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine(Math.Round(Pi, Convert.ToInt16(value)));
                Console.ReadKey(true);
            }
        }
        //Checks to see if value from user is numerical.
        public static bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
