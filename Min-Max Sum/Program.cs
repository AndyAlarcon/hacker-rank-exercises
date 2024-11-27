 List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

miniMaxSum(arr);


static void miniMaxSum(List<Int64> arr)
{
    if(!arr.Any(p=>p < 1 || p > 10e9))
    {
        Int64 minimumSum = arr.OrderBy(p=> p).Take(arr.Count -1).Sum(p=> p);
        Int64 maximumSum = arr.OrderByDescending(p=> p).Take(arr.Count -1).Sum(p=> p);
        Console.WriteLine(minimumSum + " " + maximumSum);
    }
}