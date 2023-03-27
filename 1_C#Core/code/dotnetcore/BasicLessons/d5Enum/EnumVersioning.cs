using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d5Enum
{
    public enum TaskEndStateA { Error, Completed, Running }
    public enum TaskEndStateB { Error, Timeout, Completed, Running }
    //For example, the original:
    public enum OriginalTaskEndState { Error = 0, Completed = 1, Running = 2 }
    //And the modified version:
    public enum ModifiedTaskEndState { Error = 0, Timeout = 3, Completed = 1, Running = 2 }

}

/*
 * *
 * You don't say how exactly are you serializing the Enum, 
 * which is important here. I'm going to assume that you serialize 
 * it as the underlying integral value. 
 * In that case, your current code indeed has a versioning issue, 
 * if you add a new value into the middle of the Enum.

For example, in your current code, 
Error is 0, Completed is 1 and Running is 2. 
Now imagine you changed the code to:

public enum TaskEndState { Error, Timeout, Completed, Running }
Suddenly, what you saved as Running (old 2) 
will be read as Completed (new 2), which is not correct.

The best way to deal with this is to explicitly specify 
the numeric values for each enum member and never change them. 
You can add new values laster, but they have to have a new integer value. 
For example, the original:
public enum TaskEndState { Error = 0, Completed = 1, Running = 2 }
And the modified version:
public enum TaskEndState { Error = 0, Timeout = 3, Completed = 1, Running = 2 }
 * 
 */
