using System.Collections.Generic;
using DotNet_Project.Models;
using System.Linq;

namespace DotNet_Project.services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Sam"},
        };

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id) => characters.FirstOrDefault(c => c.Id == id);
    }
}