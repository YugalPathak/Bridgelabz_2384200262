// Read number from command line argument 
let num = parseInt(process.argv[2]); 
 
// Check if the input is valid 
if (isNaN(num)) { 
    console.log("Please enter a valid number (1, 10, 100, 
1000, etc.)."); 
} else { 
    let place; 
 
    // Convert number to place value using if-else 
    if (num === 1) place = "Unit"; 
    else if (num === 10) place = "Ten"; 
    else if (num === 100) place = "Hundred"; 
    else if (num === 1000) place = "Thousand"; 
    else if (num === 10000) place = "Ten Thousand"; 
    else if (num === 100000) place = "Lakh"; 
    else if (num === 1000000) place = "Ten Lakh"; 
    else if (num === 10000000) place = "Crore"; 
    else if (num === 100000000) place = "Ten Crore"; 
    else { 
        console.log("Please enter a valid number like 1, 
10, 100, 1000, etc."); 
        process.exit(1); 
    } 
 
console.log("Place value:", place); 
}