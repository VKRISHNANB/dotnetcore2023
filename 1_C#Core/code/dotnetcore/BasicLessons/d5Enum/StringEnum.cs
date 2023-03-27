public  class LogCategory
{
    private string Value{get;set;}
    private LogCategory(string s1){Value=s1;}
    public static LogCategory Trace   { get { return new LogCategory("Trace"); } }
    public static LogCategory Debug   { get { return new LogCategory("Debug"); } }
    public static LogCategory Info    { get { return new LogCategory("Info"); } }
    public static LogCategory Warning { get { return new LogCategory("Warning"); } }
    public static LogCategory Error   { get { return new LogCategory("Error"); } }
}
public sealed class MyConsts
{

    private MyConsts() {}

    public const string Val1 = "MyVal1";
    public const string Val2 = "MyVal2";
    public const string Val3 = "MyVal3";

}
public sealed class ReadOnlyMyConsts
{

    private ReadOnlyMyConsts() {}

    public static readonly string Val1 = "MyVal1";
    public static readonly string Val2 = "MyVal2";
    public static readonly string Val3 = "MyVal3";
}
public class StringValueAttribute : System.Attribute
{

    private string _value;

    public StringValueAttribute(string value)
    {
        _value = value;
    }

    public string Value
    {
    get { return _value; }
    }

}
public enum HandTools
{
    [StringValue("Cordless Power Drill")]
    Drill = 5,
    [StringValue("Long nose pliers")]
    Pliers = 7,
    [StringValue("20mm Chisel")]
    Chisel = 9

}