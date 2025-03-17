// Read command-line argument n 
let n = parseInt(process.argv[2]); 
 
// Validate input 
if (isNaN(n) || n < 0) { 
    console.log("Please enter a valid non-negative integer."); 
    process.exit(1); 
} 
 
// Initialize factorial as 1 
let factorial = 1; 
 
// Calculate factorial using a for loop 
for (let i = 1; i <= n; i++) { 
    factorial *= i; 
} 
 
// Print result 
console.log(Factorial of ${n} is: ${factorial});