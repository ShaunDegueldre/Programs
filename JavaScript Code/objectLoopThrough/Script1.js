// JavaScript source code
let spaceship = {
    crew: {
        captain: {
            name: 'Lily',
            degree: 'Computer Engineering',
            cheerTeam() { console.log('You got this!') }
        },
        'chief officer': {
            name: 'Dan',
            degree: 'Aerospace Engineering',
            agree() { console.log('I agree, captain!') }
        },
        medic: {
            name: 'Clementine',
            degree: 'Physics',
            announce() { console.log(`Jets on!`) }
        },
        translator: {
            name: 'Shauna',
            degree: 'Conservation Science',
            powerFuel() { console.log('The tank is full!') }
        }
    }
};

//using a for loop to iterate through spaceship.crew object and list the crew roles and names in format captain: lilly chief officer: dan etc...
for (let crewmem in spaceship.crew) {
    console.log(`${crewmem}: ${spaceship.crew[crewmem].name}`)
}
//using a for loop to iterate through spaceship.crew object and list the crew names and degrees in format captain: lilly: computer engineering dan: aerospace engineering etc......
for (let crewmem in spaceship.crew) {
    console.log(`${spaceship.crew[crewmem].name}: ${spaceship.crew[crewmem].degree}`)
};