times.function flipCoin() { 
    return Math.random() < 0.5 ? "Heads" : "Tails"; // 50% 
chance 
} 
 
let headsCount = 0; 
let tailsCount = 0; 
const WINNING_SCORE = 11; 
 
while (headsCount < WINNING_SCORE && tailsCount < 
WINNING_SCORE) { 
    let result = flipCoin(); 
 
    if (result === "Heads") { 
        headsCount++; 
    } else { 
        tailsCount++; 
    } 
 
    console.log(Flip: ${result} | Score -> Heads: 
${headsCount}, Tails: ${tailsCount}); 
} 
 
console.log(`\n${headsCount === WINNING_SCORE ? "Heads" : 
"Tails"} wins the game! `);