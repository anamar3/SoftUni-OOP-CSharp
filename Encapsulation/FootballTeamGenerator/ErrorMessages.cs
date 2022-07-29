using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class ErrorMessages
    {
        public const string NullOrWhiteSpaceException = "A name should not be empty";
        public const string StatsMessage = "{0} should be between 0 and 100.";
        public const string DoesntExist = "Player {0} is not in {1} team.";
    }
}
