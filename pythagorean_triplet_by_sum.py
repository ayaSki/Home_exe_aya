import math


def get_pythagorean_triplet_by_even(even: int) -> list:
    return [math.pow(even / 2, 2) - 1, math.pow(even / 2, 2) - 1]


def get_pythagorean_triplet_by_odd(odd: int) -> list:
    return [math.pow(odd, 2) / 2 - 0.5, math.pow(odd, 2) / 2 - 0.5]


def pythagorean_triplet_by_sum(sum: int) -> None:
    first_pythagorean_num = 1
    options = []
    found = False
    while not found:
        if first_pythagorean_num % 2 == 0:
            options = get_pythagorean_triplet_by_even(first_pythagorean_num)
        options = get_pythagorean_triplet_by_odd(first_pythagorean_num)
        if first_pythagorean_num + options[0] + options[1] == sum:
            print(first_pythagorean_num, options[0], options[1])
            found = True
        first_pythagorean_num += 1


if __name__ == '__main__':
    pythagorean_triplet_by_sum(17)
