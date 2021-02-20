#include <iostream>
#include <string>
using namespace std;

//declare class and name class
class ShaunsClass {
	//public functions can be accessed outside of the class
public:
	//function to set the name for the private variable
	void setName(string x) {
		name = x;
	}
	//function to retrieve the name variable from private
	string getName() {
		return name;
	}
	//all variables should be set to private for a more secure program
private:
	string name;
};

int main() {

	//setting class to an object
	ShaunsClass shaunobject;
	//use object to call function within class and set the private name through public
	shaunobject.setName("Shaun D");
	//use object to call function to print and get name
	cout << shaunobject.getName();
	return 0;
}