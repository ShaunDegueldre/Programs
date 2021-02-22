#include <iostream>
#include <vector>
#include <string>


//start main program
int main() {

    //input string
    std::string phrase = "Hello Turtles\n";
    //create vector for vowels
    std::vector<char> vowels = { 'a', 'e', 'i', 'o', 'u' };
    //name vector for response
    std::string whaletalk;
    //for loop to run through phrase vector
    for (int i = 0; i < phrase.size(); i++) {
        //for loop to run through vowel vector
        for (int j = 0; j < vowels.size(); j++) {
            //compare vowel to phrase
            if (phrase[i] == vowels[j]) {
                //decipher whaletalk
                whaletalk.push_back(phrase[i]);
                //double e and u
                if (phrase[i] == 'u' || phrase[i] == 'e') {

                    whaletalk.push_back(phrase[i]);
                }
            }
        }
    }

    //print out original phrase
    std::cout << "Your phrase was " << phrase << "\n";
    //print out whaletalk
    std::cout << "In whale talk that is ";
    for (int k = 0; k < whaletalk.size(); k++) {
        std::cout << whaletalk[k];
    }
}