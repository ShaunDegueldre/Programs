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



//creation of long named function
const checkThatTwoPlusTwoEqualsFourAMillionTimes = () => {
    for (let i = 1; i <= 1000000; i++) {
        if ((2 + 2) != 4) {
            console.log('Something has gone very wrong :( ');
        }
    }
};
//changing name of function to shorter created name
const is2p2 = checkThatTwoPlusTwoEqualsFourAMillionTimes;
//calling function with the newly created name
is2p2();
//checking the original name of the function
console.log(is2p2.name);



//FUNCTIONS as PARAMETERS
//FUNCTIONS as PARAMETERS
//creation of function that checks if 2+2=4 a million times
const checkThatTwoPlusTwoEqualsFourAMillionTimes = () => {
    for (let i = 1; i <= 1000000; i++) {
        if ((2 + 2) != 4) {
            console.log('Something has gone very wrong :( ');
        }
    }
};
//function that takes a num and adds two then calls the result addTwo
const addTwo = num => num + 2;
//function that checks the runtime and returns it for a function
const timeFuncRuntime = funcParameter => {
    let t1 = Date.now();
    funcParameter();
    let t2 = Date.now();
    return t2 - t1;
};


const time2p2 = timeFuncRuntime(checkThatTwoPlusTwoEqualsFourAMillionTimes);
//creation of function with an input of a function and a value
const checkConsistentOutput = (func, val) => {
    //if the callback function produces the same result twice, it should return the result of the function call, otherwise, it should return the string
    let firstTry = func(val);
    let secondTry = func(val);
    if (firstTry === secondTry) {
        return firstTry
    } else {
        return 'This function returned inconsistent results'
    }
};

console.log(checkConsistentOutput(addTwo, 5));