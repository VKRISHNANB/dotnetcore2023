using System;
/**
 * Prints out a multiplication table for all
 * number from 1 to 10.
 * 
 * @author pape
 *
 */
public class MultiplicationTable {

    /**
     * Prints out the multiplication table.
     */
    public static void main(String[] args) {
        for (int i = 1; i <= 10; i++) {
            for (int j = 1; j <= 10; j++) {
                Console.WriteLine( i * j );
                Console.WriteLine("\t");
            }
            Console.WriteLine();
        }
    }

}
