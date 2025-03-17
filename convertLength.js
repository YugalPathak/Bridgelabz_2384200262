// Import readline module for user input 
const readline = require('readline'); 
// Create interface for user input 
const rl = readline.createInterface({ 
    input: process.stdin, 
    output: process.stdout 
}); 
 
// Display menu 
console.log("\nUnit Conversion Menu:"); 
console.log("1: Feet to Inch"); 
console.log("2: Feet to Meter"); 
console.log("3: Inch to Feet"); 
console.log("4: Meter to Feet"); 
 
// Prompt user for choice 
rl.question("\nEnter the conversion type (1-4): ", 
function(choice) { 
    rl.question("Enter the value to convert: ", 
function(value) { 
        let convertedValue; 
        value = parseFloat(value); // Convert input to 
number 
         
        // Perform unit conversion 
        switch (parseInt(choice)) { 
            case 1: 
                convertedValue = value * 12; // 1 ft = 12 
inches 
                console.log(${value} Feet = 
${convertedValue} Inches); 
                break; 
            case 2: 
                convertedValue = value * 0.3048; // 1 ft = 
0.3048 meters 
                console.log(${value} Feet = 
${convertedValue.toFixed(4)} Meters); 
                break; 
            case 3: 
                convertedValue = value / 12; // 1 inch = 
1/12 feet 
                console.log(${value} Inches = 
${convertedValue.toFixed(4)} Feet); 
                break; 
            case 4: 
                convertedValue = value / 0.3048; // 1 meter 
= 3.28084 feet 
                console.log(${value} Meters = 
${convertedValue.toFixed(4)} Feet); 
                break; 
            default: 
                console.log("Invalid choice. Please enter a 
number between 1 and 4."); 
        } 
 
        // Close input interface 
rl.close(); 
}); 
});