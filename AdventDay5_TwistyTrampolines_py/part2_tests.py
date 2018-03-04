from unittest import TestCase
from part2 import Advent5Part2


class Advent5Part2Tests(TestCase):

    def test_jump_10_steps(self):
        test_jumps = [0, 3, 0, 1, -3]
        adv = Advent5Part2(test_jumps)
        steps = adv.count_jumps()

        self.assertEqual(10, steps)
        self.assertEqual(2, adv.get_jump_element(0))
        self.assertEqual(3, adv.get_jump_element(1))
        self.assertEqual(2, adv.get_jump_element(2))
        self.assertEqual(3, adv.get_jump_element(3))
        self.assertEqual(-1, adv.get_jump_element(4))
