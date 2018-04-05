using System.Collections.Generic;

namespace Regex
{
    internal class AnyOneChar : NonTerminalExp
    {
        public AnyOneChar(List<IExpression> expressionsSet) : base(expressionsSet)
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
                if (CanAdvance(context))
                {
                    context.Advance(1);
                }
                else
                {
                    if (_expressionsSet[_expressionsSet.Count - 1] != item)
                        countOfMissMatch++;
                }
            }
            return countOfMissMatch == 1;
        }
    }
}
