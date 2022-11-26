Console.WriteLine("Hello!!!");
Console.WriteLine("Введите массив через запятую");

string arrayenter = Console.ReadLine();
string[] array = arrayenter.Split(",");
string[] array2 = new string[array.Length];
