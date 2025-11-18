namespace BPNN
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            CreateBpnn = new Button();
            TrainNeuralNet = new Button();
            Test = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(323, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // CreateBpnn
            // 
            CreateBpnn.Location = new Point(85, 301);
            CreateBpnn.Name = "CreateBpnn";
            CreateBpnn.Size = new Size(141, 54);
            CreateBpnn.TabIndex = 3;
            CreateBpnn.Text = "create BPNN";
            CreateBpnn.UseVisualStyleBackColor = true;
            CreateBpnn.Click += CreateBpnn_Click;
            // 
            // TrainNeuralNet
            // 
            TrainNeuralNet.Location = new Point(302, 301);
            TrainNeuralNet.Name = "TrainNeuralNet";
            TrainNeuralNet.Size = new Size(94, 54);
            TrainNeuralNet.TabIndex = 4;
            TrainNeuralNet.Text = "Train the Neural Net";
            TrainNeuralNet.UseVisualStyleBackColor = true;
            TrainNeuralNet.Click += TrainNeuralNet_Click;
            // 
            // Test
            // 
            Test.Location = new Point(478, 301);
            Test.Name = "Test";
            Test.Size = new Size(94, 54);
            Test.TabIndex = 5;
            Test.Text = "Test";
            Test.UseVisualStyleBackColor = true;
            Test.Click += Test_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 27);
            textBox5.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(Test);
            Controls.Add(TrainNeuralNet);
            Controls.Add(CreateBpnn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button CreateBpnn;
        private Button TrainNeuralNet;
        private Button Test;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
