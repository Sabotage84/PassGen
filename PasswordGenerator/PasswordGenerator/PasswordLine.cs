using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class Passwords: IEnumerable
    {
        public enum PassContent
        {
            NAME, LETTER, BigLetter, SmallLetter, NUMBER, YEAR, LowLine, END
        }

        int currentPosition;
        int tempCurrentPosition;
        string outPassword;

        PassContent[] PasswordLine = new PassContent[] { PassContent.END, PassContent.END, PassContent.END, PassContent.END, PassContent.END,
                                                            PassContent.END,PassContent.END,PassContent.END,PassContent.END,PassContent.END,
                                                            PassContent.END,PassContent.END,PassContent.END};
        
        
        private Passwords()
        {
            CurrentPosition = -1;
            tempCurrentPosition = -1;
        }

        private static readonly Passwords _instance = new Passwords();
        public static Passwords instance
        {
            get
            {
                return _instance;
            }
        }

        public int CurrentPosition
        {
            get
            {
                return currentPosition;
            }

            private set
            {
                currentPosition = value;
            }
        }

        public string OutPassword
        {
            get
            {
                return outPassword;
            }

            set
            {
                outPassword = value;
            }
        }

        public void PositionOnStart()
        {
            tempCurrentPosition = currentPosition;
            CurrentPosition = 0;
        }

        public void ReturnCurrentPosition()
        {
            currentPosition = tempCurrentPosition;
        }
        public void Add(PassContent newchar)
        {
            bool passwordLineIsFull = true;
            for (int i = 0; i < PasswordLine.Length; i++)
            {
                if (PasswordLine[i] == PassContent.END)
                {
                    CurrentPosition = i;
                    PasswordLine[CurrentPosition] = newchar;
                    passwordLineIsFull = false;
                    break;
                }
            }
            if(passwordLineIsFull)
            {
                MessageBox.Show("Пароль не может быть длиннее 13 символов!");
                PositionOnStart();
                throw new IndexOutOfRangeException();
            }

        }

        public void RemoveLast()
        {
            if (currentPosition >= 0)
            {
                PasswordLine[CurrentPosition] = PassContent.END;
                CurrentPosition--;
            }
        }

        public void ClearList()
        {
            for (int i=0;i<PasswordLine.Length;i++)
                PasswordLine[i]=PassContent.END;
            PositionOnStart();
        }

        public PassContent GetCurrentChar()
        {
            if(currentPosition>=0)
                return PasswordLine[CurrentPosition];
            return PassContent.END;
        }

        public bool NextIsEnd()
        {
            if (PasswordLine[CurrentPosition+1]==PassContent.END)
                return true;
            return false;
        }
        public bool EndOfPasswordLine()
        {
            if (PasswordLine[CurrentPosition] == PassContent.END)
                return true;
            return false;
        }

        public void StepNext()
        {
            CurrentPosition++;
        }

        public void StepBack()
        {
            CurrentPosition--;
        } 

        public int GetCountOfNames()
        {
            int result=0;
            for (int i=0; i<PasswordLine.Length; i++)
            {
                if (PasswordLine[i] == PassContent.NAME)
                    result++;
            }
            if (result == 0)
                return 1;
            else
                return result;
        }

        public string GetSymbol(PassContent pc)
        {
            switch (pc)
            {
                case PassContent.NAME:
                    return " NAME";
                    
                case PassContent.LETTER:
                    return " A..z";
                    
                case PassContent.BigLetter:
                    return " AZ";
                    
                case PassContent.SmallLetter:
                    return " az";
                    
                case PassContent.NUMBER:
                    return " #";
                    break;
                case PassContent.YEAR:
                    return " ГоД";
                    
                case PassContent.LowLine:
                    return "_";
                    
                case PassContent.END:
                    return "";
                    
                default:
                    return "";
            }     
        }

        public int GetAmountOfPass(int countOfNames)
        {
            Passwords paswordLine = this;

            int amountofPass = 1;

            paswordLine.PositionOnStart();
            while (!paswordLine.EndOfPasswordLine())

            {
                switch (paswordLine.GetCurrentChar())
                {
                    case PassContent.NAME:
                        if (countOfNames == 0)
                        {
                            amountofPass = amountofPass * 1;//если лист имен пуст чтобы не обнулялось
                        }
                        else
                        {
                            amountofPass = amountofPass * countOfNames;
                        }
                        break;

                    case PassContent.NUMBER:
                        amountofPass = amountofPass * 10;
                        break;

                    case PassContent.LETTER:
                       amountofPass = amountofPass * 52;
                        break;

                    case PassContent.SmallLetter:
                        amountofPass = amountofPass * 26;
                        break;

                    case PassContent.BigLetter:
                        amountofPass = amountofPass * 26;

                        break;

                    case PassContent.YEAR:
                        amountofPass = amountofPass * 140;

                        break;

                    case PassContent.LowLine:
                        amountofPass = amountofPass * 1;
                        break;

                    default:
                        break;

                }
                paswordLine.StepNext();
            }
            paswordLine.ReturnCurrentPosition();
            return amountofPass;
        }

        public long GetFileSize (int countOfNames, ListBox names)
        {
            Passwords paswordLine = this;
            long FileSize = 0;
            int countOFname = 1;//для того чтобы если имен нет мы прибавляли просто по еденице к размеру файла

            paswordLine.PositionOnStart();
            if (countOfNames != 0)
                countOFname = countOfNames * paswordLine.GetCountOfNames();

            while (!paswordLine.EndOfPasswordLine())

            {
                switch (paswordLine.GetCurrentChar())
                {
                    case PassContent.NAME:
                        if (countOfNames == 0)
                        {
                            countOFname = 1;
                        }
                        else
                        {
                            FileSize = FileSize + GetCharAmount(names);
                        }
                        break;

                    case PassContent.NUMBER:
                       FileSize = FileSize + countOFname;//добавляем к размеру файла
                        break;

                    case PassContent.LETTER:
                        FileSize = FileSize + countOFname;//добавляем к размеру файла
                        break;

                    case PassContent.SmallLetter:
                        FileSize = FileSize + countOFname;//добавляем к размеру файла
                        break;

                    case PassContent.BigLetter:
                        FileSize = FileSize + countOFname;//добавляем к размеру файла
                        break;

                    case PassContent.YEAR:
                        FileSize = FileSize + 4 * countOFname;//добавляем к размеру файла
                        break;

                    case PassContent.LowLine:
                        FileSize =FileSize + countOFname;//добавляем к размеру файла
                        break;

                    default:
                        break;

                }
                paswordLine.StepNext();
            }
            paswordLine.ReturnCurrentPosition();
            return FileSize;
        }

        public int GetCharAmount(ListBox names)
        {
            int res = 0;

            if (names != null)
            {
                for (int i = 0; i < names.Items.Count; i++)
                {
                    char[] letters = names.Items[i].ToString().ToCharArray();//разбиваем на буквы имена
                    res += letters.Length;
                }
            }

            return res;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (PassContent pc in PasswordLine)
            yield return pc;
        }
    }
}
