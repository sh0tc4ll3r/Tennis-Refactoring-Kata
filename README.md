# Tennis Refactoring Kata

Changes made through the refactor:

- Renamed private variables to follow standard "_xxx"
- Removed unused initializing values for score variables
- Removed unused variables
- Refactored constructor based on previously removed variables (since it ended as a default constructor I just removed it completely)
- Extracted methods from GetScore into three separate methods that make the calculations in standard situations, advantage situations and equals situations
- Cleaned up GetScore by using multiple returns instead of returning the same variable in multiple places, removed redundante elses
- Extracted score tally method from GeneralScore method
- Transformed multiple if/ifelses into switch expression on Advantage method and removed score variable since it's only being used to return the result of the switch statement; simply returning it
- Transformed switch statement to expression on EqualsScore method
