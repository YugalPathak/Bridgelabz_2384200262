function findTriplets(arr) {
    let triplets = [];

    for (let i = 0; i < arr.length - 2; i++) {
        for (let j = i + 1; j < arr.length - 1; j++) {
            for (let k = j + 1; k < arr.length; k++) {
                if (arr[i] + arr[j] + arr[k] === 0) {
                    triplets.push([arr[i], arr[j], arr[k]]);
                }
            }
        }
    }
    
    return triplets;
}

// Example array (Modify as needed)
let numbers = [-3, 1, 2, -1, 4, 0, -2, -4, 3];
let result = findTriplets(numbers);

console.log("Triplets that sum to zero:", result);