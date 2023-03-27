

/**
 * Shell sort with the gap sequence
 *  1, 3, 7, 15, ..., 2<sup>log<sub>2</sub>(n)</sup> (in reverse order).
 * 
 * @author pape
 *
 */
public class ShellSort : Sorting {

	/**
	 * Sorts the elements of a in ascending order
	 */
	public void sort(int[] a) {
		sort(a, 1);
	}

	/**
	 * Sorts the elements with Shell sort 
	 * and the gap sequence 1, 3, 7, ..., 2<sup>log<sub>2</sub>(n)</sup>
	 * (in reverse order). This methode is public for testing only.
	 */
	public void sort(int [] a, int k) {
		if (k  < a.Length) {
			sort(a, 2 * k ); // calculate powers of 2 recursivly
			kSort(a, 2 * k - 1);
		}
	}
	
	
	/**
	 * Insertion sort with gaps (k-sorting). In case of 
	 * <code>k</code> = 1 this algorithms performs an ordinary insertion sort.

	 */
	public void kSort(int [] a, int k) {
		for (int startIndex = 0; startIndex < k; startIndex++) {
			for (int i = k + startIndex; i < a.Length; i += k) {
				for (int j = i; j > k - 1 && a[j - k] > a[j]; j -= k) {
					int t = a[j];
					a[j] = a[j - k];
					a[j - k] = t;
				}
			}
		}
	}
}
