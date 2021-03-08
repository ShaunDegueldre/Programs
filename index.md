## Welcome to a Collection of C++ programs
Also included within the repository are a collection of Java Script programs.
As I learn more languages I will update with additional languages and programs. 
# Shaun R Degueldre
https://my.indeed.com/p/shaund-ud1wnga  -  link to my indeed profile page

https://www.linkedin.com/in/shaun-degueldre-1ab0041b3/  -  link to my LinkedIn profile page

### Intro

After I completed my degree in Computer Science, I knew that I wanted to code.  I enjoy doing this and have found it to be rewarding and frustrating, exciting and aggravating all in one.  But the challenge of creating something and then watching it come to life and work as intended is truly amazing.  Below is a list of some of the programs I have written.  Contained within the folder is also a bunch of basic programs that I will sometimes find myself going back to reference and use to help create new programs.  

I hope that by showcasing some of the programs I have written it will help to grant me the opportunity to further my knowledge of coding and my abilities as a programmer.  It seems that finding an entry level position is not the easiest and with the pandemic I do not want my first job coding to be one that I work from home.  The value of working with someone who is experienced in the field of software development will help to expand my knowledge and allow me to grow as a programmer much faster than if I did not have that resource.  

I have tried to maintain good coding practices by making sure that I have all my code commented so it should be easy to follow along and understand my code.  I am also continuing to code all the time and will add new programs that I write to this page and move some of the less intricate programs off the front page. Below is a program I wrote while expanding my knowledge with Codecademy. 

### Dating Profile Program
This program helps to show the use of classes, objects, private, and public options in coding.  

```
//app.cpp
#include <iostream>
#include "profile.hpp"

int main() {

	Profile shaun("Shaun D", 39, "Florida", "USA", "he/him");
	shaun.add_hobby("listening to audiobooks, coding, videogames, and podcasts");

	std::cout << shaun.view_profile();

	Profile julie("Julie C", 37, "Florida", "USA", "she/her");
	julie.add_hobby("Long Walks on the beach");
	julie.add_hobby("Sleeping In");
	julie.add_hobby("Vacations");

	std::cout << julie.view_profile();

}

//profile.cpp
#include "profile.hpp"
#include <iostream>
#include <string>

Profile::Profile(std::string new_name, int new_age, std::string new_city, std::string new_country, std::string new_pronouns) {
    name = new_name;
    age = new_age;
    city = new_city;
    country = new_country;
    pronouns = new_pronouns;
}

void Profile::add_hobby(std::string new_hobby) {

    hobbies.push_back(new_hobby);

}

std::string Profile::view_profile() {

    std::string bio = "Name: " + name;
    bio += "\nCity: " + city;
    bio += "\nCountry: " + country;
    bio += "\nAge: " + std::to_string(age);
    bio += "\nPronouns: " + pronouns;
    std::string hobby_string = "Hobbies:\n";

    for (std::string hobby : hobbies) {

        hobby_string += " - " + hobby;

    }

    return bio + "\n" + hobby_string + "\n";
}

//profile.hpp
#pragma once
#include <vector>
#include <string>

class Profile {

private:

	std::string name;
	int age;
	std::string city;
	std::string country;
	std::string pronouns;
	std::vector<std::string> hobbies;

public:

	Profile(std::string new_name, int new_age, std::string new_city, std::string new_country, std::string new_pronouns);

	std::string view_profile();

	void add_hobby(std::string new_hobby);

};

https://github.com/ShaunDegueldre/Programs/tree/main/Dating%20Profile%20Program
```

### FizzBuzz
The fizzbuzz program. 
```
#include <iostream>

int main() {

    // start of for loop
    for (int i = 1; i <= 100; i++) {

        //determine if number is divisible by 15   
        if (i % 15 == 0) {
            std::cout << "fizzbuzz\n";
        }
        //determine if number is divisible by 3
        else if (i % 3 == 0) {
            std::cout << "fizz\n";
        }
        //determine if number is divisible by 5
        else if (i % 5 == 0) {
            std::cout << "buzz\n";
        }
        //print out the rest of the numbers
        else {
            std::cout << i << "\n";
        }
    }
}
```

### Guessing Game

This is a guessing game which will show the ability to utilize different functions which call on variables that where output by other functions.  It also shows the ability to check values and make sure that inaccurate values that might be entered will not be accepted.

```
//main.cpp
#include <iostream>
#include <string>
#include <cstdlib>
#include "game.hpp"

using namespace std;

int guess;
int number;
int cycles;
int balance = 100;
string player;

int main() {

	greet();

	cout << "Please enter your name: " << endl;
	cin >> player;

	//loop to cycle through the gameplay while funds are available and track the number of bets placed.
	while (balance > 0) {

		int bet = getbet(balance);
		cout << player << ": ";
		int game = gamechoice();
		int win_loss = letsplay(game);
		int upbalance = update_balance(win_loss, bet, balance);
		balance = upbalance;
		cout << endl;
		cout << player << " your current balance is: " << balance << endl << endl;
		cycles++;
	}

	cout << endl << "Total number of bets made: " << cycles << endl << endl;
	cout << player << ", that was a good try!" << endl;
	gameover();

}

//game.cpp
#include <iostream>
#include <string>
#include "game.hpp"

using namespace std;

//This function opens up the game and explains the rules
void greet() {

	cout << "Welcome to the guessing game!" << endl;
	cout << "Choosing the different games will provide you with different winning odds" << endl;
	cout << "Picking number out of 10 will provide you with 9 to 1 odds" << endl;
	cout << "Picking number out of 50 will provide you with 49 to 1 odds" << endl;
	cout << "Picking number out of 100 will provide you with 99 to 1 odds" << endl;

}

//This function will get the bet, check it against the balance to ensure the bet is good and return the bet value
int getbet(int balance) {

	bool goodbet;
	cout << "Your current balance is: " << balance << endl;
	int bet = 0;
	cout << "Enter the amount you would like to bet: " << endl;
	cin >> bet;
	cout << "You have wagered " << bet << endl;
	while (goodbet = true)
		if (bet <= balance) {
			return bet;
			goodbet == true;
		}
		else {
			cout << "Please bet an amount less than balance." << endl;
			cout << "Your current balance is: " << balance << endl;
			cout << "Enter your correct wager: ";
			cin >> bet;
		}
}

//This function will get the gamechoice.  It checks to make sure that the player is entering in a proper choice
int gamechoice() {

	bool goodchoice;
	cout << "Please pick 1 for out of 10, 2 for out of 50 and 3 for out of 100" << endl;
	int choice;
	cin >> choice;
	while (goodchoice = true)
		if (choice == 1) {
			cout << "You have selected to play game " << choice << endl;
			return choice;
			goodchoice == true;
		}
		else if (choice == 2) {
			cout << "You have selected to play game " << choice << endl;
			return choice;
			goodchoice == true;
		}
		else if (choice == 3) {
			cout << "You have selected to play game " << choice << endl;
			return choice;
			goodchoice == true;
		}
		else {
			cout << "You have not selected a proper choice" << endl;
			cout << "Plese select 1, 2, or 3: " << endl;
			cout << "Enter your choice: ";
			cin >> choice;
		}
}

//This funciton takes the game selected and then returns if the player won or lost and which game they played
int letsplay(int game) {

	int guess;

	if (game == 1) {
		int com_num = rand() % 10;
		//used this to check for winner and loser properly
		//cout << com_num;
		cout << "Please choose a number between 0 and 10: " << endl;
		cin >> guess;

		if (com_num == guess) {
			cout << "You have won!" << endl;
			return 1;
		}
		else {
			cout << "You have lost!" << endl;
			return 2;
		}
	}
	else if (game == 2) {
		int com_num = rand() % 50;
		//used this to check for winner and loser properly
		//cout << com_num;
		cout << "Please choose a number between 0 and 50: " << endl;
		cin >> guess;

		if (com_num == guess) {
			cout << "You have won!" << endl;
			return 3;
		}
		else {
			cout << "You have lost!" << endl;
			return 4;
		}
	}
	else if (game == 3) {
		int com_num = rand() % 100;
		//used this to check for winner and loser properly
		//cout << com_num;
		cout << "Please choose a number between 0 and 100: " << endl;
		cin >> guess;

		if (com_num == guess) {
			cout << "You have won!" << endl;
			return 5;
		}
		else {
			cout << "You have lost!" << endl;
			return 6;
		}
	}
}

//This function will update the balance and pay out the correct odds for the game which was played
int update_balance(int win_loss, int bet, int balance) {
	int bal;
	if (win_loss == 1) {
		bet = ((bet * 9) / 1) + bet;
		bal = balance + bet;
		return bal;
	}
	else if (win_loss == 3) {
		bet = ((bet * 49) / 1) + bet;
		bal = balance + bet;
		return bal;
	}
	else if (win_loss == 5) {
		bet = ((bet * 99) / 1) + bet;
		bal = balance + bet;
		return bal;
	}
	else if (win_loss == 2) {
		bal = balance - bet;
		return bal;
	}
	else if (win_loss == 4) {
		bal = balance - bet;
		return bal;
	}
	else if (win_loss == 6) {
		bal = balance - bet;
		return bal;
	}
}

//This is for the ending of the game after all funds have been spent
void gameover() {

	cout << "Thanks for playing." << endl;
	cout << "Even though you lost you can always play again!" << endl;
	cout << "Better luck next time!" << endl;
}

//game.hpp
#pragma once
#include <string>

using namespace std;

void greet();
int getbet(int balance);
int gamechoice();
int letsplay(int game);
int update_balance(int win_loss, int bet, int balance);
void gameover();

https://github.com/ShaunDegueldre/Programs/tree/main/Guessing%20Game

```

### TicTacToe
Below is a TicTacToe game I wrote while completing the same course on Codecademy.  
```
//ttt.cpp
#include <iostream>
#include "ttt.hpp"

int main() {

	greet();
	displayboard();
	playerselection();
	endgame();
}

//tttfunctions.cpp
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

//ttt.hpp
#pragma on
#include <vector>

void greet();
void displayboard();
void playerselection();
void endgame(); ce

https://github.com/ShaunDegueldre/Programs/tree/main/TicTacToe%20Game
```

### UFO Hangman Game

```markdown
//ufo.cpp
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
                         
//ufo_functions.cpp
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
  
//ufo_functions.hpp
#pragma once
#include <vector>

// Declare functions
void greet();
void end_game(std::string answer, std::string codeword);
void display_misses(int misses);
void display_status(std::vector<char> incorrect, std::string answer);

https://github.com/ShaunDegueldre/Programs/tree/main/UFO%20Hangman%20Game
```

### Beginner programs

Below is a collection of small one-page programs that I have written.  

```
// RockPaperScissorsLizardSpock.cpp

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

//MagicEightBall.cpp
#include <iostream>
#include <cstdlib>
#include <string>

int main() {

	std::cout << "MAGIC 8-BALL\n\n\n";
	srand(time(NULL));
	int answer = std::rand() % 20;

	if (answer == 0) {
		std::cout << "It is certain.";
	}
	else if (answer == 1) {
		std::cout << "It is decidedly so.";
	}
	else if (answer == 2) {
		std::cout << "Without a doubt.";
	}
	else if (answer == 3) {
		std::cout << "Yes - definitely.";
	}
	else if (answer == 4) {
		std::cout << "You may rely on it.";
	}
	else if (answer == 5) {
		std::cout << "As I see it, yes.";
	}
	else if (answer == 6) {
		std::cout << "Most likely.";
	}
	else if (answer == 7) {
		std::cout << "Outlook good.";
	}
	else if (answer == 8) {
		std::cout << "Yes.";
	}
	else if (answer == 9) {
		std::cout << "Signs point to Yes.";
	}
	else if (answer == 10) {
		std::cout << "Reply hazy, try again.";
	}
	else if (answer == 11) {
		std::cout << "Ask again later.";
	}
	else if (answer == 12) {
		std::cout << "Better not tell you now.";
	}
	else if (answer == 13) {
		std::cout << "Cannot predict now.";
	}
	else if (answer == 14) {
		std::cout << "Concentrate and ask again.";
	}
	else if (answer == 15) {
		std::cout << "Don't count on it.";
	}
	else if (answer == 16) {
		std::cout << "My reply is no.";
	}
	else if (answer == 17) {
		std::cout << "My sources say no.";
	}
	else if (answer == 18) {
		std::cout << "Outlook not so good.";
	}
	else if (answer == 19) {
		std::cout << "Very doubtful.";
	}
}

//HarryPotterQuiz.cpp
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

//functionpalindrome.cpp
#include <iostream>

// Define is_palindrome() here:
bool is_palindrome(std::string text) {

    //initialize string for rev_text
    std::string rev_text = "";

    //for loop to seperate letters in text
    for (int i = text.size() - 1; i >= 0; i--) {
        rev_text += text[i];
    }

    //compare letters in text to rev_text and return t or f
    if (rev_text == text) {
        return true;
    }
    else {
        return false;
    }
}

int main() {

    std::cout << is_palindrome("madam") << "\n";
    std::cout << is_palindrome("ada") << "\n";
    std::cout << is_palindrome("lovelace") << "\n";
}

```