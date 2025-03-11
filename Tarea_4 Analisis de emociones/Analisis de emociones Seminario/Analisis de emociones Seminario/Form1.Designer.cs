namespace Analisis_de_emociones_Seminario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Message_Input = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Combo_Reponse = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Combo_Reponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Message_Input
            // 
            this.Message_Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Message_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Input.Location = new System.Drawing.Point(25, 489);
            this.Message_Input.Multiline = true;
            this.Message_Input.Name = "Message_Input";
            this.Message_Input.Size = new System.Drawing.Size(547, 92);
            this.Message_Input.TabIndex = 0;
            this.Message_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Message_Input_KeyPress);
            // 
            // Send_Button
            // 
            this.Send_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Button.Location = new System.Drawing.Point(228, 602);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(147, 71);
            this.Send_Button.TabIndex = 1;
            this.Send_Button.Text = "SEND";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Combo_Reponse
            // 
            this.Combo_Reponse.Controls.Add(this.pictureBox1);
            this.Combo_Reponse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Combo_Reponse.Location = new System.Drawing.Point(25, 28);
            this.Combo_Reponse.Name = "Combo_Reponse";
            this.Combo_Reponse.Size = new System.Drawing.Size(547, 436);
            this.Combo_Reponse.TabIndex = 2;
            this.Combo_Reponse.TabStop = false;
            this.Combo_Reponse.Text = "Response";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Analisis_de_emociones_Seminario.Properties.Resources.neutral;
            this.pictureBox1.Location = new System.Drawing.Point(57, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 708);
            this.Controls.Add(this.Combo_Reponse);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Message_Input);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis de emociones";
            this.Combo_Reponse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_Input;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.GroupBox Combo_Reponse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

