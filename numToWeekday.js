// Read number from command line argument 
let num = parseInt(process.argv[2]); 
 
// Check if number is between 1 and 7 
if (num < 1 || num > 7 || isNaN(num)) { 
    console.log("Please enter a valid number between 1 and 
7."); 
} else { 
    let day; 
 
    // Convert number to week day using if-else 
    if (num === 1) day = "Sunday"; 
    else if (num === 2) day = "Monday"; 
    else if (num === 3) day = "Tuesday"; 
    else if (num === 4) day = "Wednesday"; 
    else if (num === 5) day = "Thursday"; 
    else if (num === 6) day = "Friday"; 
    else if (num === 7) day = "Saturday"; 
 
console.log("Weekday:", day); 
} 