// JavaScript source code
//naming a varialble plantNeedsWater and using the function to do so
const plantNeedsWater = function (day) {
    //if statement to determine the boolean value of the variable.
    if (day === 'Wednesday') {
        return true;
    } else {
        return false;
    }
}
//passing in the parameter to the function and printing to console.
console.log(plantNeedsWater('Tuesday'));

