using System;

namespace Backtracking.Shared.NQueens
{
    public class Solver
    {
        public Outcome Solve(byte n)
        {
            if (n == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), $"{nameof(n)} must be positive, '{n}' supplied.");
            }

            return new Outcome.Builder()
                .Build();
        }
    }
}