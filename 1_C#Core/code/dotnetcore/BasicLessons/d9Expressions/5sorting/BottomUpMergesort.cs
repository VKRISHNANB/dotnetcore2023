

/**
 * BottomUpMergesort is a non recursive implementation of
 * mergesort.
 * In a first pass all 1-1-pairs of numbers are merged together,
 * then all 2-2-pairs, and so on, until the array is sorted.
 * <pre>
 * 7 4 6 3 1 2 8 5
 * 4 7
 *     3 6
 *         1 2
 *             5 8
 * 4 7 3 6 1 2 5 8
 * 3 4 6 7
 *         1 2 5 8
 * 3 4 6 7 1 2 5 8
 * 1 2 3 4 5 6 7 8
 * </pre>
 * <p>
 * 
 * @author pape
 */
public class BottomUpMergesort : Sorting {

	/**
	 * Array for temporary copying the merged elements
	 */
	private int [] b;
	
	/**
	 * Sorts the elements in a in ascending order.
	 */
	public void sort(int[] a) {
		b = new int[a.Length];
		int i = 1;
		
		while (i < a.Length) {
		   merge(a, i);
		   i *= 2;
		}
	}
	
	
	/**
	 * Merges the already sorted subsequences
	 *  a[i]...a[i+width-1] mit a[i+width]..a[i+2*width-1]
	 * into a ordred sequence for each i = 2*width, 4*width, ...
	 */
	private void merge(int [] a, int width) {
		for (int left = 0; left < a.Length; left += 2 * width) {
			int middle = left + width - 1;
			int right = left + 2 * width - 1;

			if (right >= a.Length) {
				right = a.Length - 1;
			}
			merge(a, left, middle, right);
		}
	}

	/**
	 * merges the sorted sequence
	 *  a[left]...a[middle] with the sorted sequence
	 *   a[middle+1]..a[right]
	 * into a sorted sequence
	 *  a[left] .. a[right].
	 */
    private void merge(int[] a, int left, int middle, int right) {
        int l = left;
        int r = middle + 1;

        for (int i = left; i <= right; i++) {
            if (r > right || (l <= middle && a[l] <= a[r])) {
                b[i] = a[l++];
            } else if (l > middle || (r <= right && a[r] <= a[l])) {
                b[i] = a[r++];
            }
        }

        for (int i = left; i <= right; i++) {
            a[i] = b[i];
        }
    }
}
