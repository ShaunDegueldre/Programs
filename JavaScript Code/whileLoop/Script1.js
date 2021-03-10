// JavaScript source code
//create array called cards
const cards = ['diamond', 'spade', 'heart', 'club'];
//creation of variable currentCard
let currentCard;
//creation of while loop with condition that currentCard does not equal spade
while (currentCard != 'spade') {
    //assigning a value to currentCard using a RNG
    currentCard = cards[Math.floor(Math.random() * 4)];
    //printing the value of currentCard to the console
    console.log(currentCard);
}