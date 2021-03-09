// JavaScript source code
//determine sleep hours per day
const getSleepHours = day => {
    if (day === 'monday') {
        return 8;
    } else if (day === 'tuesday') {
        return 8;
    } else if (day === 'wednesday') {
        return 8;
    } else if (day === 'thursday') {
        return 8;
    } else if (day === 'friday') {
        return 6;
    } else if (day === 'saturday') {
        return 8;
    } else if (day === 'sunday') {
        return 8;
    }
}
//sum of all the total of all days sleep hours
const getActualSleepHours = () => getSleepHours('monday') + getSleepHours('tuesday') + getSleepHours('wednesday') + getSleepHours('thursday') + getSleepHours('friday') + getSleepHours('saturday') + getSleepHours('sunday');
//getting the ideal number of sleep hours
const getIdealSleepHours = () => {
    const idealHours = 7.5;
    return idealHours * 7;
}
//calcuclating the sleep bank number and printing to console
const calculateSleepDebt = () => {
    const actualSleepHours = getActualSleepHours();
    const idealSleepHours = getIdealSleepHours();
    console.log('You sleep bank credit is: ' + (idealSleepHours - actualSleepHours));
    if (actualSleepHours === idealSleepHours) {
        console.log('You are getting the perfect amount of Sleep');
    } else if (actualSleepHours > idealSleepHours) {
        console.log('You are getting more sleep than needed');
    } else if (actualSleepHours < idealSleepHours) {
        console.log('You need to be getting more rest');
    }
}

calculateSleepDebt();