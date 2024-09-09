using System;
public class AnagramDemo
{
	//The pot is in the top floor He saw what was a good film 
	//hello the word parts is an anagram of strap and traps
	//Moreover 24 is 42 Please stop for pots
	
	static String s1="The pot is in the top floor."+
	" He saw what was a good film."+
	" hello the word parts is an anagram of strap and traps."+
	" Moreover 24 is 42. Please stop for pots";
/*	catalogue	coagulate
	decimate	medicate
	exitation	intoxicate
	canoe	ocean
	englander	greenland
	sweat	waste
	inapt	paint
	observe	verbose
	below	elbow
	derision	ironside
	domino	monoid
	dusty	study
	bedroom	boredom
	meteor	remote
*/
	public static void M1()
	{
		Console.WriteLine("Enter a sentence to check Anagrams");
		s1=Console.ReadLine();
		String sr=removepunct1(s1);
		Console.WriteLine(sr);
		TestForAnagram(sr);
	}
	private static String removepunct1(String word)
	{
		char[] data=word.ToCharArray();
		String s1=word;
		foreach(char c in data)
		{
			int x=(int)c;
			if (x >= 33 && x <= 46) s1=s1.Replace(c, ' ');
		}
		return s1;
	}
	private static String removepunct(String word)
	{
        char c1 = word.ToCharArray()[0];

        if ( c1>= 33 && c1<= 46) {
			if(word.Length == 1){
				return "";
			} else {
			return " "+ removepunct(word.Substring(1));
			}
		} else {
			if(word.Length == 1)
            {
				return "" + c1;
			} else
            {
			    return c1 + removepunct(word.Substring(1));
			}
		}
	}
    public static void TestForAnagram(String str)
    {
        String[] sar = str.Split(' ');
        int n = sar.Length;
        for (int j = 0; j < n - 1; j++)
        {
            for (int k = j + 1; k < n; k++)
            {
                if (sar[j].Length == sar[k].Length)
                {
                    if (!sar[j].Equals(sar[k]))
                    {
                        bool y = IsAnagram(sar[j], sar[k]);
                        if (y)
                        {
                            Console.WriteLine("\t" + sar[j] + " " + sar[k]);
                        }
                    }
                }
            }
        }
    }
    public static void TestForAnagram()
	{
        String str = "The pot is in the top floor ." +
    " He saw what was a good film ." +
    " hello the word parts is an anagram of strap and traps ." +
    " Moreover 24 is 42 . Please stop for pots"; ;
		String[] sar=str.Split(' ');
		int n=sar.Length;
	    for(int j=0;j<n-1;j++)
		{
			for(int k=j+1;k<n;k++)
			{
				if(sar[j].Length==sar[k].Length)
				{
					if(!sar[j].Equals(sar[k]))
					{
					  bool y=IsAnagram(sar[j],sar[k]);
					  if(y)
					  {
    					Console.WriteLine("\t"+sar[j]+" "+sar[k]);
					  }
					}
				}
			}
		}
	}
	private static bool IsAnagram(String word,String anagram)
	{
			char[] chars = word.ToCharArray();
			//loop through each character in `word`
			foreach (char c in chars) 
			{
			  int index = anagram.IndexOf(c);
				//if it exists in `anagram`, remove it using a combination of `substring` calls, else return false
				if (index != -1  )
				{
				  anagram = anagram.Substring(0, index) + anagram.Substring(index + 1, anagram.Length- (index + 1));
                }
				else
				{
					return false;
				}
			}
		   return (anagram.Equals(String.Empty));
	}
}
