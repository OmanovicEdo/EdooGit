class Advent5Part2:

    def __init__(self, jumps):
        self.jumps = jumps
        self.steps = 0

    def count_jumps(self):
        index = 0

        while index < len(self.jumps):
            prev_index = index

            jump_delta = 1
            if int(self.jumps[index]) >= 3:
                jump_delta = -1

            index += int(self.jumps[index])

            self.jumps[prev_index] = int(self.jumps[prev_index]) + jump_delta
            self.steps += 1

        return self.steps

    def get_jump_element(self, index):
        return self.jumps[index]