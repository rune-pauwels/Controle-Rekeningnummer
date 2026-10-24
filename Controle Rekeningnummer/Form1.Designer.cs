namespace Controle_Rekeningnummer
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
            label1 = new Label();
            label2 = new Label();
            IBANTextBox = new TextBox();
            JuistOfFoutLabel = new Label();
            ControleerButton = new Button();
            ZetOmButton = new Button();
            OudeNotatieTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 0;
            label1.Text = "Controle IBAN nummer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(200, 15);
            label2.TabIndex = 1;
            label2.Text = "Geef een IBAN rekeningnummer in...";
            // 
            // IBANTextBox
            // 
            IBANTextBox.Location = new Point(12, 57);
            IBANTextBox.Name = "IBANTextBox";
            IBANTextBox.Size = new Size(238, 23);
            IBANTextBox.TabIndex = 2;
            // 
            // JuistOfFoutLabel
            // 
            JuistOfFoutLabel.AutoSize = true;
            JuistOfFoutLabel.Location = new Point(186, 90);
            JuistOfFoutLabel.Name = "JuistOfFoutLabel";
            JuistOfFoutLabel.Size = new Size(12, 15);
            JuistOfFoutLabel.TabIndex = 3;
            JuistOfFoutLabel.Text = "?";
            // 
            // ControleerButton
            // 
            ControleerButton.Location = new Point(12, 86);
            ControleerButton.Name = "ControleerButton";
            ControleerButton.Size = new Size(158, 23);
            ControleerButton.TabIndex = 4;
            ControleerButton.Text = "Controleer IBAN nummer";
            ControleerButton.UseVisualStyleBackColor = true;
            ControleerButton.Click += button1_Click;
            // 
            // ZetOmButton
            // 
            ZetOmButton.Location = new Point(12, 128);
            ZetOmButton.Name = "ZetOmButton";
            ZetOmButton.Size = new Size(238, 23);
            ZetOmButton.TabIndex = 5;
            ZetOmButton.Text = "Zet om naar 'oude' notatie";
            ZetOmButton.UseVisualStyleBackColor = true;
            ZetOmButton.Click += button2_Click;
            // 
            // OudeNotatieTextBox
            // 
            OudeNotatieTextBox.Location = new Point(12, 157);
            OudeNotatieTextBox.Name = "OudeNotatieTextBox";
            OudeNotatieTextBox.Size = new Size(238, 23);
            OudeNotatieTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 197);
            Controls.Add(OudeNotatieTextBox);
            Controls.Add(ZetOmButton);
            Controls.Add(ControleerButton);
            Controls.Add(JuistOfFoutLabel);
            Controls.Add(IBANTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IBANTextBox;
        private Label JuistOfFoutLabel;
        private Button ControleerButton;
        private Button ZetOmButton;
        private TextBox OudeNotatieTextBox;
    }
}
