#include <iostream>
#include "ufo_functions.hpp"

int main() {
    //set word for game set answer for game
    std::string codeword = "education";
    std::string answer = "_________";

    //declare misses
    int misses = 0;

    //run greet function
    greet();


    std::vector<char> incorrect;
    bool guess = false;
    char letter;

    //while loop for gameplay
    while (answer != codeword && misses < 7) {

        display_status(incorrect, answer);


        std::cout << "\n\nPlease Enter you guess for the codeword: \n";
        std::cin >> letter;

        for (int i = 0; i < codeword.length(); i++) {

            if (letter == codeword[i]) {
                answer[i] = letter;
                guess = true;
            }

        }

        if (guess) {
            std::cout << "\nCorrect! You are closer to saving your friend!\n";
        }
        else {
            std::cout << "\nYour friend is closer to being taken by the aliens!\n";
            incorrect.push_back(letter);
            display_misses(misses);
            misses++;
        }





        guess = false;
    }



    end_game(answer, codeword);


}