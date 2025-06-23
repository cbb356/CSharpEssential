namespace Dictionary
{
    internal class Word
    {
        public string Ukrainian { get; set; }
        public string Russian { get; set; }
        public string English { get; set; }
    }

    internal class Dictionary
    {
        private Word[] dict = new Word[5];

        public Dictionary()
        {
            dict[0] = new Word { Ukrainian = "книга", Russian = "книга", English = "book" };
            dict[1] = new Word { Ukrainian = "ручка", Russian = "ручка", English = "pen" };
            dict[2] = new Word { Ukrainian = "сонце", Russian = "солнце", English = "sun" };
            dict[3] = new Word { Ukrainian = "яблуко", Russian = "яблоко", English = "apple" };
            dict[4] = new Word { Ukrainian = "стіл", Russian = "стол", English = "table" };
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < dict.Length; i++)
                {
                    if (dict[i].Ukrainian == index || dict[i].Russian == index || dict[i].English == index)
                        return dict[i].Ukrainian + "(укр.) - " + dict[i].Russian + "(рос.) - " + dict[i].English + "(англ.)";
                }

                return string.Format("{0} - немає перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < dict.Length)
                    return dict[index].Ukrainian + "(укр.) - " + dict[index].Russian + "(рос.) - " + dict[index].English + "(англ.)";
                else
                    return "Спроба звернення за межі масиву.";
            }
        }
    }

}
