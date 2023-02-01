using UpSchoolHW_01.Enums;

namespace UpSchoolHW_01.Entities
{
    public static class PasswordGenerator
    {

        public static string UpperLetters = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ";
        public static string Numbers = "0123456789";
        public static string SpecialCharacters = "!+%&/()=?*-";
        public static char[] Password;
        public static string charSet = string.Empty;
         
        public static string Generate(int length, Dictionary<int, string> selectionList)
        {
            Random rnd = new Random();
            Password = new char[length];
            foreach (var item in selectionList)
            {
                switch (item.Key)
                {
                    case (int)Combination.UppercaseCharacters:
                        charSet += UpperLetters;
                        break;
                    case (int)Combination.LowercaseCharacters:
                        charSet += UpperLetters.ToLower();
                        break;
                    case (int)Combination.SpecialCharacters:
                        charSet += SpecialCharacters;
                        break;
                    case (int)Combination.Numbers:
                        charSet += Numbers;
                        break;
                    default:
                        charSet += UpperLetters;
                        break;
                } 
            }


            for (int i = 0; i < length; i++)
            {

                Password[i] = charSet[rnd.Next(charSet.Length - 1)];
            }
            return string.Join(null, Password);
        }
    }
}
