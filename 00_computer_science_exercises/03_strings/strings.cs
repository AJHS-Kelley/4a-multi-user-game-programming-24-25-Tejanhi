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

 // String Concatenation "Con-Cat-Uh-Nation"
 string comboString = greeting + goodbye;
 Console.WriteLine(comboString);

 // String Concatenation Method #2
 string comboString2 = string.Concat(greeting, goodbye);
 Console.WriteLine(comboString2);

 // String Interpolation -- Subsituting variables into strings.
 string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}./n"'
 Console.WriteLine(comboString3);

 // Substituting Variables into Strings Method 2
 Console.Writeline("My greeting is" + greeting + "and my goodbye is "+ goodbye + "/n.";
 
 // Accesing Parts of Strings
 // index is a specific location of a character in a string
 // ALL string indexes starts at 0
 Console.WriteLine(goodbye[0]); // Print the character at index 0.
 Console.WriteLine(goodbye[4]); // Replace x with what to print the 5th char?