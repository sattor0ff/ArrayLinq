//task2
int []n = new int[]{1,2,3,4,5};

System.Console.Write("\nArrays: ");

foreach (var item in n)
{
  System.Console.Write($"{item} ");
}
System.Console.Write("\n");

  
System.Console.WriteLine($"\nSum of arrays: {n.Sum()}\n");

//Task4

var minthree = (from num in n 
                    orderby num ascending
                    select num).Distinct().Take(3);
System.Console.Write("ThreeMinimum from array: ");
foreach (var item in minthree)
{
  System.Console.Write($"{item} ");
}
System.Console.WriteLine("\n");

//Task5

System.Console.WriteLine($"Average of arrays: {n.Average()}\n");

//Task6

var maxthree = (from num in n 
                    orderby num descending
                    select num).Distinct().Take(3).Reverse();
System.Console.Write("ThreeMaximum from array: ");
foreach (var item in maxthree)
{
  System.Console.Write($"{item} ");
}
System.Console.WriteLine("\n");

// Task7

System.Console.Write("Square: ");

  var square = n.Select(x=> x*x);
  foreach (var item in square)
  {
    System.Console.Write($"{item} ");
  }
  System.Console.WriteLine("\n");

  // Task8

System.Console.Write("Cube: ");

  var cube = n.Select(x=> x*x*x);
  foreach (var item in cube)
  {
      System.Console.Write($"{item} ");
  }
  System.Console.WriteLine("\n");


// Task13

  var OddSquare = n.Where(x => x % 2 != 0).Select(x=> x*x);
  System.Console.Write("OddSquare: ");
  foreach (var item in OddSquare)
  {
    System.Console.Write($"{item} ");
  }
  System.Console.WriteLine("\n");

  // Task14

  var EvenSquare = n.Where(x => x % 2 == 0).Select(x=> x*x);
  System.Console.Write("EvenSquare: ");
  foreach (var item in EvenSquare)
  {
    System.Console.Write($"{item} ");
  }
  System.Console.WriteLine("\n");

  // Task15

  var OddCube = n.Where(x => x % 2 != 0).Select(x=> x*x*x);
  System.Console.Write("OddCube: ");
  foreach (var item in OddCube)
  {
    System.Console.Write($"{item} ");
  }
