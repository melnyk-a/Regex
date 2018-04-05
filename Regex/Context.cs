namespace Regex
{
    internal class Context
    {
        string _context;
        int _currentPosition = 0;

        public Context(string context)
        {
            _context = context;
        }

        public void Advance(int index)
        {
            _currentPosition += index;
        }
        public char GetChar()
        {
            return _context[_currentPosition];
        }
        public int GetCurrentPosition()
        {
            return _currentPosition;
        }
        public bool IsLastPosition()
        {
            return _currentPosition == _context.Length - 1;
        }
    }
}