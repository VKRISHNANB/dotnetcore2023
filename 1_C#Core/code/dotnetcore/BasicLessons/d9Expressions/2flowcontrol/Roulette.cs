using System;
/**
 * Eine "foolproof" winning strategy in roulette is to always bet
 * on the same color. If you loose then you simply double your wager for
 * compensating the loss.
 * 
 * @author pape
 */
public class Roulette {

    /**
     * Plays 1 000 000 times roulete and calculates the amount of money
     * you need at seed capital.
     */
    public static void main(String [] argv) {
        long seedCapital = 0;
        
        for (int round1 = 0; round1 < 1000000; round1++) {
            long wager = 1;
            while ( new Random().Next() < 0.5) {
                wager *= 2;
            } 
            if (wager > seedCapital) {
                seedCapital = wager;
                Console.WriteLine("[" + round1 + "] Maximum seed capital: " + seedCapital);
            }
        }
        
        long seedMoney = 1000;
        int round = 0;
        while ( seedMoney > 0 ) {
            long wager = 1;
            while ( new Random().Next() < 0.5) {
                wager *= 2;
            }
            if (wager > seedMoney) {
                seedMoney = 0;
            } else {
                seedMoney++;
            }
            round++;
        }
        
        Console.WriteLine("You lost all your money after " + round + " rounds.");
    }
}
