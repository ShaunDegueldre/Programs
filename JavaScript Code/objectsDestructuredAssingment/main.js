﻿const robot = {
    model: '1E78V2',
    energyLevel: 100,
    functionality: {
        beep() {
            console.log('Beep Boop');
        },
        fireLaser() {
            console.log('Pew Pew');
        },
    }
};
//Use destructured assignment to create a const variable named functionality that extracts the functionality property of robot
const { functionality } = robot;
console.log(functionality); //this prints {beep: [Function: beep], fireLaser: [FUnction: fireLaser]}
//call the methods available to robot.functionality simply through functionality.
const { beep } = robot.functionality;
functionality.beep(); //this prints Beep Boop