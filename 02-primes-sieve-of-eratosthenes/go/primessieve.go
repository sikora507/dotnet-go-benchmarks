package primessieve

func findPrimeNumbersSieveOfEratosthenes(max int) []int {
	b := make([]bool, max)

	var primes []int

	for i := 2; i < max; i++ {
		if b[i] {
			continue
		}

		primes = append(primes, i)

		for k := i * i; k < max; k += i {
			b[k] = true
		}
	}

	return primes
}
