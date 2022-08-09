package primessieve

import (
	"fmt"
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

func BenchmarkPrimeNumbersSieve(b *testing.B) {
	for _, v := range table {
		b.Run(fmt.Sprintf("input_size_%d", v.input), func(b *testing.B) {
			for i := 0; i < b.N; i++ {
				findPrimeNumbersSieveOfEratosthenes(v.input)
			}
		})
	}
}
