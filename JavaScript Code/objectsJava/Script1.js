// JavaScript source code
//very basic object
// creation of object named fasterShip
let fasterShip = {
    //2 key value pairs as properties seperated by a comma
    'Fuel Type': 'Turbo Fuel',
    color: 'silver'
};



//creation of object named spaceship
let spaceship = {
    //properties of object seperated by comma in key value pairs
    'Active Mission': true,
    homePlanet: 'Earth',
    color: 'silver',
    'Fuel Type': 'Turbo Fuel',
    numCrew: 5,
    'Secret Mission': 'Discover life outside of Earth.'
    flightPath: ['Venus', 'Mars', 'Saturn']
};
//creation of variable crewCount assigned the value of numCrew
const crewCount = spaceship.numCrew;
//creation of variable planetArray assinged the value of flightPath
const planetArray = spaceship.flightPath;
//printing values of crewCount and planetArray to the console
console.log(crewCount + ' ' + planetArray);

//using variable propName to account for key value 'Active Mission'
let propName = 'Active Mission';
//creation of variable isActive and assigning key value of 'Active Mission' 
const isActive = spaceship['Active Mission'];
//printing to console the value of 'Active Mission' three different ways
console.log(spaceship['Active Mission']);
console.log(isActive);
console.log(spaceship[propName]);

//change spaceship color to glorious gold
spaceship.color = 'glorious gold';
//add key numEngines with value of 5
spaceship.numEngines = 5;
//delete keyvalue secret mission discover life outside of earth
delete spaceship['Secret Mission'];

