using System.Collections.Generic;

namespace Regex
{
    internal class NoneOfChars : NonTerminalExp
    {
        public NoneOfChars(List<IExpression> charSet) : base(charSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            bool isMatch = true;

            while (!context.IsLastPosition())
            {
                foreach (var item in _charSet)
                {
                    if (item.IsMatch(context))
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (!isMatch)
                {
                    break;
                }
                else
                {
                    context.Advance(1);
                }
            }
            return isMatch;
        }
    }
}
