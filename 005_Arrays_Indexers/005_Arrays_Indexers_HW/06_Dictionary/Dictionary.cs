namespace Dictionary
{
    internal class Dictionary
    {
        private string[,] dict = new string[5,3];

        public Dictionary()
        {
            dict[0,0] = "книга"; dict[0,1] = "книга"; dict[0,2] = "book";
            dict[1,0] = "ручка"; dict[1,1] = "ручка"; dict[1,2] = "pen";
            dict[2,0] = "сонце"; dict[2,1] = "солнце"; dict[2,2] = "sun";
            dict[3,0] = "яблуко"; dict[3,1] = "яблоко"; dict[3,2] = "apple";
            dict[4,0] = "стіл"; dict[4,1] = "стол"; dict[4,2] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < dict.GetLength(0); i++)
                {
                    for (int j = 0; j < dict.GetLength(1); j++)
                    {
                        if (dict[i, j] == index)
                            return dict[i, 0] + "(укр.) - " + dict[i, 1] + "(рос.) - " + dict[i, 2] + "(англ.)";
                    }
                }
                
                return string.Format("{0} - немає перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < dict.GetLength(0))
                    return dict[index, 0] + "(укр.) - " + dict[index, 1] + "(рос.) - " + dict[index, 2] + "(англ.)";
                else
                    return "Спроба звернення за межі масиву.";
            }
        }
    }

}
