#include <iostream>

int main() {

    //set variables
    int gryffindor = 0, hufflepuff = 0, ravenclaw = 0, slytherin = 0;
    int answer1, answer2, answer3, answer4;
    int invalidinput = 0;
    std::string house;
    int max = 0;

    //open quiz
    std::cout << "The Sorting Hat Quiz!\n\n";

    //question 1
    std::cout << "1.) When I'm dead, I want people to remember me as: \n";
    std::cout << "1. The Good\n2. The Great\n3. The Wise\n4. The Bold\n";
    std::cout << "Select your answer: ";
    std::cin >> answer1;

    if (answer1 == 1) {
        hufflepuff++;
    }
    else if (answer1 == 2) {
        slytherin++;
    }
    else if (answer1 == 3) {
        ravenclaw++;
    }
    else if (answer1 == 4) {
        gryffindor++;
    }
    else {
        invalidinput++;
        std::cout << "INVALID ANSWER\n";
    }

    //question 2
    std::cout << "2.) Dawn or Dusk? \n";
    std::cout << "1. Dawn\n2. Dusk\n";
    std::cout << "Select your answer: ";
    std::cin >> answer2;

    if (answer2 == 1) {
        gryffindor++;
        ravenclaw++;
    }
    else if (answer2 == 2) {
        hufflepuff++;
        slytherin++;
    }
    else {
        invalidinput++;
        std::cout << "INVALID ANSWER\n";
    }


    //question 3
    std::cout << "3.) Which kind of instrument most pleases your ear?\n";
    std::cout << "1. The violin\n2. The trumpet\n3. The piano\n4. The drum\n";
    std::cout << "Select your answer: ";
    std::cin >> answer3;

    if (answer3 == 1) {
        slytherin++;
    }
    else if (answer3 == 2) {
        hufflepuff++;
    }
    else if (answer3 == 3) {
        ravenclaw++;
    }
    else if (answer3 == 4) {
        gryffindor++;
    }
    else {
        invalidinput++;
        std::cout << "INVALID ANSWER\n";
    }

    //question 4
    std::cout << "4.) Which road tempts you most?\n";
    std::cout << "1. The wide, sunny grassy lane\n2. The narrow, dark, lantern-lit alley\n3. The twisiting, leaf-strewn path through woods\n4. The cobbled street lined (ancient buildings)\n";
    std::cout << "Select your answer: ";
    std::cin >> answer4;

    if (answer4 == 1) {
        hufflepuff++;
    }
    else if (answer4 == 2) {
        slytherin++;
    }
    else if (answer4 == 3) {
        gryffindor++;
    }
    else if (answer4 == 4) {
        ravenclaw++;
    }
    else {
        invalidinput++;
        std::cout << "INVALID ANSWER\n";
    }

    //determine outcome of quiz
    if (gryffindor > max) {
        max = gryffindor;
        house = "Gryffindor";
    }
    if (hufflepuff > max) {
        max = hufflepuff;
        house = "Hufflepuff";
    }
    if (ravenclaw > max) {
        max = ravenclaw;
        house = "Ravenclaw";
    }
    if (slytherin > max) {
        max = slytherin;
        house = "Slytherin";
    }

    std::cout << house << "!\n";
    std::cout << "Your are the house winner!\n";
    std::cout << "There are " << invalidinput << " invalid answers!\n";

}