using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Laver nyt objekt af klassen mysticnumbers, som har til formål at udskrive det højeste tal.
            MysticNumbers myMysticNumbers = new MysticNumbers();
            Console.WriteLine(myMysticNumbers.TwoNumbers(3, 2));
            Console.WriteLine(myMysticNumbers.TwoNumbers(5, 3));
            Console.WriteLine(myMysticNumbers.TwoNumbers(2, 10));

            // tilføjet og testet metoden FourNumbers, som returnerer den højeste værdi af 4 tal
            Console.WriteLine(myMysticNumbers.FourNumbers(15, 20, 25, 40));




            // The LAST line of code should be ABOVE this 
        }
    }
}
