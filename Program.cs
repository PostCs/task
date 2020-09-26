﻿using System;
					
public class program
{
	public static void Main()
	{
		int n = 2, k = 10; 
        Console.WriteLine($"throw two {n} eggs and highest floor {eggDrop(n, k)}");
	}

     
    static int eggDrop(int n, int k) 
    { 
        
        if (k == 1 || k == 0) 
            return k; 
  
        
        if (n == 1) 
            return k; 
  
        int min = int.MaxValue; 
        int x, res; 
  
        
        for (x = 1; x <= k; x++) { 
            res = Math.Max(eggDrop(n - 1, x - 1), 
                           eggDrop(n, k - x)); 
            if (res < min) 
                min = res; 
        } 
  
        return min + 1; 
    } 
}