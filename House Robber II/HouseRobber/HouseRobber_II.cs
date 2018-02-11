using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRobber
{
  public static class HouseRobber_II
  {
    public static int Algorithm1(int[] house)
    {
      if (house == null)
      {
        throw new ArgumentNullException(nameof(house));
      }
      if (house.Length == 0)
      {
        return 0;
      }
      if (house.Any(n => n < 0))
      {
        throw new ArgumentOutOfRangeException(nameof(house));
      }
      if (house.Length == 1) return house[0];
      if (house.Length == 2) Math.Max(house[0], house[1]);
      return Math.Max(algorithm1(house, 0), algorithm1(house, 1));
    }
    private static int algorithm1(int[] house, int start_index)
    {
      int skip1_sum = -1;
      if (start_index + 2 < house.Length)
      {
        skip1_sum = house[start_index] + algorithm1(house, start_index + 2);
      }
      int skip2_sum = -1;
      if (start_index + 3 < house.Length)
      {
        skip2_sum = house[start_index] + algorithm1(house, start_index + 3);
      }
      if (skip1_sum > skip2_sum)
      {
        return house[start_index] + algorithm1(house, start_index + 2);
      }
      else if (skip1_sum < skip2_sum)
      {
        return house[start_index] + algorithm1(house, start_index + 3);
      }
      else return house[start_index];
    }
    public static int Algorithm2(int[] nums)
    {
      if (nums == null)
      {
        throw new ArgumentNullException(nameof(nums));
      }
      if (nums.Any(e => e < 0))
      {
        throw new ArgumentOutOfRangeException(nameof(nums));
      }
      if (nums.Length == 0)
      {
        return 0;
      }
      if (nums.Length == 1)
      {
        return nums[0];
      }
      int n = nums.Length;
      int[] f = new int[n];
      f[0] = nums[0];
      f[1] = Math.Max(nums[0], nums[1]);
      // House(0) is robbed
      for (int i = 2; i < n - 1; i++)
      {
        f[i] = Math.Max(f[i - 1], f[i - 2] + nums[i]);
      }
      int x = f[n - 2];
      // House(0) is not robbed
      f[0] = 0;
      f[1] = nums[1];
      for (int i = 2; i < n; i++)
      {
        f[i] = Math.Max(f[i - 1], f[i - 2] + nums[i]);
      }
      x = x > f[n - 1] ? x : f[n - 1];
      return x;
    }

    /*
        public static int Algorithm1(int[] house)
        {
          if (house == null)
          {
            throw new ArgumentNullException(nameof(house));
          }
          if (house.Any(n => n < 0))
          {
            throw new ArgumentOutOfRangeException(nameof(house));
          }
          if (house.Length == 1)
          {
            return house[0];
          }
          int even_sum = 0;
          for (int k = 0; k < house.Length - 1; k += 2)
          {
            even_sum += house[k];
          }
          int odd_sum = 0;
          for (int k = 1; k < house.Length; k += 2)
          {
            odd_sum += house[k];
          }
          return Math.Max(even_sum, odd_sum);
        }
        public static int Algorithm2(int[] nums)
        {
          if (nums == null)
          {
            throw new ArgumentNullException(nameof(nums));
          }
          if (nums.Any(e => e < 0))
          {
            throw new ArgumentOutOfRangeException(nameof(nums));
          }
          if (nums.Length == 0)
          {
            return 0;
          }
          if (nums.Length == 1)
          {
            return nums[0];
          }
          int n = nums.Length;
          int[] f = new int[n];
          f[0] = nums[0];
          f[1] = Math.Max(nums[0], nums[1]);
          // House(0) is robbed
          for (int i = 2; i < n - 1; i++)
          {
            f[i] = Math.Max(f[i - 1], f[i - 2] + nums[i]);
          }
          int x = f[n - 2];
          // House(0) is not robbed
          f[0] = 0;
          f[1] = nums[1];
          for (int i = 2; i < n; i++)
          {
            f[i] = Math.Max(f[i - 1], f[i - 2] + nums[i]);
          }
          x = x > f[n - 1] ? x : f[n - 1];
          return x;
        }
    */
  }
}