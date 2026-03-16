using System; 

class Program
{
    static void Main()
    {

        char[,] chars = {
            { 'a', 'b', 'O' },
            { 'd', 't', 'f' },
            { 'E', 'h', 'i' }
        };


        Matrix matrix = new Matrix(chars);


        Console.WriteLine($"Кількість голосних у масиві: {matrix.Vowels}");
        Console.WriteLine($"Головна діагональ [0]: {matrix[0]}");
        Console.WriteLine($"Побічна діагональ [1]: {matrix[1]}");


        Console.ReadLine();
    }
}
