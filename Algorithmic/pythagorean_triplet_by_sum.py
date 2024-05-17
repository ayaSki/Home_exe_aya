import math


def get_pythagorean_triplet_by_even(even: int) -> list:
    return [int((even/2)**2 - 1), int((even/2)**2 + 1)]


def get_pythagorean_triplet_by_odd(odd: int) -> list:
    return [int((odd**2)/2 - 0.5), int((odd**2)/2 + 0.5)]


def pythagorean_triplet_by_sum(sum: int) -> None:
    first_pythagorean_num = 1
    options = []
    while first_pythagorean_num < sum:
        if first_pythagorean_num % 2 == 0:
            options = get_pythagorean_triplet_by_even(first_pythagorean_num)
        else:
            options = get_pythagorean_triplet_by_odd(first_pythagorean_num)
        if first_pythagorean_num + options[0] + options[1] == sum:
            print(f"{first_pythagorean_num} < {options[0]} < {options[1]}")
            return
        first_pythagorean_num += 1
    print("There is no such a pythagorean triplet")