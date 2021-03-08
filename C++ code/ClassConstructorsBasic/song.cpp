#include "song.hpp"

// add the Song constructor here:
//This is the function which sets the inputed title and artist in the class
Song::Song(std::string new_title, std::string new_artist) {
	title = new_title;
	artist = new_artist;
}
//This is the function which returns the title
std::string Song::get_title() {

	return title;

}
//This is the function which returns the artist
std::string Song::get_artist() {

	return artist;

}