
namespace WhileLoopsPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.startingLabel = new System.Windows.Forms.Label();
            this.endingLabel = new System.Windows.Forms.Label();
            this.startValueInput = new System.Windows.Forms.TextBox();
            this.endValueInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.valuesOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(236, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(479, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fun With Loops!";
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingLabel.Location = new System.Drawing.Point(121, 162);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(379, 39);
            this.startingLabel.TabIndex = 1;
            this.startingLabel.Text = "Enter a starting number:";
            // 
            // endingLabel
            // 
            this.endingLabel.AutoSize = true;
            this.endingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingLabel.Location = new System.Drawing.Point(121, 241);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(390, 39);
            this.endingLabel.TabIndex = 2;
            this.endingLabel.Text = "Enter an ending number:";
            // 
            // startValueInput
            // 
            this.startValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startValueInput.Location = new System.Drawing.Point(570, 159);
            this.startValueInput.Name = "startValueInput";
            this.startValueInput.Size = new System.Drawing.Size(224, 45);
            this.startValueInput.TabIndex = 3;
            // 
            // endValueInput
            // 
            this.endValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endValueInput.Location = new System.Drawing.Point(570, 238);
            this.endValueInput.Name = "endValueInput";
            this.endValueInput.Size = new System.Drawing.Size(224, 45);
            this.endValueInput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valuesOutput
            // 
            this.valuesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesOutput.ForeColor = System.Drawing.Color.Red;
            this.valuesOutput.Location = new System.Drawing.Point(173, 409);
            this.valuesOutput.Name = "valuesOutput";
            this.valuesOutput.Size = new System.Drawing.Size(583, 127);
            this.valuesOutput.TabIndex = 6;
            this.valuesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 651);
            this.Controls.Add(this.valuesOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endValueInput);
            this.Controls.Add(this.startValueInput);
            this.Controls.Add(this.endingLabel);
            this.Controls.Add(this.startingLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "While Loops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startingLabel;
        private System.Windows.Forms.Label endingLabel;
        private System.Windows.Forms.TextBox startValueInput;
        private System.Windows.Forms.TextBox endValueInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label valuesOutput;
    }
}

