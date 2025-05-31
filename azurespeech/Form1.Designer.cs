namespace azurespeech
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnStartRecognition = new Button();
            txtRecognizedText = new TextBox();
            btnSpeak = new Button();
            txtInputText = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1463, 955);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtRecognizedText);
            tabPage1.Controls.Add(btnStartRecognition);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1447, 901);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Voz a texto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtInputText);
            tabPage2.Controls.Add(btnSpeak);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1447, 901);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Texto a voz";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStartRecognition
            // 
            btnStartRecognition.Location = new Point(502, 828);
            btnStartRecognition.Name = "btnStartRecognition";
            btnStartRecognition.Size = new Size(485, 46);
            btnStartRecognition.TabIndex = 0;
            btnStartRecognition.Text = "Iniciar Reconocimiento";
            btnStartRecognition.UseVisualStyleBackColor = true;
            btnStartRecognition.Click += btnStartRecognition_Click;
            // 
            // txtRecognizedText
            // 
            txtRecognizedText.Location = new Point(6, 6);
            txtRecognizedText.Multiline = true;
            txtRecognizedText.Name = "txtRecognizedText";
            txtRecognizedText.ReadOnly = true;
            txtRecognizedText.Size = new Size(1435, 797);
            txtRecognizedText.TabIndex = 1;
            txtRecognizedText.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSpeak
            // 
            btnSpeak.Location = new Point(485, 796);
            btnSpeak.Name = "btnSpeak";
            btnSpeak.Size = new Size(465, 54);
            btnSpeak.TabIndex = 0;
            btnSpeak.Text = "Hablar";
            btnSpeak.UseVisualStyleBackColor = true;
            btnSpeak.Click += btnSpeak_Click;
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(6, 6);
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(1435, 749);
            txtInputText.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 964);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Translate+";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtRecognizedText;
        private Button btnStartRecognition;
        private TextBox txtInputText;
        private Button btnSpeak;
    }
}
