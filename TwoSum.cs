public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if (nums == null)
            return Array.Empty<int>();
            
        Dictionary<int, int> numsSet = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (numsSet.ContainsKey(target - nums[i])) {
                numsSet.TryGetValue(target - nums[i], out int index);
                return new int[]{index, i};
            }
            numsSet[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}