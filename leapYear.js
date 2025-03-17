// Read year from command line argument
let year = parseInt(process.argv[2]);

// Check if it's a 4-digit number
if (year < 1000 || year > 9999)
{
    console.log("Please enter a valid 4-digit year.");
}
else
{
// Check Leap Year condition
if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0))
{
    console.log(year + " is a Leap Year.");
}
else
{
    console.log(year + " is NOT a Leap Year.");
}
}
