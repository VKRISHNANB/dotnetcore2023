using System;
// The approved types for an enum are 
// byte, sbyte, short, ushort, int, uint, long, or ulong.
// An enumerator cannot contain white space in its name.
public enum ArrivalStatus { Late = -1, OnTime = 0, Early  };
enum Day : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
enum Range : long { Max = 2147483648L, Min = 255L };

// FlagsAttribute Class
// Indicates that an enumeration can be treated as a bit field; 
// that is, a set of flags.

[Flags]
public enum CarOptions
{
    // The flag for SunRoof is 0001.
    SunRoof = 0x01,
    // The flag for Spoiler is 0010.
    Spoiler = 0x02,
    // The flag for FogLights is 0100.
    FogLights = 0x04,
    // The flag for TintedWindows is 1000.
    TintedWindows = 0x08,
}

public class EnumExample
{
    public static void TestEnum()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
        long m1 = (long)Range.Max;
        long m2 = (long)Range.Min;
        Console.WriteLine("Max = {0}", m1);
        Console.WriteLine("Min = {0}", m2);
        //flag
        // The bitwise OR of 0001 and 0100 is 0101.
        CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;

        // Because the Flags attribute is specified, 
        // Console.WriteLine displays
        // the name of each enum element that corresponds to a flag 
        // that has
        // the value 1 in variable options.
        Console.WriteLine(options);
        // The integer value of 0101 is 5.
        Console.WriteLine((int)options);
    }
    public static void M1()
    {
        ArrivalStatus status = ArrivalStatus.OnTime;
        Console.WriteLine("Arrival Status: {0} ({0:D})", status);
        //
        ArrivalStatus status2 = (ArrivalStatus)(1*-1);
        Console.WriteLine("Arrival Status: {0} ({0:D})", status2);
        //
        ArrivalStatus status1 = new ArrivalStatus();
        Console.WriteLine("Arrival Status: {0} ({0:D})", status1);
    }
    public static void M2()
    {
        Console.WriteLine("Enter Status: Late|OnTime|Early");
        String strValue = Console.ReadLine();
        ArrivalStatus status = (ArrivalStatus)Enum.Parse(typeof(ArrivalStatus), strValue);
        Console.WriteLine(status.ToString()+" "+(int)status);
    }
    public enum Pets
    {
        None, Dog, Cat, Bird, Rodent, Other
    };

    //public enum Pets
    //{
    //    None = 0, Dog = 1, Cat = 2, Bird = 4,Rodent = 8, Other = 16
    //};

    //public enum Pets
    //{
    //    None = 0, Dog , Cat, Bird = 10, Rodent , Other
    //};
    //IsDefined: Returns an indication whether a constant with a specified value exists 
    //             in a specified enumeration.    
    //public static bool IsDefined( Type enumType,   object value  )
    public static void TestIsDefine()
    {
        //false
        Pets value = Pets.Dog | Pets.Cat;
        //Pets.Dog is 1 ==> 00110001
        //Pets.Cat is 2 ==> 00110010
        // 1|2     is 3 ==> 00110011
        bool flag = Pets.IsDefined(typeof(Pets), value);
        Console.WriteLine("value {0:D} Exists in Pets: {1}",value,flag);
        string name = Enum.GetName(typeof(Pets), value);
        String strTrue = "name=" + name + " Value=" + value;
        String strFalse = " NameNotFound for Value=" + value;
        Console.WriteLine(name != null ? strTrue : strFalse );

        //true
        value = Pets.Dog;
        flag = Pets.IsDefined(typeof(Pets), value);
        Console.WriteLine("{0} value {0:D} Exists in Pets: {1}",value, flag);
        #region GetNames
        //String[] names = Enum.GetNames(typeof(Pets));
        //foreach (String n in names)
        //{
        //    flag = Pets.IsDefined(typeof(Pets), n);
        //    Console.WriteLine("name {0}  Exists in Pets: {1}", n, flag);
        //}
        #endregion

        Array names = Enum.GetValues(typeof(Pets));
        foreach(var n in names)
        { 
            flag = Pets.IsDefined(typeof(Pets), n);
      Console.WriteLine("name {0} {0:D} Exists in Pets: {1}", n, flag);
        }
    }
}
