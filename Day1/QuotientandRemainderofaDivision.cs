public class Solution
{
    public int[] Divide (int dividend,int divisor)
    {
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        return new int[]
        {
            quotient,remainder
        };
    }
}