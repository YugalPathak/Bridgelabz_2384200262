// Read command-line argument n 
let n = parseInt(process.argv[2]); 
 
// Validate input 
if (isNaN(n) || n < 0) { 
    console.log("Please enter a valid non-negative 
integer."); 
    process.exit(1); 
} 
 
let power = 0; 
let result = 1; // 2^0 = 1 
 
console.log(Table of Powers of 2 till 2^${n} or 256:); 
 
// Use while loop to calculate powers of 2 
while (power <= n && result <= 256) { 
    console.log(2^${power} = ${result}); 
    power++; 
    result *= 2; // Multiply by 2 for next power 
} 
