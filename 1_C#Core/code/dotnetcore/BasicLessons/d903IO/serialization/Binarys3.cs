using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


// There should be only one instance of this type per AppDomain.
[Serializable]
public sealed class Singleton : ISerializable 
{
    // This is the one instance of this type.
    private static readonly Singleton theOneObject = new Singleton();

    // Here are the instance fields.
    public String someString;
    public Int32 someNumber;

    // Private constructor allowing this type to construct the Singleton.
    private Singleton() 
    { 
        // Do whatever is necessary to initialize the Singleton.
        someString = "This is a string field";
        someNumber = 123;
    }

    // A method returning a reference to the Singleton.
    public static Singleton GetSingleton() 
    { 
        return theOneObject; 
    }

    // A method called when serializing a Singleton.
    void ISerializable.GetObjectData(
        SerializationInfo info, StreamingContext context) 
    {
        // Instead of serializing this object, 
        // serialize a SingletonSerializationHelp instead.
        info.SetType(typeof(SingletonSerializationHelper));
        // No other values need to be added.
    }

    // Note: ISerializable's special constructor is not necessary 
    // because it is never called.
}


[Serializable]
internal sealed class SingletonSerializationHelper : IObjectReference 
{
    // This object has no fields (although it could).

    // GetRealObject is called after this object is deserialized.
    public Object GetRealObject(StreamingContext context) 
    {
        // When deserialiing this object, return a reference to 
        // the Singleton object instead.
        return Singleton.GetSingleton();
    }
}

