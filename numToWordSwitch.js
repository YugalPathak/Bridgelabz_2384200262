// Read number from command line argument 
let num = parseInt(process.argv[2]); 
 
// Check if the input is valid 
if (isNaN(num) || num < 0 || num > 9) { 
    console.log("Please enter a single digit number 
(0-9)."); 
    process.exit(1); 
} 
 
// Convert number to word using switch-case 
let word; 
switch (num) { 
    case 0: word = "Zero"; break; 
    case 1: word = "One"; break; 
    case 2: word = "Two"; break; 
    case 3: word = "Three"; break; 
    case 4: word = "Four"; break; 
    case 5: word = "Five"; break; 
    case 6: word = "Six"; break; 
    case 7: word = "Seven"; break; 
    case 8: word = "Eight"; break; 
    case 9: word = "Nine"; break; 
    default: word = "Invalid"; break; 
} 
 
console.log(Number in word: ${word});