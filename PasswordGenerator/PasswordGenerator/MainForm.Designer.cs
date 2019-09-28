namespace PasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxOfNames = new System.Windows.Forms.ListBox();
            this.LoadDefaultFile = new System.Windows.Forms.Button();
            this.LoadFileOfNames = new System.Windows.Forms.Button();
            this.AddNane_tBx = new System.Windows.Forms.TextBox();
            this.AddNewName_Btn = new System.Windows.Forms.Button();
            this.AddNameToPass = new System.Windows.Forms.Button();
            this.AddLetterToPass = new System.Windows.Forms.Button();
            this.AddBigLetterToPass = new System.Windows.Forms.Button();
            this.AddSmallLetterToPass = new System.Windows.Forms.Button();
            this.AddNumberToPass = new System.Windows.Forms.Button();
            this.AddYearToPass = new System.Windows.Forms.Button();
            this.Add_ToPass = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.CreatePassList_Btn = new System.Windows.Forms.Button();
            this.ClearPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate_Btn = new System.Windows.Forms.Button();
            this.ClearCalc_Btn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Test_Btn = new System.Windows.Forms.Button();
            this.currentPassword_label = new System.Windows.Forms.Label();
            this.StopCreating_Btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteLastPassContent_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxOfNames
            // 
            this.ListBoxOfNames.FormattingEnabled = true;
            this.ListBoxOfNames.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ListBoxOfNames.Location = new System.Drawing.Point(30, 67);
            this.ListBoxOfNames.Name = "ListBoxOfNames";
            this.ListBoxOfNames.Size = new System.Drawing.Size(154, 160);
            this.ListBoxOfNames.TabIndex = 0;
            this.ListBoxOfNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxOfNames_KeyDown);
            // 
            // LoadDefaultFile
            // 
            this.LoadDefaultFile.Location = new System.Drawing.Point(30, 12);
            this.LoadDefaultFile.Name = "LoadDefaultFile";
            this.LoadDefaultFile.Size = new System.Drawing.Size(154, 23);
            this.LoadDefaultFile.TabIndex = 1;
            this.LoadDefaultFile.Text = "Загрузить список имен";
            this.LoadDefaultFile.UseVisualStyleBackColor = true;
            this.LoadDefaultFile.Click += new System.EventHandler(this.LoadDefaultFile_Click);
            // 
            // LoadFileOfNames
            // 
            this.LoadFileOfNames.Location = new System.Drawing.Point(30, 38);
            this.LoadFileOfNames.Name = "LoadFileOfNames";
            this.LoadFileOfNames.Size = new System.Drawing.Size(154, 23);
            this.LoadFileOfNames.TabIndex = 2;
            this.LoadFileOfNames.Text = "Загрузить имена из файла";
            this.LoadFileOfNames.UseVisualStyleBackColor = true;
            this.LoadFileOfNames.Click += new System.EventHandler(this.LoadFileOfNames_Click);
            // 
            // AddNane_tBx
            // 
            this.AddNane_tBx.Location = new System.Drawing.Point(31, 233);
            this.AddNane_tBx.Name = "AddNane_tBx";
            this.AddNane_tBx.Size = new System.Drawing.Size(153, 20);
            this.AddNane_tBx.TabIndex = 3;
            this.AddNane_tBx.TextChanged += new System.EventHandler(this.AddNane_tBx_TextChanged);
            this.AddNane_tBx.Enter += new System.EventHandler(this.AddNane_tBx_Enter);
            this.AddNane_tBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNane_tBx_KeyDown);
            // 
            // AddNewName_Btn
            // 
            this.AddNewName_Btn.Location = new System.Drawing.Point(30, 259);
            this.AddNewName_Btn.Name = "AddNewName_Btn";
            this.AddNewName_Btn.Size = new System.Drawing.Size(154, 24);
            this.AddNewName_Btn.TabIndex = 4;
            this.AddNewName_Btn.Text = "Добавить имя";
            this.AddNewName_Btn.UseVisualStyleBackColor = true;
            this.AddNewName_Btn.Click += new System.EventHandler(this.AddNewName_Btn_Click);
            // 
            // AddNameToPass
            // 
            this.AddNameToPass.Location = new System.Drawing.Point(190, 67);
            this.AddNameToPass.Name = "AddNameToPass";
            this.AddNameToPass.Size = new System.Drawing.Size(86, 23);
            this.AddNameToPass.TabIndex = 5;
            this.AddNameToPass.Text = "Name";
            this.AddNameToPass.UseVisualStyleBackColor = true;
            this.AddNameToPass.Click += new System.EventHandler(this.AddNameToPass_Click);
            // 
            // AddLetterToPass
            // 
            this.AddLetterToPass.Location = new System.Drawing.Point(299, 67);
            this.AddLetterToPass.Name = "AddLetterToPass";
            this.AddLetterToPass.Size = new System.Drawing.Size(86, 23);
            this.AddLetterToPass.TabIndex = 6;
            this.AddLetterToPass.Text = "a...zA...Z";
            this.AddLetterToPass.UseVisualStyleBackColor = true;
            this.AddLetterToPass.Click += new System.EventHandler(this.AddLetterToPass_Click);
            // 
            // AddBigLetterToPass
            // 
            this.AddBigLetterToPass.Location = new System.Drawing.Point(408, 67);
            this.AddBigLetterToPass.Name = "AddBigLetterToPass";
            this.AddBigLetterToPass.Size = new System.Drawing.Size(86, 23);
            this.AddBigLetterToPass.TabIndex = 7;
            this.AddBigLetterToPass.Text = "A......Z";
            this.AddBigLetterToPass.UseVisualStyleBackColor = true;
            this.AddBigLetterToPass.Click += new System.EventHandler(this.AddBigLetterToPass_Click);
            // 
            // AddSmallLetterToPass
            // 
            this.AddSmallLetterToPass.Location = new System.Drawing.Point(517, 67);
            this.AddSmallLetterToPass.Name = "AddSmallLetterToPass";
            this.AddSmallLetterToPass.Size = new System.Drawing.Size(86, 23);
            this.AddSmallLetterToPass.TabIndex = 8;
            this.AddSmallLetterToPass.Text = "a.....z";
            this.AddSmallLetterToPass.UseVisualStyleBackColor = true;
            this.AddSmallLetterToPass.Click += new System.EventHandler(this.AddSmallLetterToPass_Click);
            // 
            // AddNumberToPass
            // 
            this.AddNumberToPass.Location = new System.Drawing.Point(190, 96);
            this.AddNumberToPass.Name = "AddNumberToPass";
            this.AddNumberToPass.Size = new System.Drawing.Size(86, 23);
            this.AddNumberToPass.TabIndex = 9;
            this.AddNumberToPass.Text = "0...9";
            this.AddNumberToPass.UseVisualStyleBackColor = true;
            this.AddNumberToPass.Click += new System.EventHandler(this.AddNumberToPass_Click);
            // 
            // AddYearToPass
            // 
            this.AddYearToPass.Location = new System.Drawing.Point(299, 96);
            this.AddYearToPass.Name = "AddYearToPass";
            this.AddYearToPass.Size = new System.Drawing.Size(86, 23);
            this.AddYearToPass.TabIndex = 10;
            this.AddYearToPass.Text = "1900-2030";
            this.AddYearToPass.UseVisualStyleBackColor = true;
            this.AddYearToPass.Click += new System.EventHandler(this.AddYearToPass_Click);
            // 
            // Add_ToPass
            // 
            this.Add_ToPass.Location = new System.Drawing.Point(408, 96);
            this.Add_ToPass.Name = "Add_ToPass";
            this.Add_ToPass.Size = new System.Drawing.Size(86, 23);
            this.Add_ToPass.TabIndex = 11;
            this.Add_ToPass.Text = "\"_\"";
            this.Add_ToPass.UseVisualStyleBackColor = true;
            this.Add_ToPass.Click += new System.EventHandler(this.Add_ToPass_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(202, 16);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(266, 31);
            this.mainLabel.TabIndex = 12;
            this.mainLabel.Text = "Пароль пока пустой";
            // 
            // CreatePassList_Btn
            // 
            this.CreatePassList_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CreatePassList_Btn.Location = new System.Drawing.Point(197, 239);
            this.CreatePassList_Btn.Name = "CreatePassList_Btn";
            this.CreatePassList_Btn.Size = new System.Drawing.Size(100, 44);
            this.CreatePassList_Btn.TabIndex = 13;
            this.CreatePassList_Btn.Text = "Создать лист паролей";
            this.CreatePassList_Btn.UseVisualStyleBackColor = false;
            this.CreatePassList_Btn.Click += new System.EventHandler(this.CreatePassList_Btn_Click);
            // 
            // ClearPass
            // 
            this.ClearPass.Location = new System.Drawing.Point(517, 96);
            this.ClearPass.Name = "ClearPass";
            this.ClearPass.Size = new System.Drawing.Size(86, 23);
            this.ClearPass.TabIndex = 14;
            this.ClearPass.Text = "Очистить";
            this.ClearPass.UseVisualStyleBackColor = true;
            this.ClearPass.Click += new System.EventHandler(this.ClearPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Колличество паролей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "шт.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Размер файла";
            // 
            // Calculate_Btn
            // 
            this.Calculate_Btn.Location = new System.Drawing.Point(615, 96);
            this.Calculate_Btn.Name = "Calculate_Btn";
            this.Calculate_Btn.Size = new System.Drawing.Size(86, 23);
            this.Calculate_Btn.TabIndex = 18;
            this.Calculate_Btn.Text = "Рассчитать";
            this.Calculate_Btn.UseVisualStyleBackColor = true;
            this.Calculate_Btn.Click += new System.EventHandler(this.Calculate_Btn_Click);
            // 
            // ClearCalc_Btn
            // 
            this.ClearCalc_Btn.Location = new System.Drawing.Point(707, 96);
            this.ClearCalc_Btn.Name = "ClearCalc_Btn";
            this.ClearCalc_Btn.Size = new System.Drawing.Size(86, 23);
            this.ClearCalc_Btn.TabIndex = 19;
            this.ClearCalc_Btn.Text = "Очистить";
            this.ClearCalc_Btn.UseMnemonic = false;
            this.ClearCalc_Btn.UseVisualStyleBackColor = true;
            this.ClearCalc_Btn.Click += new System.EventHandler(this.ClearCalc_Btn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(197, 178);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(543, 44);
            this.progressBar.TabIndex = 20;
            // 
            // Test_Btn
            // 
            this.Test_Btn.Location = new System.Drawing.Point(615, 250);
            this.Test_Btn.Name = "Test_Btn";
            this.Test_Btn.Size = new System.Drawing.Size(117, 33);
            this.Test_Btn.TabIndex = 21;
            this.Test_Btn.Text = "Тест";
            this.Test_Btn.UseVisualStyleBackColor = true;
            this.Test_Btn.Click += new System.EventHandler(this.Test_Btn_Click);
            // 
            // currentPassword_label
            // 
            this.currentPassword_label.AutoSize = true;
            this.currentPassword_label.Location = new System.Drawing.Point(194, 153);
            this.currentPassword_label.Name = "currentPassword_label";
            this.currentPassword_label.Size = new System.Drawing.Size(84, 13);
            this.currentPassword_label.TabIndex = 22;
            this.currentPassword_label.Text = "CurrenPassword";
            // 
            // StopCreating_Btn
            // 
            this.StopCreating_Btn.BackColor = System.Drawing.Color.Red;
            this.StopCreating_Btn.Enabled = false;
            this.StopCreating_Btn.Location = new System.Drawing.Point(316, 239);
            this.StopCreating_Btn.Name = "StopCreating_Btn";
            this.StopCreating_Btn.Size = new System.Drawing.Size(100, 44);
            this.StopCreating_Btn.TabIndex = 23;
            this.StopCreating_Btn.Text = "Стоп";
            this.StopCreating_Btn.UseVisualStyleBackColor = false;
            this.StopCreating_Btn.Click += new System.EventHandler(this.StopCreating_Btn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // DeleteLastPassContent_btn
            // 
            this.DeleteLastPassContent_btn.Location = new System.Drawing.Point(576, 24);
            this.DeleteLastPassContent_btn.Name = "DeleteLastPassContent_btn";
            this.DeleteLastPassContent_btn.Size = new System.Drawing.Size(29, 26);
            this.DeleteLastPassContent_btn.TabIndex = 24;
            this.DeleteLastPassContent_btn.Text = "<-";
            this.DeleteLastPassContent_btn.UseVisualStyleBackColor = true;
            this.DeleteLastPassContent_btn.Click += new System.EventHandler(this.DeleteLastPassContent_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.DeleteLastPassContent_btn);
            this.Controls.Add(this.StopCreating_Btn);
            this.Controls.Add(this.currentPassword_label);
            this.Controls.Add(this.Test_Btn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ClearCalc_Btn);
            this.Controls.Add(this.Calculate_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearPass);
            this.Controls.Add(this.CreatePassList_Btn);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.Add_ToPass);
            this.Controls.Add(this.AddYearToPass);
            this.Controls.Add(this.AddNumberToPass);
            this.Controls.Add(this.AddSmallLetterToPass);
            this.Controls.Add(this.AddBigLetterToPass);
            this.Controls.Add(this.AddLetterToPass);
            this.Controls.Add(this.AddNameToPass);
            this.Controls.Add(this.AddNewName_Btn);
            this.Controls.Add(this.AddNane_tBx);
            this.Controls.Add(this.LoadFileOfNames);
            this.Controls.Add(this.LoadDefaultFile);
            this.Controls.Add(this.ListBoxOfNames);
            this.Name = "MainForm";
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDefaultFile;
        private System.Windows.Forms.Button LoadFileOfNames;
        private System.Windows.Forms.TextBox AddNane_tBx;
        private System.Windows.Forms.Button AddNewName_Btn;
        private System.Windows.Forms.Button AddNameToPass;
        private System.Windows.Forms.Button AddLetterToPass;
        private System.Windows.Forms.Button AddBigLetterToPass;
        private System.Windows.Forms.Button AddSmallLetterToPass;
        private System.Windows.Forms.Button AddNumberToPass;
        private System.Windows.Forms.Button AddYearToPass;
        private System.Windows.Forms.Button Add_ToPass;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button CreatePassList_Btn;
        private System.Windows.Forms.Button ClearPass;
        public System.Windows.Forms.ListBox ListBoxOfNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate_Btn;
        private System.Windows.Forms.Button ClearCalc_Btn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Test_Btn;
        private System.Windows.Forms.Label currentPassword_label;
        private System.Windows.Forms.Button StopCreating_Btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteLastPassContent_btn;
    }
}

