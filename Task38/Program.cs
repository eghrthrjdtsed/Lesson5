// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] arrayRealNumbers = new int[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

int maxNumber = arrayRealNumbers[0];
int minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  int decision = maxNumber - minNumber;

  Console.Write($"\n Максимальный элемент:({maxNumber})"); 
  Console.Write($"\n Минимальный элемент:({minNumber})");
  Console.WriteLine($"\n Разница между элементами:({decision})");