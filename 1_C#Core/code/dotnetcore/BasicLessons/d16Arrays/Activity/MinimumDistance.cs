using System;

public class MinimumDistance {
    /**
     * Returns the index of the first number
     * of two neighbouring numbers with minimum distance to
     * each others.
     */
    public int GetIndexOfMinimumDistance(int [] numbers)
    {
        int index = 0;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if ( Math.Abs( numbers[index] - numbers[index + 1]) >
                Math.Abs( numbers[i] - numbers[i + 1]))
                {
                	index = i;
            	}
        }
        return index;
    }
}
