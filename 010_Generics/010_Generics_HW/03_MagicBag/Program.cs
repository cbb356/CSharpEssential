/*
 * Створіть проект Console Application, де реалізуйте типізований клас "Чарівний мішок". 
 * Чарівність полягає в тому, що подарунок сам з'являється у мішку та залежить від того, 
 * хто намагається відкрити мішок. Причому подарунок для однієї істоти може з'явитись 
 * лише 1 раз на день. Використовуйте обмеження типу - інтерфейс із властивістю, 
 * що зберігає тип істоти, яка намагається отримати подарунок із мішка.
 */

namespace MagicBag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MagicBag magicBag = new MagicBag();
            Elf elf = new Elf();
            Dwarf dwarf = new Dwarf();
            Human human = new Human();
            Orc orc = new Orc();

            magicBag.Open(elf);
            magicBag.Open(dwarf);
            magicBag.Open(human);
            magicBag.Open(elf);     // Repeated - no gift!
            //magicBag.Open(orc);     // Error - not IGiftableCreature
        }
    }
}
