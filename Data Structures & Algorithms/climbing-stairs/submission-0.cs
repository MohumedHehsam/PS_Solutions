public class Solution {
    /*
    1- recursion 
    2- remember
    3-use old values
    
    */
    public int ClimbStairs(int n) 
    {   
        int[] d = new int[n+1];
        Array.Fill(d,-1);

        for(int i=0;i<n;i++)
        Recursion(d,n,i);
        return Recursion(d,n,0);
    }

    private int Recursion(int[] d, int n, int i)
    {
        if(i==n)
        return 1;
        else if(i>n)
        return 0;

        if(d[i]!=-1)
        return d[i];

        int count =0;
        count+= Recursion(d,n,i+1);
        count+= Recursion(d,n,i+2);

        d[i]=count;
        return d[i];
    }
}