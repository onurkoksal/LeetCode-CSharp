public class Solution {
    public int MySqrt(int x) {
        if (x == 0) {
            return 0;
        }

        int left = 1;
        int right = x;
        int answer = 0;

        while (left <= right) {
        
            int average = left + (right - left) / 2;

            if (average == x / average) {
                return average;
            }
            else if (average < x / average) {
                answer = average;      
                left = average + 1;    
            }
            
            else {
                right = average - 1;  
            }
        }

        return answer;
    }
}
