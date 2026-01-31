using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private readonly Reference _reference;
        private readonly List<Word> _words;
        private readonly Random _random;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _random = new Random();
            _words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(word => new Word(word))
                        .ToList();
        }

        public void Display()
        {
            Console.WriteLine($"  {_reference}");
            Console.WriteLine("  " + string.Join(" ", _words.Select(w => w.ToString())));
        }

        public void HideRandomWords(int count)
        {
            var visibleWords = _words.Where(w => !w.IsHidden).ToList();

            if (visibleWords.Count == 0)
                return;

            int wordsToHide = Math.Min(count, visibleWords.Count);
            var wordsToHideList = visibleWords.OrderBy(x => _random.Next())
                                            .Take(wordsToHide)
                                            .ToList();

            foreach (var word in wordsToHideList)
            {
                word.Hide();
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden);
        }
    }
}
