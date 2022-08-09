public static class PrimesSieve
{
    public static long[] FindPrimeNumbersSieve(long max)
    {
        var primes = new List<long>();
        for (long i = 2; i < max; i++)
        {
            var isPrime = true;
            for (long j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }
        return primes.ToArray();
    }
}