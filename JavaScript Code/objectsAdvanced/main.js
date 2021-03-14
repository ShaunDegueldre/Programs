//creation of object robot
const robot = {
    //value pair of model and model number followed by ,
    model: '1E78V2',
    //value pair of energyLevel and level of energy follwed by ,
    energyLevel: 100,
    //function of provideInfo retruning the string using interpolation
    provideInfo() {
        //return command with ` not needing + or '' calling this.item (this.value of the value pair)
        return `I am ${this.model} and my current energy level is ${this.energyLevel} .`
    }
};
//console.log(the object followed by the function)
console.log(robot.provideInfo());



//another example
//creation of object robot
const robot = {
    //value pair of energy level and level of energy in number value 
    energyLevel: 100,
    //function checkEnergy console log using the this.item
    checkEnergy() {
        console.log(`Energy is currently at ${this.energyLevel}%.`)
    }
}
//calling the function.  since the function is already logging to console and not a return no need to console.log(object followed by the function) just call the function
robot.checkEnergy();