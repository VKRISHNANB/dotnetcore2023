using System;
/**
 * Recursive implementation of Euclids algorithms.
 * 
 * @author pape
 */
public class GreatestCommonDivisor {

	/**
	 * Returns the greates common divisor of a and b.
	 */
	public int getGcd(int a, int b) {
		if (a == b) {
			return a;
		} else if (a < b) {
			return getGcd(a, b - a);
		} else {
			return getGcd(a - b, b);
		}
	}
}
