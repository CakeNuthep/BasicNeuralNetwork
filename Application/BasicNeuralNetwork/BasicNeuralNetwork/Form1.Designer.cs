namespace BasicNeuralNetwork
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pathFile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_weight1 = new System.Windows.Forms.Label();
            this.label_weight2 = new System.Windows.Forms.Label();
            this.label_weight3 = new System.Windows.Forms.Label();
            this.textBox_predict = new System.Windows.Forms.TextBox();
            this.textBox_input3 = new System.Windows.Forms.TextBox();
            this.textBox_input2 = new System.Windows.Forms.TextBox();
            this.textBox_input1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numberOfIteration = new System.Windows.Forms.TextBox();
            this.button_predict = new System.Windows.Forms.Button();
            this.button_train = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.textBox_pathFile);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(505, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // textBox_pathFile
            // 
            this.textBox_pathFile.Location = new System.Drawing.Point(18, 22);
            this.textBox_pathFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_pathFile.Name = "textBox_pathFile";
            this.textBox_pathFile.Size = new System.Drawing.Size(392, 20);
            this.textBox_pathFile.TabIndex = 1;
            // 
            // button_browse
            // 
            this.button_browse.BackColor = System.Drawing.Color.PowderBlue;
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browse.Location = new System.Drawing.Point(428, 17);
            this.button_browse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(68, 28);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_numberOfIteration);
            this.groupBox2.Controls.Add(this.button_predict);
            this.groupBox2.Controls.Add(this.button_train);
            this.groupBox2.Location = new System.Drawing.Point(20, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(505, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BasicNeuralNetwork.Properties.Resources.BG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label_weight1);
            this.panel1.Controls.Add(this.label_weight2);
            this.panel1.Controls.Add(this.label_weight3);
            this.panel1.Controls.Add(this.textBox_predict);
            this.panel1.Controls.Add(this.textBox_input3);
            this.panel1.Controls.Add(this.textBox_input2);
            this.panel1.Controls.Add(this.textBox_input1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 222);
            this.panel1.TabIndex = 5;
            // 
            // label_weight1
            // 
            this.label_weight1.AutoSize = true;
            this.label_weight1.Location = new System.Drawing.Point(79, 106);
            this.label_weight1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_weight1.Name = "label_weight1";
            this.label_weight1.Size = new System.Drawing.Size(34, 13);
            this.label_weight1.TabIndex = 8;
            this.label_weight1.Text = "0.000";
            // 
            // label_weight2
            // 
            this.label_weight2.AutoSize = true;
            this.label_weight2.Location = new System.Drawing.Point(163, 106);
            this.label_weight2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_weight2.Name = "label_weight2";
            this.label_weight2.Size = new System.Drawing.Size(34, 13);
            this.label_weight2.TabIndex = 8;
            this.label_weight2.Text = "0.000";
            // 
            // label_weight3
            // 
            this.label_weight3.AutoSize = true;
            this.label_weight3.Location = new System.Drawing.Point(245, 106);
            this.label_weight3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_weight3.Name = "label_weight3";
            this.label_weight3.Size = new System.Drawing.Size(34, 13);
            this.label_weight3.TabIndex = 8;
            this.label_weight3.Text = "0.000";
            // 
            // textBox_predict
            // 
            this.textBox_predict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox_predict.Location = new System.Drawing.Point(174, 142);
            this.textBox_predict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_predict.Name = "textBox_predict";
            this.textBox_predict.Size = new System.Drawing.Size(26, 28);
            this.textBox_predict.TabIndex = 7;
            // 
            // textBox_input3
            // 
            this.textBox_input3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox_input3.Location = new System.Drawing.Point(259, 37);
            this.textBox_input3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_input3.Name = "textBox_input3";
            this.textBox_input3.Size = new System.Drawing.Size(26, 28);
            this.textBox_input3.TabIndex = 6;
            // 
            // textBox_input2
            // 
            this.textBox_input2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox_input2.Location = new System.Drawing.Point(172, 37);
            this.textBox_input2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_input2.Name = "textBox_input2";
            this.textBox_input2.Size = new System.Drawing.Size(26, 28);
            this.textBox_input2.TabIndex = 5;
            // 
            // textBox_input1
            // 
            this.textBox_input1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox_input1.Location = new System.Drawing.Point(80, 37);
            this.textBox_input1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_input1.Name = "textBox_input1";
            this.textBox_input1.Size = new System.Drawing.Size(26, 28);
            this.textBox_input1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(161, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(245, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(163, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(78, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of Iteration :";
            // 
            // textBox_numberOfIteration
            // 
            this.textBox_numberOfIteration.Location = new System.Drawing.Point(145, 33);
            this.textBox_numberOfIteration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_numberOfIteration.Name = "textBox_numberOfIteration";
            this.textBox_numberOfIteration.Size = new System.Drawing.Size(265, 20);
            this.textBox_numberOfIteration.TabIndex = 3;
            // 
            // button_predict
            // 
            this.button_predict.BackColor = System.Drawing.Color.PowderBlue;
            this.button_predict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_predict.Location = new System.Drawing.Point(428, 80);
            this.button_predict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_predict.Name = "button_predict";
            this.button_predict.Size = new System.Drawing.Size(68, 28);
            this.button_predict.TabIndex = 2;
            this.button_predict.Text = "Predict";
            this.button_predict.UseVisualStyleBackColor = false;
            this.button_predict.Click += new System.EventHandler(this.button_predict_Click);
            // 
            // button_train
            // 
            this.button_train.BackColor = System.Drawing.Color.PowderBlue;
            this.button_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_train.Location = new System.Drawing.Point(428, 28);
            this.button_train.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_train.Name = "button_train";
            this.button_train.Size = new System.Drawing.Size(68, 28);
            this.button_train.TabIndex = 1;
            this.button_train.Text = "Train";
            this.button_train.UseVisualStyleBackColor = false;
            this.button_train.Click += new System.EventHandler(this.button_train_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Basic Neural Network";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pathFile;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_predict;
        private System.Windows.Forms.TextBox textBox_input3;
        private System.Windows.Forms.TextBox textBox_input2;
        private System.Windows.Forms.TextBox textBox_input1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numberOfIteration;
        private System.Windows.Forms.Button button_predict;
        private System.Windows.Forms.Button button_train;
        private System.Windows.Forms.Label label_weight1;
        private System.Windows.Forms.Label label_weight2;
        private System.Windows.Forms.Label label_weight3;
    }
}

