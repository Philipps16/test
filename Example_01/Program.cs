void PrintArray1 (string [] array)
{
    Console.WriteLine ($"Начальный массив: ");
    for (int i = 0; i < array.Length; i++)
    Console.Write ($"{array[i]} ");
}







Console.Clear();
string [] array = new string [5] {"123", "test", "word", "or", "mail"};
PrintArray1 (array);
Console.WriteLine();
Console.WriteLine ("Результат");
PrintArray2(array);
