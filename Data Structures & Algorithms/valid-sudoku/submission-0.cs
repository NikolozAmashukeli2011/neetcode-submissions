public class Solution {


    public bool IsValidSudoku(char[][] board) {

        for(int i = 0; i < board.Length; i++)
        {
             HashSet<char> set = new();

            for(int j = 0; j < board.Length; j++)
            {
           char item = board[i][j];
            if(set.Contains(item))
            {
                return false;
            } else if(item != '.')
            {
             set.Add(item);
            }

            }
        }

    for(int i = 0; i < board.Length; i++)
        {
            HashSet<char> set = new();
            
            for(int j = 0; j < board.Length; j++)
            {
            char item = board[j][i];
            if(set.Contains(item))
            {
                return false;
            } else if(item != '.')
            {
             set.Add(item);
            }

            }

        }
        

for(int i = 0; i < 9; i += 3)
{

for(int j = 0; j < 9; j += 3)
{
HashSet<char> set = new();

for(int row = i; row < i + 3; row++)
{

for(int col = j; col < j + 3; col++)
{
char val = board[row][col];

if(val != '.')
{
    if(!set.Add(val))
    {
        return false;
    }
}

}

}

}

}

return true;
   }

  }

