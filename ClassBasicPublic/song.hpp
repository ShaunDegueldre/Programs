#pragma once
#include <string>

// add the Song class here:
//class name
class Song {
	variable within class
	std::string title;

//access specifier
public:
	//function within class
	void add_title(std::string new_title);
	std::string get_title();
};