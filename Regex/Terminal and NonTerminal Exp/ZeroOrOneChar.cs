using System.Collections.Generic;

namespace Regex
{
    internal class ZeroOrOneChar : NonTerminalExp
    {
        public ZeroOrOneChar(List<IExpression> charSet) : base(charSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            int countOfMissMatch = 0;

            foreach (var item in _charSet)
            {
                if (item.IsMatch(context))
                {
                    countOfMissMatch++;
                }
            }
            return (countOfMissMatch == 1 || countOfMissMatch == 0);
        }
    }
}
