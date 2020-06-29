namespace KGEU.CourseWork
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxFirstAnswer = new System.Windows.Forms.TextBox();
            this.textBoxSecondAnswer = new System.Windows.Forms.TextBox();
            this.textBoxThirdAnswer = new System.Windows.Forms.TextBox();
            this.richTextBoxExample = new System.Windows.Forms.RichTextBox();
            this.buttonToAnswer = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // taskDescription
            // 
            this.taskDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.taskDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescription.Location = new System.Drawing.Point(11, 35);
            this.taskDescription.MaxLength = 5000;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(779, 185);
            this.taskDescription.TabIndex = 1;
            this.taskDescription.Text = "";
            // 
            // textBoxFirstAnswer
            // 
            this.textBoxFirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstAnswer.Location = new System.Drawing.Point(11, 245);
            this.textBoxFirstAnswer.Name = "textBoxFirstAnswer";
            this.textBoxFirstAnswer.Size = new System.Drawing.Size(127, 29);
            this.textBoxFirstAnswer.TabIndex = 2;
            // 
            // textBoxSecondAnswer
            // 
            this.textBoxSecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondAnswer.Location = new System.Drawing.Point(11, 280);
            this.textBoxSecondAnswer.Name = "textBoxSecondAnswer";
            this.textBoxSecondAnswer.Size = new System.Drawing.Size(127, 29);
            this.textBoxSecondAnswer.TabIndex = 3;
            // 
            // textBoxThirdAnswer
            // 
            this.textBoxThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxThirdAnswer.Location = new System.Drawing.Point(12, 315);
            this.textBoxThirdAnswer.Name = "textBoxThirdAnswer";
            this.textBoxThirdAnswer.Size = new System.Drawing.Size(127, 29);
            this.textBoxThirdAnswer.TabIndex = 4;
            // 
            // richTextBoxExample
            // 
            this.richTextBoxExample.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxExample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxExample.Location = new System.Drawing.Point(144, 245);
            this.richTextBoxExample.Name = "richTextBoxExample";
            this.richTextBoxExample.Size = new System.Drawing.Size(599, 147);
            this.richTextBoxExample.TabIndex = 5;
            this.richTextBoxExample.Text = "";
            // 
            // buttonToAnswer
            // 
            this.buttonToAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToAnswer.Location = new System.Drawing.Point(675, 9);
            this.buttonToAnswer.Name = "buttonToAnswer";
            this.buttonToAnswer.Size = new System.Drawing.Size(115, 40);
            this.buttonToAnswer.TabIndex = 6;
            this.buttonToAnswer.Text = "Ответить";
            this.buttonToAnswer.UseVisualStyleBackColor = true;
            this.buttonToAnswer.Click += new System.EventHandler(this.buttonToAnswer_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(547, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 40);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.Location = new System.Drawing.Point(11, 231);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(379, 78);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.Location = new System.Drawing.Point(11, 315);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(379, 77);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.Location = new System.Drawing.Point(425, 245);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(365, 64);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton4.Location = new System.Drawing.Point(428, 315);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(362, 77);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonToAnswer);
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 62);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.richTextBoxExample);
            this.Controls.Add(this.textBoxThirdAnswer);
            this.Controls.Add(this.textBoxSecondAnswer);
            this.Controls.Add(this.textBoxFirstAnswer);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.RichTextBox taskDescription;
        private System.Windows.Forms.TextBox textBoxFirstAnswer;
        private System.Windows.Forms.TextBox textBoxSecondAnswer;
        private System.Windows.Forms.TextBox textBoxThirdAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxExample;
        private System.Windows.Forms.Button buttonToAnswer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
    }
}

