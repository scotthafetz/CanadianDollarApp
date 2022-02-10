// See https://aka.ms/new-console-template for more information
// Author: Scott Hafetz
// Date: 2/10/22
// Description: This application will convert CAD to USD with an increment inputted by the user up to 200

// Ask user to choose increment value
Console.WriteLine("Please input increment value between 5 and 25");
Console.WriteLine("Press Enter");
try
{
    //Gather and store user input
    string input = Console.ReadLine();
    decimal increment = decimal.Parse(input);
    //Execute loop if input is between 5 and 25
    if ((increment >= 5) && (increment <= 25))
    {
        Console.WriteLine("CAD to USD Conversion Table");
        for (decimal d = 0; d <= 200; d += increment)
        {
            Console.WriteLine("CAD= " + d + " USD= " + d * .792367m);
        }
        Console.WriteLine("Press any key to exit");
        Console.ReadKey(true);
    }
}
//Catch invalid user input values
catch
{
    Console.WriteLine("Please input a valid increment value");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey(true);
}