public class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        var index = 0;

        if (nums2.Count() !=0)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] == 0 && i >= m)
                {
                    nums1[i] = nums2[index];
                    index++;
                }
            }
        }


        Array.Sort(nums1);
    }

    public static void Main(string[] args)
    {
        int m = Convert.ToInt32(Console.ReadLine());
        var nums1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        int n = Convert.ToInt32(Console.ReadLine());
        var nums2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

        Merge(nums1, m, nums2, n);
        
    }
}

