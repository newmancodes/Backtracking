using System.Collections.Generic;

namespace Backtracking.Shared.NQueens
{
    public class Outcome
    {
        public bool SolutionFound { get; init; }
        
        public IReadOnlyCollection<Solution> Solutions { get; init; }

        public Outcome()
        {
            SolutionFound = false;
            Solutions = new List<Solution>();
        }
        
        internal class Builder
        {
            public Outcome Build()
            {
                return new Outcome();
            }
        }
    }
}