// написать прогу, которая принимает массив из строчных элементов, 
// и формирует массив в котором количество символов меньше или равно 3
// задать с клавиатуры или на старте программы, не использовать коллекции

Console.WriteLine("Давайте выведем на экран только те элементы нашего массива, размер которых 3 или меньше символов");
Console.WriteLine("Укажите количество слов, которое вы хотите проверить");
int quantity=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Необходимые слова водите через  ENTER");
string [] words= new string [quantity];//создали массив из строчных элементов и его заполнили
for (int k=0; k<quantity; k++)
{
    words[k]=Console.ReadLine();
}
string [] normalWords= new string [words.Length];
for (int i=0; i<words.Length; i++)//проверка на количество символов в каждом элементе
{
    if (words[i].Length<4)
    {
        for (int j=0; j<normalWords.Length; j++)
        {
            normalWords[j]=words[i];
        }
    }
}
Console.WriteLine(String.Join(", ", words));//вывод первого массива
Console.WriteLine(String.Join(", ", normalWords));//вывод контрольного массива