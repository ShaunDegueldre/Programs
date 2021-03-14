//creation of object robot
const robot = {
    //value pairs for object robot
    _model: '1E78V2',
    _energyLevel: 100,
    _numOfSensors: 15,
    //getter function retrieving the numOfSenors value
    get numOfSensors() {
        if (typeof this._numOfSensors === 'number') {
            return this._numOfSensors;
        } else {
            return 'Sensors are currently down.'
        }
    },
    //setter function allowing for the setting of the value of numOfSensors
    set numOfSensors(num) {
        if (typeof num === 'number' && num >= 0) {
            this._numOfSensors = num;
        } else {
            console.log('Pass in a number that is greater than or equal to 0')
        }
    }
};
//using settor function function to replace value with 100
robot.numOfSensors = 100
//using the getter function to call the new value of numOfSensors
console.log(robot.numOfSensors);