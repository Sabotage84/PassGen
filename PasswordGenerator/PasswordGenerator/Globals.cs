using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PasswordGenerator
{
    public static class Globals
    {
        public const string DEFAULT_FILE_OF_NAMES = "names.txt";//имя файла с именами по умолчанию
        public static string[] LETTERS = {"Q","W","E","R","T","Y","U","I","O","P","A","S","D","F",//массив букв для подбора
                         "G","H","J","K","L","Z","X","C","V","B","N","M","q","w","e","r","t","y","u","i","o","p","a","s","d","f",//массив букв для подбора
                         "g","h","j","k","l","z","x","c","v","b","n","m" };

        public static string[] literasSMALL ={"q","w","e","r","t","y","u","i","o","p","a","s","d","f",//массив букв для подбора
                         "g","h","j","k","l","z","x","c","v","b","n","m"};
        public static string[] literasBIG ={"Q","W","E","R","T","Y","U","I","O","P","A","S","D",
                              "F","G","H","J","K","L","Z","X","C","V","B","N","M"};

        public static int[] years = new int[140];
        
        
    }
}
