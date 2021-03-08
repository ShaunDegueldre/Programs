#include <iostream>

// Define needs_water() here:
//return string name function(values to be inputted seperated by comma)
std::string needs_water(int days, bool is_succulent) {

    //start of if loop with determining values
    if (is_succulent == false && days > 3) {
        return "Time to water the plant.";
    }
    //is_succulent defaults to true as determined in the above bool value inputted into function
    else if (is_succulent && days <= 12) {
        return "Dont water the plant!";
    }
    else if (is_succulent && days >= 13) {
        return "Go ahead and give the plant a little water.";
    }
    else {
        return "Don't water the plant!";
    }



}

int main() {

    std::cout << needs_water(10, false) << "\n";

}