// JavaScript source code
//creation of array called artists
const artists = ['Picasso', 'Kahlo', 'Matisse', 'Utamaro'];
//iterator to loop through each item in the array and print to console
artists.forEach(artist => {
    console.log(artist + ' is one of my favorite artists.');
});
//creation of array called numbers
const numbers = [1, 2, 3, 4, 5];
//creation of function using .map which returns a new array made up of the return values from the callback function 
const squareNumbers = numbers.map(number => {
    return number * number;
});
//printing the new squareNumbers array
console.log(squareNumbers);
//creation of array called things
const things = ['desk', 'chair', 5, 'backpack', 3.14, 100];
//creation of function using .filter a callback function for each of the elements must return either true or false. The returned array is a new array with any elements for which the callback function returns true
const onlyNumbers = things.filter(thing => {
    return typeof thing === 'number';
});
//printing the results of the onlynumbers function
console.log(onlyNumbers);


//.forEach
//breakdown for .forEach iteration

//creation of array named fruits
const fruits = ['mango', 'papaya', 'pineapple', 'apple'];
// Iterate over fruits below
//calls .forEach with array
//create variable named fruitItem for each item in fruit array
//function to print to console string with fruitItem
fruits.forEach(fruitItem => console.log('I want to eat a ' + fruitItem));


//.map
//breakdown for .map iteration

//creation of array called animals
const animals = ['Hen', 'elephant', 'llama', 'leopard', 'ostrich', 'Whale', 'octopus', 'rabbit', 'lion', 'dog'];
//creation of secretMessage array
//use .map on animals array create animal varialbe return 1st index of animal which is the iteration through animals array
const secretMessage = animals.map(animal => {
    return animal[0];
});
//print the array secretMessage with join to create a word
console.log(secretMessage.join(''));
//creation of bigNumbers array
const bigNumbers = [100, 200, 300, 400, 500];
//creation of smallNumbers array
//use .map on bigNumbers array create variable smallNumber which returns the division of bigNumbers array by 100 in each index
const smallNumbers = bigNumbers.map(smallNumber => {
    return smallNumber / 100;
})
//print smallNumbers array to console
console.log(smallNumbers);


//.filter
//breakdown of .filter iteration

//creation of array named randomNumbers
const randomNumbers = [375, 200, 3.14, 7, 13, 852];
//creation of array called smallNumbers
//call .filter on randomNumbers create variable called number and return number that is less than 250 to smallNumbers array
const smallNumbers = randomNumbers.filter(number => {
    return number < 250;
})
//print smallNumbers array to console
console.log(smallNumbers);
//creation of array names favoriteWords
const favoriteWords = ['nostalgia', 'hyperbole', 'fervent', 'esoteric', 'serene'];
// Call .filter() on favoriteWords below
const longFavoriteWords = favoriteWords.filter(word => {
    return word.length > 7;
})
//print longFavoriteWords array to console
console.log(longFavoriteWords);


//.findIndex
//breakdown of .findIndex iteration

//creation of array called animals
const animals = ['hippo', 'tiger', 'lion', 'seal', 'cheetah', 'monkey', 'salamander', 'elephant'];
//creation of variable foundAnimal
//call .findIndex on animals array create variable animal which will retrun the index location of elephant
const foundAnimal = animals.findIndex(animal => {
    return animal === 'elephant';
});
//print index location of animal in animals array that is elephant
console.log(foundAnimal);
//creation of variable startsWithS
//call .findindex on animals array create variable named animal which will return the index location of the first word that starts with s
const startsWithS = animals.findIndex(animal => {
    return animal[0] === 's';
})
//print index location of animal in animals array that starts with s
console.log(startsWithS);


//.reduce
//breakdown of .reduce iteration
//creation of array called newNumbers
const newNumbers = [1, 3, 5, 7];
//creation of varialbe newSum
//call .reduce on newNumbers and takes in a callback function as an argument
//callback function has two parameters accumulator and currentValue
const newSum = newNumbers.reduce((accumulator, currentValue) => {
    //printing the value of accumlulator and currentValue
    console.log('The value of accumulator: ', accumulator);
    console.log('The value of currentValue: ', currentValue);
    //returning the addition of two values accumulator and currentValue
    return accumulator + currentValue;
})
//printing to console the value of newSum
console.log(newSum);
//creation of varialbe newNewSum
//call .reduce on newNumbers and takes in a callback function as an argument
//callback function has two parameters accumulator and currentValue
const newNewSum = newNumbers.reduce((accumulator, currentValue) => {
    //printing the value of accumlulator and currentValue
    console.log('The value of accumulator: ', accumulator);
    console.log('The value of currentValue: ', currentValue);
    //returning the addition of two values accumulator and currentValue
    return accumulator + currentValue;
    //addition of second argumetn to .reduce()  
}, 10)
//printing to console the value of newNewSum
console.log(newNewSum);


//.some
//.every
//breakdown of .some and .every iteration
//creation or array words
const words = ['unique', 'uncanny', 'pique', 'oxymoron', 'guise'];
//print to the console
//from array words call .some to return true or false if any words length is less than 6
console.log(words.some(word => {
    return word.length < 6;
}));
//use filter to determine which words are in array that are more than 5 characters
const interestingWords = words.filter(word => {
    return word.length > 5;
})
//print to console the array of interestingWords
console.log(interestingWords);
//print to console
//from array interestingWords call .every to retrun true or false if every words length is more than 5
console.log(interestingWords.every((word) => {
    return word.length > 5;
}));



// Creation of array cities
const cities = ['Orlando', 'Dubai', 'Edinburgh', 'Chennai', 'Accra', 'Denver', 'Eskisehir', 'Medellin', 'Yokohama'];

// Creation of array nums
const nums = [1, 50, 75, 200, 350, 525, 1000];

//  Choose a method that will return undefined
cities.forEach(city => console.log('Have you visited ' + city + '?'));

// Choose a method that will return a new array
const longCities = cities.filter(city => city.length > 7);

// Choose a method that will return a single value
const word = cities.reduce((acc, currVal) => {
    return acc + currVal[0]
}, "C");

console.log(word)

// Choose a method that will return a new array
const smallerNums = nums.map(num => num - 5);

// Choose a method that will return a boolean value
nums.every(num => num < 0);