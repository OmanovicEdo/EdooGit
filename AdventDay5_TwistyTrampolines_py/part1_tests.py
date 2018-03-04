from unittest import TestCase
from part1 import Advent5Part1


class Advent5Part1Tests(TestCase):

    def test_jump_5_steps(self):
        test_jumps = [0, 3, 0, 1, -3]
        adv = Advent5Part1(test_jumps)
        steps = adv.count_jumps()

        self.assertEqual(5, steps)
        self.assertEqual(2, adv.get_jump_element(0))
        self.assertEqual(5, adv.get_jump_element(1))
        self.assertEqual(0, adv.get_jump_element(2))
        self.assertEqual(1, adv.get_jump_element(3))
        self.assertEqual(-2, adv.get_jump_element(4))
