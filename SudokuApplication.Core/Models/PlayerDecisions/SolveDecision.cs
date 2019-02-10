using System;

using SudokuApplication.Core.Contracts;
using SudokuApplication.Core.Enums;

namespace SudokuApplication.Core.Models.PlayerDecisions
{
    public class SolveDecision : CompletelyChangeGridDecision, IPlayerChoice
    {
        public SolveDecision(SudokuRow[] sudokuGrid) : base(sudokuGrid)
        {
        }

        public PlayerChoiceType PlayerDecisionType
        {
            get
            {
                return PlayerChoiceType.Solve;
            }
        }
    }
}
