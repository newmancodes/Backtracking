namespace Backtracking.Shared.NQueens
{
    public class Solution
    {
        public class Builder
        {
            public Builder(byte n)
            {
            }

            public Builder WithQueenAt(byte x, byte y)
            {
                return this;
            }

            public Solution Build()
            {
                return new Solution();
            }
        }
    }
}