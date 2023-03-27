using System;
/**
 * Converts a number of bytes given as an int value
 * such that the best metric unit is choosen for
 * representation.
 * 
 * @author pape
 *
 */
public class ConvertUnitsOfBytes {

    /**
     * Prints out the number of bytes with
     * the best metric unit.
     */
    public static void main(String[] args) {
        int bytes = 1532300001;
        double bytesMetric = 0;
        String unit = "Byte";
        
        if (bytes / 1000 == 0) {
            bytesMetric = bytes;
        } else if (bytes / 1000000 == 0) {
            bytesMetric = bytes / 1000.0;
            unit = "KByte";
        } else if (bytes / 1000000000 == 0) {
            bytesMetric = bytes / 1000000.0;
            unit = "MByte";            
        } else {
            bytesMetric = bytes / 1000000000.0;
            unit = "GByte";                        
        }
        
        Console.WriteLine(bytes + " are " + bytesMetric + " " + unit);
    }

}
