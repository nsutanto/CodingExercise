//https://leetcode.com/problems/same-tree/description/

using System;
namespace LeetCode
{
    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }

            if (p.val == q.val)
            {
                IsSameTree(p.left, q.left);
                IsSameTree(p.right, p.right);
            }
            else
            {
                return false;
            }
            return false;

        }
    }

}
