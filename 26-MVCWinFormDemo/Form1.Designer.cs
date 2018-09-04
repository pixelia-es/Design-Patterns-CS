namespace _26_MVCWinFormDemo
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addStudentTextBox = new System.Windows.Forms.TextBox();
            this.showStudentsListView = new System.Windows.Forms.ListView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Sample MVC Winform Application Demo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add a student";
            // 
            // addStudentTextBox
            // 
            this.addStudentTextBox.Location = new System.Drawing.Point(43, 127);
            this.addStudentTextBox.Name = "addStudentTextBox";
            this.addStudentTextBox.Size = new System.Drawing.Size(141, 20);
            this.addStudentTextBox.TabIndex = 2;
            // 
            // showStudentsListView
            // 
            this.showStudentsListView.Location = new System.Drawing.Point(276, 127);
            this.showStudentsListView.Name = "showStudentsListView";
            this.showStudentsListView.Size = new System.Drawing.Size(121, 237);
            this.showStudentsListView.TabIndex = 6;
            this.showStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(43, 194);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(126, 36);
            this.addStudentButton.TabIndex = 7;
            this.addStudentButton.Text = "Add a student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(43, 255);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(126, 39);
            this.removeStudentButton.TabIndex = 8;
            this.removeStudentButton.Text = "Remove Selected Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(43, 316);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.showStudentsListView);
            this.Controls.Add(this.addStudentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addStudentTextBox;
        private System.Windows.Forms.ListView showStudentsListView;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button exitButton;
    }
}

