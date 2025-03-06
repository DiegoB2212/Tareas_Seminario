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
            // 
            // Combo_Reponse
            // 
            this.Combo_Reponse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Combo_Reponse.Location = new System.Drawing.Point(25, 28);
            this.Combo_Reponse.Name = "Combo_Reponse";
            this.Combo_Reponse.Size = new System.Drawing.Size(547, 436);
            this.Combo_Reponse.TabIndex = 2;
            this.Combo_Reponse.TabStop = false;
            this.Combo_Reponse.Text = "Response";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_Input;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.GroupBox Combo_Reponse;
    }
}

