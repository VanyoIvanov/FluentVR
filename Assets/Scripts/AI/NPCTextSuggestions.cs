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
            FranciscoPizarro,
            HernanCortes,
            FerdinandMagellan,
            ChristopherColumbus,
            WilliamShakespeare,
            EleonorRoosevelt,
            WinstonChurchill,
            QueenVictoria,
            FlorenceNightingale,
            ThomasEdison,
            German,
            Italian,
            Chinese,
            Greek,
            Turkish,
            French,
            Russian
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
        { Character.CharacterType.FranciscoPizarro, new Character
            {
                characterType = Character.CharacterType.FranciscoPizarro,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hola, señor Pizarro. Es un honor hablar con usted. ¿Cómo fue su experiencia en la conquista del Imperio Inca?", translationText = "Здравейте, господин Писаро. Чест е да разговарям с вас. Как беше вашето изживяване при завоеванието на инките?" },
                    new ConversationStarter { mainText = "¿Cuál considera que fue el momento más crucial en la caída del imperio Inca?", translationText = "Кое считате за най-съдбовния момент при падането на инките?" },
                    new ConversationStarter { mainText = "¿Cómo manejó los desafíos y las dificultades durante la expedición a Perú?", translationText = "Как се справихте с предизвикателствата и трудностите по време на експедицията в Перу?" },
                    new ConversationStarter { mainText = "¿Cuál fue su visión para la colonización y el establecimiento de Lima?", translationText = "Каква беше вашата визия за колонизацията и установяването на Лима?" },
                    new ConversationStarter { mainText = "¿Cómo describiría sus relaciones con los líderes indígenas durante la conquista?", translationText = "Как бихте описали вашите отношения с индианските лидери по време на завоеванието?" },
                    new ConversationStarter { mainText = "¿Qué le motivó a emprender la expedición a través de América del Sur?", translationText = "Какво ви мотивира да започнете експедицията през Южна Америка?" },
                    new ConversationStarter { mainText = "¿Cómo enfrentó los desafíos políticos y las tensiones internas entre los conquistadores?", translationText = "Как сте се справили с политическите предизвикателства и вътрешните напрежения между завоевателите?" },
                    new ConversationStarter { mainText = "¿Tiene algún consejo para aquellos interesados en la exploración y la conquista?", translationText = "Имате ли някакви съвети за тези, които са заинтересовани от изследванията и завоеванията?" },
                    new ConversationStarter { mainText = "¿Cómo veía su papel en la historia de España y la exploración del Nuevo Mundo?", translationText = "Как виждахте вашата роля в историята на Испания и изследването на Новия свят?" },
                    new ConversationStarter { mainText = "¿Cuál fue el mayor desafío que enfrentó en la creación y consolidación del Virreinato del Perú?", translationText = "Какво беше най-голямото предизвикателство, пред което сте се изправили при създаването и укрепването на Вицеройството на Перу?" },
                }
            }
        },
        { Character.CharacterType.HernanCortes, new Character
            {
                characterType = Character.CharacterType.HernanCortes,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hola, Hernán Cortés. Es un honor hablar con usted. ¿Cómo fue su experiencia durante la conquista de México?", translationText = "Здравейте, Ернан Кортес. Чест е да разговарям с вас. Как беше вашето изживяване по време на завоеванието на Мексико?" },
                    new ConversationStarter { mainText = "¿Cuál considera que fue el momento más desafiante durante la caída de Tenochtitlán?", translationText = "Кое считате за най-трудния момент по време на падането на Теночтитлан?" },
                    new ConversationStarter { mainText = "¿Cómo manejó las complejidades y los retos durante su expedición en tierras aztecas?", translationText = "Как се справихте със сложностите и предизвикателствата по време на вашата експедиция в ацтекските земи?" },
                    new ConversationStarter { mainText = "¿Cuál fue su visión para la fundación de Veracruz y el avance hacia el interior de México?", translationText = "Каква беше вашата визия за основаването на Веракрус и проникването във вътрешността на Мексико?" },
                    new ConversationStarter { mainText = "¿Cómo describiría sus relaciones con Moctezuma y otros líderes indígenas durante la conquista?", translationText = "Как бихте описали вашите отношения с Моктесума и другите индиански лидери по време на завоеванието?" },
                    new ConversationStarter { mainText = "¿Qué le motivó a explorar y conquistar nuevas tierras en el nombre de España?", translationText = "Какво ви мотивира да изследвате и завоювате нови земи в името на Испания?" },
                    new ConversationStarter { mainText = "¿Cómo abordó las tensiones internas y los desafíos políticos entre los conquistadores?", translationText = "Как сте се справили с вътрешните напрежения и политическите предизвикателства между завоевателите?" },
                    new ConversationStarter { mainText = "¿Tiene algún consejo para aquellos interesados en la exploración y la conquista?", translationText = "Имате ли някакви съвети за тези, които са заинтересовани от изследванията и завоеванията?" },
                    new ConversationStarter { mainText = "¿Cómo veía su papel en la historia de España y el descubrimiento del Nuevo Mundo?", translationText = "Как виждахте вашата роля в историята на Испания и откриването на Новия свят?" },
                    new ConversationStarter { mainText = "¿Cuál fue el mayor desafío que enfrentó en la creación y consolidación de la Nueva España?", translationText = "Какво беше най-голямото предизвикателство, пред което сте се изправили при създаването и укрепването на Нова Испания?" },
                }
            }
        },
        { Character.CharacterType.FerdinandMagellan, new Character
            {
                characterType = Character.CharacterType.FerdinandMagellan,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hola, Fernando Magallanes. Es un honor hablar contigo. ¿Cómo fue tu famosa expedición para circumnavegar el mundo?", translationText = "Здравейте, Фернандо Магелан. Чест е да разговарям с вас. Как беше вашата известна експедиция за обикаляне на света?" },
                    new ConversationStarter { mainText = "¿Cuál considera que fue el momento más desafiante durante la travesía por el Estrecho de Magallanes?", translationText = "Кое считате за най-трудния момент по време на прехода през Магелановия проток?" },
                    new ConversationStarter { mainText = "¿Cómo manejó los desafíos y las dificultades durante la expedición que condujo a la primera vuelta al mundo?", translationText = "Как се справихте с предизвикателствата и трудностите по време на експедицията, която доведе до първото обикаляне на света?" },
                    new ConversationStarter { mainText = "¿Cuál fue tu visión para encontrar una ruta occidental hacia las islas de las especias?", translationText = "Каква беше вашата визия за намиране на западен маршрут към островите на подправките?" },
                    new ConversationStarter { mainText = "¿Cómo describirías tu relación con los marineros y tripulación durante la travesía?", translationText = "Как бихте описали вашите отношения с моряците и екипажа по време на пътешествието?" },
                    new ConversationStarter { mainText = "¿Qué te inspiró a emprender una expedición tan ambiciosa en nombre de España?", translationText = "Какво ви вдъхнови да предприемете такава амбициозна експедиция в името на Испания?" },
                    new ConversationStarter { mainText = "¿Cómo abordaste los desafíos de la navegación y la cartografía en aquella época?", translationText = "Как се справихте с предизвикателствата на навигацията и картографията през това време?" },
                    new ConversationStarter { mainText = "¿Tienes algún consejo para aquellos interesados en la exploración y la navegación?", translationText = "Имате ли някакви съвети за тези, които са заинтересовани от изследванията и навигацията?" },
                    new ConversationStarter { mainText = "¿Cómo crees que tu expedición influyó en la comprensión del mundo en ese momento?", translationText = "Как смятате, че вашата експедиция повлия на разбирането за света през този период?" },
                    new ConversationStarter { mainText = "¿Cuál fue el mayor desafío que enfrentaste durante la circumnavegación y cómo lo superaste?", translationText = "Кое беше най-голямото предизвикателство, пред което се изправихте по време на обикалянето и как го преодоляхте?" },
                }
            }
        },
        { Character.CharacterType.ChristopherColumbus, new Character
            {
                characterType = Character.CharacterType.ChristopherColumbus,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hola, Cristóbal Colón. Es un honor hablar contigo. ¿Cómo fue tu famoso viaje hacia el Nuevo Mundo?", translationText = "Здравейте, Кристофър Колумб. Чест е да разговарям с вас. Как беше вашият известен път към Новия свят?" },
                    new ConversationStarter { mainText = "¿Cuál considera que fue el momento más emocionante durante tu travesía por el océano Atlántico?", translationText = "Кое считате за най-вълнуващия момент по време на пътуването ви през Атлантическия океан?" },
                    new ConversationStarter { mainText = "¿Cómo manejaste los desafíos y las incertidumbres durante tu expedición hacia el oeste?", translationText = "Как се справихте с предизвикателствата и несигурностите по време на вашата експедиция към запад?" },
                    new ConversationStarter { mainText = "¿Cuál era tu visión para encontrar una ruta occidental hacia Asia y las especias?", translationText = "Каква беше вашата визия за намиране на западен маршрут към Азия и подправките?" },
                    new ConversationStarter { mainText = "¿Cómo describirías tus interacciones con los miembros de la tripulación y los nativos que encontraste?", translationText = "Как бихте описали взаимодействията си с членовете на екипажа и местните жители, които срещнахте?" },
                    new ConversationStarter { mainText = "¿Qué te motivó a emprender un viaje tan arriesgado en nombre de los Reyes Católicos de España?", translationText = "Какво ви мотивира да предприемете толкова рисково пътуване в името на Католическите крале на Испания?" },
                    new ConversationStarter { mainText = "¿Cómo afrontaste las críticas y desafíos que enfrentaste después de tu primer viaje?", translationText = "Как се справихте с критиките и предизвикателствата, които изпитахте след първото си пътуване?" },
                    new ConversationStarter { mainText = "¿Tienes algún consejo para aquellos interesados en la exploración y el descubrimiento?", translationText = "Имате ли някакви съвети за тези, които са заинтересовани от изследванията и откриванията?" },
                    new ConversationStarter { mainText = "¿Cómo crees que tus viajes influyeron en la comprensión del mundo en ese momento?", translationText = "Как смятате, че вашите пътешествия повлияха на разбирането за света през този период?" },
                    new ConversationStarter { mainText = "¿Cuál fue el mayor desafío que enfrentaste durante tus expediciones y cómo lo superaste?", translationText = "Кое беше най-голямото предизвикателство, пред което се изправихте по време на вашите експедиции и как го преодоляхте?" },
                }
            }
        },
        { Character.CharacterType.WilliamShakespeare, new Character
            {
                characterType = Character.CharacterType.WilliamShakespeare,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hello, Mr. Shakespeare. It's an honor to speak with you. How do you think your works have influenced literature throughout the centuries?", translationText = "Здравейте, г-н Шекспир. Чест е да разговарям с вас. Как смятате, че вашите произведения са влияли на литературата през вековете?" },
                    new ConversationStarter { mainText = "What inspired you to become a playwright, and how did you find inspiration for your iconic characters?", translationText = "Какво ви вдъхнови да станете драматург и как намирахте вдъхновение за вашия иконичен герои?" },
                    new ConversationStarter { mainText = "How did the political and social context of your time influence your writing, especially in plays like \"Macbeth\" or \"Hamlet\"?", translationText = "Как политическият и социалният контекст на вашето време влияеше на вашето писане, особено в пиеси като \"Макбет\" или \"Хамлет\"?" },
                    new ConversationStarter { mainText = "Your sonnets are renowned for their poetic beauty. What emotions or experiences inspired your sonnet writing?", translationText = "Вашите сонети са известни с поетичната си красота. Какви чувства или преживявания ви вдъхновиха за писането на сонети?" },
                    new ConversationStarter { mainText = "Is there a particular play or character that holds a special place in your heart, and if so, why?", translationText = "Има ли определена пиеса или герой, който заема специално място във вашия сърце, и ако да, защо?" },
                    new ConversationStarter { mainText = "How did you navigate the challenges and successes of being a playwright in Elizabethan England?", translationText = "Как се справихте с предизвикателствата и успехите да бъдете драматург в Елизабетанска Англия?" },
                    new ConversationStarter { mainText = "If you could give advice to aspiring writers today, what would it be based on your own experiences?", translationText = "Ако можехте да дадете съвет на бъдещи писатели днес, какъв би бил, базиран на вашите собствени преживявания?" },
                    new ConversationStarter { mainText = "Your works have been translated into numerous languages. How do you feel about the global impact of your writing?", translationText = "Вашите произведения са преведени на много езици. Как се чувствате по отношение на глобалния влияние на вашето писане?" },
                    new ConversationStarter { mainText = "What role did love and relationships play in inspiring your romantic works, such as \"Romeo and Juliet\"?", translationText = "Каква роля играят любовта и взаимоотношенията във вдъхновяването на вашите романтични произведения, като \"Ромео и Жулиета\"?" },
                    new ConversationStarter { mainText = "Your legacy has endured for centuries. How do you perceive the immortality of your literary contributions?", translationText = "Вашият наследник продължава векове. Как възприемате безсмъртието на вашите литературни приноси?" },
                }
            }
        },
        { Character.CharacterType.EleonorRoosevelt, new Character
            {
                characterType = Character.CharacterType.EleonorRoosevelt,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hello, Mrs. Roosevelt. It's an honor to speak with you. How did your experiences shape your advocacy for human rights?", translationText = "Здравейте, г-жо Рузвелт. Чест е да разговарям с вас. Как вашите преживявания формираха вашата защита на правата на човека?" },
                    new ConversationStarter { mainText = "You were a strong advocate for civil rights. What motivated you to take a stand, and how do you think your efforts influenced the civil rights movement?", translationText = "Вие бяхте силен защитник на гражданските права. Какво ви мотивира да заемете позиция и как мислите, че вашите усилия повлияха на движението за граждански права?" },
                    new ConversationStarter { mainText = "Your role as the First Lady was unconventional for its time. How did you use your position to address social issues and promote change?", translationText = "Вашата роля като Първа дама беше необичайна за това време. Как използвахте вашата позиция, за да се занимавате с обществени проблеми и насърчавате промени?" },
                    new ConversationStarter { mainText = "You were instrumental in the drafting of the Universal Declaration of Human Rights. What drove you to undertake such a significant initiative?", translationText = "Бяхте ключова при съставянето на Универсалната декларация за правата на човека. Какво ви побуди да предприемете толкова значима инициатива?" },
                    new ConversationStarter { mainText = "Your \"My Day\" column allowed you to connect with the public. How did you see the role of media in shaping public opinion during your time?", translationText = "Колоната ви \"Моят ден\" ви позволяваше да взаимодействате с обществото. Как виждахте ролята на медиите в формирането на общественото мнение във ваше време?" },
                    new ConversationStarter { mainText = "As a diplomat and activist, how did you navigate the challenges of promoting peace and human rights on the international stage?", translationText = "Като дипломат и активист, как се справяхте с предизвикателствата при насърчаването на мир и права на човека на международната сцена?" },
                    new ConversationStarter { mainText = "Your commitment to education was notable. How do you believe education contributes to social progress and equality?", translationText = "Вашето ангажиране с образованието беше забележително. Как смятате, че образованието допринася за социалния напредък и равенство?" },
                    new ConversationStarter { mainText = "If you could give advice to young women today, based on your own experiences, what would it be?", translationText = "Ако можехте да дадете съвет на младите жени днес, базиран на вашите собствени преживявания, какъв би бил този съвет?" },
                    new ConversationStarter { mainText = "You were involved in various humanitarian efforts. Which of your initiatives are you most proud of, and why?", translationText = "Участвахте в различни хуманитарни усилия. За коя от вашите инициативи сте най-горди и защо?" },
                    new ConversationStarter { mainText = "How do you see the role of women in leadership evolving, and what challenges do you think still need to be addressed?", translationText = "Как виждате развитието на ролята на жените в лидерството и какви предизвикателства смятате, че все още трябва да бъдат решени?" },
                }
            }
        },
        { Character.CharacterType.WinstonChurchill, new Character
            {
                characterType = Character.CharacterType.WinstonChurchill,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hello, Sir Winston Churchill. It's an honor to speak with you. How did your experiences shape your leadership during World War II?", translationText = "Здравейте, сър Уинстън Чърчил. Чест е да разговарям с вас. Как вашите преживявания формираха вашето лидерство по време на Втората световна война?" },
                    new ConversationStarter { mainText = "Your speeches are iconic. What motivated the powerful rhetoric you used during critical moments of the war?", translationText = "Вашите речи са иконични. Какво ви мотивира да използвате силната реторика по време на критичните моменти на войната?" },
                    new ConversationStarter { mainText = "As Prime Minister, how did you navigate the challenges of leading a nation through such a tumultuous time?", translationText = "Като премиер, как се справихте с предизвикателствата на ръководенето на нацията през такъв бурен период?" },
                    new ConversationStarter { mainText = "Your famous quote is \"We shall never surrender.\" What message did you intend to convey with these words?", translationText = "Вашата известна цитат е \"Никога няма да се предадем\". Какво послание искахте да предадете с тези думи?" },
                    new ConversationStarter { mainText = "How did your partnership with other world leaders, such as Roosevelt and Stalin, shape the course of history during and after the war?", translationText = "Как вашето партньорство с други световни лидери, като Рузвелт и Сталин, формираше хода на историята по време и след войната?" },
                    new ConversationStarter { mainText = "You were known for your resilience. How did you maintain morale and determination during challenging times?", translationText = "Бяхте известни с устойчивостта си. Как поддържахте боен дух и решителност по време на трудни периоди?" },
                    new ConversationStarter { mainText = "Your legacy extends beyond the war. What do you believe is your most significant contribution to history?", translationText = "Вашето наследство продължава и след войната. Какво смятате, че е вашият най-значителен принос към историята?" },
                    new ConversationStarter { mainText = "If you could offer advice to leaders facing challenges today, what would it be based on your experiences?", translationText = "Ако можете да дадете съвет на лидери, които се сблъскват с предизвикателства днес, какъв би бил, базиран на вашите преживявания?" },
                    new ConversationStarter { mainText = "Your paintings are renowned. How did your artistic pursuits contribute to your life, especially during moments of reflection?", translationText = "Вашите картини са известни. Как вашият художествен път допринесе за вашия живот, особено по време на моменти на размисъл?" },
                    new ConversationStarter { mainText = "How do you think your leadership style would adapt to the challenges and complexities of the modern world?", translationText = "Как смятате, че вашето стил на лидерство би се адаптирал към предизвикателствата и сложностите на съвременния свят?" },
                }
            }
        },
        { Character.CharacterType.QueenVictoria, new Character
            {
                characterType = Character.CharacterType.QueenVictoria,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hello, Your Majesty. It's an honor to speak with you. How did your long reign shape the Victorian era and the British Empire?", translationText = "Здравейте, Ваше Величество. Чест е да разговарям с вас. Как вашето дълго управление формира епохата на Викторианска Англия и Британската империя?" },
                    new ConversationStarter { mainText = "As the \"Grandmother of Europe,\" how did your family ties influence European politics and diplomacy during your reign?", translationText = "Като \"Баба на Европа\", как вашият семеен облик влияеше на европейската политика и дипломация по време на вашето управление?" },
                    new ConversationStarter { mainText = "Your marriage to Prince Albert was a great love story. How did this partnership shape your role as a monarch and your contributions to society?", translationText = "Вашето бракосочетание с Принц Албърт беше велика любовна история. Как този партньорски съюз формира вашата роля като монарх и вашият принос към обществото?" },
                    new ConversationStarter { mainText = "During your reign, the Industrial Revolution transformed society. How did you perceive these changes, and what were your views on social issues of the time?", translationText = "През вашето управление, Промишлената революция трансформира обществото. Как сте възприемали тези промени и какви бяха вашите виждания по социалните въпроси на това време?" },
                    new ConversationStarter { mainText = "You had a keen interest in cultural and artistic developments. Which aspects of the arts were most significant to you, and why?", translationText = "Имахте голям интерес към културното и художествено развитие. Кои аспекти на изкуствата бяха най-значими за вас и защо?" },
                    new ConversationStarter { mainText = "The British Empire expanded significantly during your reign. How did you approach the challenges and responsibilities of imperial rule?", translationText = "Британската империя се разшири значително по време на вашето управление. Как се отнасяхте към предизвикателствата и отговорностите на имперското управление?" },
                    new ConversationStarter { mainText = "Your mourning for Prince Albert was well-known. How did personal grief impact your role as a queen and your interactions with the public?", translationText = "Траурът ви за Принц Албърт беше добре известен. Как личната тъга влияеше на вашата роля като кралица и на взаимодействията ви с обществото?" },
                    new ConversationStarter { mainText = "You played a pivotal role in the abolition of slavery. What motivated you to support this cause, and how did you navigate the political landscape of the time?", translationText = "Играехте ключова роля в аболицията на робството. Какво ви мотивира да подкрепите този кауз и как се справихте с политическата обстановка на това време?" },
                    new ConversationStarter { mainText = "Your journals and letters provide insight into your thoughts. What aspect of your personal writings do you believe reflects your truest self?", translationText = "Вашите дневници и писма предоставят изглед върху вашите мисли. Кой аспект на вашите лични записи смятате, че отразява истинската ви същност?" },
                    new ConversationStarter { mainText = "How do you think your legacy as Queen Victoria has influenced the role of the monarchy in modern times?", translationText = "Как смятате, че вашият наследник като кралица Виктория е влиял на ролята на монархията в съвременните времена?" },
                }
            }
        },
        { Character.CharacterType.FlorenceNightingale, new Character
            {
                characterType = Character.CharacterType.FlorenceNightingale,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hello, Miss Nightingale. It's an honor to speak with you. How did your experiences in nursing shape your commitment to healthcare reform?", translationText = "Здравейте, г-ца Найтингейл. Чест е да разговарям с вас. Как вашите преживявания в медицинската сестринска практика формираха вашето ангажимент към реформите в здравеопазването?" },
                    new ConversationStarter { mainText = "Your work during the Crimean War is well-known. How did the conditions at the military hospitals influence your approach to nursing and public health?", translationText = "Вашата работа по време на Кримската война е добре известна. Как условията в военните болници влияха на вашия подход към медицинската сестринска практика и общественото здраве?" },
                    new ConversationStarter { mainText = "You were a pioneer in statistical analysis in healthcare. How did you use data to advocate for improvements in sanitation and patient care?", translationText = "Бяхте пионер в статистическия анализ в здравеопазването. Как използвахте данни, за да пропагандирате за подобрения в санитацията и грижата за пациентите?" },
                    new ConversationStarter { mainText = "Your efforts transformed nursing into a respected profession. How did you overcome the societal norms of your time to achieve this change?", translationText = "Вашите усилия превърнаха медицинската сестринска практика в уважавана професия. Как преодоляхте обществените норми на вашето време, за да постигнете това промяна?" },
                    new ConversationStarter { mainText = "You were known for your advocacy for proper nutrition in healthcare. How did your views on nutrition contribute to advancements in patient well-being?", translationText = "Бяхте известни с пропагандата си за правилното хранене в здравеопазването. Как вижданията ви за храненето допринесоха за напредъка в благосъстоянието на пациентите?" },
                    new ConversationStarter { mainText = "Your work laid the foundation for modern nursing education. How did you envision the role of education in improving healthcare outcomes?", translationText = "Вашата работа заложи основата за съвременното образование в медицинската сестринска практика. Как виждахте ролята на образованието в подобряването на резултатите в здравеопазването?" },
                    new ConversationStarter { mainText = "The Nightingale Pledge is still used today. What inspired you to create this oath, and how do you think it impacts nursing ethics?", translationText = "Обетът на Найтингейл все още се използва днес. Какво ви вдъхнови да създадете този обет и как смятате, че той влияе на етиката в медицинската сестринска практика?" },
                    new ConversationStarter { mainText = "Your work in healthcare reform extended to military and civilian contexts. How did you balance these responsibilities, and what challenges did you face?", translationText = "Вашата работа в реформите в здравеопазването се разпространи във военния и гражданския контекст. Как уравновесявахте тези отговорности и с какви предизвикателства се сблъскавахте?" },
                    new ConversationStarter { mainText = "Your dedication to patient care extended beyond physical health. How did you address mental health in your approach to nursing?", translationText = "Вашият ангажимент към грижата за пациентите се разпространи и върху психичното здраве. Как се справяхте с психичното здраве във вашето подход към медицинската сестринска практика?" },
                    new ConversationStarter { mainText = "Your legacy in healthcare is profound. How do you hope to be remembered, and what lessons do you believe can still be learned from your work?", translationText = "Вашето наследство в здравеопазването е дълбоко. Как се надявате да бъдете помнена и какви уроци вярвате, че все още могат да бъдат научени от вашата работа?" },
                }
            }
        },
        { Character.CharacterType.ThomasEdison, new Character
            {
                characterType = Character.CharacterType.ThomasEdison,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hello, Mr. Edison. It's an honor to speak with you. Your inventions transformed the world. What inspired you to become an inventor?", translationText = "Здравейте, г-н Едисън. Чест е да разговарям с вас. Вашите изобретения трансформираха света. Какво ви вдъхнови да станете изобретател?" },
                    new ConversationStarter { mainText = "The invention of the light bulb is iconic. Can you share the story behind its creation and the challenges you faced during the process?", translationText = "Изобретението на крушката е иконично. Можете ли да споделите историята зад нейното създаване и предизвикателствата, пред които се изправихте по време на процеса?" },
                    new ConversationStarter { mainText = "Your work in the development of the phonograph and motion pictures was groundbreaking. How did you envision these inventions shaping entertainment and communication?", translationText = "Вашият труд в развитието на фонографа и киното беше революционен. Как виждахте тези изобретения да формират забавлението и комуникацията?" },
                    new ConversationStarter { mainText = "You held over a thousand patents. Is there a particular invention that you are most proud of, and why?", translationText = "Притежавате над хиляда патента. Има ли конкретно изобретение, на което сте най-горди, и защо?" },
                    new ConversationStarter { mainText = "Your research on direct current (DC) and alternating current (AC) had a significant impact on electrical systems. How did you approach these experiments, and what did you learn from them?", translationText = "Вашите изследвания върху постоянния ток (DC) и сменния ток (AC) имаха значително влияние върху електрическите системи. Как подходихте към тези експерименти и какво научихте от тях?" },
                    new ConversationStarter { mainText = "You were a proponent of the idea that \"Genius is one percent inspiration, ninety-nine percent perspiration.\" How did hard work and determination play a role in your success?", translationText = "Бяхте привърженик на идеята, че \"Геният е един процент вдъхновение, деветдесет и девет процента пот.\" Как роля играха усърдието и решимостта във вашия успех?" },
                    new ConversationStarter { mainText = "Your invention of the electric power distribution system revolutionized the way we use electricity. What challenges did you face in implementing this system, and how did it change society?", translationText = "Вашето изобретение на системата за разпределение на електроенергия революционизира начина, по който използваме електричество. С какви предизвикателства се сблъскахте при въвеждането на тази система и как тя промени обществото?" },
                    new ConversationStarter { mainText = "Your famous quote is \"I have not failed. I've just found 10,000 ways that won't work.\" How did you maintain such perseverance in the face of setbacks?", translationText = "Вашият известен цитат е \"Не съм се провалил. Просто съм открил 10 000 начина, които не работят.\" Как поддържахте толкова устойчивост пред предизвикателствата?" },
                    new ConversationStarter { mainText = "Your contributions to the development of the modern research and development laboratory are notable. How did you approach innovation and experimentation in your labs?", translationText = "Вашият принос към развитието на модерната лаборатория за научни изследвания и развитие е забележителен. Как подходихте към иновациите и експериментите във вашите лаборатории?" },
                    new ConversationStarter { mainText = "If you could give advice to aspiring inventors today, what would it be based on your own experiences?", translationText = "Ако можехте да дадете съвет на младите изобретатели днес, какъв би бил този съвет, базиран на вашите собствени преживявания?" },
                }
            }
        },
        { Character.CharacterType.German, new Character
            {
                characterType = Character.CharacterType.German,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Hallo, Heinrich! Wie geht es dir? Was hast du heute gemacht?", translationText = "Здравей, Хайнрих! Как си? Какво прави днес?" },
                    new ConversationStarter { mainText = "Hey Heinrich, wie war dein Wochenende? Hast du etwas Besonderes unternommen?", translationText = "Здравей, Хайнрих! Как беше уикенда ти? Направил ли си нещо специално?" },
                    new ConversationStarter { mainText = "Hallo Heinrich, ich habe gehört, dass du ein großer Fußballfan bist. Welches Team unterstützt du?", translationText = "Здравей, Хайнрих! Чух, че си голям фен на футбола. Кое е отбора, който подкрепяш?" },
                    new ConversationStarter { mainText = "Heinrich, ich habe gehört, dass du gerne reist. Welches war dein Lieblingsreiseziel bisher?", translationText = "Хайнрих, чух, че обичаш да пътуваш. Кои е бил твоето любимо местоназначение до момента?" },
                    new ConversationStarter { mainText = "Hallo Heinrich, was machst du beruflich? Bist du zufrieden mit deinem Job?", translationText = "Здравей, Хайнрих! Каква е професията ти? Доволен ли си от работата си?" },
                    new ConversationStarter { mainText = "Hey Heinrich, ich habe gehört, du spielst gerne Gitarre. Seit wann spielst du schon?", translationText = "Хей, Хайнрих! Чух, че обичаш да свириш на китара. От какво време свириш?" },
                    new ConversationStarter { mainText = "Hallo Heinrich, was machst du gerne in deiner Freizeit? Hast du besondere Hobbys?", translationText = "Здравей, Хайнрих! Какво обичаш да правиш в свободното си време? Имаш ли специални хобита?" },
                    new ConversationStarter { mainText = "Heinrich, ich habe gehört, dass du gerne kochst. Was ist dein Lieblingsgericht, das du zubereitest?", translationText = "Хайнрих, чух, че обичаш да готвиш. Кое е твоето любимо ястие, което приготвяш?" },
                    new ConversationStarter { mainText = "Hallo Heinrich, ich sehe, dass du gerne liest. Welches Buch liest du gerade?", translationText = "Здравей, Хайнрих! Виждам, че обичаш да четеш. Коя книга четеш в момента?" },
                    new ConversationStarter { mainText = "Heinrich, ich habe gehört, dass du gerne wandern gehst. Was ist dein Lieblingswanderweg?", translationText = "Хайнрих, чух, че обичаш да ходиш на разходки. Кои е твоят любим маршрут за разходка?" },
                }
            }
        },
        { Character.CharacterType.Italian, new Character
            {   
                characterType = Character.CharacterType.Italian,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Ciao Lorenzo! Come va? Cosa hai fatto oggi?", translationText = "Здравей, Лоренцо! Как си? Какво прави днес?" },
                    new ConversationStarter { mainText = "Ehi Lorenzo, com'è stato il tuo fine settimana? Hai fatto qualcosa di speciale?", translationText = "Здравей, Лоренцо! Как беше уикенда ти? Направил ли си нещо специално?" },
                    new ConversationStarter { mainText = "Ciao Lorenzo, ho sentito che sei un grande appassionato di calcio. Quale squadra tifi?", translationText = "Здравей, Лоренцо! Чух, че си голям фен на футбола. Кое е отбора, който подкрепяш?" },
                    new ConversationStarter { mainText = "Lorenzo, ho sentito che ami viaggiare. Qual è stata la tua destinazione preferita finora?", translationText = "Лоренцо, чух, че обичаш да пътуваш. Кои е бил твоето любимо местоназначение до момента?" },
                    new ConversationStarter { mainText = "Ciao Lorenzo, che lavoro fai? Sei soddisfatto del tuo lavoro?", translationText = "Здравей, Лоренцо! Каква е професията ти? Доволен ли си от работата си?" },
                    new ConversationStarter { mainText = "Ehi Lorenzo, ho sentito che ti piace suonare la chitarra. Da quanto tempo suoni?", translationText = "Хей, Лоренцо! Чух, че обичаш да свириш на китара. От какво време свириш?" },
                    new ConversationStarter { mainText = "Ciao Lorenzo, cosa ti piace fare nel tempo libero? Hai qualche hobby particolare?", translationText = "Здравей, Лоренцо! Какво обичаш да правиш в свободното си време? Имаш ли специални хобита?" },
                    new ConversationStarter { mainText = "Lorenzo, ho sentito che ti piace cucinare. Qual è il tuo piatto preferito che prepari?", translationText = "Лоренцо, чух, че обичаш да готвиш. Кое е твоето любимо ястие, което приготвяш?" },
                    new ConversationStarter { mainText = "Ciao Lorenzo, vedo che ti piace leggere. Quale libro stai leggendo in questo momento?", translationText = "Здравей, Лоренцо! Виждам, че обичаш да четеш. Коя книга четеш в момента?" },
                    new ConversationStarter { mainText = "Lorenzo, ho sentito che ti piace fare escursioni. Qual è il tuo sentiero preferito?", translationText = "Лоренцо, чух, че обичаш да ходиш на разходки. Кои е твоят любим маршрут за разходка?" },
                }
            }
        },
        { Character.CharacterType.Chinese, new Character
            {
                characterType = Character.CharacterType.Chinese,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "你好，陈！最近过得怎么样？有什么新鲜事吗？", translationText = "Здравей, Чен! Как си? Има ли нещо ново?" },
                    new ConversationStarter { mainText = "嗨，陈！你周末过得怎么样？有没有做什么特别的事情？", translationText = "Здравей, Чен! Как беше уикенда ти? Направил ли си нещо специално?" },
                    new ConversationStarter { mainText = "你好，陈！我听说你是个足球迷。你支持哪个球队？", translationText = "Здравей, Чен! Чух, че си фен на футбола. Кой отбор подкрепяш?" },
                    new ConversationStarter { mainText = "陈，我听说你喜欢旅行。迄今为止，你最喜欢的旅行目的地是哪里？", translationText = "Чен, чух, че обичаш да пътуваш. Кои е твоят любим местоназначение до момента?" },
                    new ConversationStarter { mainText = "你好，陈！你的工作是做什么的？对你的工作满意吗？", translationText = "Здравей, Чен! Каква е професията ти? Доволен ли си от работата си?" },
                    new ConversationStarter { mainText = "嘿，陈！我听说你喜欢弹吉他。你弹了多久了？", translationText = "Хей, Чен! Чух, че обичаш да свириш на китара. От какво време свириш?" },
                    new ConversationStarter { mainText = "你好，陈！你在业余时间喜欢做什么？有什么特别的爱好吗？", translationText = "Здравей, Чен! Какво обичаш да правиш в свободното си време? Имаш ли специални хобита?" },
                    new ConversationStarter { mainText = "陈，我听说你喜欢做饭。你最喜欢做的菜是什么？", translationText = "Чен, чух, че обичаш да готвиш. Кое е твоето любимо ястие, което приготвяш?" },
                    new ConversationStarter { mainText = "你好，陈！我看到你喜欢阅读。你现在在读什么书？", translationText = "Здравей, Чен! Виждам, че обичаш да четеш. Коя книга четеш в момента?" },
                    new ConversationStarter { mainText = "陈，我听说你喜欢徒步旅行。你最喜欢的徒步路线是什么？", translationText = "Чен, чух, че обичаш да ходиш на разходки. Кои е твоят любим маршрут за разходка?" },
                }
            }
        },
        { Character.CharacterType.Greek, new Character
            {
                characterType = Character.CharacterType.Greek,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Γεια σου, Αθηνά! Τι κάνεις; Πώς περνάς τον ελεύθερο σου χρόνο;", translationText = "Здравей, Атина! Как си? Как прекарваш свободното си време?" },
                    new ConversationStarter { mainText = "Γεια σου, Αθηνά! Ποιο είναι το αγαπημένο σου χόμπι;", translationText = "Здравей, Атина! Какво е твоето любимо хоби?" },
                    new ConversationStarter { mainText = "Γεια σου, Αθηνά! Πώς περνάς το σαββατοκύριακο; Έκανες κάτι ενδιαφέρον;", translationText = "Здравей, Атина! Как беше уикенда ти? Направила ли нещо интересно?" },
                    new ConversationStarter { mainText = "Αθηνά, έχω ακούσει ότι σου αρέσει η τέχνη. Ποιος είναι ο αγαπημένος σου καλλιτέχνης;", translationText = "Атина, чух, че обичаш изкуството. Кой е твоят любим художник?" },
                    new ConversationStarter { mainText = "Γεια σου, Αθηνά! Τι βιβλίο διαβάζεις αυτήν την περίοδο;", translationText = "Здравей, Атина! Коя книга четеш в момента?" },
                    new ConversationStarter { mainText = "Αθηνά, έχω ακούσει ότι σου αρέσει η μουσική. Ποιος είναι ο αγαπημένος σου μουσικός;", translationText = "Атина, чух, че обичаш музиката. Кой е твоят любим музикант?" },
                    new ConversationStarter { mainText = "Γεια σου, Αθηνά! Πού σου αρέσει να πηγαίνεις για διακοπές;", translationText = "Здравей, Атина! Къде обичаш да отиваш на почивка?" },
                    new ConversationStarter { mainText = "Αθηνά, έχω ακούσει ότι σου αρέσει να μαγειρεύεις. Ποιο είναι το αγαπημένο σου φαγητό;", translationText = "Атина, чух, че обичаш да готвиш. Какво е твоето любимо ястие?" },
                    new ConversationStarter { mainText = "Γεια σου, Αθηνά! Ποιος είναι ο αγαπημένος σου τόπος στην πόλη;", translationText = "Здравей, Атина! Кой е твоят любим местен ъгъл в града?" },
                    new ConversationStarter { mainText = "Αθηνά, έχω ακούσει ότι σου αρέσει να κάνεις πεζοπορία. Ποιο είναι το αγαπημένο σου μονοπάτι;", translationText = "Атина, чух, че обичаш да правиш пешеходни разходки. Кой е твоят любим път?" },
                }
            }
        },
        { Character.CharacterType.Turkish, new Character
            {
                characterType = Character.CharacterType.Turkish,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Merhaba, Mustafa! Nasılsın? Bugün ne yaptın?", translationText = "Здравей, Мустафа! Как си? Какво правиш днес?" },
                    new ConversationStarter { mainText = "Hey Mustafa, hafta sonun nasıldı? Özel bir şey yaptın mı?", translationText = "Здравей, Мустафа! Как беше уикенда ти? Направил ли си нещо специално?" },
                    new ConversationStarter { mainText = "Merhaba Mustafa, büyük bir futbol fanatiği olduğunu duydum. Hangi takımı destekliyorsun?", translationText = "Здравей, Мустафа! Чух, че си голям фен на футбола. Кой отбор подкрепяш?" },
                    new ConversationStarter { mainText = "Mustafa, seyahat etmeyi sevdiğini duydum. Şimdiye kadar en sevdiğin seyahat noktası hangisiydi?", translationText = "Мустафа, чух, че обичаш да пътуваш. Кои е твоят любим местоназначение до момента?" },
                    new ConversationStarter { mainText = "Merhaba Mustafa, mesleğiniz nedir? İşinizden memnun musunuz?", translationText = "Здравей, Мустафа! Каква е професията ти? Доволен ли си от работата си?" },
                    new ConversationStarter { mainText = "Hey Mustafa, gitar çalmayı sevdiğini duydum. Ne zamandır çalıyorsun?", translationText = "Хей, Мустафа! Чух, че обичаш да свириш на китара. От какво време свириш?" },
                    new ConversationStarter { mainText = "Merhaba Mustafa, boş zamanlarında neler yaparsın? Özel hobilerin var mı?", translationText = "Здравей, Мустафа! Какво обичаш да правиш в свободното си време? Имаш ли специални хобита?" },
                    new ConversationStarter { mainText = "Mustafa, yemek pişirmeyi sevdiğini duydum. En sevdiğin yemeği hangisi?", translationText = "Мустафа, чух, че обичаш да готвиш. Кое е твоето любимо ястие, което приготвяш?" },
                    new ConversationStarter { mainText = "Merhaba Mustafa, okumayı sevdiğini görüyorum. Şu anda hangi kitabı okuyorsun?", translationText = "Здравей, Мустафа! Виждам, че обичаш да четеш. Коя книга четеш в момента?" },
                    new ConversationStarter { mainText = "Mustafa, doğada yürümeyi sevdiğini duydum. En sevdiğin yürüyüş rotası nedir?", translationText = "Мустафа, чух, че обичаш да ходиш на разходки. Кои е твоят любим маршрут за разходка?" },
                }
            }
        },
        { Character.CharacterType.French, new Character
            {
                characterType = Character.CharacterType.French,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Salut Jeanne d'Arc, quelles étaient tes pensées et sentiments lorsque tu as entendu les voix divines pour la première fois?", translationText = "Здравей, Жана д'Арк! Какви бяха твоите мисли и чувства, когато първи път чу гласовете на небесата?" },
                    new ConversationStarter { mainText = "Bonjour Jeanne d'Arc, peux-tu me raconter une expérience surnaturelle que tu as vécue pendant la guerre?", translationText = "Здравей, Жана д'Арк! Можеш ли да ми разкажеш за някакъв свръхестествен опит, който преживя за време на войната?" },
                    new ConversationStarter { mainText = "Salut Jeanne d'Arc, comment as-tu su que tu avais une mission divine? Quels signes as-tu reçus?", translationText = "Здравей, Жана д'Арк! Как разбра, че имаш божествена мисия? Какви знаци получи?" },
                    new ConversationStarter { mainText = "Bonjour Jeanne d'Arc, qu'est-ce qui t'a motivée à te battre pour la France et à devenir une figure emblématique de la guerre?", translationText = "Здравей, Жана д'Арк! Какво те подтикна да се бориш за Франция и да станеш символ на войната?" },
                    new ConversationStarter { mainText = "Salut Jeanne d'Arc, quelles étaient tes interactions avec le roi Charles VII? Comment s'est passée ta première rencontre avec lui?", translationText = "Здравей, Жана д'Арк! Какви бяха твоите взаимодействия с краля Шарл VII? Как протече твоят първи разговор с него?" },
                    new ConversationStarter { mainText = "Bonjour Jeanne d'Arc, comment envisages-tu ton héritage et ton impact sur l'histoire de France?", translationText = "Здравей, Жана д'Арк! Как виждаш своето наследство и влияние върху историята на Франция?" },
                    new ConversationStarter { mainText = "Salut Jeanne d'Arc, quels étaient tes espoirs et tes rêves pour l'avenir de la France après la guerre?", translationText = "Здравей, Жана д'Арк! Какви бяха надеждите и мечтите ти за бъдещето на Франция след войната?" },
                    new ConversationStarter { mainText = "Bonjour Jeanne d'Arc, comment as-tu surmonté les difficultés et les obstacles pendant ta mission?", translationText = "Здравей, Жана д'Арк! Как преодоля трудностите и препятствията по време на твоята мисия?" },
                    new ConversationStarter { mainText = "Salut Jeanne d'Arc, quels étaient tes moments les plus mémorables sur le champ de bataille?", translationText = "Здравей, Жана д'Арк! Какви бяха твоите най-запомнящи се моменти на бойното поле?" },
                    new ConversationStarter { mainText = "Bonjour Jeanne d'Arc, comment envisages-tu ta place dans l'histoire de France? Quel message voudrais-tu transmettre aux générations futures?", translationText = "Здравей, Жана д'Арк! Как виждаш своето място в историята на Франция? Какво послание би искала да предадеш на бъдещите поколения?" }
                }
            }
        },
        { Character.CharacterType.Russian, new Character
            {
                characterType = Character.CharacterType.Russian,
                conversationStarters = new ConversationStarter[]
                {
                    new ConversationStarter { mainText = "Привет, Борис! Как твои дела? Чем занимался сегодня?", translationText = "Здравей, Борис! Как си? Какво правиш днес?" },
                    new ConversationStarter { mainText = "Привет, Борис! Как прошел твой уикенд? Делал что-нибудь особенное?", translationText = "Здравей, Борис! Как беше уикенда ти? Направил ли си нещо специално?" },
                    new ConversationStarter { mainText = "Привет, Борис! Я слышал, что ты большой фанат футбола. Какая команда тебе нравится?", translationText = "Здравей, Борис! Чух, че си голям фен на футбола. Кой е отбора, който подкрепяш?" },
                    new ConversationStarter { mainText = "Борис, я слышал, что ты любишь путешествовать. Какое было твоё любимое место для поездки?", translationText = "Борис, чух, че обичаш да пътуваш. Кои е бил твоето любимо местоназначение до момента?" },
                    new ConversationStarter { mainText = "Привет, Борис! Какая у тебя профессия? Доволен ли ты своей работой?", translationText = "Здравей, Борис! Каква е професията ти? Доволен ли си от работата си?" },
                    new ConversationStarter { mainText = "Привет, Борис! Я слышал, что ты играешь на гитаре. Сколько времени ты это делаешь?", translationText = "Здравей, Борис! Чух, че обичаш да свириш на китара. От какво време свириш?" },
                    new ConversationStarter { mainText = "Привет, Борис! Что ты обычно делаешь в свободное время? Есть ли у тебя увлечения?", translationText = "Здравей, Борис! Какво обичаш да правиш в свободното си време? Имаш ли специални хобита?" },
                    new ConversationStarter { mainText = "Борис, я слышал, что ты умеешь вкусно готовить. Какое твоё любимое блюдо?", translationText = "Борис, чух, че обичаш да готвиш. Кое е твоето любимо ястие, което приготвяш?" },
                    new ConversationStarter { mainText = "Привет, Борис! Я вижу, что ты любишь читать. Какая книга у тебя сейчас на руках?", translationText = "Здравей, Борис! Виждам, че обичаш да четеш. Коя книга четеш в момента?" },
                    new ConversationStarter { mainText = "Борис, я слышал, что ты любишь гулять на природе. Какой твой любимый маршрут для прогулок?", translationText = "Борис, чух, че обичаш да ходиш на разходки. Кои е твоят любим маршрут за разходка?" }
                }
            }
        }


        // Add more characters as needed
    };
}
