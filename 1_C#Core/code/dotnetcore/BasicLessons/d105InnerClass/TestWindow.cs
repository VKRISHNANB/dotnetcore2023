using System;


namespace BasicLessons
{
    class TestWindow
    {
        public static void TestA()
        {
            Wall w1 = new Wall();
            w1.Height = 10;
            w1.Width=15;
            w1.Color = "White";

            Wall.Window win = new Wall.Window();
            win.WindowType = "Wood";
            Console.WriteLine(win.WindowType);
        }
        public static void TestB()
        {
            WoodenWall wall1 = new WoodenWall();
            WoodenWall.Window gw1 = new WoodenWall.Window(wall1);
            wall1.Height = 10;
            wall1.Width = 15;
            wall1.Color = "White";
            gw1.WindowType = "Glass";
            Console.WriteLine(gw1.WindowType);
        }
    }
}
