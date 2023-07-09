int[] num = { 1, 5, 4, 8, 9, 10 };

var numEven = from number in num
              where number % 2 == 0
              select number;

Console.WriteLine("NUMBER EVEN : ");

foreach(int numb in numEven)
    Console.WriteLine(numb);
Console.WriteLine();

var numOdd = num.Where(number => number % 2 != 0);

Console.WriteLine("NUMBER ODD : ");

foreach (int numb in numOdd)
    Console.WriteLine(numb);
