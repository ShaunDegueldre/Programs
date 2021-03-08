// JavaScript source code
//function to determine userinput
const getUserChoice = userInput => {
    userInput = userInput.toLowerCase();
    if (userInput === 'rock') {
        console.log("You entered 'ROCK'");
        return userInput;
    } else if (userInput === 'scissor') {
        console.log("You entered 'SCISSOR'");
        return userInput
    } else if (userInput === 'paper') {
        console.log("You entered 'PAPER'");
        return userInput
    } else {
        console.log('You have entered an invalid choice');
        return ("Please select 'ROCK', 'PAPER', or 'SCISSOR'");
    }
};
//function to determine computer input
const getComputerChoice = () => {
    const randomChoice = Math.floor(Math.random() * 3);
    if (randomChoice === 0) {
        console.log("Computer plays 'ROCK'");
        return 'rock'
    } else if (randomChoice === 1) {
        console.log("Computer plays 'SCISSOR'");
        return 'scissor'
    } else if (randomChoice === 2) {
        console.log("Computer plays 'PAPER'");
        return 'paper'
    }
};
//function deciding who the winner is
const determineWinner = (userChoice, getComputerChoice) => {
    if (userChoice === 'rock' && getComputerChoice === 'rock') {
        return ('This game is a tie')
    } else if (userChoice === 'rock' && getComputerChoice === 'paper') {
        return ('Computer WINS')
    } else if (userChoice === 'rock' && getComputerChoice === 'scissor') {
        return ('User WINS')
    } else if (userChoice === 'scissor' && getComputerChoice === 'paper') {
        return ('User WINS')
    } else if (userChoice === 'scissor' && getComputerChoice === 'scissor') {
        return ('This game is a Tie')
    } else if (userChoice === 'scissor' && getComputerChoice === 'rock') {
        return ('Computer WINS')
    } else if (userChoice === 'paper' && getComputerChoice === 'rock') {
        return ('User WINS')
    } else if (userChoice === 'paper' && getComputerChoice === 'scissor') {
        return ('Computer WINS')
    } else if (userChoice === 'paper' && getComputerChoice === 'paper') {
        return ('This game is a Tie')
    }
};
//function to play the game
const playGame = () => {
    const userChoice = getUserChoice('paper');
    const ComputerChoice = getComputerChoice();
    //console.log(`You threw: ${userChoice}`);
    //console.log(`The computer played: ${ComputerChoice}`);

    console.log(determineWinner(userChoice, ComputerChoice));
}

playGame()