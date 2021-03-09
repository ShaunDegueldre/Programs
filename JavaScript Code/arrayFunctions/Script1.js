// JavaScript source code
//create array concept
const concept = ['arrays', 'can', 'be', 'mutated'];
//use function to add to array
function changeArr(arr) {
    arr[3] = 'MUTATED';
}
//call function to add to array concept
changeArr(concept);
//print updated array concept
console.log(concept);
//create a function to remove the last index of an array
function removeElement(newArr) {
    newArr.pop();
}
//call function to remove last index in concept array
removeElement(concept);
//print updated array concept
console.log(concept);