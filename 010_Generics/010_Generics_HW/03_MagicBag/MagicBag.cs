namespace MagicBag
{
    internal class MagicBag
    {
        private Dictionary<string, string> creatures = new Dictionary<string, string>
            {
                {"Elf", "Bow" },
                {"Dwarf", "Axe" },
                {"Human", "Sword" },
                {"Orc", "Polearm" },
                {"Wizard", "Wand" }
            };

        private Dictionary<string, DateTimeOffset> gifts = new Dictionary<string, DateTimeOffset>();

        public void GetGift(string creature)
        {
            if (creatures.ContainsKey(creature))
            {
                if (!gifts.ContainsKey(creature) || gifts.ContainsKey(creature) && gifts[creature].Date < DateTimeOffset.Now.Date)
                {
                    gifts[creature] = DateTimeOffset.Now;
                    Console.WriteLine($"The {creature.ToLower()} has a new {creatures[creature].ToLower()} as a gift ");
                }
                else
                {
                    Console.WriteLine($"The {creature.ToLower()} already has received the gift today!");
                }
            }
            else
            {
                Console.WriteLine("There are no such creature!");
            }
        }
    }
}
