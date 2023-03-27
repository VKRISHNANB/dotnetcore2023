using System;

/**
 * Natural mergesort is a improved version of bottom-up mergesort.
 * It finds and merges pairs of subsequence that are already ordered.
 * <p>In the sequence <code>7 4 6 3 1 2 8 5</p> 
 * first all pairs of sorted subsequences are merged:
 * 7 with 4 6 , 3 with  1 2 8, and 5 is not merged.
 * We use | for seperating the sorted subsequences:
 * </p>
 * <pre>
 * 7 | 4 6 | 3 |1  2 | 8 | 5
 * 4 6 7 | 3 | 1 2 | 8 | 5
 * 4 6 7   1 2 3 | 8 | 5
 * 4 6 7 1 2 3 5 8
 * 
 * 4 6 7 | 1 2 3 | 5 8
 * 1 2 3 4 6 7 | 5 8
 * 
 * 1 2 3 4 5 6 7 8
 * </pre>
 * <p>
 * The best case for natural merge sort is a sorted array, the running
 * time is O(n). The worst case still is O(n log<sub>2</sub>n).
 * </p>
 * 
 * @author pape
 *
 */
public class NaturalMergeSort : Sorting {
	
	private int [] b;
	
	/**
	 * Sorts the elements of a in ascending order.
	 */
	public void sort(int[] a) {
		b = new int[a.Length];
		naturalMergeSort(a);
	}
	

	
	private void  naturalMergeSort(int [] a) {
		int left = 0;
		int right = a.Length - 1;
		bool sorted = false;
		int l = 0;
		int r = right;
		
		do {
			sorted = true;
			left = 0;
			
			while (left < right) {
				l = left;
				while (l < right &&  a[l] <= a[l + 1]) {
					l++;
				}
				r = l + 1;
				while (r == right - 1 || r < right && a[r] <= a[r + 1]) {
					r++;
				}
				if (r <= right) {
					merge(a, left, l, r);
					sorted = false;
				}
				left = r + 1;
			}
		} while (! sorted);
		
	}

	/**
	 * Merges the sorted sequence
	 *  a[links]...a[mitte] with a[mitte+1]..a[rechts]
	 *  into a sorted sequence
	 *  a[links] .. a[rechts].
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
