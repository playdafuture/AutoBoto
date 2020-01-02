namespace AutoBoto
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Delay_Init = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Delay_Runs = new System.Windows.Forms.TextBox();
            this.TB_Repeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Advanced = new System.Windows.Forms.Button();
            this.TB_Delay_Keys = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Start.Location = new System.Drawing.Point(11, 291);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(217, 49);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Delay";
            // 
            // TB_Delay_Init
            // 
            this.TB_Delay_Init.Location = new System.Drawing.Point(111, 5);
            this.TB_Delay_Init.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Delay_Init.Name = "TB_Delay_Init";
            this.TB_Delay_Init.Size = new System.Drawing.Size(117, 20);
            this.TB_Delay_Init.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Between Runs";
            // 
            // TB_Delay_Runs
            // 
            this.TB_Delay_Runs.Location = new System.Drawing.Point(110, 53);
            this.TB_Delay_Runs.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Delay_Runs.Name = "TB_Delay_Runs";
            this.TB_Delay_Runs.Size = new System.Drawing.Size(118, 20);
            this.TB_Delay_Runs.TabIndex = 4;
            // 
            // TB_Repeats
            // 
            this.TB_Repeats.Location = new System.Drawing.Point(111, 77);
            this.TB_Repeats.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Repeats.Name = "TB_Repeats";
            this.TB_Repeats.Size = new System.Drawing.Size(117, 20);
            this.TB_Repeats.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Repeats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keystroke Sequence";
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(11, 132);
            this.TB_Input.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Input.Multiline = true;
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(217, 151);
            this.TB_Input.TabIndex = 8;
            // 
            // BTN_Advanced
            // 
            this.BTN_Advanced.Location = new System.Drawing.Point(160, 108);
            this.BTN_Advanced.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Advanced.Name = "BTN_Advanced";
            this.BTN_Advanced.Size = new System.Drawing.Size(68, 19);
            this.BTN_Advanced.TabIndex = 9;
            this.BTN_Advanced.Text = "Advanced";
            this.BTN_Advanced.UseVisualStyleBackColor = true;
            this.BTN_Advanced.Click += new System.EventHandler(this.BTN_Advanced_Click);
            // 
            // TB_Delay_Keys
            // 
            this.TB_Delay_Keys.Location = new System.Drawing.Point(110, 29);
            this.TB_Delay_Keys.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Delay_Keys.Name = "TB_Delay_Keys";
            this.TB_Delay_Keys.Size = new System.Drawing.Size(118, 20);
            this.TB_Delay_Keys.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Between Keys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Delay_Keys);
            this.Controls.Add(this.BTN_Advanced);
            this.Controls.Add(this.TB_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Repeats);
            this.Controls.Add(this.TB_Delay_Runs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Delay_Init);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AulutuluBoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Delay_Init;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Delay_Runs;
        private System.Windows.Forms.TextBox TB_Repeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Advanced;
        private System.Windows.Forms.TextBox TB_Delay_Keys;
        private System.Windows.Forms.Label label5;
    }
}

