
public class Solution {
  public static void Main(args[])
  {
    int[] nums = [2,2,1,1,5,3,3,5];
    
    var value = MaxEqualFreq(nums);
    
    if(value != 7)
    {
      throw new Exception("Failure to be correct.");
    }
  }
  
  public int MaxEqualFreq(int[] nums) {
      List<int> numsList = new List<int>();
      SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
      for(int i=0; i<nums.Length; i++)
      {
          numsList.Add(nums[i]);
          if(counts.ContainsKey(nums[i]))
          {
              counts[nums[i]]++;
          }
          else
          {
              counts.Add(nums[i],1);
          }
      }
      var maxFreq = counts[counts.Count-1];
      return numsList.IndexOf(maxFreq);
    }
}
