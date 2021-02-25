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