// Read command-line arguments for range 
let start = parseInt(process.argv[2]); 
let end = parseInt(process.argv[3]); 
 
// Validate input 
if (isNaN(start) || isNaN(end) || start < 2 || end < 2 || start > end) 
{ 
    console.log("Please enter a valid range (both numbers should be >= 
2 and start should be <= end)."); 
    process.exit(1); 
} 
 
// Function to check if a number is prime 
function isPrime(n) { 
    if (n < 2) return false; 
    for (let i = 2; i <= Math.sqrt(n); i++) { 
        if (n % i === 0) return false; 
    } 
    return true; 
} 
 
// Find and print prime numbers in the given range 
console.log(Prime numbers between ${start} and ${end} are:); 
for (let num = start; num <= end; num++) { 
    if (isPrime(num)) { 
        process.stdout.write(num + " "); // Print numbers in a single 
line 
    } 
} 
console.log(); // New line after output