def run_length_encoding(input_string):
    encoding = ''
    i = 0

    while i < len(input_string):
        count = 1
        while i + 1 < len(input_string) and input_string[i] == input_string[i+1]:
            i += 1
            count += 1
        encoding += str(count) + input_string[i]
        i += 1
    return encoding

if __name__ == "__main__":
    input_string = input("Enter the string to be encoded: ")
    print(run_length_encoding(input_string))