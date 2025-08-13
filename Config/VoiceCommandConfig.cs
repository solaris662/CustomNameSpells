using System.Security.Policy;
using BepInEx.Configuration;

namespace CustomNameSpells.Config
{
    public static class VoiceCommandConfig
    {
        public static ConfigEntry<string> bola,fuegoCommand;
        public static ConfigEntry<string> congelaCommand;
        public static ConfigEntry<string> entradaCommand;
        public static ConfigEntry<string> salidaCommand;
        public static ConfigEntry<string> misil,magicoCommand;
        public static ConfigEntry<string> espejitoCommand;
        
        public static ConfigEntry<string> RocaCommand;
        public static ConfigEntry<string> luzCommand;
        public static ConfigEntry<string> laserCommand;
        public static ConfigEntry<string> divinoCommand;
        public static ConfigEntry<string> saltaCommand;
        public static ConfigEntry<string> rayo,truenoCommand;

        public static void Init(ConfigFile config)
        {
            bola,fuegoCommand = config.Bind("Commands", "fuego", "bola", 
                "Command for bola,fuego spell (all variants of the word can be separated by a space)");
                
            congelaCommand = config.Bind("Commands", "congela", "hielo",
                "Command for Frost Bolt spell (all variants of the word can be separated by a space)");
                
            wormCommand = config.Bind("Commands", "entrada", "pueta",
                "Command for Worm spell (all variants of the word can be separated by a space)");
                
            HoleCommand = config.Bind("Commands", "salida", "ventana",
                "Command for Hole spell (all variants of the word can be separated by a space)");
                
            MagicMissileCommand = config.Bind("Commands", "Magico", "magica",
                "Command for Magic Missile spell (all variants of the word can be separated by a space)");
                
            MirrorCommand = config.Bind("Commands", "espejito", "mirror",
                "Command for Mirror spell (all variants of the word can be separated by a space)");
                
            RockCommand = config.Bind("AdditionalCommands", "roca", "tierra",
                "Command for Rock spell (all variants of the word can be separated by a space)");
                
            WispCommand = config.Bind("AdditionalCommands", "luz", "wisp",
                "Command for Wisp spell (all variants of the word can be separated by a space)");
                
            BlastCommand = config.Bind("AdditionalCommands", "laser", "dark blast",
                "Command for Blast spell (all variants of the word can be separated by a space)");
                
            DivineCommand = config.Bind("AdditionalCommands", "divino", "divine light",
                "Command for Divine spell (all variants of the word can be separated by a space)");
                
            BlinkCommand = config.Bind("AdditionalCommands", "saltar", "blink",
                "Command for Blink spell (all variants of the word can be separated by a space)");
                
            ThunderboltCommand = config.Bind("AdditionalCommands", "rayo", "trueno",
                "Command for Thunderbolt spell (all variants of the word can be separated by a space)");
        }
    }
}
