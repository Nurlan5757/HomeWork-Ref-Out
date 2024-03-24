using System.Globalization;

namespace C__HomeWork_Out__Ref
{
    internal class Program
    {
        static void Main()
        {
            #region taks1
            /*int[] arr = { 3, -1, 2, 1, -2, 7, -4 };
            negative(ref arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }

        }
        static void negative(ref int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = nums[i] * -1;
                }
            }*/

            #endregion
            #region task2

            /* string word = "salam";
             A(ref word);

             Console.WriteLine(A(ref word));

         }
         static bool A(ref string arr )
         {
             for (int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] == 'a')
                 {
                     return true;    
                 }
             }
             return false;

         }*/
            #endregion
            #region task3

            /*int[] arr = { 2, 4, 5, 1, 3 };
            Min(ref arr);

            Console.WriteLine(Min(ref arr));

        }
        static int Min(ref int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            return min;*/
            #endregion
            #region task4

            /* int a = 4;

             Num( ref a);

         }
         static void Num(ref int num)
         {
            int count = 0;
             int b;
            while (num!=0)
             {
                 b = num % 10;

                 num /= 10;

                 count++; 
             }
             Console.WriteLine(count);*/
            #endregion
            #region task5
            /*var word = "salam olsun Sabir Məllimə";

            VowelLetter(ref word);

        }
        static void VowelLetter( ref string arr)
        {
            int count = 0;
            var sait="aiuoeüöıəAİUOEÜÖIƏ";

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < sait.Length; j++) 
                {
                    if (arr[i] == sait[j])
                    {
                        count++;  
                    }   
                }
            }
            Console.WriteLine(count);*/
            #endregion
            #region task6
            /*int[] arr = {5,5,4,6};

            Numaverage( ref arr);

        }
        static void Numaverage( ref int[] nums)
        {
            int Numaverage = 0;
            int count=0;
            int sum=0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                count++;
            }
            Numaverage=sum/count;

            Console.WriteLine(Numaverage);*/
            #endregion
        }
    }
}