
namespace PooCartas.Windows
{
    partial class FrmCarta
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
            this.label1 = new System.Windows.Forms.Label();
            this.CartasComboBox = new System.Windows.Forms.ComboBox();
            this.CartaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Carta:";
            // 
            // CartasComboBox
            // 
            this.CartasComboBox.FormattingEnabled = true;
            this.CartasComboBox.Location = new System.Drawing.Point(141, 28);
            this.CartasComboBox.Name = "CartasComboBox";
            this.CartasComboBox.Size = new System.Drawing.Size(211, 21);
            this.CartasComboBox.TabIndex = 1;
            this.CartasComboBox.SelectedIndexChanged += new System.EventHandler(this.CartasComboBox_SelectedIndexChanged);
            // 
            // CartaPictureBox
            // 
            this.CartaPictureBox.Location = new System.Drawing.Point(49, 72);
            this.CartaPictureBox.Name = "CartaPictureBox";
            this.CartaPictureBox.Size = new System.Drawing.Size(302, 437);
            this.CartaPictureBox.TabIndex = 2;
            this.CartaPictureBox.TabStop = false;
            // 
            // FrmCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.CartaPictureBox);
            this.Controls.Add(this.CartasComboBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmCarta";
            this.Text = "FrmCarta";
            this.Load += new System.EventHandler(this.FrmCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CartasComboBox;
        private System.Windows.Forms.PictureBox CartaPictureBox;
    }
}