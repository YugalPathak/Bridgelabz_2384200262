const prompt = require("prompt-sync")(); // For user input 
 
// Function to check if a number is a palindrome 
function isPalindrome(num) { 
    let originalNum = num.toString(); 
    let reversedNum = 
originalNum.split("").reverse().join(""); 
    return originalNum === reversedNum; 
} 
 
// Function to check if two numbers are palindromes 
function checkTwoPalindromes(num1, num2) { 
    let isNum1Palindrome = isPalindrome(num1); 
    let isNum2Palindrome = isPalindrome(num2); 
 
    console.log(${num1} ${isNum1Palindrome ? "is" : "is 
NOT"} a Palindrome.); 
    console.log(${num2} ${isNum2Palindrome ? "is" : "is 
NOT"} a Palindrome.); 
 
    if (isNum1Palindrome && isNum2Palindrome) { 
        console.log("Both numbers are Palindromes! "); 
    } else { 
        console.log(" Both numbers are NOT Palindromes."); 
    } 
} 
 
// Taking user input 
let num1 = parseInt(prompt("Enter first number: ")); 
let num2 = parseInt(prompt("Enter second number: ")); 
// Check both numbers 
checkTwoPalindromes(num1, num2);