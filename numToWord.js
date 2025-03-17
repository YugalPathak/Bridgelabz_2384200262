// Read number from command line argument 
let num = parseInt(process.argv[2]); 
 
// Check if number is a single digit (0-9) 
if (num < 0 || num > 9 || isNaN(num)) { 
    console.log("Please enter a valid single-digit number 
(0-9)."); 
} else { 
    let word; 
 
    // Convert number to word using if-else 
    if (num === 0) word = "Zero"; 
    else if (num === 1) word = "One"; 
    else if (num === 2) word = "Two"; 
    else if (num === 3) word = "Three"; 
    else if (num === 4) word = "Four"; 
    else if (num === 5) word = "Five"; 
    else if (num === 6) word = "Six"; 
    else if (num === 7) word = "Seven"; 
    else if (num === 8) word = "Eight"; 
    else if (num === 9) word = "Nine"; 
 
    console.log("Number in word:", word); 
}