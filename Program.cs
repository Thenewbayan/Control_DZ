// написать прогу, которая принимает массив из строчных элементов, 
// и формирует массив в котором количество символов меньше или равно 3
// задать с клавиатуры или на старте программы, не использовать коллекции

//два решения, для проверки каждого закоментить/раскоментить 
//первое решение строки 9-41
//второе решение строки 43-96

// Console.WriteLine($"Давайте выведем на экран только те элементы нашего массива, размер которых будет равен или меньше заданного");
// Console.WriteLine("Введите какое количество символов в нашем элементе будет контрольным");
// int sizeStr = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите количество слов, которое вы хотите проверить");
// int quantity = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Необходимые слова водите через  ENTER");
// string[] words = new string[quantity];//создали массив из строчных элементов и его заполнили
// for (int k = 0; k < quantity; k++)
// {
//     words[k] = Console.ReadLine();
// }
// int count = 0;
// for (int i = 0; i < words.Length; i++)//проверка на количество символов в каждом элементе
// {
//     if (words[i].Length < sizeStr)
//     {
//         count++;//проверяем сколько элементов и размер контрольного массива
//     }
// }
// string[] normalWords = new string[count];//контрльный массив
// int l = 0;
// for (int j = 0; j < words.Length; j++)
// {
//     if (words[j].Length < sizeStr)
//     {
//         normalWords[l] = words[j];//поочередно проверяем элементы из первого массива, если подходит - записываем в контр. масс.
//         l++;
//     }
// }
// Console.WriteLine("Ваш введенный массив выглядит так:");
// Console.WriteLine(String.Join(", ", words));//вывод первого массива
// Console.WriteLine($"Массив, каждый элемент которого по длинне меньше или равен {sizeStr} выглядит так:");
// Console.WriteLine(String.Join(", ", normalWords));//вывод контрольного массива

//или через методы
/// <summary>
/// Создание строчного массива с заданным размером
/// </summary>
/// <param name="size">размер массива строк</param>
/// <returns></returns>
string[] GetInputArray(int size)
{
    string[] inputArr = new string[size];
    for (int i = 0; i < size; i++)
    {
        inputArr[i] = Console.ReadLine();
    }
    return inputArr;
}
/// <summary>
/// Возвращает массив с элементами меньше или равно заданной длинны
/// </summary>
/// <param name="array">исходный массив</param>
/// <param name="length">контрольная длинна</param>
/// <returns></returns>
string[] GetSortedOfLengthArray(string[] array, int length)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            count++;
        }
    }
    string[] controlArray = new string[count];
    int j = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length <= length)
        {
            controlArray[j] = array[k];
            j++;
        }
    }
    return controlArray;
}
Console.WriteLine($"Давайте выведем на экран только те элементы нашего массива, размер которых будет меньше или равен заданного");
Console.WriteLine("Для начала задади размер массива и введем значения с клавиатуры");
int size = Convert.ToInt32(Console.ReadLine());
string[] userArray = GetInputArray(size);
Console.WriteLine("Зададим контрольный размер ");
int cotrolLength = Convert.ToInt32(Console.ReadLine());
string[] controlUserArray = GetSortedOfLengthArray(userArray, cotrolLength);
Console.WriteLine("Ваш введенный массив выглядит так:");
Console.WriteLine(String.Join(", ", userArray));
Console.WriteLine($"Массив, каждый элемент которого по длинне меньше или равен {cotrolLength} выглядит так:");
Console.WriteLine(String.Join(", ", controlUserArray));