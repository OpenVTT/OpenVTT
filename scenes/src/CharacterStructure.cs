using System.IO;
using Godot;
using Tomlyn;

namespace OpenVTT.Scenes
{
    public class CharacterStructure : WindowDialog
    {
        private void parse()
        {
            string text;
            using (var sr = new StreamReader("./example_campaign/character_sheet.toml"))
            {
                text = sr.ReadToEnd();
            }

            var toml = Toml.Parse(text);
            var parsed = toml.ToModel();
        }
    }
}