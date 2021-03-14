// JavaScript source code
//creation of object menu
const menu = {
    //_courses object with empty arrays of appetizers, mains, dessserts 
    _courses: {
        appetizers: [],
        mains: [],
        desserts: [],
    },
    //getter function for appetizers which returns the values within the appetrizers array from the _courses object
    get appetizers() {
        return this._courses.appetizers;
    },
    //getter function for mains which returns the values within the mains array from the _courses object
    get mains() {
        return this._courses.mains;
    },
    //getter function for desserts which returns the values within the desserts array from the _courses object
    get desserts() {
        return this._courses.desserts;
    },
    //three setter functions for appetiers, mains, desserts which sets the values within the respective arrays within the _courses object
    set appetizers(data) {
        this._courses.appetizers = data;
    },
    set mains(data) {
        this._courses.mains = data;
    },
    set desserts(data) {
        this._courses.desserts = data;
    },
    //getter function which returns key value pairs for appetizers mains and desserts
    get courses() {
        return {
            appetizers: this.appetizers,
            mains: this.mains,
            desserts: this.desserts,
        }
    },
    //method addDishToCourse which sets values with a courseName dishName and dishPrice used to add a new dish to specified course on menu
    addDishToCourse(courseName, dishName, dishPrice) {
        const dish = {
            name: dishName,
            price: dishPrice,
        };

        return this._courses[courseName].push(dish);
    },
    //Retrieving the array of the given course’s dishes from the menu‘s _courses object and storing it in a variable called dishes.
    getRandomDishFromCourse(courseName) {
        const dishes = this._courses[courseName];
        //a random index by multiplying Math.random() by the length of the dishes array (This will guarantee that the random number will be between 0 and the length of the array)
        const randomIndex = Math.floor(Math.random() * dishes.length);
        //Return the dish located at that index in dishes
        return dishes[randomIndex];
    },
    //getting a random dish from a course and returning it
    generateRandomMeal() {
        const appetizer = this.getRandomDishFromCourse('appetizers');
        const main = this.getRandomDishFromCourse('mains');
        const dessert = this.getRandomDishFromCourse('desserts');
        const totalPrice = appetizer.price + main.price + dessert.price;

        return `Your meal is ${appetizer.name}, ${main.name}, and ${dessert.name}, the total price is $${totalPrice}.`;
    },
};
//placing items in the appetizers with name and price
menu.addDishToCourse('appetizers', 'salad', 4.75);
menu.addDishToCourse('appetizers', 'wings', 8.00);
menu.addDishToCourse('appetizers', 'nachos', 7.50);
//placing items in the mains with name and price
menu.addDishToCourse('mains', 'steak', 18.75);
menu.addDishToCourse('mains', 'chicken', 10.00);
menu.addDishToCourse('mains', 'salmon', 12.50);
//placing items in the desserts with name and price
menu.addDishToCourse('desserts', 'ice cream', 7.50);
menu.addDishToCourse('desserts', 'cake', 8.75);
menu.addDishToCourse('desserts', 'fruit', 5.00);
//generating a random meal
const meal = menu.generateRandomMeal();
//printing the random meal to the console
console.log(meal);