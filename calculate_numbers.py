from typing import List, Any


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


def exe_flow() -> None:
    numbers = get_numbers()
    print(f"Your numbers average: {get_average(numbers)}\n"
          f"All the positive numbers: {get_positive_numbers(numbers)}")
    return_sorted_list(numbers)
    print(f"Sorted numbers: {numbers}")


if __name__ == '__main__':
    exe_flow()