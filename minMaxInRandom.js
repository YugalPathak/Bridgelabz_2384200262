function getRandomNumber() {
    return Math.floor(Math.random() * 900) + 100; // 3-digit random number
}

function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
        // Find largest and second largest
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        // Find smallest and second smallest
        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    return { secondLargest, secondSmallest };
}

// Step 1: Generate 10 random 3-digit numbers
let numbers = Array.from({ length: 10 }, getRandomNumber);

console.log("Generated Numbers:", numbers);

// Step 2 & 3: Find the 2nd largest and 2nd smallest numbers
let result = findSecondLargestAndSmallest(numbers);

console.log("Second Largest:", result.secondLargest);
console.log("Second Smallest:", result.secondSmallest);