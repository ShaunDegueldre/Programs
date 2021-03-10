// JavaScript source code
//creating an array called bobsFollowers
const bobsFollowers = ['Jim', 'Allen', 'Jill', 'Alice'];
//creating an array called tinasFollowers
const tinasFollowers = ['Jim', 'Alex', 'Jill'];
//creating an empty array called mutualFollowers
const mutualFollowers = [];

//for loop to cycle through bobsFollowers
for (let i = 0; i < bobsFollowers.length; i++) {
    //for loop to compare bobsFollowers to each item in array tinasFollowers
    for (let j = 0; j < tinasFollowers.length; j++) {
        //Condition which will occur if bobsFollowers and tinasFollowers are equal
        if (bobsFollowers[i] === tinasFollowers[j]) {
            //placing the same items in both arrays to the empty array mutualFollowers
            mutualFollowers.push(tinasFollowers[j]);
            //printing to console the same names
            console.log('Bob and Tina have the same follower named: ' + tinasFollowers[j])
            //printing the items in mutualFollowers array
            console.log(mutualFollowers);
        }
    }
}