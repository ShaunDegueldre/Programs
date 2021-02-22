#include <iostream>
#include <vector>

// Define first_three_multiples() here:

//using vector as return<>   name of function(type used within function)
std::vector<int> first_three_multiples(int num) {

    //name and define vector that is returning (along with its values)
    std::vector<int> multiples{ num, num * 2, num * 3 };

    return multiples;

}

int main() {

    for (int element : first_three_multiples(8)) {
        std::cout << element << "\n";
    }

}