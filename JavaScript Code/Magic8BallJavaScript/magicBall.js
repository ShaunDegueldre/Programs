// JavaScript source code

let userName = '';

userName ? console.log(`Hello, ${userName}`) : console.log('Hello!');

console.log(`Ask the great 8 ball a qestion ${userName}`);

let userQuestion = 'Will I be rich';

console.log(`You have asked the question '${userQuestion}?' to the great magic 8 ball.`)

let randomNumber = Math.floor(Math.random() * 8);

if (randomNumber === 1) {
    console.log("The magic 8 ball replies with: 'It is certain'")
} else if (randomNumber === 2) {
    console.log("The magic 8 ball replies with: 'It is decidedly so'")
} else if (randomNumber === 3) {
    console.log("The magic 8 ball replies with: 'Reply hazy try again'")
} else if (randomNumber === 4) {
    console.log("The magic 8 ball replies with: 'Cannot predict now'")
} else if (randomNumber === 5) {
    console.log("The magic 8 ball replies with: 'Do not count on it'")
} else if (randomNumber === 6) {
    console.log("The magic 8 ball replies with: 'My sources say no'")
} else if (randomNumber === 7) {
    console.log("The magic 8 ball replies with: 'Outlook not so good'")
} else if (randomNumber === 0) {
    console.log("The magic 8 ball replies with: 'Signs point to yes'")
} else {
    console.log("I have been broken!")
}