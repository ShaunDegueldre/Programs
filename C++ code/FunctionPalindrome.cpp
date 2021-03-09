//functionpalindrome.cpp
#include <iostream>

// Define is_palindrome() here:
bool is_palindrome(std::string text) {

    //initialize string for rev_text
    std::string rev_text = "";

    //for loop to seperate letters in text
    for (int i = text.size() - 1; i >= 0; i--) {
        rev_text += text[i];
    }

    //compare letters in text to rev_text and return t or f
    if (rev_text == text) {
        return true;
    }
    else {
        return false;
    }

}

int main() {

    std::cout << is_palindrome("madam") << "\n";
    std::cout << is_palindrome("ada") << "\n";
    std::cout << is_palindrome("lovelace") << "\n";

}