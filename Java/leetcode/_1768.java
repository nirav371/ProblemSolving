package leetcode;

class _1768 {

    public String mergeAlternately(String word1, String word2) {
        int minLength = Math.min(word1.length(), word2.length());
        StringBuilder Result = new StringBuilder();
        char[] word1List = word1.toCharArray();
        char[] word2List = word2.toCharArray();

        for (int i = 0; i < minLength; i++) {
            Result.append(word1List[i]);
            Result.append(word2List[i]);
        }
        if(word1.length()>minLength){
            Result.append(word1List, minLength , word1.length()-minLength);
        }
        if(word2.length()>minLength){
            Result.append(word2List, minLength , word2.length()-minLength);
        }
        return Result.toString();
    }
}

//class Solution {
//    public String mergeAlternately(String word1, String word2) {
//        StringBuilder result = new StringBuilder();
//        int minLength = Math.min(word1.length(), word2.length());
//        int i = 0;
//        while (i < minLength) {
//            result.append(word1.charAt(i));
//
//            result.append(word2.charAt(i));
//
//            i++;
//        }
//        result.append(word1.substring(minLength));
//        result.append(word2.substring(minLength));
//        return result.toString();
//    }
//}