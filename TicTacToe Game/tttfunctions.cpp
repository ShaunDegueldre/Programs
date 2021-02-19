#include <iostream>
#include <vector>

//Define functions

// greet shows the opening and explains the rules
void greet() {

    std::cout << "========================\n";
    std::cout << "=Welcome to Tic Tac Toe=\n";
    std::cout << "========================\n\n";
    std::cout << "This is a two player game.  \nPlayer one will be X and Player two will be O\n";
    std::cout << "Below is the board please select a number \nto select your location on the board.\n\n";
}
// shows board placement in the beggining of the game
void displayboard() {

    std::cout << " 1 | 2 | 3 \n";
    std::cout << "===========\n";
    std::cout << " 4 | 5 | 6 \n";
    std::cout << "===========\n";
    std::cout << " 7 | 8 | 9 \n";

}
// main loop for gameplay.  
void playerselection() {

    //declaring values
    int winner = 0;
    int turns;
    int xselect;

    //declaring vectors for board
    std::vector<char> row1(3);
    std::vector<char> row2(3);
    std::vector<char> row3(3);

    //for loop which conditions a winner and total number of turns
    for (turns = 0; winner != 1 && turns < 9; turns++) {

        //getting info from player for selection of location
        std::cout << "Please make a selection: \n";
        std::cin >> xselect;

        //determining and placing pieces on the gameboard through use of vectors
        if (turns % 2 == 0) {
            if (xselect == 1) {
                row1[0] = 'X';
            }
            else if (xselect == 2) {
                row1[1] = 'X';
            }
            else if (xselect == 3) {
                row1[2] = 'X';
            }
            else if (xselect == 4) {
                row2[0] = 'X';
            }
            else if (xselect == 5) {
                row2[1] = 'X';
            }
            else if (xselect == 6) {
                row2[2] = 'X';
            }
            else if (xselect == 7) {
                row3[0] = 'X';
            }
            else if (xselect == 8) {
                row3[1] = 'X';
            }
            else if (xselect == 9) {
                row3[2] = 'X';
            }
        }
        else if (turns % 2 != 0) {
            if (xselect == 1) {
                row1[0] = 'O';
            }
            else if (xselect == 2) {
                row1[1] = 'O';
            }
            else if (xselect == 3) {
                row1[2] = 'O';
            }
            else if (xselect == 4) {
                row2[0] = 'O';
            }
            else if (xselect == 5) {
                row2[1] = 'O';
            }
            else if (xselect == 6) {
                row2[2] = 'O';
            }
            else if (xselect == 7) {
                row3[0] = 'O';
            }
            else if (xselect == 8) {
                row3[1] = 'O';
            }
            else if (xselect == 9) {
                row3[2] = 'O';
            }
        }

        //display the board after each turn
        std::cout << "\n\n";
        std::cout << " " << row1[0] << " | " << row1[1] << " | " << row1[2] << " \n";
        std::cout << "===========\n";
        std::cout << " " << row2[0] << " | " << row2[1] << " | " << row2[2] << " \n";
        std::cout << "===========\n";
        std::cout << " " << row3[0] << " | " << row3[1] << " | " << row3[2] << " \n\n";

        //determining if we have a winner and displaying the winner message for the winner
        if (row1[0] == 'X' && row1[1] == 'X' && row1[2] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row2[0] == 'X' && row2[1] == 'X' && row2[2] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row3[0] == 'X' && row3[1] == 'X' && row3[2] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row1[0] == 'X' && row2[0] == 'X' && row3[0] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row1[1] == 'X' && row2[1] == 'X' && row3[1] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row1[2] == 'X' && row2[2] == 'X' && row3[2] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row1[0] == 'X' && row2[1] == 'X' && row3[2] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row3[0] == 'X' && row2[1] == 'X' && row1[2] == 'X') {
            winner = 1;
            std::cout << "X is the winner.  Great Job Player 1\n";
        }
        else if (row1[0] == 'O' && row1[1] == 'O' && row1[2] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row2[0] == 'O' && row2[1] == 'O' && row2[2] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row3[0] == 'O' && row3[1] == 'O' && row3[2] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row1[0] == 'O' && row2[0] == 'O' && row3[0] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row1[1] == 'O' && row2[1] == 'O' && row3[1] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row1[2] == 'O' && row2[2] == 'O' && row3[2] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row1[0] == 'O' && row2[1] == 'O' && row3[2] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
        else if (row3[0] == 'O' && row2[1] == 'O' && row1[2] == 'O') {
            winner = 1;
            std::cout << "O is the winner.  Great Job Player 2\n";
        }
    }
}
//display endgame message and ask to play agian
void endgame() {

    std::cout << "The game is over. Please Play again!\n\n";
}





