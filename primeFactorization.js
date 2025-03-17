// Read command-line argument N 
let N = parseInt(process.argv[2]); 
 
// Validate input 
if (isNaN(N) || N <= 1) { 
    console.log("Please enter a valid number greater than 1."); 
    process.exit(1); 
} 
 
// Function to find prime factors 
function findPrimeFactors(n) { 
    let factors = []; 
 
    // Remove factors of 2 
    while (n % 2 === 0) { 
        factors.push(2); 
        n = n / 2; 
    } 
 
    // Check odd numbers from 3 onwards 
    for (let i = 3; i * i <= n; i += 2) { 
        while (n % i === 0) { 
            factors.push(i); 
            n = n / i; 
        } 
    } 
 
    // If remaining number is prime and greater than 2, add it to factors 
    if (n > 2) { 
        factors.push(n); 
    } 
 
    return factors; 
} 
 
// Get prime factors and print them 
let primeFactors = findPrimeFactors(N); 
console.log(Prime factors of ${N} are: ${primeFactors.join(", ")}); 