void InputArray (int [] array)
{
    for (int i =0; i < array.Length; i++)
    array [i] = new Random (). Next (-10, 11);
}
    int CountEventNumbers (int [] array)
    {
    int sum=0;
    for (int i =1; i < array.Length; i+=2)
    sum=sum+array [i];
    return sum;
    }
    Console.Clear ();
Console.Write ("Введите массив: ");
int n=Convert.ToInt32 (Console.ReadLine());
int [] array = new int [n];
InputArray (array);
Console.Write ($"[{string.Join(", ", array)}]");
Console.Write ($"сумма эл-тов нечетных позиций:{CountEventNumbers (array)}");
