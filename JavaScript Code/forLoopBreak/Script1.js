// JavaScript source code
//creation of rapperArray array
const rapperArray = ["Lil' Kim", "Jay-Z", "Notorious B.I.G.", "Tupac"];
//creation of for loop to cycle through rapperArray array
for (let i = 0; i < rapperArray.length; i++) {
    //logging each iteration in the loop from rapperArray
    console.log(rapperArray[i]);
    //condition to break out of loop if rapperArray equals Notorious B.I.G.
    if (rapperArray[i] === "Notorious B.I.G.") {
        break;
    }
    //printing to console after each iteration in the for loop 
    console.log("And if you don't know, now you know.");
}