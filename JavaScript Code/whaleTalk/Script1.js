// JavaScript source code
///creation of statement which needs to be changed into whale talk
const input = 'This sentence is translated to whale talk';
//creating an array to compare that consists of whale talk language..only vowels
const vowels = ['a', 'e', 'i', 'o', 'u'];
//creation of blank array to store results in
const resultArray = [];
//creation of for loop to iterate through the input text
for (let i = 0; i < input.length; i++) {
    //creation of for loop to compare vowels array to input array
    for (let j = 0; j < vowels.length; j++) {
        //condition if input iteration = vowels iteration
        if (input[i] === vowels[j]) {
            //addition of met condition to resultArray array
            resultArray.push(input[i])
        }
    }
    //adding an additional e if the result is an e
    if (input[i] === 'e')
        resultArray.push('e');
    //adding an additional u if the result is a u
    if (input[i] === 'u')
        resultArray.push('u');
}
//printing the resultArray array to the console
console.log(resultArray);
//creating a variable named whaleTalk to store the resultArray as one sentence
let whaleTalk = resultArray.join('');
//printing the resultArray with the join command
console.log(resultArray.join(''));
//printing the created variable whaleTalk 
console.log(whaleTalk);
