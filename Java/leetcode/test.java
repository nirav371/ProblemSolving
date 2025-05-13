package leetcode;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class test {
    static List<Integer> get(int a, int b)
    {
        a = a + b;
        b = b - a;
        a = a - b;
        return Arrays.asList(a,b);
    }
    static int sumOfDigits(int n) {

        int res = 0;
        while (n > 0) {
            res += n % 10;
            n /= 10;
        }
        return res;
    }
    int sumOfMatrix(int N, int M, int[][] Grid) {
        int res = 0;
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < M; j++) {
                res += Grid[i][j];
            }
        }
        return  res;
    }
    String isVowel(char c){
        String a = "aeiouAEIOU";
        if(a.indexOf(c) != -1){
            return "NO";
        }
        return "YES";
    }
    int greatestOfThree(int A, int B, int C) {
        return Math.max(Math.max(A,B),C);
    }
    static String getBinaryRep(int n) {
        String binary = Integer.toBinaryString(n);
        return String.format("%32s", binary).replace(' ', '0');
    }
    public static int product(int arr[],int n)
    {
        int i = 0;
        int res = 1;
        while(i < n){
            res *= arr[i];
            i++;
        }
        return res;
    }
    public int[] findSum(int n) {
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <= n; i++) {
            if(i%2 == 0){
                evenSum += i;
            }else {
                oddSum += i;
            }
        }
        return new int[]{evenSum, oddSum};
    }
    public List<Integer> getAlternates(int arr[]) {
        ArrayList<Integer> res = new ArrayList<>();
        for (int i = 0; i < arr.length; i += 2) {
            res.add(arr[i]);
        }

        return res;
    }
//    static int evenlyDivides(int n) {
//        // code here
//        String s = Integer.toString(n);
//        int i = 0;
//        int res = 0;
//        List<Character> chars = {};
//        while(i < s.length()){
//            if(n%(s.charAt(i) + '0') == 0 && chars.contains(s.charAt(i))){
//                chars.add(s.charAt(i));
//                res += 1;
//            }
//            i++;
//        }
//    }
    public static boolean isPalinArray(int[] arr) {
        // add code here.
        int i = 0;
        while(i < arr.length){
            String original = String.valueOf(arr[i]);
            String reversed = new StringBuilder(original).reverse().toString();
            if(!original.equals(reversed)){
                return false;
            }
            i++;
        }
        return true;
    }
    public double findMedian(int[] arr) {
        Arrays.sort(arr);  // Step 1: Sort the array
        int n = arr.length;

        if (n % 2 == 1) {
            return arr[n / 2];  // Odd length: return middle element
        } else {
            return (arr[n / 2 - 1] + arr[n / 2]) / 2.0;  // Even length: average of two middle elements
        }
    }
    static boolean armstrongNumber(int n) {
        String a = String.valueOf(n);
        int res = 0;

        for (int i = 0; i < a.length(); i++) {
            int digit = a.charAt(i) - '0';
            res += digit * digit * digit;
        }

        return n == res;
    }
    public int reverseDigits(int n) {
        // Code here
        StringBuilder numReverseString = new StringBuilder(Integer.toString(n)).reverse();
        return  Integer.parseInt(numReverseString.toString());
    }
    boolean isDigitSumPalindrome(int n) {
        String numString = Integer.toString(n);
        int res = 0;
        for (int i = 0; i < numString.length(); i++) {
            res += numString.charAt(i) - '0';
        }
        return Integer.toString(res).contentEquals(new StringBuilder(Integer.toString(res)).reverse());
    }
    public static boolean isPerfect(int[] arr) {
        for (int i = 0; i < (arr.length + arr.length%2)/2; i++) {
            if(arr[i] != arr[arr.length - i - 1]){
                return false;
            }
        }
        return true;
    }
    static ArrayList<Integer> getTable(int n) {
        // code here
        ArrayList<Integer> res = new ArrayList<>();
        for (int i = 1; i <= 10; i++) {
            res.add(n*i);
        }
        return res;
    }
//    static String modify (String s)
//    {
//        List<Character> chars = new ArrayList<>();
//        String vowels = "aeiou";
//        for (int i = 0; i < s.length(); i++) {
//            if(vowels.contains(s.charAt(i))){
//                chars.add(s.charAt(i));
//            }
//        }
//        return
//    }
    public String chartostr(char arr[], int N){
            return Arrays.toString(arr);
    }
    public int distance(int x1, int y1, int x2, int y2)
    {
        // Code here
        return (int) Math.sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    }
    public String longest(List<String> arr) {
        int longestStringIndex = 0;
        for (int i = 1; i < arr.size(); i++) {
            if (arr.get(i).length() > arr.get(longestStringIndex).length()) {
                longestStringIndex = i;
            }
        }
        return arr.get(longestStringIndex);
    }
    static void printFloydTriangle(int n) {
        // code here
        int start = 1;
        for (int i = 1; i <= n; i++) {
            for (int j = 0; j < i; j++) {
                System.out.println(start + " ");
                start++;
            }
            System.out.println();
        }
    }
    public int DiagonalSum(int[][] matrix)
    {
        // code here
        int res = 0;
        for (int i = 0; i < matrix.length; i++) {

                res += matrix[i][i];
        }
        for (int i = 0; i < matrix.length; i++) {
            res += matrix[i][matrix.length -i - 1];
        }
        return res;
    }
    public String is_AutomorphicNumber(int n)
    {
        int squareNumb = n*n;
        return String.valueOf(squareNumb).charAt(String.valueOf(squareNumb).length()-1) == String.valueOf(n).charAt(String.valueOf(n).length()-1) ? "Automorphic" : "Not Automorphic";
    }
}
