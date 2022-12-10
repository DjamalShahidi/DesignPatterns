using System.Collections.Generic;
using System.Security.Cryptography;
namespace Flyweight
{
    public interface ICharacter
    {
        void Draw(string fontFamily, int fontSize);
    }

    public class CharacterA : ICharacter
    {
        private char _actualCharacter = 'a';
        private string _fontFamily = string.Empty;
        private int _fontSize;

        public void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Console.WriteLine($"Drawing {_actualCharacter},{_fontFamily},{_fontSize}");
        }
    }
    public class CharacterB : ICharacter
    {
        private char _actualCharacter = 'b';
        private string _fontFamily = string.Empty;
        private int _fontSize;

        public void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Console.WriteLine($"Drawing {_actualCharacter},{_fontFamily},{_fontSize}");
        }
    }

    public class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characters = new();

        public ICharacter? GetCharacter(char characterIdentifier)
        {

            if (_characters.ContainsKey(characterIdentifier))
            {
                Console.WriteLine("Character reuse");
                return _characters[characterIdentifier];
            }

            Console.WriteLine("Character construction");

            switch (characterIdentifier)
            {
                case 'a':
                    _characters[characterIdentifier] = new CharacterA();
                    return _characters[characterIdentifier];
                case 'b':
                    _characters[characterIdentifier] = new CharacterB();
                    return _characters[characterIdentifier];
                default:
                    return null;
            }

            return null;
        }
    }
}