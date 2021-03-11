// JavaScript source code
//creation of variable retreatMessage
let retreatMessage = 'We no longer wish to conquer your planet. It is full of dogs, which we do not care for.';
//creation of object alienShip
let alienShip = {
    //method(function) stored within the object
    retreat() {
        console.log(retreatMessage);
    },
    //a , seperates a second method(function) stored within the object
    takeOff() {
        console.log('Spim... Borp... Glix... Blastoff!');
    }
}
//calling the two methods(functions) within the alienShip object
alienShip.retreat();
alienShip.takeOff();