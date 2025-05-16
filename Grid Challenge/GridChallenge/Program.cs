using System.CodeDom.Compiler;
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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        List<char[]> orderedGrid = new List<char[]>();
        foreach(var row in grid)
        {
            var array = row.ToCharArray().OrderBy(x=>x).ToArray();
            // orderedGrid.Add(new string(array));
            orderedGrid.Add(array);
        }
        // bool sortedColumn = true;
        for(int i = 0; i< orderedGrid.Count; i++)
        {
            for(int j = 0; j < orderedGrid.Count -1; j++)
            {
                // var valA = orderedGrid[j][i];
                // var valB = orderedGrid[j+1][i];
                // var a = (int)orderedGrid[j][i];
                // var b = (int)orderedGrid[j+1][i];
                if((int)orderedGrid[j][i] > (int)orderedGrid[j+1][i])
                {
                    // sortedColumn = false;
                    return "NO";
                }
            }
        }
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);
            Console.WriteLine(result);
            // textWriter.WriteLine(result);
        }

        // textWriter.Flush();
        // textWriter.Close();
    }
}
