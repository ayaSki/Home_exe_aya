def is_sorted_str(str_test: str) -> bool:
    str_test = str_test.lower()
    for i in range(len(str_test)//2):
        if str_test[i] > str_test[i + 1]:
            return False
    return True


def is_polyndrom(str_test: str) -> bool:
    return str_test == str_test[::-1]


def is_sorted_polyndrom(str_test) -> bool:
    return is_sorted_str(str_test) and is_polyndrom(str_test)

