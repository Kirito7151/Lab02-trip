using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
/*
* Name: Jonathan Parkhurst
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
reports on a whole group instead of one person
*/

Console.Write("What was is the Round Trip in miles? ");
int milesofthetrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon that the car can go? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price of gas per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesofthetrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;


// do the output

System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString ("F2"));
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

//

int Peoplegoing = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How many Pizza are needed? ");
int AmountofPizza = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the Price Per Pizza? ");
double pizzaprice = Convert.ToDouble(Console.ReadLine());
const int pizzaslices = 8;
// do the math

double totalslices = AmountofPizza * pizzaslices;

double Slicesperperson = totalslices / Peoplegoing;

double pizzacost = AmountofPizza * pizzaprice;

// do the output

System.Console.WriteLine("Total Slices: " + totalslices.ToString("F2"));
System.Console.WriteLine("Slices per person: " + Slicesperperson.ToString ("F2"));
System.Console.WriteLine("Pizza Cost: " + pizzacost.ToString ("C"));

//

int Hoursworked = Convert.ToInt32(Console.ReadLine());


double hourlyrate = Convert.ToDouble(Console.ReadLine());

const double tax = .18;

// do the math

double grosspay = Hoursworked * hourlyrate;

double taxwithheld = grosspay * tax;

double takehome = grosspay - taxwithheld;

// do the output

System.Console.WriteLine("Gross pays: " + grosspay.ToString("F2"));
System.Console.WriteLine("Tax withheld:"+ taxwithheld.ToString("F2"));
System.Console.WriteLine("Take Home Pay: " + takehome.ToString("C"));

// do the math

double triptotal = fuelCost + pizzacost;

double costperperson = triptotal / Peoplegoing;

double takehomepayperhour = takehome / Hoursworked;

double hoursmustwork = costperperson /takehomepayperhour;


//do the output

System.Console.WriteLine("Trip Total: "  + triptotal.ToString("F2"));
System.Console.WriteLine("Cost Per Person: " + costperperson.ToString("F2"));
System.Console.WriteLine("Take Home Pay Per Hour: " + takehomepayperhour.ToString("F2"));
System.Console.WriteLine("Hours you must work to cover your share: " +hoursmustwork.ToString("C"));

Console.WriteLine("=== Part 1: Road Trip ===");
Console.WriteLine("Round Trip Miles: " + milesofthetrip.ToString("F2"));
Console.WriteLine("Mile Per Gallon: " + milesPerGallon.ToString("F2"));
Console.WriteLine("Price Per Gallon: " + pricePerGallon.ToString("C"));
Console.WriteLine("");
Console.WriteLine("Gallons needed: " +gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
Console.WriteLine("");
Console.WriteLine("=== Part 2: Pizza Party ===");
Console.WriteLine("How many people are going: " + Peoplegoing.ToString("F2"));
Console.WriteLine("How mant Pizzas: " + AmountofPizza.ToString("F2"));
Console.WriteLine("Price per pizza: " + pizzaprice.ToString("C"));
Console.WriteLine("");
Console.WriteLine("Total Slices: " + pizzaslices.ToString("F2"));
Console.WriteLine("Slices Per person: " + Slicesperperson.ToString("F2"));
Console.WriteLine("Pizza cost: " + pizzacost.ToString("C"));
Console.WriteLine("");
Console.WriteLine("=== Part 3: Paycheck ===");
Console.WriteLine("Hours worked this week: " + Hoursworked.ToString("F2"));
Console.WriteLine("Hourly Rate: " + hourlyrate.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("Gross pay: " + grosspay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxwithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takehome.ToString("C"));
Console.WriteLine("");
Console.WriteLine("=== Part 4: The Whole Trip ===");
Console.WriteLine("Trip Total: " + triptotal.ToString("C"));
Console.WriteLine("Cost per person: " + costperperson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takehomepayperhour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursmustwork.ToString("F2"));
Console.WriteLine("");

//
//
static double Fuel(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
double fuel = FuelCost(260, 28, 2.89);

static double FuelCost(double milesofthetrip, double milesPerGallon, double pricePerGallon)
{
    return (milesofthetrip / milesPerGallon) * pricePerGallon;
}
static double TakeHomePay(double Hoursworked, double hourlyRate, double tax)
{
    return(Hoursworked * hourlyRate) *  (1.0 - tax);
}
static double HoursToCover(double takehome, double takehomepayperhour)
{
    return (takehome / takehomepayperhour);
}

