#http://adventofcode.com/2017/day/4

fo = open('advent4_input_text.txt', 'r')
input_text = fo.read()
lines = input_text.split("\n")

pass_phrase_counter = 0
for line in lines:
    words = line.split(" ")
    uniques = set(words)

    if len(words) == len(uniques):
        pass_phrase_counter += 1

print(pass_phrase_counter)

#explanation
#challenge: http://adventofcode.com/2017/day/4
#read all lines from test file, iterate through lines and splits every line on whitespace
#set() finds list of distinct (unique) words in a line
#if length of words and uniques of a line is the same, then passphrase is valid, passphrase_counter is incremented