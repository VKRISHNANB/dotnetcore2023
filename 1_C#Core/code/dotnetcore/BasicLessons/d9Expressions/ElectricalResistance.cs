using System;
/**
 * <p>
 * Computes the current passing through a wire.
 * </p>
 * <p>
 * The Length of the wire, its diameter, its resistivity are given.
 * </p> 
 * @author pape
 */
public class ElectricalResistance {

    /**
     * Computes the electrical resistance for 
     * a wire.
     */
    public static void MainB(String[] args) {
        double Length = 1; // 2 meter
        double diameter = 0.001; // 1 mm
        double resistivity = 1.78E-8; // copper
        double area = (diameter * diameter / 4) * Math.PI;
        double resistance = resistivity * ( Length / area);
        
        Console.WriteLine( resistance + " Ohm");
        
        double current = 1; // 1 Ampere
        
        Console.WriteLine("Potential difference " + ( resistance * current ) + " Volt " +
        		"are neccesary to pass " + 
                + current + " Ampere through the wire"); 
    }

}
