﻿using System.Collections.Generic;

namespace Regex
{
    internal class AnyOfChars : NonTerminalExp
    {
        public AnyOfChars(List<IExpression> charSet) : base(charSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            bool isMatch = false;

            while (!context.IsLastPosition())
            {
                foreach (var item in _charSet)
                {
                    if (item.IsMatch(context))
                    {
                        isMatch = true;
                        break;
                    }
                }
                if (isMatch)
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