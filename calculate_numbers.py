def get_numbers() -> list:
    print("Enter numbers, when you want to stop enter -1\n")
    number = 0
    numbers = []
    while number != "-1":
        number = input("Enter number: ")
        if number.isdigit() and number != "-1":
            numbers.append(int(number))
    return numbers


def get_average(numbers: list) -> int:
    return sum(numbers)//len(numbers)


def get_positive_numbers(numbers: list) -> int:
    return len([i for i in range(len(numbers)) if i > 0])


def return_sorted_list(numbers: list) -> list:
    return numbers.sort()


def exe_flow() -> None:
    numbers = get_numbers()
    print(f"Your numbers average: {get_average(numbers)}\n"
          f"All the positive numbers: {get_positive_numbers(numbers)}\n"
          f"Sorted numbers: {return_sorted_list(numbers)}")

if __name__ == '__main__':
    exe_flow()