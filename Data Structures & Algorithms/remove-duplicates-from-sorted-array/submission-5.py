class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:

        # set a left and right pointer
        r = 0
        l = 0
        n = len(nums)
        
        # use left pointer to keep track of where the unique value goes
        while r < n:
            # set current value to the right pointer value since we know its unique
            nums[l]=nums[r]
            
            # increment the right pointer while the string end
            # is not reached and the values are the same
            while r < n and nums[l] == nums[r]:
                r += 1

            # incrment the left pointer when we found a unique value with the right pointer
            l += 1

        return l
   