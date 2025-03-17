function gamblerGame(startMoney, goalMoney) { 
let money = startMoney; 
let bets = 0; 
let wins = 0; 
    while (money > 0 && money < goalMoney) { 
        bets++; 
        let betResult = Math.random() < 0.5; // 50% chance 
to win or lose 
 
        if (betResult) { 
            money++; // Win ₹1 
            wins++; 
        } else { 
            money--; // Lose ₹1 
        } 
 
        console.log(Bet ${bets}: ${betResult ? "Win" : 
"Lose"} | Current Money: ₹${money}); 
    } 
 
    console.log(\nTotal Bets: ${bets}); 
    console.log(Total Wins: ${wins}); 
    console.log(money === goalMoney ? " Goal Reached! You 
Won! " : " You are Broke! Game Over. "); 
} 
 
// Start game with ₹100 and goal of ₹200 
gamblerGame(100, 200); 