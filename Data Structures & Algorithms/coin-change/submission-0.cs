public class Solution {
    public int CoinChange(int[] coins, int amount) 
    {
        var min = MinCoins(coins,0,0,0,amount);
        return min==int.MaxValue?-1:min;
    }

    int MinCoins(int[] ar ,int i,int coins,int total,int target)
    {
        if(i>=ar.Length)
        return int.MaxValue;

        else if(total<target)
        {
            int min1 = MinCoins(ar,i,coins+1,total+ar[i],target); //we added crnt coin
            int min2 = MinCoins(ar,i+1,coins,total,target);  //we didn't add crnt coin
            return Math.Min(min1,min2);
        }
        else if(total==target)
        {
            return coins;
        }
        else return int.MaxValue;


    }
}
