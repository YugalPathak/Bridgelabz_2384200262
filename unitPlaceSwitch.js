// Read number from command line argument 
let num = parseInt(process.argv[2]); 
 
// Check if the input is valid (must be 1, 10, 100, 1000, 
...) 
if (isNaN(num)) { 
    console.log("Please enter a valid number."); 
    process.exit(1); 
} 
 
// Convert number to place value using switch-case 
let placeValue; 
switch (num) { 
    case 1: placeValue = "Unit"; break; 
    case 10: placeValue = "Ten"; break; 
    case 100: placeValue = "Hundred"; break; 
    case 1000: placeValue = "Thousand"; break; 
    case 10000: placeValue = "Ten Thousand"; break; 
    case 100000: placeValue = "Lakh"; break; 
    case 1000000: placeValue = "Ten Lakh"; break; 
    case 10000000: placeValue = "Crore"; break; 
    default:  
        console.log("Please enter a valid place value (1, 
10, 100, 1000, etc.)."); 
        process.exit(1); 
} 
 
console.log(Place Value: ${placeValue}); 
