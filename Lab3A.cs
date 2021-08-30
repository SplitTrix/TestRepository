using System;

class Lab3A
{
  public static void Main(string[] args)
  {
    Console.Write("Amount owed: $");
    float fpCCBalance = Convert.ToSingle(Console.ReadLine());
    Console.Write("APR: ");
    float fpAPR = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Monthly percentage rate: " + fpAPR / 12);
    fpAPR /= 100; // Converts percent to decimal form for calculation
    Console.WriteLine("Minimum payment: " + (fpCCBalance * fpAPR) / 12);
  }
}