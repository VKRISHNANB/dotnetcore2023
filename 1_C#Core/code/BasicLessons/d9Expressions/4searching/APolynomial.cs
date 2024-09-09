
/**
 * Implements the polynomial
 * 2x<sup>3</sup> - 5x<sup>2</sup> + 7x + 2.
 * f(1) = 2 - 5 + 7 = 6 and
 * f(-1) = -2 - 5 - 7 = -14 holds.
 * 
 * @author pape
 *
 */
public class APolynomial : Function {

	/**
	 * Returns the value of this polynomial for the given x.
	 */
	public double f(double x) {
		return 2*x*x*x - 5*x*x + 7*x + 2;
	}

	
}
