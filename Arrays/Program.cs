static void Main(string[] args)
{
    int[] array1 = new [] { 0,1,1,2,3,5,8,13};

    string[] Month = new [] { "January", "February", "March", "April", "May", "June", "July", "August", "September ", "October", "November", "December" };


    int[,] a = new int[3, 3] 
    {
                {2, 3, 4},
                {4, 9, 16},
                {8, 27, 64}
    };

    class Math
    {
    const double E = 3.1415926535897931;
    const double PI = 3.14;

    int[][] b = new int[3][]
    {
                new int[5] {1,2,3,4,5},
                new int[2] { E, PI},
                new int[4] { log1, log10,log100,log1000 }
     };
}

int[] array3 = { 1, 2, 3, 4, 5 };
int[] array2 = new [] { 7, 8, 9, 10, 11, 12, 13 };
Array.Copy(array3,  0, array2, 0, 12);


string[] sample = { "1", "2", "3", "4", "5", "6", "7", "8" };
Array.Resize(ref sample, 16 );  
