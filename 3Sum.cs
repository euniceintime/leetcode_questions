public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        if (nums == null)
            return new List<IList<int>>();

        Array.Sort(nums);
        IList<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++) {
            if (i >= 1 && nums[i] == nums[i-1])
                continue;
            int total = -nums[i];
            int left = i + 1, right = nums.Length - 1;
            while (left < right) {
                if (nums[left - 1] == nums[left] && left - 1 != i)
                    left++;
                else if (nums[left] + nums[right] > total)
                    right--;
                else if (nums[left] + nums[right] < total)
                    left++;
                else{
                    ans.Add(new List<int>(){nums[i], nums[left], nums[right]});
                    left++;
                    right--;
                }
            }
        }
        return ans;
    }
}