#include <iostream>
#include <cmath>

//Below is 2 function both requiring type infront of function that has a return(int,double,string,)

// Define tenth_power() here:
int tenth_power(int num) {

	return(num * num * num * num * num * num * num * num * num * num);

}

// Define average()here:
double average(double num1, double num2) {

	return ((num1 + num2) / 2);

}


int main() {

	std::cout << tenth_power(0) << "\n";
	std::cout << tenth_power(1) << "\n";
	std::cout << tenth_power(2) << "\n";

	std::cout << average(42.0, 24.0) << "\n";
	std::cout << average(1.0, 2.0) << "\n";

}