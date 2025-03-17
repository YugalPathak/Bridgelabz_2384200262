// Read number from command line argument 
let num = parseInt(process.argv[2]); 
 
// Check if the input is valid (1-7) 
if (isNaN(num) || num < 1 || num > 7) { 
    console.log("Please enter a number between 1 and 7."); 
    process.exit(1); 
} 
 
// Convert number to weekday using switch-case 
let day; 
switch (num) { 
    case 1: day = "Sunday"; break; 
    case 2: day = "Monday"; break; 
    case 3: day = "Tuesday"; break; 
    case 4: day = "Wednesday"; break; 
    case 5: day = "Thursday"; break; 
    case 6: day = "Friday"; break; 
    case 7: day = "Saturday"; break; 
    default: day = "Invalid"; break; 
} 
 
console.log(Day: ${day});