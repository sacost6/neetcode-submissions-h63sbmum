class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        # set a left pointer to the second value
        # this is the tracker pointer as well 

        l = 1
        
        # keep r as the right pointer to find duplicates
        for r in range(1, len(nums)):

            # check if the previous right pointer value is not
            # the same
            if(nums[r-1] != nums[r]):
                # set the left pointer position to the unique right pointer value
                nums[l] = nums[r]

                #increment the left pointer by one
                l += 1

        
        return l 

        