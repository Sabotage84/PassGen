using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace PasswordGenerator
{
   

    public partial class MainForm : Form
    {
        //Массив пароля заполняем изначально нулями, делаем его не больше 20
        //так как более длинный пароль буде ОЧЕНЬ большим
       

        int currentNumberofPass = 0;
        string currentPass = "";
       

        Passwords pass = Passwords.instance;

        FileWork fileForPasswords = new FileWork();

        public MainForm()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
           
            //Заполняем массив с годами
            for (int i = 1900; i < 2031; i++)
                Globals.years[i - 1900] = i;

        }
       
        /// <summary>
        /// 1)Загружам имена из файла по умолчанию в список имен
        /// 2)вычисляем колличество букв для дальнейшего рассчета размера файла
        /// 3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadDefaultFile_Click(object sender, EventArgs e)
        {
            string[] content;

            content = File.ReadAllLines(Globals.DEFAULT_FILE_OF_NAMES);
            for (int i = 0; i < content.Length; i++)
            {
                ListBoxOfNames.Items.Add(content[i]);
            }
           
        }

        /// <summary>
        /// Добавляем Имя из поля AddNane_tBx, если оно есть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewName_Btn_Click(object sender, EventArgs e)
        {
            if (AddNane_tBx.Text != "")//если имя есть иначе ничего не делать
            {
                ListBoxOfNames.Items.Add(AddNane_tBx.Text);
                AddNane_tBx.Text = "";
                AddNane_tBx.Focus();

            }
        }

        /// <summary>
        /// 1)Очищаем ListBoxOfNames
        /// 2)Открываем другой/свой файл с именами и заполняем им ListBoxOfNames
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFileOfNames_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();//Экземпляр диалог окна открытия файла
            OpenFile.Filter = "Text (*.txt;)|*.txt";//Маска только на TXT
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                ListBoxOfNames.Items.Clear(); //очищаем перед загрузкой

                string[] content;
                content = File.ReadAllLines(OpenFile.FileName);
                for (int i = 0; i < content.Length; i++)
                {
                    ListBoxOfNames.Items.Add(content[i]);
                }

            }
        }
        
        /// <summary>
        /// Добавляем имя по энтеру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNane_tBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewName_Btn_Click(sender, e);
        }

        /// <summary>
        /// Добавляем имя к парольной фразе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNameToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.NAME);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
        }
        
        /// <summary>
        /// Добавляем букву к парольной фразе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLetterToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.LETTER);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
        }

        /// <summary>
        /// Добавляем только большие буквы к паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBigLetterToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.BigLetter);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
        }

        /// <summary>
        /// Добавляем маленькую букву к паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSmallLetterToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.SmallLetter);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
        }

        /// <summary>
        /// Добавляем цифру к паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNumberToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.NUMBER);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
         }

        /// <summary>
        /// Добавляем год к паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddYearToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.YEAR);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
         }

        /// <summary>
        /// Добавляем _ к паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_ToPass_Click(object sender, EventArgs e)
        {
            pass.Add(Passwords.PassContent.LowLine);
            FeelPassLabel(pass.GetSymbol(pass.GetCurrentChar()));
        }

        /// <summary>
        /// Сбрасываем парольный масив и главный лайбл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearPass_Click(object sender, EventArgs e)
        {
            mainLabel.ResetText();
            pass.ClearList();
        }

        private void CreatePassList_Btn_Click(object sender, EventArgs e)
        {
           
            StopCreating_Btn.Enabled = true;

            if (mainLabel.Text == "" || mainLabel.Text == "Пароль пока пустой")//если в строке пароля ниче нет, то и создавать нечего
            {
                MessageBox.Show("Невозможно создать лист паролей. Нет парольной строки!");
            }
            else
            {
                Calculate_Btn_Click(sender, e);// для подсчета и определения максимума в прогресс баре
                pass.PositionOnStart();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Метод создания пароль листа
        /// </summary>
        /// <param name="inputLine"></param>
        /// <param name="st"></param>
        void CreateList(BackgroundWorker worker, DoWorkEventArgs e)
        {
            
            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                
            }
            else
            {
                if (pass.CurrentPosition < 3)
                    backgroundWorker1.ReportProgress(currentNumberofPass, currentPass);
                
                switch (pass.GetCurrentChar())
                {
                    
                    case Passwords.PassContent.NAME: //если в парольной фразе ИМЯ
                        for (int m = 0; m < ListBoxOfNames.Items.Count; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + ListBoxOfNames.Items[m];//прибавление ИМЕНИ к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов
                        break;

                    case Passwords.PassContent.NUMBER://если в парольной фразе ЧИСЛО

                        for (int m = 0; m < 10; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + m;//прибавление ЦИФРЫ к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов

                        break;

                    case Passwords.PassContent.LETTER://если в парольной фразе БУКВА
                        for (int m = 0; m < 52; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + Globals.LETTERS[m];//прибавление БУКВЫ к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов
                        break;

                    case Passwords.PassContent.SmallLetter://если в парольной фразе маленькая БУКВА
                        for (int m = 0; m < 26; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + Globals.literasSMALL[m];//прибавление БУКВЫ к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов
                        break;

                    case Passwords.PassContent.BigLetter://если в парольной фразе БОЛЬШАЯ БУКВА
                        for (int m = 0; m < 26; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + Globals.literasBIG[m];//прибавление БУКВЫ к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов
                        break;

                    case Passwords.PassContent.YEAR://если в парольной фразе ГОД
                        for (int m = 0; m < 131; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + Globals.years[m];//прибавление ГОДА к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов
                        break;

                    case Passwords.PassContent.LowLine://если в парольной фразе "_"
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + "_";//прибавление "_" к паролю

                            CheckPassForEnd(worker, e);

                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                            pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов
                        }
                        break;

                    default:
                        break;

                }
            }  
            
        }

        private void CheckPassForEnd(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (!pass.NextIsEnd())
            {
                pass.StepNext();
                CreateList(worker, e);//итерация рекурсии если парольная фраза не закончилась
            }
            else
            {
                fileForPasswords.WriteToFile(pass.OutPassword);//ДОПИСЫВАЕТ в файл пароли
                currentNumberofPass++;
                currentPass = pass.OutPassword;
            }
        }

        /// <summary>
        /// Вычисляем количество паролей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Btn_Click(object sender, EventArgs e)
        {
            currentNumberofPass = 0;

            int countOFname = 1;//для того чтобы если имен нет мы прибавляли просто по еденице к размеру файла
            if (ListBoxOfNames.Items.Count!=0)
                countOFname = ListBoxOfNames.Items.Count*pass.GetCountOfNames();

            if (string.IsNullOrEmpty(mainLabel.Text))//если в строке пароля ниче нет, то и создавать нечего
            {
                label2.Text = "0 шт.";
                label3.Text = "0 байт";
            }
            else
            {
                label2.Text = pass.GetAmountOfPass(ListBoxOfNames.Items.Count) + " шт.";//Вывод количества паролей
                progressBar.Value = 0;
                progressBar.Maximum = pass.GetAmountOfPass( ListBoxOfNames.Items.Count);
                CalculateFileSize(pass.GetFileSize(ListBoxOfNames.Items.Count, ListBoxOfNames), pass.GetAmountOfPass(ListBoxOfNames.Items.Count));
            }
        }

        /// <summary>
        /// Вычисляем размер файла
        /// </summary>
        /// <param name="inputFileSize"></param>
        /// <param name="inputAmountOfPass"></param>
        public void CalculateFileSize(long inputFileSize, long inputAmountOfPass)
        {
            string stringToOut;
            double realFileSize;//для точного вывода размера файла с дробной частью
            if (ListBoxOfNames.Items.Count > 0)
            {
                inputFileSize = inputFileSize * inputAmountOfPass / ListBoxOfNames.Items.Count + 2 * inputAmountOfPass;
            }
            else
            {
                inputFileSize = inputFileSize * inputAmountOfPass + 2 * inputAmountOfPass;
            }
            if (inputFileSize < 1024)
            {
                label3.Text = inputFileSize + " байт";
            }

            if (inputFileSize >= 1024 && inputFileSize < 1048576)
            {
                realFileSize = inputFileSize;
                realFileSize = realFileSize / 1024;
                stringToOut = string.Format("{0:N2}", realFileSize);
                label3.Text = stringToOut + " Кб";
            }

            if (inputFileSize >= 1048576 && inputFileSize < 1073741824)
            {
                realFileSize = inputFileSize;
                realFileSize = realFileSize / 1048576;
                stringToOut = string.Format("{0:N2}", realFileSize);
                label3.Text = stringToOut + " Мб";

            }
            if (inputFileSize >= 1073741824)
            {
                realFileSize = inputFileSize;
                realFileSize = realFileSize / 1073741824;
                stringToOut = string.Format("{0:N2}", realFileSize);
                label3.Text = stringToOut + " Гб";
            }
        }

        /// <summary>
        /// Очистка расчетов количества и размера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCalc_Btn_Click(object sender, EventArgs e)
        {
            label2.Text = "0 шт.";
            label3.Text = "0 байт";
        }
        
        private void StopCreating_Btn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
                backgroundWorker1.CancelAsync();
            StopCreating_Btn.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            fileForPasswords.CreateFile("List");
            CreateList(worker, e);
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            currentPassword_label.Text = (string)e.UserState;
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fileForPasswords.CloseFile();
            pass.ReturnCurrentPosition();
            if (e.Cancelled == true)
            {
                
                progressBar.Value = progressBar.Minimum;
                MessageBox.Show("Canceled!");
                currentPassword_label.Text = "Operation canceled!";
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                progressBar.Value = progressBar.Maximum;
                MessageBox.Show("Лист паролей создан!!!");
            }
        }

        
        /// <summary>
       /// TEST BUTTON
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Test_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pass.GetCharAmount(ListBoxOfNames).ToString()); 
        }

        private void FeelPassLabel(string newchar)
        {
            if (mainLabel.Text == "Пароль пока пустой")
                mainLabel.Text = newchar;
            else
                mainLabel.Text = mainLabel.Text + newchar;
           
        }

        //Not in use
        private void AddNane_tBx_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddNane_tBx_Enter(object sender, EventArgs e)
        {

        }

        void CreateList2(StreamWriter st, BackgroundWorker worker, DoWorkEventArgs e)
        {
            
            if (worker.CancellationPending == true)
            {
                e.Cancel = true;

            }
            else
            {
                if (pass.CurrentPosition<4)
                    backgroundWorker1.ReportProgress(currentNumberofPass, currentPass);

                switch (pass.GetCurrentChar())
                {
                    

                    case Passwords.PassContent.NUMBER://если в парольной фразе ЧИСЛО

                        for (int m = 0; m < 10; m++)
                        {
                            string tempPassword = pass.OutPassword;
                            pass.OutPassword = pass.OutPassword + m;//прибавление ЦИФРЫ к паролю
                            if (!pass.NextIsEnd())
                            {
                                pass.StepNext();
                                CreateList2(st, worker, e);//итерация рекурсии если парольная фраза не закончилась
                            }
                            else
                            {
                                st.WriteLine(pass.OutPassword);//ДОПИСЫВАЕТ в файл пароли
                                currentNumberofPass++;
                                currentPass = pass.OutPassword;
                            }
                            pass.OutPassword = tempPassword;//сброс строки для следуещего прибавления
                        }
                        pass.StepBack();//уменьшение счетчика вложенность для нескольких проходов

                        break;

                    default:
                        break;

                }
            }

        }

        private void DeleteLastPassContent_btn_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(mainLabel.Text))
                mainLabel.Text = mainLabel.Text.Substring(0, mainLabel.Text.Length-pass.GetSymbol(pass.GetCurrentChar()).Length);
            pass.RemoveLast();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ListBoxOfNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                ListBoxOfNames.Items.RemoveAt(ListBoxOfNames.SelectedIndex);
        }
    }
}
