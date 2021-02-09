// Rock Paper Scissors Lizard Spock

#include <iostream>
#include <ctime>
#include <stdlib.h>




int main() {

    srand(time(NULL));

    int computer = rand() % 5 + 1;

    int user = 0;

    std::cout << "=====================================\n";
    std::cout << "Rock, Paper, Scissors, Lizard, Spock!\n";
    std::cout << "=====================================\n";

    //Intro
    std::cout << "Which do you wish to choose?\n";
    std::cout << "1) ROCK✊\n";
    std::cout << "2) PAPER✋\n";
    std::cout << "3) SCISSOR✌️\n";
    std::cout << "4) LIZARD🦎\n";
    std::cout << "5) SPOCK🖖\n";

    //countdown to shoot
    std::cout << "3....2....1....Shoot!: ";
    std::cin >> user;

    //display user pick
    if (user == 1) {
        std::cout << "You selected ROCK\n";
    }
    else if (user == 2) {
        std::cout << "You selected PAPER\n";
    }
    else if (user == 3) {
        std::cout << "You selected SCISSOR\n";
    }
    else if (user == 4) {
        std::cout << "You selected LIZARD\n";
    }
    else if (user == 5) {
        std::cout << "You selected SPOCK\n";
    }
    else {
        std::cout << "INVALID SELECTION\n";
    }

    //display computer pick
    if (computer == 1) {
        std::cout << "Computer selected ROCK\n";
    }
    else if (computer == 2) {
        std::cout << "Computer selected PAPER\n";
    }
    else if (computer == 3) {
        std::cout << "Computer selected SCISSOR\n";
    }
    else if (computer == 4) {
        std::cout << "Computer selected LIZARD\n";
    }
    else {
        std::cout << "Computer selected SPOCK\n";
    }

    //diplay winner
    if (user == 1 && computer == 1) {
        std::cout << "IT IS A TIE!\n";
    }
    else if (user == 1 && computer == 2) {
        std::cout << "COMPUTER WINS!\n";
    }
    else if (user == 1 && computer == 3) {
        std::cout << "YOU WIN!\n";
    }
    else if (user == 1 && computer == 4) {
        std::cout << "YOU WIN!\n";
    }
    else if (user == 1 && computer == 5) {
        std::cout << "COMPUTER WINS!\n";
    }
    else if (user == 2 && computer == 2) {
        std::cout << "IT IS A TIE!\n";
    }
    else if (user == 2 && computer == 3) {
        std::cout << "COMPUTER WINS!\n";
    }
    else if (user == 2 && computer == 4) {
        std::cout << "COMPUTER WINS!\n";
    }
    else if (user == 2 && computer == 5) {
        std::cout << "YOU WIN!\n";
    }
    else if (user == 3 && computer == 3) {
        std::cout << "IT IS A TIE!\n";
    }
    else if (user == 3 && computer == 4) {
        std::cout << "YOU WIN!\n";
    }
    else if (user == 3 && computer == 5) {
        std::cout << "COMPUTER WINS!\n";
    }
    else if (user == 4 && computer == 4) {
        std::cout << "IT IS A TIE!\n";
    }
    else if (user == 4 && computer == 5) {
        std::cout << "YOU WIN!\n";
    }
    else if (user == 5 && computer == 5) {
        std::cout << "IT IS A TIE!\n";
    }


}
