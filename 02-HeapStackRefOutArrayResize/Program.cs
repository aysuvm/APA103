
    static  void  ArrayResize( ref int[] numbers, params int[] newNumbers)
    {
        int[] result = new int[numbers.Length + newNumbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[i];
        }

        for (int i = 0; i < newNumbers.Length; i++)
        {
            result[numbers.Length + i] = newNumbers[i];
        }

    numbers = result;
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        ArrayResize( ref numbers, 4, 5, 6);

        for (int i = 0;i < numbers.Length; i++) {

        Console.WriteLine(numbers[i]);
        }
    
}
Main();
