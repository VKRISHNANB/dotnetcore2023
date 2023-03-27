using System;
/**
 * <p>Anagram is responsible to check two given Strings
 * whether one is an anagram of the other.
 * White spaces and letter case is ignored.</p>
 * <p>
 * Examples of anagrams are:
 *  <ul>
 *    <li>"Desperation" -> "A Rope Ends It"</li>
 *    <li>"Eleven plus two" -> "Twelve plus one"</li>
 *  </ul>
 * </p>
 * 
 * @author pape
 *
 */
public class Anagram {

	/**
	 * Retruns true if the letters of <code>phrase</code> can
	 * be rearranged to the given String <code>anagram</code>.
	 * White spaces and letter case are ignored.
	 */
	public bool IsAnagram(String phrase, String anagram) {
		char [] s1 = phrase.ToLower().ToCharArray();
		char [] s2 = anagram.ToLower().ToCharArray();
		int [] h1 = new int[256];
		int [] h2 = new int[256];
		
		createHistogramm(s1, h1);
		createHistogramm(s2, h2);
		
		for (int i=0; i < 256; i++) {
			if (h1[i] != h2[i]) {
				return false;
			}
		}
		
		return true;
	}

	/**
	 * Creates into h1 a histogram with all frequencies of the characters in s1.
	 */
	private void createHistogramm(char[] s1, int[] h1) {
		foreach (char c in s1) {
			if (! Char.IsWhiteSpace(c)) {
				h1[c]++;
			}
		}
	}
}
