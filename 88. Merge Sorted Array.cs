public class Solution 
{
     public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int length = nums1.Length -1;
        if (n == 0)
        {
            return;
        }
        while (m > 0 && n > 0)
        {
            if (nums1[m-1] > nums2[n-1])
            {
                nums1[length] = nums1[m-1];
                m--;
                length--;
            }
            else
            {
                nums1[length] = nums2[n-1];
                n--;
                length--;
            }
        }
        while (n != 0)
        {
            nums1[length] = nums2[n-1];
                n--;
                length--;
        }
    }
}