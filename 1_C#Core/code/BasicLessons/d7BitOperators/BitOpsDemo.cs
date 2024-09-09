using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7BitOperators
{
    //C# Bitwise and Bit Shift Operators
    /*
     * Finding Binary from Decimal:
     * 23 - 23/2    - 11    - 1
     *      11/2    - 05    - 1
     *      05/2    - 02    - 1
     *      02/2    - 01    - 0
     *      01/2    - 00    - 1
     *  10111
     *  --------------------------------
     *  Finding Decimal from Binary:
     *  Find the decimal value of 111001 :
     *      1 - 2^0 (2 to the power 0)
     *      0 - 2^1
     *      0 - 2^2
     *      1 - 2^3
     *      1 - 2^4
     *      1 - 2^5
     *  1*2^0+0*2^1+0*2^2+1*2^3+1*2^4+1*2^5=57 base 10
     * */
    class BitOpsDemo
    {
        //Bitwise OR  | Operator
        /*
         *Bitwise OR operator is represented by |. 
         * It performs bitwise OR operation on the corresponding bits of two operands. 
         * If either of the bits is 1, then the result is 1. 
         * Otherwise the result is 0.
         * 14 = 00001110(In Binary)
           11 = 00001011(In Binary)
           -------------
           15 = 00001111
           -------------             
         */
        public static void TestBitwiseORinteger()
        {
            int firstNumber = 14, secondNumber = 11, result=0;
            result = firstNumber | secondNumber;
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result);
        }
        /*
         *If the operands are of type bool, 
         * the bitwise OR operation is equivalent to logical OR operation between them.
         */
        public static void TestBitwiseORbool()
        {
            bool flag = (true | false);// True
            Console.WriteLine("true | false=" + flag);
            flag = (false | false);// False
            Console.WriteLine("false|false=" + flag);
            flag = (true | true);// True
            Console.WriteLine("true|true=" +flag );
        }

        //Bitwise AND - &
        /*
         * Bitwise AND operator is represented by &. 
         * It performs bitwise AND operation on the corresponding bits of two operands. 
         * If either of the bits is 0, the result is 0. 
         * Otherwise the result is 1.
         * 14 = 00001110(In Binary)
           11 = 00001011(In Binary)
           -------------
           10 = 00001010
           -------------     
         * If the operands are of type bool,
         * the bitwise AND operation is equivalent to logical AND operation between them.
         * */
        public static void TestBitwiseAND()
        {
            int firstNumber = 14, secondNumber = 11, result;
            result = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);
            // bool
            bool flag = (true & false); //false
            Console.WriteLine("true & false=" + flag);
            flag = (false & false); // false
            Console.WriteLine("false&false=" + flag);
            flag = (true & true); // true
            Console.WriteLine("true&true=" + flag);
            //
            int i = 2, j = i;
            Console.WriteLine("i|j " + (i | j));
            Console.WriteLine("(i|j)&5 " + (i | j & 5)); 
            //00110010 & 00110101
            Console.WriteLine("2 -25*1 " + (2 - 25 * 1));
            Console.WriteLine("((i|j)&5 ) & (2 -25*1) " + ((i | j & 5) & (2 - 25 * 1)));
            //if (Convert.Tobool((i | j & 5) & (j - 25 * 1)))
            //    Console.WriteLine(1);
            //else
            //    Console.WriteLine(0);
        }

        // Bitwise XOR
        /*
         * Bitwise XOR operator is represented by ^. 
         * It performs bitwise XOR operation on the corresponding bits of two operands. 
         * If the corresponding bits are same, the result is 0. 
         * If the corresponding bits are different, the result is 1.
         * If the operands are of type bool, 
         * the bitwise XOR operation is equivalent to logical XOR operation between them.
         * 
         * */
        public static void TestBitwiseXOR()
        {
            int firstNumber = 14, secondNumber = 11, result;
            result = firstNumber ^ secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);

            // bool
            bool flag = (true ^ false);
            Console.WriteLine("true ^ false=" + flag);
            flag = (false ^ false);
            Console.WriteLine("false^false=" + flag);
            flag = (true ^ true);
            Console.WriteLine("true^true=" + flag);
        }
    }
}
