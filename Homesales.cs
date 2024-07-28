using System;

class Program {
  public static void Main (string[] args) {
    double totalD = 0;
    double totalE = 0;
    double totalF = 0;
    string highestSalesperson = "";
    double highestTotal = 0;

    while (true)
    {
      Console.WriteLine("Enter salesperson's initial (D, E, or F). Enter Z to quit.");
      string initial = Console.ReadLine().ToUpper();

      if (initial == "Z"){
        break;
      }
      if (initial != "D" && initial != "E" && initial != "F")
      {
        Console.WriteLine("Error, invalid salesperson selected, please try again.");
        continue;
      }
      Console.WriteLine("Enter the amount of the sale: ");
      if (!double.TryParse(Console.ReadLine(), out double saleAmount))
      {
        Console.WriteLine("Error, invalid sale amount, please try again.");
        continue;
      }

      switch (initial){
      case "D":
        totalD += saleAmount;
        break;
      case "E":
        totalE += saleAmount;
        break;
      case "F":
        totalF += saleAmount;
        break;
      }
    }

    double grandTotal = totalD + totalE + totalF;

    if (totalD > totalE && totalD > totalF)
    {
      highestSalesperson = "D";
      highestTotal = totalD;
    }
    else if (totalE > totalD && totalE > totalF)
    {
      highestSalesperson = "E";
      highestTotal = totalE;
    }
    else
    {
      highestSalesperson = "F";
      highestTotal = totalF;
    }

    Console.WriteLine($"Total sales by D: {totalD:C}");
    Console.WriteLine( $"Total sales by E: {totalE:C}");
    Console.WriteLine( $"Total sales by F: {totalF:C}");
    Console.WriteLine($"Grand Total: {grandTotal:C}");
    Console.WriteLine($"Highest Sale: {highestSalesperson} with {highestTotal:C}");
  }
}