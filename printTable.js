// Read command-line argument n 
let n = parseInt(process.argv[2]); 
 
// Validate input 
if (isNaN(n) || n < 0) { 
    console.log("Please enter a valid non-negative integer."); 
    process.exit(1); 
} 
 
// Print header 
console.log(`\nPower of 2 Table (Up to 2^${n}):\n`); 
 
// Print powers of 2 using a for loop 
for (let i = 0; i <= n; i++) { 
    console.log(`2^${i} = ${Math.pow(2, i)}`); 
} 
