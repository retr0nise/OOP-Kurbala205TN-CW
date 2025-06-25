namespace OOP_Kurbala205TN_CW
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LineBox = new TextBox();
            ColumnsBox = new TextBox();
            PathBox = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SavingBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(57, 30);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Кількість Рядків";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(57, 76);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 1;
            label2.Text = "Кількість Стовпців";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(57, 117);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 2;
            label3.Text = "Шлях до файлу";
            // 
            // LineBox
            // 
            LineBox.Location = new Point(251, 32);
            LineBox.Name = "LineBox";
            LineBox.Size = new Size(56, 23);
            LineBox.TabIndex = 3;
            LineBox.Text = mainForm.getParam(2);
            // 
            // ColumnsBox
            // 
            ColumnsBox.Location = new Point(251, 81);
            ColumnsBox.Name = "ColumnsBox";
            ColumnsBox.Size = new Size(56, 23);
            ColumnsBox.TabIndex = 4;
            ColumnsBox.Text = mainForm.getParam(3);

            // 
            // PathBox
            // 
            PathBox.Location = new Point(251, 122);
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(245, 23);
            PathBox.TabIndex = 5;
            PathBox.Text = mainForm.getParam(0);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 191);
            button1.Name = "button1";
            button1.Size = new Size(564, 56);
            button1.TabIndex = 6;
            button1.Text = "Зберегти налаштування";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(57, 163);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 7;
            label4.Text = "Шлях Збереження";
            // 
            // SavingBox
            // 
            SavingBox.Location = new Point(251, 162);
            SavingBox.Name = "SavingBox";
            SavingBox.Size = new Size(245, 23);
            SavingBox.TabIndex = 8;
            SavingBox.Text = mainForm.getParam(1); 
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 259);
            Controls.Add(SavingBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(PathBox);
            Controls.Add(ColumnsBox);
            Controls.Add(LineBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SettingForm";
            Text = "Налаштування";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LineBox;
        private TextBox ColumnsBox;
        private TextBox PathBox;
        private Button button1;
        private Label label4;
        private TextBox SavingBox;
    }
}
