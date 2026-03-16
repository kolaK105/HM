using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Matrix
{

    private char[,] _matrix;

    private int liters;


    public int Vowels
    {
        get { return liters; }
        private set { liters = value; }
    }


    public Matrix(char[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new ArgumentException("Масив має бути квадратним, щоб мати повноцінні діагоналі.");
        }

        _matrix = matrix;
        CalcVowels();
    }

    //Підрахування голосних літер.
    private void CalcVowels()
    {
        char[] vowels = "aeiouAEIOU".ToCharArray();
        int count = 0;

        foreach (char c in _matrix)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        Vowels = count;
    }


    public string this[int diagonalType]
    {
        get
        {
            int size = _matrix.GetLength(0);
            char[] diagonalChars = new char[size];

            if (diagonalType == 0) // Головна діагональ
            {
                for (int i = 0; i < size; i++)
                {
                    diagonalChars[i] = _matrix[i, i];
                }
            }
            else if (diagonalType == 1) // Побічна діагональ
            {
                for (int i = 0; i < size; i++)
                {
                    diagonalChars[i] = _matrix[i, size - 1 - i];
                }
            }
            else
            {
                throw new IndexOutOfRangeException(". . . . . . . . .");
            }

            return new string(diagonalChars);
        }
    }
}
