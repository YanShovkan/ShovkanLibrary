
namespace TestApp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.universityTextBox = new VisualComponents.UniversityTextBox();
            this.universityComboBox = new VisualComponents.UniversityComboBox();
            this.universityListBox = new VisualComponents.UniversityListBox();
            this.buttonFillListBox = new System.Windows.Forms.Button();
            this.buttonPickFromListBox = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // universityTextBox
            // 
            this.universityTextBox.example = "shovkan@mail.ru";
            this.universityTextBox.Location = new System.Drawing.Point(146, 13);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.sample = "^[A-Za-z0-9]+(?:[._%+-])?[A-Za-z0-9._-]+[A-Za-z0-9]@[A-Za-z0-9]+(?:[.-])?[A-Za-z0" +
    "-9._-]+\\.[A-Za-z]{2,6}$";
            this.universityTextBox.Size = new System.Drawing.Size(150, 27);
            this.universityTextBox.TabIndex = 4;
            this.universityTextBox.value = null;
            // 
            // universityComboBox
            // 
            this.universityComboBox.item = null;
            this.universityComboBox.Location = new System.Drawing.Point(12, 12);
            this.universityComboBox.Name = "universityComboBox";
            this.universityComboBox.Size = new System.Drawing.Size(128, 28);
            this.universityComboBox.TabIndex = 3;
            // 
            // universityListBox
            // 
            this.universityListBox.index = -1;
            this.universityListBox.Location = new System.Drawing.Point(12, 202);
            this.universityListBox.Name = "universityListBox";
            this.universityListBox.Size = new System.Drawing.Size(389, 207);
            this.universityListBox.TabIndex = 5;
            // 
            // buttonFillListBox
            // 
            this.buttonFillListBox.Location = new System.Drawing.Point(12, 415);
            this.buttonFillListBox.Name = "buttonFillListBox";
            this.buttonFillListBox.Size = new System.Drawing.Size(182, 23);
            this.buttonFillListBox.TabIndex = 6;
            this.buttonFillListBox.Text = "Заполнить ";
            this.buttonFillListBox.UseVisualStyleBackColor = true;
            this.buttonFillListBox.Click += new System.EventHandler(this.buttonFillListBox_Click);
            // 
            // buttonPickFromListBox
            // 
            this.buttonPickFromListBox.Location = new System.Drawing.Point(219, 415);
            this.buttonPickFromListBox.Name = "buttonPickFromListBox";
            this.buttonPickFromListBox.Size = new System.Drawing.Size(182, 23);
            this.buttonPickFromListBox.TabIndex = 7;
            this.buttonPickFromListBox.Text = "Взять";
            this.buttonPickFromListBox.UseVisualStyleBackColor = true;
            this.buttonPickFromListBox.Click += new System.EventHandler(this.buttonPickFromListBox_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(408, 202);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(380, 236);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.Text = "Бэбра";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonPickFromListBox);
            this.Controls.Add(this.buttonFillListBox);
            this.Controls.Add(this.universityListBox);
            this.Controls.Add(this.universityTextBox);
            this.Controls.Add(this.universityComboBox);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion
        private VisualComponents.UniversityComboBox universityComboBox;
        private VisualComponents.UniversityTextBox universityTextBox;
        private VisualComponents.UniversityListBox universityListBox;
        private System.Windows.Forms.Button buttonFillListBox;
        private System.Windows.Forms.Button buttonPickFromListBox;
        private System.Windows.Forms.Button buttonTest;
    }
}

