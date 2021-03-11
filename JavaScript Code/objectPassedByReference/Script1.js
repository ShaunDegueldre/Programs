// JavaScript source code
//creation of object spaceship
let spaceship = {
    'Fuel Type': 'Turbo Fuel',
    homePlanet: 'Earth'
};
//function named greenEnergy that has an object parameter which sets fuel type to avocado oil
let greenEnergy = obj => {
    obj['Fuel Type'] = 'avocado oil';
}
//function named remotelyDisable which has an object parameter which set the disabled property to true
let remotelyDisable = obj => {
    obj.disabled = true
}
//call function greenEnergy with object parameter spaceship
greenEnergy(spaceship);
//print value of object spaceship to console with change in fuel type to avocado oil
console.log(spaceship);
//call function remotelyDisable with object parameter spaceship
remotelyDisable(spaceship);
//print value of object spaceship to console after updated disabled property set to true
console.log(spaceship);