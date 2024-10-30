// Collections Example, Te'janhi Nester, v0.0
using System;
using System.Linq;
using System.Coleections;


class 04_Collections {
  static void Main() { // DO NOT DELETE!

  /*
  In C# an collection is known as an ARRAY.
  -- EACH ITEM IN THE ARRAY IS AN ELEMENT
  -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED.
  -- CONTENTS OF EACH ELEMENT CAN CHANGE.
  -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
  -- POSITION OF THE ELEMENT IS THE INDEX
  -- FIRST ELEMENT INDEX IS 0.
  */

  // DECLARING AND DEFINING AN ARRAY
  string[] breakfastFoods = {"Bacon", "Eggs", "Cold Pizza", "Capn' Crunch",}
  int[] testScore = {0, 25, 15, 75, 99};
  double[] GPA = {0.27d, 1.99D, 4.02D, 0.0D, 3.25};

  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakfastFoods: \n" + String.Join (",", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen.