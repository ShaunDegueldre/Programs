// JavaScript source code
//creation of cupsOfSugarNeeded variable
const cupsOfSugarNeeded = 2;
//since cupsAdded is changing it needs to be lets
let cupsAdded = 0;
//do portion of do-while loop which will always perform task once
do {
    //adding one to cupsAdded
    cupsAdded++;
    //printing the single cup added
    console.log(cupsAdded + ' cup was added')
    //start of while loop to loop through until condition is met
} while (cupsAdded < cupsOfSugarNeeded);