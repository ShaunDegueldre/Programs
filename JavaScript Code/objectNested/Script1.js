// JavaScript source code
//creation of object spaceship
let spaceship = {
    //nested object within spaceship object
    passengers: [{ name: 'Chewy' }],
    //nested object within spaceship object
    telescope: {
        //keyvalues of the telescope object nested within the spaceship object
        yearBuilt: 2018,
        model: "91031-XLT",
        focalLength: 2032
    },
    crew: {
        //captain object nested in crew object nested in spaceship object
        captain: {
            //keyvalues of the captain object as well as a method(function)
            name: 'Sandra',
            degree: 'Computer Engineering',
            encourageTeam() { console.log('We got this!') },
            'favorite foods': ['cookies', 'cakes', 'candy', 'spinach']
        }
    },
    engine: {
        model: "Nimbus2000"
    },
    nanoelectronics: {
        computer: {
            terabytes: 100,
            monitors: "HD"
        },
        'back-up': {
            battery: "Lithium",
            terabytes: 50
        }
    }
};
//creation of variable capFave which stores the value in the zero index of favorite foods in the captain object nested in to the crew object nested into the spaceship object
const capFave = spaceship.crew.captain['favorite foods'][0];
//creation of variable firstPassenger which stores value in the zero index of the passagers object nested in the spaceship object
const firstPassenger = spaceship.passengers[0];
//printing to console the value in the zero index of favorite foods in the captain object nested in to the crew object nested into the spaceship object
console.log(spaceship.crew.captain['favorite foods'][0]);