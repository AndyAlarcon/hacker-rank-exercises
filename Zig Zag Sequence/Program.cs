namespace Zig_Zag_Sequence;
using System.Linq;

class Result
{
    public static string findZigZagSequencev1(List<int> arr)
    {
        var increasingSubList = new List<int>();
        var decreasingSubList = new List<int>();
        
        var cont = 0;
        var shift = true;

        arr = arr.OrderBy(p=>p).ToList();

        increasingSubList.Add(arr[0]);

        for (int i = 1; i < arr.Count; i++)
        {
            if(cont == 2)
            {
                shift = !shift;
                cont = 0;
            }
            if(shift)
            {
                decreasingSubList.Add(arr[i]);
                cont++;
            }
            else
            {
                increasingSubList.Add(arr[i]);
            }
        }

        increasingSubList.AddRange(decreasingSubList.OrderByDescending(p=>p));

        return increasingSubList.Aggregate("", (item, next) => {
            if(item == string.Empty)
            {
                item += next;
            }
            else
            {   
                item += " " + next;
            }
            return item;
        });
    }
    public static string findZigZagSequencev2(List<int> arr)
    {
        var ZigZagList = arr.OrderBy(p=>p).Take(Convert.ToInt16(arr.Count/2)).ToList();

        ZigZagList.AddRange(arr.OrderByDescending(p=>p).Take(Convert.ToInt16(arr.Count/2) + 1).ToList());
        
        return  ZigZagList.Aggregate("", (item, next) => {
            if(item == string.Empty)
            {
                item += next;
            }
            else
            {   
                item += " " + next;
            }
            return item;
        });

    }
}
class Solution
{
    static void Main(string[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(p => Convert.ToInt32(p)).ToList();
            Console.WriteLine(Result.findZigZagSequencev2(arr));
        }

    }
}
