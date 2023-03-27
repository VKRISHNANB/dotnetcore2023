namespace StreamsSamples
{
    class DemoA
    {
        //char streams
        public static void M1()
        {
            char ch;
            Console.WriteLine("Press a key followed by ENTER: ");
            int x = Console.Read();
            ch = (char)x; // get a char
            Console.WriteLine("\n"+x+" Your key is: " + ch);
        }
        public static void M2()
        {
            char ch= ' ';
            Console.WriteLine("Press a key q to exit: ");
            while (ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is: " + ch);
            }
        }
        public static void M3()
        {
            Console.Out.WriteLine("Enter a sentence");
            String? str = Console.ReadLine();
            Console.Out.WriteLine(" "+str);
        }
     }
}
