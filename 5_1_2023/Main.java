import java.lang.*;
public class Main {

    public static int warOfNumbers(int[] arr) {
        int even = 0;
        int odd = 0;
        for (int val : arr) {
            if (val % 2 == 0)
                even += val;
            else
                odd += val;
        }
        return Math.abs(even - odd);
    }

    public static void main(String[] args) {
        int[] arr1 = {2, 8, 7, 5};
        int[] arr2 = {12, 90, 75};
        int[] arr3 = {5, 9, 45, 6, 2, 7, 34, 8, 6, 90, 5, 243};
        System.out.println(warOfNumbers(arr1));
        System.out.println(warOfNumbers(arr2));
        System.out.println(warOfNumbers(arr3));
    }
}