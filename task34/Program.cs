void InputArray (int [] array)
{
    for (int i =0; i < array.Length; i++)
    array [i] = new Random (). Next (100, 1000);

}
int CountEventNumbers (int [] array)
{
    int count=0;
    for (int i =0; i < array.Length; i++)
    {
        if (array [i]%2==0)
        count++;
    }
    return count;
}
Console.Clear ();
Console.Write ("Введите массив: ");
int n=Convert.ToInt32 (Console.ReadLine());
int [] array = new int [n];
InputArray (array);
Console.Write ($"[{string.Join(", ", array)}]");
Console.Write ($"кол-во четных элементов:{CountEventNumbers (array)}");
