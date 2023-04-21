public class Main {

    public static int[] arrayOfMultiples(int num, int length) {
        int[] result = new int[length];
        for (int i = 1; i <= length; i++) {
            result[i - 1] = num * i;
        }
        return result;
    }

    public static void main(String[] args) {
        System.out.println(Arrays.toString(arrayOfMultiples(7, 5)));
        System.out.println(Arrays.toString(arrayOfMultiples(12, 10)));
        System.out.println(Arrays.toString(arrayOfMultiples(17, 6)));
    }
}