using System ;
using System.Reflection ;
using System.Reflection.Emit ;

public class CodeGenerator{
	// AppDomain           cDomain  ;
	// AssemblyName     aName ;
	// AssemblyBuilder   aBuilder ;
	// ModuleBuilder       mBuilder ;
	// TypeBuilder          tBuilder ;
	// MethodBuilder      mthBuilder ;
	// ILGenerator          msil ;
	// Type t;
	
  //   public void GenCode()
  //   {
  //       cDomain = AppDomain.CurrentDomain ;
  //       aName = new AssemblyName() ;
  //       aName.Name = "MyFirstDynamicAssembly"; 
  //       aBuilder = cDomain.DefineDynamicAssembly(aName, AssemblyBuilderAccess.RunAndSave) ;
  //       mBuilder = aBuilder.DefineDynamicModule("Hello.dll","Hello.dll") ;
  //       tBuilder = mBuilder.DefineType ("Car", TypeAttributes.Public) ;
  //       mthBuilder = tBuilder.DefineMethod("SayHello",MethodAttributes.Public, null,null);
  //       msil = mthBuilder.GetILGenerator() ;
  //       msil.EmitWriteLine("Hello Car "   ) ;
  //       msil.Emit(OpCodes.Ret) ;
  //       //   Generate MSIL.
  //       t = tBuilder.CreateType() ;
  //       aBuilder.Save("Hello.dll");
	// }
  // public   Type GetCustomType() 
  // {
	// 		 return t;
  // }
}