// написать прогу, которая принимает массив из строчных элементов, 
// и формирует массив в котором количество символов меньше или равно 3
// задать с клавиатуры или на старте программы, не использовать коллекции

Console.WriteLine($"Давайте выведем на экран только те элементы нашего массива, размер которых будет равен или меньше заданного");
Console.WriteLine("Введите какое количество символов в нашем элементе будет контрольным");
int sizeStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество слов, которое вы хотите проверить");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Необходимые слова водите через  ENTER");
string[] words = new string[quantity];//создали массив из строчных элементов и его заполнили
for (int k = 0; k < quantity; k++)
{
    words[k] = Console.ReadLine();
}
int count = 0;
for (int i = 0; i < words.Length; i++)//проверка на количество символов в каждом элементе
{
    if (words[i].Length < sizeStr)
    {
        count++;//проверяем сколько элементов и размер контрольного массива
    }
}
string[] normalWords = new string[count];//контрльный массив
int l = 0;
for (int j = 0; j < words.Length; j++)
{
    if (words[j].Length < sizeStr)
    {
        normalWords[l] = words[j];//поочередно проверяем элементы из первого массива, если подходит - записываем в контр. масс.
        l++;
    }
}
Console.WriteLine("Ваш введенный массив выглядит так:");
Console.WriteLine(String.Join(", ", words));//вывод первого массива
Console.WriteLine($"Массив, каждый элемент которого по длинне меньше или равен {sizeStr} выглядит так:");
Console.WriteLine(String.Join(", ", normalWords));//вывод контрольного массива