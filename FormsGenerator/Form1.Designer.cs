namespace FormsGenerator
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
            this.StlLabel = new System.Windows.Forms.Label();
            this.StlTextBox = new System.Windows.Forms.TextBox();
            this.GenerateGCode_button = new System.Windows.Forms.Button();
            this.gCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StlLabel
            // 
            this.StlLabel.AutoSize = true;
            this.StlLabel.Location = new System.Drawing.Point(13, 13);
            this.StlLabel.Name = "StlLabel";
            this.StlLabel.Size = new System.Drawing.Size(49, 13);
            this.StlLabel.TabIndex = 0;
            this.StlLabel.Text = "STL File:";
            // 
            // StlTextBox
            // 
            this.StlTextBox.Location = new System.Drawing.Point(68, 10);
            this.StlTextBox.Name = "StlTextBox";
            this.StlTextBox.Size = new System.Drawing.Size(100, 20);
            this.StlTextBox.TabIndex = 1;
            // 
            // GenerateGCode_button
            // 
            this.GenerateGCode_button.Location = new System.Drawing.Point(174, 8);
            this.GenerateGCode_button.Name = "GenerateGCode_button";
            this.GenerateGCode_button.Size = new System.Drawing.Size(106, 23);
            this.GenerateGCode_button.TabIndex = 2;
            this.GenerateGCode_button.Text = "Generate GCode";
            this.GenerateGCode_button.UseVisualStyleBackColor = true;
            this.GenerateGCode_button.Click += new System.EventHandler(this.GenerateGCode_button_Click);
            // 
            // gCodeTextBox
            // 
            this.gCodeTextBox.Location = new System.Drawing.Point(16, 36);
            this.gCodeTextBox.Multiline = true;
            this.gCodeTextBox.Name = "gCodeTextBox";
            this.gCodeTextBox.Size = new System.Drawing.Size(264, 225);
            this.gCodeTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.gCodeTextBox);
            this.Controls.Add(this.GenerateGCode_button);
            this.Controls.Add(this.StlTextBox);
            this.Controls.Add(this.StlLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StlLabel;
        private System.Windows.Forms.TextBox StlTextBox;
        private System.Windows.Forms.Button GenerateGCode_button;
        private System.Windows.Forms.TextBox gCodeTextBox;
    }
}

