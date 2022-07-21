//Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitive datatypes (you can find the list here). Leave the Object datatype out.
//And also please initialize each variable with a working value.
//Then create two values of type string. 
//The first one should say "I control text"

//The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.

//Add each an output for each of the variables and write it onto the console. (WriteLine)
//Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
//Have fun :)

using System;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = 1;
            sbyte sbyte1 = -15;
            int int1 = 3;
            uint uint1 = 4;
            short short1 = 30000;
            ushort ushort1 = 30001;
            long long1 = 585920058573;
            ulong ulong1 = 93984733939938;
            float float1 = 3.1415f;
            double double1 = 1.5;
            char char1 = 'a';
            bool bool1 = true;
            string string1 = "Szla laseczka";
            decimal decimal1 = 1.5m;

            Console.WriteLine("I control text");
            string stringToInt = "1";
            int int2 = int.Parse(stringToInt);
            Console.WriteLine(int2);

            Console.WriteLine("byte1 = " + byte1);
            Console.WriteLine($"sbyte1 = {sbyte1}"); // string interpolation
            Console.WriteLine("int1 = " + int1);
            Console.WriteLine("uint1 = " + uint1);
            Console.WriteLine("short1 = " + short1);
            Console.WriteLine("ushort1 = " + ushort1);
            Console.WriteLine("long1 = " + long1);
            Console.WriteLine("ulong1 = " + ulong1);
            Console.WriteLine("float1 = " + float1);
            Console.WriteLine("double1 = ", double1);
            Console.WriteLine("char1 = " + char1);
            Console.WriteLine("bool1 = " + bool1);
            Console.WriteLine("string1 = " + string1);
            Console.WriteLine("decimal1 = " + decimal1);

            Console.Read();


//Add each an output for each of the variables and write it onto the console. (WriteLine)

        }
    }
}
