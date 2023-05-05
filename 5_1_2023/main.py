def sum_odd_and_even(arr):
    odd = 0
    even = 0
    for num in arr:
        if num % 2 == 0:
            even += num
        else:
            odd += num
    return [even, odd]

def main():
    arr1 = [1, 2, 3, 4, 5, 6]
    arr2 = [-1, -2, -3, -4, -5, -6]
    arr3 = [0, 0]
    print(sum_odd_and_even(arr1))
    print(sum_odd_and_even(arr2))
    print(sum_odd_and_even(arr3))

if __name__ == "__main__":
    main()
