namespace MagicBag
{
    public interface IGiftableCreature
    {
        string Name { get; }
        string Gift { get; }
    }

    internal class Elf : IGiftableCreature
    {
        public string Name => "Elf";
        public string Gift => "Bow";
    }

    internal class Dwarf : IGiftableCreature
    {
        public string Name => "Dwarf";
        public string Gift => "Axe";
    }
    
    internal class Human : IGiftableCreature
    {
        public string Name => "Human";
        public string Gift => "Sword";
    }
    
    internal class Orc
    {
        public string Name => "Orc";
        public string Gift => "Polearm";
    }
}
