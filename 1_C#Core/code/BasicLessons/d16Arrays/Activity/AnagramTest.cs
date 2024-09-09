using System;
public class AnagramTest {

	private Anagram anagram = new Anagram();
    public bool AssertEquals(int v1, int v2)
    {
        bool result = false;
        if (v1 == v2) result = true;
        return result;
    }
    public void testIsAnagram() {
		AssertTrue(anagram.IsAnagram("abc", "cab"));
	}

	public void testIsAnagram2() {
		AssertTrue(anagram.IsAnagram("aBc", "Cab"));
	}

    private void AssertTrue(bool v)
    {
        Console.WriteLine(v);
    }

    public void testIsAnagram3() {
		AssertTrue(anagram.IsAnagram("Eleven plus two", "Twelve plus one"));
	}
	
	public void testIsAnagram4() {
		AssertTrue(anagram.IsAnagram("Desperation", "A Rope Ends It"));
	}
	
	public void testIsAnagram5() {
		AssertTrue(anagram.IsAnagram("Rumpelstilzchen", "Hotzenplotz"));
	}
}
