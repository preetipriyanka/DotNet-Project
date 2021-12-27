using System.Collections.Generic;
using DotNet_Project.Models;

namespace DotNet_Project.services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}