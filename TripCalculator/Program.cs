using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
/*
* Name: Jonathan Parkhurst
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 22, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

Console.Write("What was is the Round Trip in miles? ");
int milesofthetrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon that the car can go? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price of gas per gallon? ");
double gasprice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesofthetrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasprice;

// do the output

System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString ("F2"));
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

//
System.Console.Write("How many people are going on the trip? ");
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

System.Console.Write("How many hours did you work this week? ");
int Hoursworked = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is your hourly pay? ");
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
Console.WriteLine("Price Per Gallon: " + gasprice.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("Gallons needed: " +gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("=== Part 2: Pizza Party ===");
Console.WriteLine("How many people are going: " + Peoplegoing.ToString("F2"));
Console.WriteLine("How mant Pizzas: " + AmountofPizza.ToString("F2"));
Console.WriteLine("Price per pizza: " + pizzaprice.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("Total Slices: " + pizzaslices.ToString("F2"));
Console.WriteLine("Slices Per person: " + Slicesperperson.ToString("F2"));
Console.WriteLine("Pizza cost: " + pizzacost.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("=== Part 3: Paycheck ===");
Console.WriteLine("Hours worked this week: " + Hoursworked.ToString("F2"));
Console.WriteLine("Hourly Rate: " + hourlyrate.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("Gross pay: " + grosspay.ToString("F2"));
Console.WriteLine("Tax withheld: " + taxwithheld.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
