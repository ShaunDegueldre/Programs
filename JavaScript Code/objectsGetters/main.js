//creation of object named robot
const robot = {
    //value pair of _model and model number _energyLevel and numerical value
    _model: '1E78V2',
    _energyLevel: 100,
    //function called energyLevel which determines if the value for _energyLevel is a num it returns one thing if not a num it returns another
    get energyLevel() {
        if (typeof this._energyLevel === 'number') {
            return `My current energy level is ${this._energyLevel}`;
        } else {
            return `System malfunction: cannot retrieve energy level`;
        }
    }
};
//calling function. since it is a get function no additional quotes required.  result is 1st return.
console.log(robot.energyLevel);
//change of _energyLevel value to a string
robot._energyLevel = 'full';
//calling function.  since it is a get function no additional quotes at end required (console.log(robot.energyLevel())). prints the second return.
console.log(robot.energyLevel);