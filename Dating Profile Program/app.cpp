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