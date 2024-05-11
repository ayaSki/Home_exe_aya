def num_len(number: int) -> int:
    return 1 + num_len(number//10) if number > 0 else 0
