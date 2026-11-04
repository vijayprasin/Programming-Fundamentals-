public class Solution{
    public int[] SecondsToHMS (int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int remaining = totalSeconds % 3600;

        int minutes = remaining / 60;
        int seconds = remiaining % 60;

        return new int[]
        {
            hours,minutes,seconds
        };
    }
}