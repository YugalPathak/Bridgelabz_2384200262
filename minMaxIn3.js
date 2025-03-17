// Read numbers from command line arguments 
let a = parseFloat(process.argv[2]); 
let b = parseFloat(process.argv[3]); 
let c = parseFloat(process.argv[4]); 
 
// Check if inputs are valid numbers 
if (isNaN(a) || isNaN(b) || isNaN(c)) { 
    console.log("Please enter valid numbers."); 
    process.exit(1); 
} 
 
// Perform arithmetic operations 
let result1 = a + b * c; 
let result2 = a % b + c; 
let result3 = c + a / b; 
let result4 = a * b + c; 
 
console.log(`1. a + b * c = ${result1}`); 
console.log(`2. a % b + c = ${result2}`); 
console.log(`3. c + a / b = ${result3}`); 
console.log(`4. a * b + c = ${result4}`); 
 
// Finding Maximum Value using if-else-if 
let maxValue = result1; 
if (result2 > maxValue) maxValue = result2; 
if (result3 > maxValue) maxValue = result3; 
if (result4 > maxValue) maxValue = result4; 
 
// Finding Minimum Value using if-else-if 
let minValue = result1; 
if (result2 < minValue) minValue = result2; 
if (result3 < minValue) minValue = result3; 
if (result4 < minValue) minValue = result4; 
 
console.log(`Maximum value: ${maxValue}`); 
console.log(`Minimum value: ${minValue}`); 
