 using System;
 class Strings {
    static Void Main() {
        // In C# ALL STRINGS MUST USE DOUBLE-QUOTES " "

        string greeting = "Hello, how are you? Won't you tell me your name?/n";
        string goodbye = "See you later alligator./n";

        // In C# strings are treated like an OBJECT that has properties and methods.
        // PROPERTIES -- things that describe the object such as length, values, data type, etc.
        // Methods -- built in functions related to that object

        // Length is an imporant property for strings.
        Console.WriteLine(greeting.Length);
        Console.WriteLine(goodbye.Length);
    
if (greeting.Length > goodbye.Length)      
{
    Console.WriteLine("The greeting has more characters than the goodbye ./n");
}

// Useful String Methods
    }
 Console.WriteLine(greeting.ToUpper(); // Make entire string UPPERCASE
 Console.WriteLine(greeting.ToLower()); // Make entire string lowercase
 