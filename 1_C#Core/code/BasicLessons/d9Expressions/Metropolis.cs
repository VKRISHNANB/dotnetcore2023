using System;

/**
 * A <em>Metropolis</em> is a city, that is either a capital city with
 * more than 100 000 citizens, or a city with more than 200 000 citizens paying
 * more than 720 000 000 tax per year.
 * 
 * @author pape
 */
public class Metropolis {

    /**
     * Prints out whether the city given by three variables is a metropolis or not.
     */
    public static void MainC(String[] args) {
        bool isCapitalCity = true;
        int numberOfCitizens = 150000;
        double taxPerCititzen = 430.0;
        
        if ( isCapitalCity && numberOfCitizens >= 100000
                || numberOfCitizens >= 200000 
                     && taxPerCititzen * 12 * numberOfCitizens > 720000000) {
            Console.WriteLine("City is a metroplis");
        } else  {
            Console.WriteLine("City is not a metropolis");            
        }
    }

}
