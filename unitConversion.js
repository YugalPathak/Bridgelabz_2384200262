// a. Convert 42 inches to feet
let inches = 42;
let feet = inches / 12;
console.log(`${inches} inches = ${feet.toFixed(2)} feet`);

// b. Convert Rectangular Plot (60ft x 40ft) to meters
let lengthFeet = 60;
let widthFeet = 40;
let feetToMeters = 0.3048; // 1 foot = 0.3048 meters

let lengthMeters = lengthFeet * feetToMeters;
let widthMeters = widthFeet * feetToMeters;
console.log(`Plot Size: ${lengthFeet}ft x ${widthFeet}ft = ${lengthMeters.toFixed(2)}m x ${widthMeters.toFixed(2)}m`);

// c. Calculate area of 25 such plots in acres
let plotAreaMeters = lengthMeters * widthMeters;
let totalPlots = 25;
let totalAreaMeters = plotAreaMeters * totalPlots;
let metersToAcres = 0.000247105; // 1 sq meter = 0.000247105 acres

let totalAreaAcres = totalAreaMeters * metersToAcres;
console.log(`Total area of ${totalPlots} plots in acres: ${totalAreaAcres.toFixed(4)} acres`);