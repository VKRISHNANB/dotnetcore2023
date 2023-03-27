using System;
/**
 * Sorts three int-values, given as local variables a, b, and c.
 * The program uses three if-statements to decide whether the
 * values have to be exchanged or not.
 * 
 * @author pape
 */
public class SortThreeNumbers {

    /**
     * Sorts the numbers of thre variables by comparing
     * and exchanging.
     */
    public static void MainA(String[] args) {
        int a = 3;
        int b = 1;
        int c = 2;
        int t;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

        Console.WriteLine("sorting...");

        if (a > b) {
            t = b;
            b = a;
            a = t;
        }
        if (a > c) {
            t = c;
            c = a;
            a = t;
        }
        if (b > c) {
            t = c;
            c = b;
            b = t;
        }
        
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
    }

}
