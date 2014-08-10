//Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.
using System;

namespace StringInCSharp
{
    class StringInCSharp
    {
        static void Main()
        {
            Console.WriteLine(@"
A string is a sequence of characters. It is a data type which stores a sequence of data values,
usually bytes, in which elements usually stand for characters according to a character encoding.
When a string appears literally in the source code, it is known as a string literal.
Strings are objects. The String is an immutable sequence of characters.
Most important methods in String class are:
    Concat() method concatenates two strings.
    Compare() method compares two specified strings and returns an integer that indicates their 
relative position in the sort order. If the returned value is less than zero, the first string 
is less than the second. If it returns zero, both strings are equal. Finally, if the returned 
value is greater than zero, the first string is greater than the second. 
    Equals() method compares if two strings are the same. Returns bool value - true or false.
    IndexOf(), LastIndexOf() methods return index of given char or substring. If it is not 
contained n the given string return -1.
    Contains() method checks if given string is contained in another. Returns a bool value.
    ToCharArray() method creates char array from string.
    SubString() method Retrieves a substring from this instance. The substring starts at a 
specified character position (and has a specified length).
    Join() method concatenates all the elements of a string array, using the specified 
separator between each element. 
    Split() method returns a string array that contains the substrings in this instance that 
are delimited by elements of a specified Unicode character array.
    ToLower() makes all letters in string small
    ToUpper() makes all letters in string capital
    Format() formats the string.");
        }
    }
}
