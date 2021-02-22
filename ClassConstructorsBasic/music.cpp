#include <iostream>
#include "song.hpp"

int main() {
	//creates in song class called (back_to_black,smooth_criminal,wooden_ships) title of song and artist
	Song back_to_black("Back to Black", "Amy Winehouse");
	Song smooth_criminal("Smooth Criminal", "Micheal Jackson");
	Song wooden_ships("Wooden Ships", "Crosby Stills Nash and Young");

	//prints title and artist 
	std::cout << back_to_black.get_title() << "\n";
	std::cout << smooth_criminal.get_title() << "\n";
	std::cout << wooden_ships.get_title() << "\n";
	std::cout << back_to_black.get_artist() << "\n";
	std::cout << smooth_criminal.get_artist() << "\n";
	std::cout << wooden_ships.get_artist() << "\n";
}