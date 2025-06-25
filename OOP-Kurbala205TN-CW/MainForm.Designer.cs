namespace OOP_Kurbala205TN_CW
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NextPage = new Button();
            PreviousPage = new Button();
            Page = new Label();
            TextBox = new TextBox();
            SettingButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // NextPage
            // 
            NextPage.Location = new Point(476, 403);
            NextPage.Name = "NextPage";
            NextPage.Size = new Size(36, 35);
            NextPage.TabIndex = 0;
            NextPage.Text = ">";
            NextPage.UseVisualStyleBackColor = true;
            NextPage.Click += NextPage_Click;
            // 
            // PreviousPage
            // 
            PreviousPage.Location = new Point(293, 403);
            PreviousPage.Name = "PreviousPage";
            PreviousPage.Size = new Size(36, 35);
            PreviousPage.TabIndex = 1;
            PreviousPage.Text = "<";
            PreviousPage.UseVisualStyleBackColor = true;
            PreviousPage.Click += PreviousPage_Click;
            // 
            // Page
            // 
            Page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Page.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page.Location = new Point(335, 403);
            Page.Name = "Page";
            Page.Size = new Size(135, 35);
            Page.TabIndex = 2;
            Page.Text = "Сторінка 1";
            Page.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextBox.Location = new Point(12, 12);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(776, 388);
            TextBox.TabIndex = 3;
            
            // 
            // SettingButton
            // 
            SettingButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SettingButton.Location = new Point(12, 406);
            SettingButton.Name = "SettingButton";
            SettingButton.Size = new Size(253, 32);
            SettingButton.TabIndex = 4;
            SettingButton.Text = "Налаштування";
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += SettingButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(518, 406);
            button1.Name = "button1";
            button1.Size = new Size(253, 32);
            button1.TabIndex = 5;
            button1.Text = "Зберегти файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(SettingButton);
            Controls.Add(TextBox);
            Controls.Add(Page);
            Controls.Add(PreviousPage);
            Controls.Add(NextPage);
            Name = "Form1";
            Text = "Курбала 205-ТН ООП Курсова робота";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NextPage;
        private Button PreviousPage;
        private Label Page;
        private TextBox TextBox;
        private Button SettingButton;
        private Button button1;
    }
}
