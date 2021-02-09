#include <iostream>
#include <vector>

int main() {
    //create vector
    std::vector<int> num = {};
    //create int for even and odd num totals
    int numeven = 0;
    int numodd = 0;

    //add numbers to vector
    num.push_back(1);
    num.push_back(5);
    num.push_back(7);
    num.push_back(11);
    num.push_back(4);

    //print total numbers in vector
    std::cout << num.size() << "\n";

    //create for loop to seperate odd and even nums
    for (int i = 0; i < num.size(); i++) {

        if (num[i] % 2 == 0) {

            numeven = numeven + num[i];

        }
        else {

            numodd = numodd + num[i];

        }


    }

    //print even and odd totals
    std::cout << numeven << "\n" << numodd;

}