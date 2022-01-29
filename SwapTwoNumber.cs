using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramDay5
{
    //Each Word 1st Letter has to Start With UpperCase 
    //Pascal Case
    //Pascal Will Follow For Classname And Method Name 
    internal class SwapTwoNumber
    {
        public static void SwapingNumbers()
        {
            //Camal Case For Local Variable And Method Parameter
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("Please Enter First Number");
            firstNum = Convert.ToInt32(Console.ReadLine()); //10
            Console.WriteLine("Please Enter Second Number");
            secondNum = Convert.ToInt32(Console.ReadLine()); //20

            Console.WriteLine("Before Exchanging Values: first{0}, second={1}", firstNum, secondNum);
            temp = firstNum; //10
            firstNum = secondNum; //20
            secondNum = temp; //10
            Console.WriteLine("After Exchanging Values: first={0}, second={1}", firstNum, secondNum);
        }
    }
}
