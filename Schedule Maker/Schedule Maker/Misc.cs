using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Maker
{
    class Misc
    {
        public static string SymbolCheckerToDatabase(string text)
        {
            text = text.ToString().Replace("'", "&qoute;");
            return text;
        }

        public static string SymbolCheckerFromDatabase(string text)
        {
            text = text.ToString().Replace("&qoute;", "'");
            return text;
        }
        public static string ConvertTime(string word)
        {

            word = word.Replace(":00:00", ":00");
            word = word.Replace(":15:00", ":15");
            word = word.Replace(":30:00", ":30");
            word = word.Replace(":45:00", ":45");

            switch (word)
            {
                case "06:00":
                case "06:15":
                case "06:30":
                case "06:45":
                case "07:00":
                case "07:15":
                case "07:30":
                case "07:45":
                case "08:00":
                case "08:15":
                case "08:30":
                case "08:45":
                case "09:00":
                case "09:15":
                case "09:30":
                case "09:45":
                case "10:00":
                case "10:15":
                case "10:30":
                case "10:45":
                case "11:00":
                case "11:15":
                case "11:30":
                case "11:45":
                    word += " AM";
                    break;
                case "12:00":
                case "12:15":
                case "12:30":
                case "12:45":
                case "13:00":
                case "13:15":
                case "13:30":
                case "13:45":
                case "14:00":
                case "14:15":
                case "14:30":
                case "14:45":
                case "15:00":
                case "15:15":
                case "15:30":
                case "15:45":
                case "16:00":
                case "16:15":
                case "16:30":
                case "16:45":
                case "17:00":
                case "17:15":
                case "17:30":
                case "17:45":
                case "18:00":
                case "18:15":
                case "18:30":
                case "18:45":
                case "19:00":
                case "19:15":
                case "19:30":
                case "19:45":
                case "20:00":
                case "20:15":
                case "20:30":
                case "20:45":
                case "21:00":
                case "21:15":
                case "21:30":
                case "21:45":
                    word += " PM";
                    break;

            }

            switch (word)
            {
                case "13:00 PM":
                    word = "01:00 PM";
                    break;
                case "13:15 PM":
                    word = "01:15 PM";
                    break;
                case "13:30 PM":
                    word = "01:30 PM";
                    break;
                case "13:45 PM":
                    word = "01:45 PM";
                    break;
                case "14:00 PM":
                    word = "02:00 PM";
                    break;
                case "14:15 PM":
                    word = "02:15 PM";
                    break;
                case "14:30 PM":
                    word = "02:30 PM";
                    break;
                case "14:45 PM":
                    word = "02:45 PM";
                    break;
                case "15:00 PM":
                    word = "03:00 PM";
                    break;
                case "15:15 PM":
                    word = "03:15 PM";
                    break;
                case "15:30 PM":
                    word = "03:30 PM";
                    break;
                case "15:45 PM":
                    word = "03:45 PM";
                    break;
                case "16:00 PM":
                    word = "04:00 PM";
                    break;
                case "16:15 PM":
                    word = "04:15 PM";
                    break;
                case "16:30 PM":
                    word = "04:30 PM";
                    break;
                case "16:45 PM":
                    word = "04:45 PM";
                    break;
                case "17:00 PM":
                    word = "05:00 PM";
                    break;
                case "17:15 PM":
                    word = "05:15 PM";
                    break;
                case "17:30 PM":
                    word = "05:30 PM";
                    break;
                case "17:45 PM":
                    word = "05:45 PM";
                    break;
                case "18:00 PM":
                    word = "06:00 PM";
                    break;
                case "18:15 PM":
                    word = "06:15 PM";
                    break;
                case "18:30 PM":
                    word = "06:30 PM";
                    break;
                case "18:45 PM":
                    word = "06:45 PM";
                    break;
                case "19:00 PM":
                    word = "07:00 PM";
                    break;
                case "19:15 PM":
                    word = "07:15 PM";
                    break;
                case "19:30 PM":
                    word = "07:30 PM";
                    break;
                case "19:45 PM":
                    word = "07:45 PM";
                    break;
                case "20:00 PM":
                    word = "08:00 PM";
                    break;
                case "20:15 PM":
                    word = "08:15 PM";
                    break;
                case "20:30 PM":
                    word = "08:30 PM";
                    break;
                case "20:45 PM":
                    word = "08:45 PM";
                    break;
                case "21:00 PM":
                    word = "09:00 PM";
                    break;
                case "21:15 PM":
                    word = "09:15 PM";
                    break;
                case "21:30 PM":
                    word = "09:30 PM";
                    break;
                case "21:45 PM":
                    word = "09:45 PM";
                    break;
            }
            return word;
        }
    }
}
