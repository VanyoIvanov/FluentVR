using System.Collections.Generic;

public static class NPCTextSuggestions
{
    [System.Serializable]
    public class ConversationStarter
    {
        public string mainText;
        public string translationText;
    }

    [System.Serializable]
    public class Character
    {
        public enum CharacterType
        {
            IsabeldeCastilla,
            B,
            C
        }

        public CharacterType characterType;
        public ConversationStarter[] conversationStarters;
    }

    public static Dictionary<Character.CharacterType, Character> characterDictionary = new Dictionary<Character.CharacterType, Character>
    {
        { Character.CharacterType.IsabeldeCastilla, new Character
            {
                characterType = Character.CharacterType.IsabeldeCastilla,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hola, Majestad. Es un honor hablar con la reina Isabella. ¿Cómo ha sido su día?", translationText = "Здравейте, Ваше Величество. За мен е чест да говоря с кралица Изабела. Как мина денят Ви?" },
                    new ConversationStarter { mainText = "¿Cuál considera que fue su logro más significativo durante su reinado?", translationText = "Кое считате за най-същественото си постижение по време на вашия царски мандат?" },
                    new ConversationStarter { mainText = "¿Cómo tomó decisiones importantes durante su reinado para fortalecer Castilla y León?", translationText = "Как сте вземали важни решения по време на вашето управление, за да укрепите Кастилия и Леон?" },
                    new ConversationStarter { mainText = "¿Cuál era su visión para el futuro de España bajo su liderazgo?", translationText = "Каква беше вашата визия за бъдещето на Испания под вашето ръководство?" },
                    new ConversationStarter { mainText = "¿Cómo equilibró la administración del reino y sus deberes familiares como reina?", translationText = "Как сте балансирали управлението на царството и семейните си задължения като кралица?" },
                    new ConversationStarter { mainText = "¿Cómo enfrentó los desafíos políticos y sociales de su tiempo?", translationText = "Как сте се справяли с политическите и социални предизвикателства на вашето време?" },
                    new ConversationStarter { mainText = "¿Cómo ve el papel de las mujeres en la política y el liderazgo hoy en día?", translationText = "Как виждате ролята на жените в политиката и лидерството днес?" },
                    new ConversationStarter { mainText = "¿Tiene algún consejo para líderes actuales basado en sus experiencias como reina?", translationText = "Имате ли някакъв съвет за настоящите лидери, базиран на вашите опити като кралица?" },
                }
            }
        },
        { Character.CharacterType.B, new Character
            {
                characterType = Character.CharacterType.B,
                conversationStarters = new ConversationStarter[]
                {
                    // new ConversationStarter { mainText = "", translationText = "" },
                }
            }
        },
        { Character.CharacterType.C, new Character
            {
                characterType = Character.CharacterType.C,
                conversationStarters = new ConversationStarter[]
                {
                    // new ConversationStarter { mainText = "", translationText = "" },
                }
            }
        }
        // Add more characters as needed
    };
}
