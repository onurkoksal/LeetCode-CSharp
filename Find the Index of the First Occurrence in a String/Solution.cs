public class Solution {
    public int StrStr(string haystack, string needle) {
        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            int j = 0;
            
            for (; j < needle.Length; j++) {
                if (haystack[i + j] != needle[j]) {
                    break;
                }
            }
            
            if (j == needle.Length) {
                return i;
            }
        }
        
        return -1;
    }
}
