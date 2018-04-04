namespace Regex
{
    internal class CharTerminalExpression : IExpression
    {
        private char _terminalChar;
        public CharTerminalExpression(char terminalChar)
        {
            _terminalChar = terminalChar;
        }
        public bool IsMatch(Context context)
        {
            bool isMatch = context.GetChar() == _terminalChar;
            return isMatch;
        }
    }
}
