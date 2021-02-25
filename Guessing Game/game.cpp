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