function generateBirthMonths() {
    let birthData = {}; // Dictionary to store individuals by month

    // Initialize dictionary with empty arrays for each month
    for (let i = 1; i <= 12; i++) {
        birthData[i] = [];
    }

    // Generate birth months for 50 individuals
    for (let i = 1; i <= 50; i++) {
        let birthMonth = Math.floor(Math.random() * 12) + 1; // Random month (1-12)
        birthData[birthMonth].push(Person${i}); // Store in respective month
    }

    return birthData;
}

// Generate and store birth months
let birthMonths = generateBirthMonths();

// Print results
console.log("Individuals grouped by birth month:");
for (let month in birthMonths) {
    console.log(Month ${month}: ${birthMonths[month].length > 0 ? birthMonths[month].join(", ") : "No birthdays"});
}