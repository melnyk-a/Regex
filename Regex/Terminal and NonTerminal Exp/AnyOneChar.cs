using System.Collections.Generic;

namespace Regex
{
    internal class AnyOneChar : NonTerminalExp
    {
        public AnyOneChar(List<IExpression> charSet) : base(charSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            int countOfMissMatch = 0;

            foreach (var item in _expressionsSet)
            {
                if (!item.IsMatch(context))
                {
                    countOfMissMatch++;
                }
            }
            return countOfMissMatch == 1;
        }
    }
}
