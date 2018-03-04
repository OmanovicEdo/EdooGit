from part1 import Advent5Part1
from part2 import Advent5Part2

fo = open('advent5_puzzle_input.txt', 'r')
text = fo.read()
text.split('\n')
jumpsTest1 = text.split('\n')
jumpsTest2 = text.split('\n')

adv = Advent5Part1(jumpsTest1)
print("part1 steps: ", adv.count_jumps())

#it takes 5+ sec to calculate part2
adv = Advent5Part2(jumpsTest2)
print("part2 steps: ", adv.count_jumps())

#https://adventofcode.com/2017/day/5
#ANS1: 355965
#ANS2: 26948068