# Python Documentation

# Run Length Encoding in Python

This repository contains a Python script that implements the Run Length Encoding (RLE) algorithm for data compression. The script takes a string as input and returns a new string where each sequence of the same character is replaced by the number of occurrences of the character followed by the character itself.

## Script Description

The script `run_length_encoding.py` contains a single function `run_length_encoding(input_string)`. This function takes a string as input and returns the run length encoded version of the string.

The function works by iterating over the input string and counting the number of times each character appears consecutively. It then appends the count and the character to the output string. This process is repeated until all characters in the input string have been processed.

Here is a brief explanation of the function:

- `encoding = ''`: This line initializes the output string.
- `i = 0`: This line initializes the counter used to iterate over the input string.
- `while i < len(input_string)`: This loop continues until all characters in the input string have been processed.
- `count = 1`: This line initializes the count of consecutive occurrences of a character.
- `while i + 1 < len(input_string) and input_string[i] == input_string[i+1]`: This loop continues as long as the next character is the same as the current one.
- `i += 1`: This line increments the counter.
- `count += 1`: This line increments the count of consecutive occurrences of a character.
- `encoding += str(count) + input_string[i]`: This line appends the count and the character to the output string.
- `i += 1`: This line increments the counter to move to the next character.

## Usage

To use this script, you can run it from the command line and enter the string to be encoded when prompted:

```bash
python run_length_encoding.py
```

## Libraries

This script does not use any external libraries. It only uses built-in Python features.

## Conclusion

This script provides a simple implementation of the Run Length Encoding algorithm in Python. It can be used as a starting point for more complex data compression tasks.

---

# C# Documentation

# Run Length Encoding in C#

This repository contains a simple C# script that performs Run Length Encoding (RLE) on a user-inputted string. RLE is a basic form of data compression where consecutive elements that are the same are replaced with the element followed by the count of the element.

## Script Explanation

The script first prompts the user to enter a string to compress. It then calls the `RunLengthEncode` function with the user's input, which performs the RLE. The compressed string is then printed to the console.

## Code Breakdown

The script is composed of a `Main` function and a `RunLengthEncode` function.

### Main Function

The `Main` function is the entry point of the script. It first prompts the user to enter a string to compress. It then calls the `RunLengthEncode` function with the user's input and prints the result to the console.

### RunLengthEncode Function

The `RunLengthEncode` function takes a string as input and returns the RLE of the string. It uses a `StringBuilder` to efficiently build the compressed string. It iterates over the input string, keeping a count of consecutive identical characters. When it encounters a different character, it appends the previous character and its count to the `StringBuilder`, and resets the count.

## Imported Libraries

The script imports two libraries:

- `System`: This is a fundamental library in C# that provides classes for input/output, string manipulation, and other basic functionalities. In this script, it is used for console input/output and string manipulation.

- `System.Text`: This library provides classes for working with text. In this script, it is used for the `StringBuilder` class, which provides a mutable string object for efficiently building strings.

## Usage

To use this script, simply run it in a C# environment, enter a string when prompted, and the compressed string will be printed to the console.

---

# Java Documentation

# Java Run-Length Encoding Script

This repository contains a simple Java script that performs run-length encoding on a given string. Run-length encoding is a simple form of data compression in which consecutive elements that are the same are replaced with the number of elements followed by the element itself.

## Script Explanation

The script starts by importing the `java.util.Scanner` class, which is a simple text scanner that can parse primitive types and strings using regular expressions. It is used in this script to read the input string from the user.

The `main` method initializes a `Scanner` object and uses it to read the next line of input from the user. This input string is then passed to the `encode` method, which performs the run-length encoding. The result is then printed to the console.

The `encode` method works by iterating over each character in the source string. For each character, it counts how many consecutive characters are the same (the run length). It then appends the run length and the character to the destination string. This process is repeated for all characters in the source string.

## Imported Libraries

- `java.util.Scanner`: This class is a part of the Java Collections Framework and is used to parse text for strings and primitive types using regular expressions. In this script, it is used to read the user's input from the console.

## Usage

To use this script, simply run the `Main` class. When prompted, enter the string you wish to encode. The encoded string will be printed to the console.

## Example

Input: `aaabbbccc`

Output: `3a3b3c`

This indicates that the input string contains three 'a' characters, followed by three 'b' characters, followed by three 'c' characters.

---
