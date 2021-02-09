#include <iostream>

int main() {

    // start of for loop
    for (int i = 1; i <= 100; i++) {

        //determine if number is divisible by 15   
        if (i % 15 == 0) {
            std::cout << "fizzbuzz\n";
        }
        //determine if number is divisible by 3
        else if (i % 3 == 0) {
            std::cout << "fizz\n";
        }
        //determine if number is divisible by 5
        else if (i % 5 == 0) {
            std::cout << "buzz\n";
        }
        //print out the rest of the numbers
        else {
            std::cout << i << "\n";
        }
    }
}