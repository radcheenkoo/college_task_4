namespace Task4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_message = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_Execute = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_info_about_sides = new System.Windows.Forms.TextBox();
            this.textBox_info_about_sides_numb = new System.Windows.Forms.TextBox();
            this.label_equal = new System.Windows.Forms.Label();
            this.pictureBox_triangel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_triangel)).BeginInit();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_message.Location = new System.Drawing.Point(329, 37);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(405, 31);
            this.label_message.TabIndex = 0;
            this.label_message.Text = "Введіть сторини трикутника a,b,c:";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_A.Location = new System.Drawing.Point(400, 99);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(39, 31);
            this.label_A.TabIndex = 1;
            this.label_A.Text = "A:";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_B.Location = new System.Drawing.Point(400, 152);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(38, 31);
            this.label_B.TabIndex = 2;
            this.label_B.Text = "B:";
            this.label_B.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_C.Location = new System.Drawing.Point(400, 201);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(38, 31);
            this.label_C.TabIndex = 3;
            this.label_C.Text = "C:";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(464, 107);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 23);
            this.textBox_A.TabIndex = 4;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(464, 160);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 23);
            this.textBox_B.TabIndex = 5;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(464, 209);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 23);
            this.textBox_C.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат:";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(486, 360);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(226, 23);
            this.textBox_result.TabIndex = 8;
            // 
            // button_Execute
            // 
            this.button_Execute.Location = new System.Drawing.Point(431, 415);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(75, 23);
            this.button_Execute.TabIndex = 9;
            this.button_Execute.Text = "execute";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // button_info
            // 
            this.button_info.Location = new System.Drawing.Point(551, 415);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(75, 23);
            this.button_info.TabIndex = 10;
            this.button_info.Text = "about App";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(678, 415);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_info_about_sides
            // 
            this.textBox_info_about_sides.Location = new System.Drawing.Point(400, 290);
            this.textBox_info_about_sides.Name = "textBox_info_about_sides";
            this.textBox_info_about_sides.ReadOnly = true;
            this.textBox_info_about_sides.Size = new System.Drawing.Size(100, 23);
            this.textBox_info_about_sides.TabIndex = 12;
            // 
            // textBox_info_about_sides_numb
            // 
            this.textBox_info_about_sides_numb.Location = new System.Drawing.Point(567, 290);
            this.textBox_info_about_sides_numb.Name = "textBox_info_about_sides_numb";
            this.textBox_info_about_sides_numb.ReadOnly = true;
            this.textBox_info_about_sides_numb.Size = new System.Drawing.Size(59, 23);
            this.textBox_info_about_sides_numb.TabIndex = 13;
            // 
            // label_equal
            // 
            this.label_equal.AutoSize = true;
            this.label_equal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_equal.Location = new System.Drawing.Point(516, 290);
            this.label_equal.Name = "label_equal";
            this.label_equal.Size = new System.Drawing.Size(25, 25);
            this.label_equal.TabIndex = 14;
            this.label_equal.Text = "=";
            // 
            // pictureBox_triangel
            // 
            this.pictureBox_triangel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_triangel.Image")));
            this.pictureBox_triangel.Location = new System.Drawing.Point(76, 99);
            this.pictureBox_triangel.Name = "pictureBox_triangel";
            this.pictureBox_triangel.Size = new System.Drawing.Size(211, 239);
            this.pictureBox_triangel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_triangel.TabIndex = 15;
            this.pictureBox_triangel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_triangel);
            this.Controls.Add(this.label_equal);
            this.Controls.Add(this.textBox_info_about_sides_numb);
            this.Controls.Add(this.textBox_info_about_sides);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_message);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_triangel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_message;
        private Label label_A;
        private Label label_B;
        private Label label_C;
        private TextBox textBox_A;
        private TextBox textBox_B;
        private TextBox textBox_C;
        private Label label1;
        private TextBox textBox_result;
        private Button button_Execute;
        private Button button_info;
        private Button button_close;
        private TextBox textBox_info_about_sides;
        private TextBox textBox_info_about_sides_numb;
        private Label label_equal;
        private PictureBox pictureBox_triangel;




    }
}