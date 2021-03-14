//creation of factory function with parameters to input
const robotFactory = (model, mobile) => {
    //returns an object that has the properties located within the parameters
    return {
        //creation of value pairs for object
        model: model,  //if the properties key and value share the same name you can remove the : model leaving just model,
        mobile: mobile,
        //function created for the created object
        beep() {
            console.log('Beep Boop');
        }
    }
};
//creation of the tinCan object with the value pairs
const tinCan = robotFactory('P-500', true);
//calling the function within the tinCan object
tinCan.beep();





//another example
//creation of monsterFactory factory function with parameters to input
const monsterFactory = (name, age, energySource, catchPhrase) => {
    //returns an object that has the properties located within the parameters of the factory function
    return {
        //creation of value pairs for the object
        name: name,
        age: age,
        energySource: energySource,
        //function created for the created object
        scare() {
            console.log(catchPhrase);
        }
    }
};
//creation of the ghost object with the required value pairs
const ghost = monsterFactory('Ghouly', 251, 'ectoplasm', 'BOO!');
//calling the fucntion within the ghost object
ghost.scare(); // 'BOO!'