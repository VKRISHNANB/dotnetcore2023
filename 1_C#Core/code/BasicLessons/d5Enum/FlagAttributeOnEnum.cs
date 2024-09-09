using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d5Enum
{
    /*
     * The following example illustrates the use of the 
     * FlagsAttribute attribute and shows the effect on the 
     * ToString method of using FlagsAttribute on an Enum declaration.
     */
    class FlagAttributeOnEnum
    {
        // Define an Enum without FlagsAttribute.
        enum SingleHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        // Define an Enum with FlagsAttribute.
        [FlagsAttribute]
        enum MultiHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        static void M1()
        {
            // Display all possible combinations of values.
            Console.WriteLine(
                 "All possible combinations of values without FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (SingleHue)val);

            // Display all combinations of values, and invalid values.
            Console.WriteLine(
                 "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);
        }
        // The example displays the following output:
        //       All possible combinations of values without FlagsAttribute:
        //         0 - None
        //         1 - Black
        //         2 - Red
        //         3 - 3
        //         4 - Green
        //         5 - 5
        //         6 - 6
        //         7 - 7
        //         8 - Blue
        //         9 - 9
        //        10 - 10
        //        11 - 11
        //        12 - 12
        //        13 - 13
        //        14 - 14
        //        15 - 15
        //        16 - 16
        //       
        //       All possible combinations of values with FlagsAttribute:
        //         0 - None
        //         1 - Black
        //         2 - Red
        //         3 - Black, Red
        //         4 - Green
        //         5 - Black, Green
        //         6 - Red, Green
        //         7 - Black, Red, Green
        //         8 - Blue
        //         9 - Black, Blue
        //        10 - Red, Blue
        //        11 - Black, Red, Blue
        //        12 - Green, Blue
        //        13 - Black, Green, Blue
        //        14 - Red, Green, Blue
        //        15 - Black, Red, Green, Blue
        //        16 - 16
        //
        /*
         * The following example defines two color-related enumerations, 
         * SingleHue and MultiHue. 
         * The latter has the FlagsAttribute attribute; the former does not. 
         * The example shows the difference in behavior when a range of integers, 
         * including integers that do not represent underlying values of 
         * the enumeration type, are cast to the enumeration type and their 
         * string representations displayed. 
         * For example, note that 3 cannot be represented as a SingleHue value 
         * because 3 is not the underlying value of any SingleHue member, 
         * whereas the FlagsAttribute attribute makes it possible to represent 3 
         * as a MultiHue value of Black, Red.
         * 
         */
        [FlagsAttribute]
        public enum PhoneService
        {
            None = 0,
            LandLine = 1,
            Cell = 2,
            Fax = 4,
            Internet = 8,
            Other = 16
        }
        public static void M2()
        {
            // Define three variables representing the types of phone service
            // in three households.
            var household1 = PhoneService.LandLine | PhoneService.Cell |
                             PhoneService.Internet;
            var household2 = PhoneService.None;
            var household3 = PhoneService.Cell | PhoneService.Internet;

            // Store the variables in an array for ease of access.
            PhoneService[] households = { household1, household2, household3 };

            // Which households have no service?
            for (int ctr = 0; ctr < households.Length; ctr++)
                Console.WriteLine("Household {0} has phone service: {1}",
                                  ctr + 1,
                                  households[ctr] == PhoneService.None ?
                                      "No" : "Yes");
            Console.WriteLine();

            // Which households have cell phone service?
            for (int ctr = 0; ctr < households.Length; ctr++)
                Console.WriteLine("Household {0} has cell phone service: {1}",
                                  ctr + 1,
                                  (households[ctr] & PhoneService.Cell) == PhoneService.Cell ?
                                     "Yes" : "No");
            Console.WriteLine();

            // Which households have cell phones and land lines?
            var cellAndLand = PhoneService.Cell | PhoneService.LandLine;
            for (int ctr = 0; ctr < households.Length; ctr++)
                Console.WriteLine("Household {0} has cell and land line service: {1}",
                                  ctr + 1,
                                  (households[ctr] & cellAndLand) == cellAndLand ?
                                     "Yes" : "No");
            Console.WriteLine();

            // List all types of service of each household?//
            for (int ctr = 0; ctr < households.Length; ctr++)
                Console.WriteLine("Household {0} has: {1:G}",
                                  ctr + 1, households[ctr]);
            Console.WriteLine();
        }
        // The example displays the following output:
        //    Household 1 has phone service: Yes
        //    Household 2 has phone service: No
        //    Household 3 has phone service: Yes
        //
        //    Household 1 has cell phone service: Yes
        //    Household 2 has cell phone service: No
        //    Household 3 has cell phone service: Yes
        //
        //    Household 1 has cell and land line service: Yes
        //    Household 2 has cell and land line service: No
        //    Household 3 has cell and land line service: No
        //
        //    Household 1 has: LandLine, Cell, Internet
        //    Household 2 has: None
        //    Household 3 has: Cell, Internet
    }
}
