function primeFactors(n) {
    let factors = [];

    // Step 1: Remove all 2s (smallest prime)
    while (n % 2 === 0) {
        factors.push(2);
        n = n / 2;
    }

    // Step 2: Remove odd prime factors from 3 to sqrt(n)
    for (let i = 3; i <= Math.sqrt(n); i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = n / i;
        }
    }

    // Step 3: If n is a prime number > 2, add it
    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

// Example: Find prime factors of 120
let number = 120;
let result = primeFactors(number);

console.log(Prime Factors of ${number}:, result);