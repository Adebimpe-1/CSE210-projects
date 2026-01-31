namespace ScriptureMemorizer
{
    public class Word
    {
        private readonly string _originalText;
        private bool _isHidden;

        public Word(string text)
        {
            _originalText = text.Trim().ToLower();
            _isHidden = false;
        }

        public bool IsHidden => _isHidden;

        public void Hide()
        {
            _isHidden = true;
        }

        public string GetDisplayText()
        {
            if (_isHidden)
            {
                return new string('_', _originalText.Length);
            }
            return _originalText;
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }
}
