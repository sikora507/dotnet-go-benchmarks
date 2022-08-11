public static class PrimesSieve
{
    public static long[] FindPrimeNumbersSieve(long max)
    {
        var b = new bool[max];
        var primes = new List<long>();

        for (long i = 2; i < max; i++)
        {
            if (b[i])
            {
                continue;
            }

            primes.Add(i);

            for (var k = i * i; k < max; k += i)
            {
                b[k] = true;
            }
        }

        return primes.ToArray();
    }
}