// Read command-line argument n 
let n = parseInt(process.argv[2]); 
 
// Validate input 
if (isNaN(n) || n <= 0) { 
    console.log("Please enter a valid positive integer."); 
    process.exit(1); 
} 
 
// Initialize harmonic sum 
let harmonicSum = 0; 
 
// Calculate nth harmonic number using a for loop 
for (let i = 1; i <= n; i++) { 
    harmonicSum += 1 / i; 
} 
 
// Print the result 
console.log(The ${n}th Harmonic Number is: ${harmonicSum.toFixed(4)}); 
 
