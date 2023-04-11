/* 
 * Description: 
 * Write, compile, and test a program named PersonalInfo that displays a person’s name, birthdate, work phone number, and cell phone number on separate lines.
 * Follow the format in the example below:
 * Lucinda Potter
 * 6/24/1992
 * work 000-555-0101
 * cell 000-555-0189
*/

using System;
using static System.Console;

class PersonalInfo
{
    static void Main()
    {
        const string name = "Lucinda Potter";
        const string birthdate = "6/24/1992";
        const string workPhone = "000-555-0101";
        const string cellPhone = "000-555-0189";

        WriteLine(name);
        WriteLine(birthdate);
        WriteLine($"work {workPhone}");
        WriteLine($"cell {cellPhone}");
    }
}
