// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

    Console.WriteLine("Enter M:");
    int M = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter N:");
    int N = int.Parse(Console.ReadLine());
    if (M <= N) 
    {
    int[] numbers = new int[N-M+1];
    for (int i = M; i <= N; ++i) 
    {
        numbers[i-M] = i;
    }
    Console.WriteLine(string.Join(",", numbers));
    }