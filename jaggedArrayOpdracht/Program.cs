public class Program
{
    //Example jagged array
    int[][] array = new int[][]{ 
    new int[] { 3, 4 },                // -> array[0]
    new int[] { 1, 3, -2, 9},          // -> array[1]
    new int[] { 3, -1, 9 },            // -> array[2]
    new int[] { 3, -1, 9, 40, 100 }    // -> array[3]
    };

    public List<int> getSumOfNestedArrays()
    {
        int sum0 = 0;
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                switch(i)
                {
                    case 0:
                        sum0 += array[i][j];
                        break;
                    case 1:
                        sum1 += array[i][j];
                        break;
                    case 2:
                        sum2 += array[i][j];
                        break;
                    case 3:
                        sum3 += array[i][j];
                        break;
                    default:
                        break;
                }
                
            }
        }
        List<int> sumList = new List<int>{ sum0, sum1, sum2, sum3 };
        return sumList;
    }
}