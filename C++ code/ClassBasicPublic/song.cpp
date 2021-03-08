#include "song.hpp"

// add Song method definitions here:
//function type class name method name method type
void Song::add_title(std::string new_title) {
	title = new_title;
}
//data type class name method name
std::string Song::get_title() {
	return title;
}