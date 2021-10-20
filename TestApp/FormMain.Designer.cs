
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
            this.buttonFillListBox = new System.Windows.Forms.Button();
            this.buttonPickFromListBox = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.buttonTest.Text = "тест";
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

