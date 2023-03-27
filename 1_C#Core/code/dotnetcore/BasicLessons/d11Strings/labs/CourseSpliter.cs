using System;
public class CourseSpliter
{
	public static void M1(String[] args)
	{
		if(null==args || args.Length<1)
		{
			Console.WriteLine("Arguments not provided");
            Console.WriteLine("java CourseSpliter ABC 123 : Course Description");
			return;
	   }
		String course=args[0];
		String[] data=course.Split(':');
		String[] data1=data[0].Split(' ');
        Console.WriteLine("Course Name: "+data1[0]);
        Console.WriteLine("Course Number: "+data1[1]);
        Console.WriteLine("Course Description: "+data[1]);

	}
}
