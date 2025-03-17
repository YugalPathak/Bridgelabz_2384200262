// Read command-line argument n 
let n = parseInt(process.argv[2]); 
 
// Validate input 
if (isNaN(n) || n < 2) { 
    console.log("Please enter a valid integer greater than or equal to 
2."); 
    process.exit(1); 
} 
 
// Assume n is prime 
let isPrime = true; 
 
// Check for factors from 2 to sqrt(n) 
for (let i = 2; i <= Math.sqrt(n); i++) { 
    if (n % i === 0) { 
        isPrime = false; 
        break; 
    } 
} 
 
// Print result 
if (isPrime) { 
    console.log(${n} is a Prime Number.); 
} else { 
    console.log(${n} is NOT a Prime Number.); 
}