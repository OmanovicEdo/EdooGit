def is_valid(pass_line):
    words = pass_line.split(" ")
    for index1 in range(0, len(words)):
        sorted_first_word = sorted(words[index1])
        for index2 in range(0, len(words)):
            if index1 != index2 and len(words[index1]) == len(words[index2]):
                sorted_second_word = sorted(words[index2])
                if sorted_first_word == sorted_second_word:
                    return False

    return True


fo = open('advent4_input_text.txt', 'r')
input_text = fo.read()
lines = input_text.split("\n")
pass_phrase_counter = 0
for line in lines:
    if is_valid(line):
        pass_phrase_counter += 1

print(pass_phrase_counter)

#Explanation
#challenge: http://adventofcode.com/2017/day/4
#nested for loops compare every word  in a given line with each other, if the words are of the same length
#also, a word is not compared with itself
#words are then sorted before comparing because valid passphrases do not allow words that can be same if permutated
#if pass_phrase passes the rules it return True from is_valid() function and pass_phrase_counter is incremented


