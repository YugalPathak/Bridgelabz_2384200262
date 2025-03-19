function getRandomNumber() {
    return Math.floor(Math.random() * 900) + 100; // Generate 3-digit random number
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

// Step 2: Find 2nd largest and 2nd smallest without sorting
let result = findSecondLargestAndSmallest(numbers);
console.log("Without Sorting - Second Largest:", result.secondLargest);
console.log("Without Sorting - Second Smallest:", result.secondSmallest);

// Step 3: Sort the array
let sortedNumbers = [...numbers].sort((a, b) => a - b);
console.log("Sorted Numbers:", sortedNumbers);

// Step 4: Find 2nd largest and 2nd smallest from the sorted array
let secondSmallestSorted = sortedNumbers[1];  // 2nd element
let secondLargestSorted = sortedNumbers[sortedNumbers.length - 2]; // 2nd last element

console.log("With Sorting - Second Largest:", secondLargestSorted);
console.log("With Sorting - Second Smallest:", secondSmallestSorted);