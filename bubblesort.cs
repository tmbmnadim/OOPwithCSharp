using System;

namespace selectionSort
{
    class selectionSort
    {
        public int printarr(int[] arr, int size)
        {   
            
            for(int i = 0; i<size;i++)
            {   
                Console.WriteLine("{0}",arr[i]);
            }
            return 0;
        }
        public int[] sortFunc(int[] array){
            int sizeofarr = array.Length;
            int i = 0;
            int j = 0;
            int minIndex = 0;
            while(i<=sizeofarr){
                j=i;
                while(j<=sizeofarr-1){
                    if(array[minIndex]>array[j]){
                        minIndex=j;
                        j++;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
                i++;
            }
            printarr(array, sizeofarr);
            return array;
        }

        static int Main(){
            selectionSort sort = new selectionSort();
            int[] array = {5,9,7,8,7,8,2,4,56,6,4};
            sort.sortFunc(array);
            return 0;
        }
    }
}