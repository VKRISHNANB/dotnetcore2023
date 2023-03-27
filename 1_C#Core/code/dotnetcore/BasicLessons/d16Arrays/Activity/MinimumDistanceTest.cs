using System;

public class MinimumDistanceTest {

    private MinimumDistance minimumDistance = new MinimumDistance();
    
    public void TestGetIndexOfMinimumDistance() {
        int [] numbers = {1, 1};
        
        AssertEquals(0, minimumDistance.GetIndexOfMinimumDistance(numbers));
    }

    public static void AssertEquals(int v1, int v2)
    {
        bool result = false;
        if (v1 == v2) result = true;
        Console.WriteLine( result);
    }

    public void testGetIndexOfMinimumDistance1() {
        int [] numbers = {1, 3, 2};
        
        AssertEquals(1, minimumDistance.GetIndexOfMinimumDistance(numbers));
    }

    public static void TestGetIndexOfMinimumDistance2() {
        int [] numbers = {1, 3, 2, 3, 7, 9, 9, 8, 2, 2};
     MinimumDistance minimumDistance = new MinimumDistance();

    AssertEquals(5, minimumDistance.GetIndexOfMinimumDistance(numbers));
    }
}
