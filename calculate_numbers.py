from typing import List, Any
import matplotlib.pyplot as plt


def get_numbers() -> list:
    print("Enter numbers, when you want to stop enter -1\n")
    number = 0
    numbers = []
    while number != "-1":
        number = input("Enter number: ")
        if number != "-1":
            numbers.append(int(number))
    return numbers


def get_average(numbers: list) -> int:
    return sum(numbers)//len(numbers)


def get_positive_numbers(numbers: list) -> list:
    return [number for number in numbers if number > 0]


def return_sorted_list(numbers: list) -> None:
    numbers.sort()


def create_graph(numbers: list) -> None:
    x = [i + 1 for i in range(len(numbers))]
    plt.scatter(x, numbers)
    plt.show()


def exe_flow() -> None:
    numbers = get_numbers()
    print(f"Your numbers average: {get_average(numbers)}\n"
          f"All the positive numbers: {get_positive_numbers(numbers)}")
    create_graph(numbers)
    return_sorted_list(numbers)
    print(f"Sorted numbers: {numbers}")
