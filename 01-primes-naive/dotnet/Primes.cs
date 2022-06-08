public static class Primes
{
    public static long[] FindPrimeNumbers(long range)
    {
        var primes = new List<long>();
        for (long i = 2; i < range; i++)
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