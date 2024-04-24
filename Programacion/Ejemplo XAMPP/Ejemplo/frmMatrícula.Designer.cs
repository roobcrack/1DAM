namespace Ejemplo
{
    partial class frmMatrícula
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
            listView1 = new ListView();
            listView2 = new ListView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(44, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(379, 271);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(458, 63);
            listView2.Name = "listView2";
            listView2.Size = new Size(377, 271);
            listView2.TabIndex = 25;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(458, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(595, 31);
            button1.Name = "button1";
            button1.Size = new Size(119, 26);
            button1.TabIndex = 28;
            button1.Text = "Matricular Alumno";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(730, 31);
            button2.Name = "button2";
            button2.Size = new Size(140, 26);
            button2.TabIndex = 29;
            button2.Text = "Desmatricular Alumno";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(458, 361);
            button3.Name = "button3";
            button3.Size = new Size(181, 52);
            button3.TabIndex = 30;
            button3.Text = "Ver cursos del alumno";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(242, 361);
            button4.Name = "button4";
            button4.Size = new Size(181, 52);
            button4.TabIndex = 31;
            button4.Text = "Ver alumnos del curso";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(44, 361);
            button5.Name = "button5";
            button5.Size = new Size(181, 52);
            button5.TabIndex = 32;
            button5.Text = "Ver todos";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(654, 361);
            button6.Name = "button6";
            button6.Size = new Size(181, 52);
            button6.TabIndex = 33;
            button6.Text = "Ver todos";
            button6.UseVisualStyleBackColor = true;
            // 
            // frmMatrícula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "frmMatrícula";
            Text = "frmMatrícula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}