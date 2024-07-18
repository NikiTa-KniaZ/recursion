{ 
        int[] array = { 1, 12, 54, 42, 65, 18, 256 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(array, array.Length - 1); 
    } 
 
    void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 

{ 
Console.WriteLine(""); 
Console.Write("Введите неотрицательное число m: "); 
int m = int.Parse(Console.ReadLine()); 
 
Console.Write("Введите неотрицательное число n: "); 
int n = int.Parse(Console.ReadLine()); 
 
int result = AckermannFunction(m, n); 
Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}"); 
    
 
    int AckermannFunction(int m, int n) 
    { 
        if (m == 0) 
            return n + 1; 
        else if (n == 0) 
            return AckermannFunction(m - 1, 1); 
        else 
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
    } 
}

