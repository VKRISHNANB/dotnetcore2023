using System;
/**
 * Searches for a zero of a continueous function f : R -> R
 * with a binary partition algorithm.
 * 
 * @author pape
 */
public class FindZero {

	/**
	 * the continueous function f for which we want to find a zero
	 */
	private Function function;
	
	/**
	 * precision of the zero
	 */
	private double precision = 0.000001;
	
	/**
	 * Creates a new instance of FindZero to find a zero for
	 * the given continueous function f and desired precision of the zero.
	 * 
	 * @param function a <code>continueous</code>  function
	 */
	public FindZero(Function function, double precision) {
		this.function = function;
		this.precision = precision;
	}

	/**
	 * Searches for a zero in the given intervall [left, right].
	 * If f(left)f(right) < 0 holds a zero is found and returned.
	 */
	public double searchZero(double left, double right) {
		double middle = (left + right) / 2.0;
		
		if ( Math.Abs( function.f(middle) ) < precision ) {
			return middle;
		} else if ( function.f(middle) * function.f(right) < 0 ) {
			return searchZero(middle, right);
		} else {
			return searchZero(left, middle);
		}
	}
}
