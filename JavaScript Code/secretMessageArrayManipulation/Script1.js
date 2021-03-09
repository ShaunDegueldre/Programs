// JavaScript source code
//creates the array secretMessage
let secretMessage = ['Learning', 'is', 'not', 'about', 'what', 'you', 'get', 'easily', 'the', 'first', 'time,', 'it', 'is', 'about', 'what', 'you', 'can', 'figure', 'out.', '-2015,', 'Chris', 'Pine,', 'Learn', 'JavaScript'];
//log the length of the array to the console
console.log(secretMessage.length);
//removes the last index from array secretMessage
secretMessage.pop();
//log the lenth of the new array to the console
console.log(secretMessage.length);
//add the strings to and Program to the array
secretMessage.push('to', 'Program');
//log the length of the array to the console
console.log(secretMessage.length);
//change the word easily to right within the array secretMessage
//find the index location of the word easily
console.log(secretMessage.indexOf('easily'));
//change the idex number printed to console to right
secretMessage[7] = 'right';
//use an array method to remove the first string of the array
secretMessage.shift();
//use an array method to add programming the first string of the array
secretMessage.unshift('Programming');
//use an array method to remove get, right, the, first, time, and replace with know
//create secretMessageOne array holding the first half
secretMessageOne = secretMessage.slice(0, 6);
//create secretMessageTwo array holding the second half
secretMessageTwo = secretMessage.slice(11, 25);
//print secretMessageOne
console.log(secretMessageOne);
//add know to the end of secretMessageOne
secretMessageOne.push('know');
//print updated secretMessageOne
console.log(secretMessageOne);
//print secretMessageTwo
console.log(secretMessageTwo);
//combine both messages
secretMessage = secretMessageOne.concat(secretMessageTwo);
//log the updated secretMessage array to the console.
console.log(secretMessage);
//log with join to the console to print as a full sentence
console.log(secretMessage.join(' '));