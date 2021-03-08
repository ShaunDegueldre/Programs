#include <iostream>

#include "numbers.hpp"

//This allows for more than one type of data type to be entered as long as they are the same for each function call.
//Meaning that you can call a double on one call and then an int on another and the function will work properly for both

int main() {

	std::cout << get_smallest(100, 60) << "\n";
	std::cout << get_smallest(2543.2, 3254.3) << "\n";

}