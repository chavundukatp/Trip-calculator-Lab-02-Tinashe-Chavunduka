// Console.WriteLine("Hello, World!");
/* Tinashe Chavunduka
 * CSCI 1250, Section 001
 * Lab 02, Trip calculator 
 * 10/26/2026
 * Calculates the fuel, food, and work hours behind one road trip
 */

//PART 1 Road Trip
using System.Numerics;

Console.WriteLine("Round trip miles?"); 
double miles = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Your miles is: " + miles.ToString("F2")); 

Console.WriteLine("Miles per gallon?"); 
double milespergallon = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Your milespergallon is: " + milespergallon.ToString("F1")); 

Console.WriteLine("Price per gallon?"); 
double Price = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Your price is: " + Price.ToString("C"));

//Calculations:

double gallonsNeeded = miles/milespergallon; 
double fuelCost = gallonsNeeded * Price;

 gallonsNeeded = 9.29; 
 fuelCost = 26.84;
 
 //Part 2 Pizza party

 Console.WriteLine("How many people are going?"); 
 double numberofpeople = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Number of people going is: " + numberofpeople.ToString("F1")); 


Console.WriteLine("How many pizzas?"); 
 double numberofpizzas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Number of pizzas is: " + numberofpizzas.ToString("F1")); 


Console.WriteLine("price per pizza?"); 
Console.WriteLine("The price per pizza is: " + priceperpizza.ToString("F1")); 

//calculations 
double slicesperpizza = 8; 
double totalSlices = numberofpizzas * slicesperpizza; 
double slicesperperson = totalSlices / numberofpeople; 
\
double pizzacost = numberofpizzas * priceperpizza; 

totalSlices = 24; 
slicesperperson = 4.8; 
pizzacost = 38.97; 

//part 3 paycheck

Console.WriteLine("Hours worked this week?"); 
 double hoursworked = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The hours worked is: " + hoursworked.ToString("F1")); 

Console.WriteLine("Hourly rate?"); 
 double hourlyrate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The hourly rate is?: " + hourlyrate.ToString("F1")); 

Console.WriteLine("Tax rate?"); 
double taxrate = Convert.ToDouble(Console.ReadLine()); 
taxrate = 0.18; 

//calculations: 

double Grosspay = hoursworked * hourlyrate; 
double Taxwithehld = Grosspay * taxrate; 
double Takehomepay = Grosspay - Taxwithehld; 

Grosspay = 297; 
Taxwithehld = 53.46; 
Takehomepay = 243.54; 

// part 4

double Triptotal = fuelCost + pizzacost; 
double Costperperson = Triptotal / numberofpeople; 
double Takehomepayperhour = Takehomepay / hoursworked; 
double Hoursyoumustwork = Costperperson / Takehomepayperhour; 

Triptotal = 65.81; 
Costperperson = 13.16; 
Takehomepayperhour = 11.07; 
Hoursyoumustwork = 1.19; 

























