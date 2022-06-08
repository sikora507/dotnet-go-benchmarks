package primes

import (
	"testing"
)

var table = []struct {
	input int
}{
	{input: 1000},
	{input: 10000},
	{input: 100000},
	{input: 1000000},
}

var num = 1000

func BenchmarkPrimeNumbers(b *testing.B) {
	for i := 0; i < b.N; i++ {
		findPrimeNumbers(num)
	}
}
