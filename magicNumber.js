const readline = require("readline"); 
 
// Create readline interface for user input 
const rl = readline.createInterface({ 
    input: process.stdin, 
    output: process.stdout 
}); 
 
console.log("Think of a number between 1 and 100. I will guess it!"); 
 
let low = 1, high = 100; 
let found = false; 
 
function askQuestion(query) { 
    return new Promise((resolve) => rl.question(query, resolve)); 
} 
 
async function findMagicNumber() { 
    while (low <= high && !found) { 
        let mid = Math.floor((low + high) / 2); 
        let answer = await askQuestion(`Is your number ${mid}? 
(yes/no): `); 
 
        if (answer.toLowerCase() === "yes") { 
            console.log(`Yay! Your magic number is ${mid} `); 
            found = true; 
        } else { 
            let greater = await askQuestion(`Is your number greater 
than ${mid}? (yes/no): `); 
            if (greater.toLowerCase() === "yes") { 
                low = mid + 1; 
            } else { 
                high = mid - 1; 
            } 
        } 
    } 
    rl.close(); 
} 
 
// Start the guessing process 
findMagicNumber();