
namespace Harjoitus11
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
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::Harjoitus11.Properties.Resources.dice01;
            this.Noppa01PB.Location = new System.Drawing.Point(12, 125);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(227, 188);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 0;
            this.Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Harjoitus11.Properties.Resources.dice01;
            this.Noppa02PB.Location = new System.Drawing.Point(274, 125);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(227, 188);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 1;
            this.Noppa02PB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(489, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Heitä";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nopan heitto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01PB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Noppa01PB;
        private System.Windows.Forms.PictureBox Noppa02PB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

