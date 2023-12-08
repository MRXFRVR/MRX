namespace c_sharp3
{
    internal class Program
    {
        interface IMagic
        {
            void CastSpell(Spell spell);
        }
        class Spell
        {
            public int Mana { get; private set; }
            private string Effect { get; set; }
            public string Name_cast { get; set; }
            public Spell(string name_cast, int mana, string effect)
            {
                Mana = mana;
                Effect = effect;
                Name_cast = name_cast;
            }

            public void Use()
            {
                Console.WriteLine(Effect);
            }
        }

        class Magician : IMagic
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            public Magician(string name, int mana)
            {
                Name = name;
                Mana = mana;
            }


            public void CastSpell(Spell spell)
            {
                if (Mana >= spell.Mana)
                {
                    Mana -= spell.Mana;
                    Console.WriteLine(Name + " колдует! ");
                    spell.Use();
                }
                else
                {
                    Console.WriteLine("Для использования " + spell.Name_cast + " не хватает " + (spell.Mana - Mana) + " единиц маны. Хлебнице зелья!");
                }

            }
        }
        static void Main(string[] args)
        {
            Spell alohomora = new Spell("alohomora", 60, "Замок открывается!");
            Spell vingardiumLeviosa = new Spell("vingardiumLeviosa", 60, "Предмет поднимается в воздух!");

            Magician garryPotter = new Magician("Гарри Поттер", 100);

            garryPotter.CastSpell(vingardiumLeviosa);
            garryPotter.CastSpell(alohomora);

            Console.ReadKey(true);
        }
    }
}