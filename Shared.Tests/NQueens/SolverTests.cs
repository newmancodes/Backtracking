using System;
using Backtracking.Shared.NQueens;
using FluentAssertions;
using Xunit;

namespace Shared.Tests.NQueens
{
    public class SolverTests
    {
        [Fact]
        public void N_Must_Be_Positive()
        {
            // Arrange
            const byte n = 0;
            var solver = new Solver();

            // Act
            Action actor = () => solver.Solve(n);

            // Assert
            actor.Should().Throw<ArgumentOutOfRangeException>()
                .Which.ParamName.Should().Be("n");
        }

        [Fact]
        public void N_of_1_Has_One_Solution()
        {
            // Arrange
            const byte n = 1;
            var solver = new Solver();

            // Act
            var outcome = solver.Solve(n);

            // Assert
            outcome.SolutionFound.Should().BeTrue();
            outcome.Solutions.Count.Should().Be(1);

            var possibleSolution = new Solution.Builder(n)
                .WithQueenAt(0, 0)
                .Build();
            outcome.Solutions.Should().Contain(possibleSolution);
        }

        [Fact]
        public void N_of_2_Has_No_Solution()
        {
            // Arrange
            const byte n = 2;
            var solver = new Solver();

            // Act
            var outcome = solver.Solve(n);

            // Assert
            outcome.SolutionFound.Should().BeFalse();
            outcome.Solutions.Count.Should().Be(0);
        }

        [Fact]
        public void N_of_3_Has_No_Solution()
        {
            // Arrange
            const byte n = 3;
            var solver = new Solver();

            // Act
            var outcome = solver.Solve(n);

            // Assert
            outcome.SolutionFound.Should().BeFalse();
            outcome.Solutions.Count.Should().Be(0);
        }

        [Fact]
        public void N_of_4_Has_Two_Solutions()
        {
            // Arrange
            const byte n = 4;
            var solver = new Solver();

            // Act
            var outcome = solver.Solve(n);

            // Assert
            outcome.SolutionFound.Should().BeTrue();
            outcome.Solutions.Count.Should().Be(2);

            var possibleSolution = new Solution.Builder(n)
                .WithQueenAt(0, 1)
                .WithQueenAt(1, 3)
                .WithQueenAt(2, 0)
                .WithQueenAt(3, 2)
                .Build();
            outcome.Solutions.Should().Contain(possibleSolution);

            possibleSolution = new Solution.Builder(n)
                .WithQueenAt(0, 2)
                .WithQueenAt(1, 0)
                .WithQueenAt(2, 3)
                .WithQueenAt(3, 1)
                .Build();
            outcome.Solutions.Should().Contain(possibleSolution);
        }
    }
}