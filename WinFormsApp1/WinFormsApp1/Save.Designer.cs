namespace WinFormsApp1
{
    partial class Save
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRno = new TextBox();
            txtName = new TextBox();
            txtYear = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(508, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 94);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Rno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 169);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 246);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 3;
            label3.Text = "Year";
            // 
            // txtRno
            // 
            txtRno.Location = new Point(372, 94);
            txtRno.Name = "txtRno";
            txtRno.Size = new Size(165, 27);
            txtRno.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(372, 166);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 27);
            txtName.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(372, 246);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(165, 27);
            txtYear.TabIndex = 6;
            // 
            // Save
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtYear);
            Controls.Add(txtName);
            Controls.Add(txtRno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Save";
            Text = "Save";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRno;
        private TextBox txtName;
        private TextBox txtYear;
    }
}