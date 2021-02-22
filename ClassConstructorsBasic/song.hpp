#pragma once
#include <string>

class Song {
	//these are in private and create the variables for title and artist
	std::string title;
	std::string artist;

public:
	//this creates the command for the class to give a title(string) and artist(string) to be stored
	Song(std::string new_title, std::string new_artist);
	//this allows for the title that has been stored to be retrieved
	std::string get_title();
	//this allows for the artist that has been stored to be retrieved
	std::string get_artist();

};