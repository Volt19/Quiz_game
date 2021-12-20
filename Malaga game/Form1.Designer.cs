
namespace Malaga_game
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
            this.label1 = new System.Windows.Forms.Label();
            this.custom_button_11 = new Malaga_game.CustomButton.Custom_button_1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(118, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Learning to end hunger";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // custom_button_11
            // 
            this.custom_button_11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custom_button_11.BackColor = System.Drawing.Color.Transparent;
            this.custom_button_11.BackgroundColor = System.Drawing.Color.Transparent;
            this.custom_button_11.BorderColor = System.Drawing.Color.Aquamarine;
            this.custom_button_11.BorderRadius = 20;
            this.custom_button_11.BorderSize = 0;
            this.custom_button_11.FlatAppearance.BorderSize = 0;
            this.custom_button_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_button_11.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.custom_button_11.ForeColor = System.Drawing.Color.Black;
            this.custom_button_11.Location = new System.Drawing.Point(295, 203);
            this.custom_button_11.Name = "custom_button_11";
            this.custom_button_11.Size = new System.Drawing.Size(130, 57);
            this.custom_button_11.TabIndex = 1;
            this.custom_button_11.Text = "Play";
            this.custom_button_11.TextColor = System.Drawing.Color.Black;
            this.custom_button_11.UseVisualStyleBackColor = false;
            this.custom_button_11.Click += new System.EventHandler(this.custom_button_11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Malaga_game.Properties.Resources.depositphotos_67982999_stock_illustration_horizontally_seamless_game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custom_button_11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(742, 449);
            this.MinimumSize = new System.Drawing.Size(742, 449);
            this.Name = "Form1";
            this.Text = "Learning to end hunger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton.Custom_button_1 custom_button_11;
        private System.Windows.Forms.Label label1;
    }
}

