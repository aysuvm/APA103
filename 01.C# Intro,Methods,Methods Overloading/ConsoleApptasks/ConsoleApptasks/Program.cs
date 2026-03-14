static void Math()
{
    int a = 10;
    int b = 5;

    Console.WriteLine("Toplama: " + Topla(a, b));
    Console.WriteLine("Cixma: " + Cix(a, b));
    Console.WriteLine("Vurma: " + Hasil(a, b));
    Console.WriteLine("Bolme: " + Bol(a, b));
}

static int Topla(int a, int b)
{
    return a + b;
}


static int Cix(int a, int b)
{
    return a - b;
}


static int Hasil(int a, int b)
{
    return a * b;
}


static double Bol(int a, int b)
{
    return a / b;
}




///static void OddEven(int[] arr)
//{
// for (int i = 0; i < arr.Length; i++)
// {
//  if (arr[i] % 2 == 0)
//  {
//      Console.WriteLine(arr[i] + " cut ededdir");
// }
// else
//  {
//     Console.WriteLine(arr[i] + " tek ededdir");
// }
//  }
//}
//{
//int[] arr = { 14, 20, 35, 40, 57, 60, 100 };

// Program p = new Program();
// p.OddEven(arr);
//}



//static void TekCutTap(int[] arr)
//{
//for (int i = 0; i < arr.Length; i++)
// {

// if (arr[i] % 2 == 0)
// {
//    Console.WriteLine(arr[i] + " cutdur");
// }
// else
// {
//    Console.WriteLine(arr[i] + " tekdir");
//}
//}
//}


int[] ededler = { 14, 20, 35, 40, 57, 60, 100 };
TekCutTap(ededler);
static void SimvolSay(string cumle, char simvol)
{
 int say = 0;
 for (int i = 0; i < cumle.Length; i++)
 {
  if (cumle[i] == simvol)
 {
  say++;
 }
   }

 Console.WriteLine($"'{simvol}' simvolu cümlədə {say} dəfə var.");
}


//string cumle = "elimden geleni etmeye calisiram";
//char simvol = 'e';


//SimvolSay(cumle, simvol);

