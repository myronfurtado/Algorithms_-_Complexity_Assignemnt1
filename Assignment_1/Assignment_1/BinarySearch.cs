using System;


namespace Assignment_1
{
    class BinarySearch
    {
         public static int BinarySearch1(int[] array, int l, int r, int x)
         {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                // if the element is there in middle
                if (array[mid] == x)
                    return mid;
                //if the number is smaller than the one in the middle
                if (array[mid] > x)
                    return BinarySearch1(array, l, mid - 1, x);
                //if not then the element is checked for in the right array
                return BinarySearch1(array, mid + 1, r, x);
            }
            return -1;

         }
    }
}
