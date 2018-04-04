using System.Collections.Generic;

namespace Regex
{
    internal class AnyOneChars : NonTerminalExp
    {
        public AnyOneChars(List<IExpression> charSet) : base(charSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            int countOfMissMatch = 0;

            foreach (var item in _charSet)
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
