function rollDie() {
    return Math.floor(Math.random() * 6) + 1; // Generates number between 1 and 6
}

function simulateDiceRolls() {
    let diceCount = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 }; // Dictionary to store counts
    let maxRolls = 10;
    let reachedMax = false;

    while (!reachedMax) {
        let roll = rollDie();
        diceCount[roll]++;

        // Check if any number has reached maxRolls
        if (diceCount[roll] === maxRolls) {
            reachedMax = true;
        }
    }

    console.log("Final Dice Counts:", diceCount);

    // Find number that appeared the most and the least
    let maxNumber = Object.keys(diceCount).reduce((a, b) => (diceCount[a] > diceCount[b] ? a : b));
    let minNumber = Object.keys(diceCount).reduce((a, b) => (diceCount[a] < diceCount[b] ? a : b));

    console.log(Number that reached 10 times first: ${maxNumber});
    console.log(Number that appeared the least: ${minNumber});
}

simulateDiceRolls();