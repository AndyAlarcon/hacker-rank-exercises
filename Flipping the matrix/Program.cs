﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    public static void print(List<List<int>> matrix)
    {
        Console.WriteLine("\n");

        foreach (var row in matrix)
        {
            string line = string.Empty;
            foreach (var col in row)
            {
                line += Convert.ToString(col) + " ";
            }
            Console.WriteLine(line);
        }
    }
    public static List<List<int>> reverseMatrix(List<List<int>> matrix)
    {
        List<List<int>> reverseMatrix = new List<List<int>>();

        for (int i = 0; i < matrix.Count; i++)
        {
            List<int> reverseRow = new List<int>();

            for(int j = 0; j < matrix.Count; j++)
            {
                reverseRow.Add(matrix[j][i]);
            }
            reverseMatrix.Add(reverseRow);
        }
        return reverseMatrix;
    }
    public static int flippingMatrix(List<List<int>> matrix)
    {
        // var n = matrix.Count / 2;

        // // print (reverseMatrix(matrix));

        // for (int i = 0; i < matrix.Count; i++)
        // {
        //     if (matrix[i].Take(n).Sum(p => p) < matrix[i].Skip(n).Sum(p => p))
        //     {
        //         matrix[i].Reverse();
        //     }
        // }
        // Console.WriteLine("Operación en filas");

        // print(matrix);

        // var reverseAuxMatrix = reverseMatrix(matrix);

        // for (int i = 0; i < matrix.Count; i++)
        // {
        //     if (reverseAuxMatrix[i].Take(n).Sum(p => p) < reverseAuxMatrix[i].Skip(n).Sum(p => p))
        //     {
        //         reverseAuxMatrix[i].Reverse();
        //     }
        // }
        // Console.WriteLine("Operación en columnas");
        // print(reverseAuxMatrix);


        // matrix = reverseMatrix(reverseAuxMatrix);

        // Console.WriteLine("final");

        // print(matrix);

        var maxRowSum = 0;

        for(int i = 0; i < matrix.Count; i ++)
        {

        }

        return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix);

            // textWriter.WriteLine(result);
        }

        // textWriter.Flush();
        // textWriter.Close();
    }
}
