internal partial class Program
{
     //Array in Fuction
     public int maxVal(int [] arr){
        int max = arr[0];
        for(int j=0;j<arr.Length;j++){
            if(arr[j]>max){
                max = arr[j];
            }
        }
        return max;
     }

     public int maxxi(params int[] val){
        int max = val[0];
        for(int j=0;j<val.Length;j++){
            if(val[j]>max){
                max = val[j];
            }
        }
        return max;
     }
    private static void Main(string[] args)
    {
        // Array Definition
        // type brackets name=new type brackets values
        Program p=new Program();
        int [] numbers=new int [4] {2,3,4,5};

        // Access To Element in Array
        int i=numbers[1];

        //Multidimentional Arrays
        int [,] MultiArray=new int [2,2]{{2,3},{3,3}};

        // Access MultiDimesntional Array
        int j=MultiArray[0,1];

        // Functional Access
        int k=p.maxVal(numbers);

        // Jagged Array
        int [][] jaggedArray=new int [2][]{
            new int [2]{1,2},
            new int [3]{3,4,5}
        };

        //Params
        p.maxxi(2,3,25,12,21,2);




       


      
    }
}