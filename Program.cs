

static void CustomArrResize(ref int[] arr, params int [] newNumbers)
{

  int [] result = new int[arr.Length +  newNumbers.Length];
    for (int i = 0; i < arr.Length; i++)
        result[i] = arr[i];

  

    for (int i = 0; i < newNumbers.Length; i++)
        result[arr.Length + i] = newNumbers[i] ;
    arr = result;

}

static void Main()
{
    int[] nums = { 1, 2, 3 };
    CustomArrResize(ref nums, 5,6, 7);

   
    for (int i = 0; i < nums.Length; i++) 
        Console.WriteLine(nums[i]);

    
}
Main();