// JavaScript source code
//simple for loop to count from 5 to 10 printing after each iteration.  let counter = 5 where counter is less than 11 add one to counter.
for (let counter = 5; counter < 11; counter++) {
    console.log(counter);
}
//for loop that counts down under the same pretences as the loop above it 
for (let counter = 3; counter >= 0; counter--) {
    console.log(counter);
}
//creation of array vacationSpots
const vacationSpots = ['Bali', 'Paris', 'Tulum'];
//loop scrolling through array vacationSpots printing the values
for (let i = 0; i < vacationSpots.length; i++) {
    console.log('I would love to visit ' + vacationSpots[i]);
}