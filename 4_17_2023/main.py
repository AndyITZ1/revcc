def fizz_buzz(n):
    if n % 3 == 0 and n % 5 == 0:
        return "FizzBuzz"
    elif n % 3 == 0:
        return "Fizz"
    elif n % 5 == 0:
        return "Buzz"
    else:
        return str(n)

def main():
    print(fizz_buzz(3))
    print(fizz_buzz(5))
    print(fizz_buzz(15))
    print(fizz_buzz(4))

if __name__ == "__main__":
    main()