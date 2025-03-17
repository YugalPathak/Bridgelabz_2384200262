const prompt = require("prompt-sync")(); // For user input 
 
// Function to check if a number is prime 
function isPrime(num) { 
    if (num < 2) return false; 
    for (let i = 2; i <= Math.sqrt(num); i++) { 
        if (num % i === 0) return false; 
    } 
    return true; 
} 
 
// Function to get the palindrome of a number 
function getPalindrome(num) { 
    return parseInt(num.toString().split("").reverse().join("")); 
} 
 
// Main function to check if a number and its palindrome are both prime 
function checkPrimeAndPalindrome() { 
    let num = parseInt(prompt("Enter a number: ")); 
 
    if (isPrime(num)) { 
        console.log(${num} is a Prime Number.); 
        let palindrome = getPalindrome(num); 
        console.log(Palindrome of ${num} is ${palindrome}.); 
 
        if (isPrime(palindrome)) { 
            console.log(${palindrome} is also a Prime Number.); 
        } else { 
            console.log(${palindrome} is NOT a Prime Number.); 
        } 
    } else { 
        console.log(${num} is NOT a Prime Number.); 
    } 
} 
 
// Run the function 
checkPrimeAndPalindrome();