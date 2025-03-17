const prompt = require("prompt-sync")(); // For user input 
 
// Function to convert Celsius to Fahrenheit 
function cToF(celsius) { 
    return (celsius * 9/5) + 32; 
} 
 
// Function to convert Fahrenheit to Celsius 
function fToC(fahrenheit) { 
    return (fahrenheit - 32) * 5/9; 
} 
 
// Ask user for conversion type 
console.log("Choose Conversion:"); 
console.log("1. Celsius to Fahrenheit"); 
console.log("2. Fahrenheit to Celsius"); 
 
let choice = prompt("Enter choice (1 or 2): "); 
 
if (choice == "1") { 
    let celsius = prompt("Enter temperature in Celsius: "); 
    console.log(${celsius}°C = ${cToF(celsius).toFixed(2)}°F); 
}  
else if (choice == "2") { 
    let fahrenheit = prompt("Enter temperature in Fahrenheit: "); 
    console.log(${fahrenheit}°F = ${fToC(fahrenheit).toFixed(2)}°C); 
}  
else { 
    console.log("Invalid choice! Please enter 1 or 2."); 
}