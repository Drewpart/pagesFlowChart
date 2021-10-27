
namespace pagesFlowChart
{
    partial class cornMazeBackground
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
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.Option2Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.BackColor = System.Drawing.Color.Transparent;
            this.option1Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.Black;
            this.option1Label.Location = new System.Drawing.Point(127, 215);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(99, 28);
            this.option1Label.TabIndex = 0;
            this.option1Label.Text = "Option1";
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.BackColor = System.Drawing.Color.Transparent;
            this.option2Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.Black;
            this.option2Label.Location = new System.Drawing.Point(127, 266);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(99, 28);
            this.option2Label.TabIndex = 1;
            this.option2Label.Text = "Option2";
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(5, 215);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 23);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // Option2Button
            // 
            this.Option2Button.Location = new System.Drawing.Point(5, 271);
            this.Option2Button.Name = "Option2Button";
            this.Option2Button.Size = new System.Drawing.Size(75, 23);
            this.Option2Button.TabIndex = 3;
            this.Option2Button.UseVisualStyleBackColor = true;
            this.Option2Button.Click += new System.EventHandler(this.Option2Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(0, -2);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(799, 114);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "You and your Best friend are Stuck in a Corn Maze";
            // 
            // imageBox
            // 
            this.imageBox.Image = global::pagesFlowChart.Properties.Resources.hubs_1829581167_9147f6f937_b;
            this.imageBox.Location = new System.Drawing.Point(486, 85);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(313, 315);
            this.imageBox.TabIndex = 5;
            this.imageBox.Text = "label1";
            // 
            // cornMazeBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.Option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Name = "cornMazeBackground";
            this.Text = "The Corn Maze";
            this.Load += new System.EventHandler(this.cornMazeBackground_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button Option2Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label imageBox;
    }
}

