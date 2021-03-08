#include <iostream>
#include <vector>

// Define functions

//greet is the greeting function which displays instructions and name of game
void greet() {
    std::cout << "===============\n";
    std::cout << "=UFO: THE GAME=\n";
    std::cout << "===============\n";
    std::cout << "\nINSTRUCTIONS: Save your friend from alien abduction by guessing the letters in the codeword to free them from the TRACTOR BEAM!\n";

}

//end_game explains the outcome of the game after the while loop has run its course in the main program
void end_game(std::string answer, std::string codeword) {

    if (answer == codeword) {

        std::cout << "Hooray! You have saved your friend and earned the MEDAL OF HONOR!\n";

    }
    else {

        std::cout << "Oh no! The UFO just flew away the your friend!\n";
    }
}

//display status shows the current guesses and what answers are correct allowing for the input of incorrect and answer arguments
void display_status(std::vector<char> incorrect, std::string answer) {

    std::cout << "\nIncorrect Guesses:\n";

    for (int i = 0; i < incorrect.size(); i++) {
        std::cout << incorrect[i] << ' ';
    }

    std::cout << "\nCodeword:\n";

    for (int i = 0; i < answer.length(); i++) {
        std::cout << answer[i] << ' ';
    }

}




//display_misses shows the outcome of what happens after each miss is recorded in the while loop
void display_misses(int misses) {

    if (misses == 0) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /     \\        ( They Got me ) \n";
        std::cout << "             /   0   \\      / `-----------'  \n";
        std::cout << "            /  --|--  \\    /                 \n";
        std::cout << "           /     |     \\                     \n";
        std::cout << "          /     / \\     \\                   \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 1) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /     \\        (  Send help! ) \n";
        std::cout << "             /   0   \\      / `-----------'  \n";
        std::cout << "            /  --|--  \\    /                 \n";
        std::cout << "           /     |     \\                     \n";
        std::cout << "          /     / \\     \\                   \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 2) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /  0  \\        (  Send help! ) \n";
        std::cout << "             / --|-- \\      / `-----------'  \n";
        std::cout << "            /    |    \\    /                 \n";
        std::cout << "           /    / \\    \\                    \n";
        std::cout << "          /             \\                    \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 3) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /--|--\\        (  Send help! ) \n";
        std::cout << "             /   |   \\      / `-----------'  \n";
        std::cout << "            /   / \\   \\    /                \n";
        std::cout << "           /           \\                     \n";
        std::cout << "          /             \\                    \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 3) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /--|--\\        (  Send help! ) \n";
        std::cout << "             /   |   \\      / `-----------'  \n";
        std::cout << "            /   / \\   \\    /                \n";
        std::cout << "           /           \\                     \n";
        std::cout << "          /             \\                    \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 4) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /  |  \\        (  Send help! ) \n";
        std::cout << "             /  / \\  \\      / `-----------' \n";
        std::cout << "            /         \\    /                 \n";
        std::cout << "           /           \\                     \n";
        std::cout << "          /             \\                    \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 5) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              / / \\ \\        (  Send help! )\n";
        std::cout << "             /       \\      / `-----------'  \n";
        std::cout << "            /         \\    /                 \n";
        std::cout << "           /           \\                     \n";
        std::cout << "          /             \\                    \n";
        std::cout << "         /               \\                   \n";

    }
    else if (misses == 6) {

        std::cout << "                 .                            \n";
        std::cout << "                 |                            \n";
        std::cout << "              .-\"^\"-.                       \n";
        std::cout << "             /_....._\\                       \n";
        std::cout << "         .-\"`         `\"-.                  \n";
        std::cout << "        (  ooo  ooo  ooo  )                   \n";
        std::cout << "         '-.,_________,.-'    ,-----------.   \n";
        std::cout << "              /     \\        (  Send help! ) \n";
        std::cout << "             /       \\      / `-----------'  \n";
        std::cout << "            /         \\    /                 \n";
        std::cout << "           /           \\                     \n";
        std::cout << "          /             \\                    \n";
        std::cout << "         /               \\                   \n";

    }

}