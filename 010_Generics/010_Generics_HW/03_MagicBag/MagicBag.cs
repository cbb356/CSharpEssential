namespace MagicBag
{
    internal class MagicBag
    {
        private Dictionary<string, DateTime> gifts = new Dictionary<string, DateTime>();

        public void Open<T>(T creature) where T : IGiftableCreature
        {
            string creatureName = creature.Name;
            string gift = creature.Gift;
            DateTime today = DateTime.Today;

            if (gifts.ContainsKey(creatureName) && gifts[creatureName].Date == today)
            {
                Console.WriteLine($"The {creatureName} already has got the gift today!");
            }
            else
            {
                gifts[creatureName] = today;
                Console.WriteLine($"The {creatureName} has a new {gift} as a gift ");
            }
        }
    }
}
