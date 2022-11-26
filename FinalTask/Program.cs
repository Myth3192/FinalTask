Console.WriteLine("Hello!!!");
Console.WriteLine("Введите массив через запятую");

string arrayenter = Console.ReadLine();
string[] array = arrayenter.Split(",");
string[] array2 = new string[array.Length];

for (int i=0; i<array.Length; i++)
{
   if (array[i].Length <= 3)
   {
        array2[i] = array[i];
        
    }
    
}