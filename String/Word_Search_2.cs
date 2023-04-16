using System;
using System.Collections.Generic;

public class Solution{
    public static int NumberIslands(char[,] grid){
        int count = 0;
        for(int i = 0; i < grid.GetLength(0); ++i){
            for(int j = 0; j < grid.GetLength(1); ++j){
                if(grid[i,j]=='1'){
                    dfs(grid,i,j);
                    count++;
                }
            }
        }
        return count;
    }
    private static bool dfs(char[,] grid, int i, int j){
        if(i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i,j]=='0'){
            return false;
        }
        int[] dx = {-1,0,0,1};
        int[] dy = {0,-1,1,0};
        if(grid[i,j]=='1'){
            grid[i,j] = '0';
            for(int k = 0; k < 4; ++k){
                if(dfs(grid,i+dx[k],j+dy[k])){
                    return true;
                }
            }
        }
        return false;
    }
    public static void Main(){
        char[,] grid = {{'1', '1', '0', '0', '0'},
                        {'1', '1', '0', '0', '0'},
                        {'0', '0', '1', '0', '0'},
                        {'0', '0', '0', '1', '1'}};
        
        Console.Write(NumberIslands(grid));
    }
}
