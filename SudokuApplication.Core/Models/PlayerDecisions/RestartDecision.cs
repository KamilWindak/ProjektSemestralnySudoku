using System;

using SudokuApplication.Core.Contracts;
using SudokuApplication.Core.Enums;

namespace SudokuApplication.Core.Models.PlayerDecisions
{
    public class RestartDecision : CompletelyChangeGridDecision, IPlayerChoice
    {
        public RestartDecision(SudokuRow[] sudokuGrid) : base(sudokuGrid)
        {
        }

        public PlayerChoiceType PlayerDecisionType
        {
            get
            {
                return PlayerChoiceType.Restart;
            }
        }
    }
}
