function findRepeatedDigitNumbers() {
    let repeatedNumbers = [];

    for (let i = 10; i <= 99; i++) {
        let strNum = i.toString();
        if (strNum[0] === strNum[1]) {
            repeatedNumbers.push(i);
        }
    }

    return repeatedNumbers;
}

// Get the repeated digit numbers
let repeatedDigitsArray = findRepeatedDigitNumbers();

// Print the result
console.log("Numbers with repeated digits:", repeatedDigitsArray);