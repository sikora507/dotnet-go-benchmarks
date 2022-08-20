# C# vs GO benchmarks

Same algoritms written in the most similar way possible in C# and GO for perfornamce comparison.

Each directory in the root should contain 'dotnet' and 'go' subdirectories as well as the python script that will run the benchmarks and write normalized output to a file.

The python script in the root directory runs all or selected benchmarks, gets the statistict and plots the charts.

## List of benchmarks

### 01-primes-naive

Prime numbers search. Naive approach.

### 02-primes-sieve-of-eratosthenes

Prime numbers search. Optimized approach.

### 03-fibonacci-recursive

X first fibonacci numbers using recursion.

### 04-fibonacci-iterative

X first fibonacci numbers using iterative approach.

### 05-web-api

Simple web api.
Testing GET requests for the same data with bombardier load testing tool.

GO version is based on GIN tutorial from go.dev website: https://go.dev/doc/tutorial/web-service-gin
