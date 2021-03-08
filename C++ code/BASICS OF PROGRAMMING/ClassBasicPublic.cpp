#include <iostream>
using namespace std

//class informs that you are creating a class (declaring a class) followed by the name of the class(uppercase)
class ShaunsClass {

//this will either set private or public. access specifier.  Public allows for use outside of the class itself.
public:
	
	//basic function within the created class
	void coolSaying() {
		cout << "Learning how to code" << endl;
		}

};

int main()
{
	//object is used to access the functions within the class.  similar to creating a variable.  name of class (space) name of created object
	ShaunsClass shaunsObject;

	//call object with a dot seperater than function
	shaunsObject.coolsaying();
	return 0;
}
