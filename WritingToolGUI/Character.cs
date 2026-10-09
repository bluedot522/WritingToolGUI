using System;
using System.Collections.Generic;
using System.Text;

namespace WritingToolGUI
{
    public class Character : Item
    {
        public static List<Character> characterList = new List<Character>();
        public static void AddCharacter(string name, string description, List<string> tags)
        {
            characterList.Add(new Character { Name = name, Description = description, Tags = tags });
        }

        public static void RemoveCharacter(Character character)
        {
            characterList.Remove(character);
        }

        public static void EditCharacter(Character character, string newName, string newDescription, List<string> newTags)
        {
            character.Name = newName;
            character.Description = newDescription;
            character.Tags = newTags;
        }
    }
}
