// JavaScript source code
//creates array condiments
let condiments = ['Ketchup', 'Mustard', 'Soy Sauce', 'Sriracha'];
//creates array utensils
const utensils = ['Fork', 'Knife', 'Chopsticks', 'Spork'];
//changes the 0 index to mayo
condiments[0] = 'Mayo';
//prints the 0 index
console.log(condiments[0]);
//prints the array condiments
console.log(condiments);
//changes the contents of the array to only Mayo
condiments = ['Mayo'];
//changes the 3rd index to spoon
utensils[3] = 'Spoon';
//prints the array utensils
console.log(utensils);
//prints the updated array of condiments
console.log(condiments);


//creates objectives array
const objectives = ['Learn a new languages', 'Read 52 books', 'Run a marathon'];
//shows the length of the objectives array
console.log(objectives.length);


//creates the array chores
const chores = ['wash dishes', 'do laundry', 'take out trash'];
//push items to the array chores
chores.push('make bed', 'vac house');
//prints updated array chores to console
console.log(chores);
//removes last index of array chores
chores.pop();
//prints updated array chores to console
console.log(chores);


//creates array grocerylist
const groceryList = ['orange juice', 'bananas', 'coffee beans', 'brown rice', 'pasta', 'coconut oil', 'plantains'];
//remove the first item from the array
groceryList.shift();
//print the updated array to the console
console.log(groceryList);
//place a new item at the beginning of the array
groceryList.unshift('popcorn');
//print the updated array to the console
console.log(groceryList);
//split the list selecting the first item to the last item and print those items to the console
console.log(groceryList.slice(1, 4));
//print the whole grocerylist array to console again
console.log(groceryList);
console.log(groceryList.indexOf('pasta'));
//log the index of the element pasta to the variable pastaIndex
const pastaIndex = groceryList.indexOf('pasta');
//print the variable pastaIndex
console.log(pastaIndex);