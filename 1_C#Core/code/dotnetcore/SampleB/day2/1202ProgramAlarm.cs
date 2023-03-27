using System;
using System.Collections.Generic;
using System.Collections;
public class Puzzle3
{
 static int[] indataA={1,9,10,3,2,3,11,0,99,30,40,50};
 static int[] indataB={1,0,0,0,99};
 static int[] indataC={2,4,4,5,99,0};
static int[] inputdataD={1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19,1,19,5,23,1,23,6,27,2,9,27,31,1,5,31,35,1,35,10,39,1,39,10,43,2,43,9,47,1,6,47,51,2,51,6,55,1,5,55,59,2,59,10,63,1,9,63,67,1,9,67,71,2,71,6,75,1,5,75,79,1,5,79,83,1,9,83,87,2,87,10,91,2,10,91,95,1,95,9,99,2,99,9,103,2,10,103,107,2,9,107,111,1,111,5,115,1,115,2,119,1,119,6,0,99,2,0,14,0};
static int[]  inputdataE={1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19,1,19,5,23,1,23,6,27,2,9,27,31,1,5,31,35,1,35,10,39,1,39,10,43,2,43,9,47,1,6,47,51,2,51,6,55,1,5,55,59,2,59,10,63,1,9,63,67,1,9,67,71,2,71,6,75,1,5,75,79,1,5,79,83,1,9,83,87,2,87,10,91,2,10,91,95,1,95,9,99,2,99,9,103,2,10,103,107,2,9,107,111,1,111,5,115,1,115,2,119,1,119,6,0,99,2,0,14,0};

    private static void SolutionA(int[] inputdata)
    {
        int opcode1=1;
        int opcode2=2;
        int opcode3=99;
        int length=inputdata.Length-1;
        int x=0;int y=0;
        int suma=0;
        int productb=0;

        foreach(int r in inputdata)
            Console.Write(r+",");
        Console.Write("--->");
        
        for(int i=0;i<=length;i+=4)
        {

            if(inputdata[i]==opcode3)break;
            if(inputdata[i]==opcode1)
            {
                x=inputdata[inputdata[i+1]];
                y=inputdata[inputdata[i+2]];
                suma=x+y;
                inputdata[inputdata[i+3]]=suma;
            }
            else if(inputdata[i]==opcode2)
            {
                x=inputdata[inputdata[i+1]];
                y=inputdata[inputdata[i+2]];
                productb=x*y;
                inputdata[inputdata[i+3]]=productb;
            }
            else 
            {
                Console.WriteLine("unknown opcode!!! Something went Wrong");
            }
        }
        foreach(int r in inputdata)
            Console.Write(r+",");
        Console.WriteLine("\n******************");
        
    }
  
   public static void TestSolutionA()
    {
        // SolutionA(indataA);
        // SolutionA(indataB);
        // SolutionA(indataC);
        SolutionA(inputdataD);
    }

    /**
    *   Part Two
    */
    static int partTwoData=19690720;
    // This is a Comment
    private static void SolutionB()
    {
       int keyValue = 0;
       int x=0;
       int y=0;
       while(keyValue != 19690720) 
       {
            int range = 99;
            Random random=new Random();
            x = (int)(random.Next(range));
            y = (int)(random.Next(range));

            List<int> input = new List<int>{1,x,y,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19,1,19,5,23,1,23,6,27,2,9,27,31,1,5,31,35,1,35,10,39,1,39,10,43,2,43,9,47,1,6,47,51,2,51,6,55,1,5,55,59,2,59,10,63,1,9,63,67,1,9,67,71,2,71,6,75,1,5,75,79,1,5,79,83,1,9,83,87,2,87,10,91,2,10,91,95,1,95,9,99,2,99,9,103,2,10,103,107,2,9,107,111,1,111,5,115,1,115,2,119,1,119,6,0,99,2,0,14,0};
            for (int i = 0; i < input.Count; i+=4) 
            {
                if(input[i] == 1) {
                    input[input[i+3]]= input[input[i+1]] + input[input[i+2]];
                } else if (input[i] == 2) {
                    input[input[i+3]]=  input[input[i+1]] * input[input[i+2]];
                } else if (input[i] == 99) {
                    break;
                }
            }
            keyValue = input[0];
          
        }
        Console.WriteLine(keyValue+" we did it, values are: " + x + " " + y);
        Console.WriteLine("Result{0}",(100*x)+y);

    }
     private static void SolutionC()
    {
        int opcode1=1;
        int opcode2=2;
        int opcode3=99;
        int x=0;int y=0;
        int sum_a=0;
        int product_b=0;
        for(int p=1;p<100;p++)
        {
           for(int q=1;q<100;q++)
           {
               int[]  input={1,p,q,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19,1,19,5,23,1,23,6,27,2,9,27,31,1,5,31,35,1,35,10,39,1,39,10,43,2,43,9,47,1,6,47,51,2,51,6,55,1,5,55,59,2,59,10,63,1,9,63,67,1,9,67,71,2,71,6,75,1,5,75,79,1,5,79,83,1,9,83,87,2,87,10,91,2,10,91,95,1,95,9,99,2,99,9,103,2,10,103,107,2,9,107,111,1,111,5,115,1,115,2,119,1,119,6,0,99,2,0,14,0};

               for(int i=0;i<input.Length;i+=4)
               {
                    // if(input[i]==opcode3)
                    //     break;
                    if(input[i]==opcode1)
                    {
                        input[input[i+3]]= input[input[i+1]] + input[input[i+2]];
                    }
                    else if(input[i]==opcode2)
                    {
                        input[input[i+3]]= input[input[i+1]] * input[input[i+2]];
                    }
                }
                if(input[0]==partTwoData)
                {
                    Console.WriteLine("product {2}==> noun={0},verb={1}",p,q,partTwoData);
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Result{0}",(100*p)+q);
                    Console.WriteLine("-----------------");
                    break;
                }
            } 
        }
    }
    public static void TestSolutionTwo()
    {
       SolutionC();
    }   
}