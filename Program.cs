// написать прогу, которая принимает массив из строчных элементов, 
// и формирует массив в котором количество символов меньше или равно 3
// задать с клавиатуры или на старте программы, не использовать коллекции

string [] words= {"rex", "text", "sdfsdf"};
string [] normalWords= new string [words.Length];
for (int i=0; i<words.Length; i++)
{
    if (words[i].Length<4)
    {
        for (int j=0; j<normalWords.Length; j++)
        {
            normalWords[j]=words[i];
        }
    }
}
Console.WriteLine(String.Join(", ", words));
Console.WriteLine(String.Join(", ", normalWords));