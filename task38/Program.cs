void InputArray (double [] array)
{
    for (int i =0; i < array.Length; i++)
    array [i] = Math.Round(new Random (). NextDouble()*10,  3);
}
    double CountEventNumbers (double [] array)
    {
        double minArray=array [0], maxArray=array [0];
    for (int i =1; i < array.Length; i++)
    {
        if ( maxArray < array[i])
        maxArray=array[i];
        else if (minArray> array[i])
        minArray=array[i];

    }
    return maxArray-minArray;
    }
    Console.Clear ();
Console.Write ("Введите массив: ");
int n=Convert.ToInt32 (Console.ReadLine());
double [] array = new double [n];
InputArray (array);
Console.Write ($"[{string.Join(", ", array)}]");
Console.Write ($"разница между максимальным и минимальным элементами массива:{CountEventNumbers (array)}");

