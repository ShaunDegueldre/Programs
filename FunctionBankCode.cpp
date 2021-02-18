#include <iostream>

//function created to ask and confirm passcode
void enter_code(int passcode) {

    if (passcode == 0310) {

        std::string bank_info = "Account number: 123456789, Balance: $12,000";

        std::cout << bank_info << "\n";

    }
    else {

        std::cout << "Sorry, incorrect!\n";

    }
}

int main() {


    enter_code(0123);
    enter_code(0310);


}