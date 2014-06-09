namespace QuienQuiereSerAprobado
{
    partial class frmPreguntas
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
            this.btnRespuesta1 = new System.Windows.Forms.Button();
            this.btnRespuesta2 = new System.Windows.Forms.Button();
            this.btnRespuesta3 = new System.Windows.Forms.Button();
            this.btnRespuesta4 = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRespuesta1
            // 
            this.btnRespuesta1.BackColor = System.Drawing.Color.Transparent;
            this.btnRespuesta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuesta1.Location = new System.Drawing.Point(32, 221);
            this.btnRespuesta1.Name = "btnRespuesta1";
            this.btnRespuesta1.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta1.TabIndex = 0;
            this.btnRespuesta1.Text = "Respuesta1";
            this.btnRespuesta1.UseVisualStyleBackColor = false;
            // 
            // btnRespuesta2
            // 
            this.btnRespuesta2.Location = new System.Drawing.Point(32, 250);
            this.btnRespuesta2.Name = "btnRespuesta2";
            this.btnRespuesta2.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta2.TabIndex = 1;
            this.btnRespuesta2.Text = "Respuesta2";
            this.btnRespuesta2.UseVisualStyleBackColor = true;
            // 
            // btnRespuesta3
            // 
            this.btnRespuesta3.Location = new System.Drawing.Point(32, 279);
            this.btnRespuesta3.Name = "btnRespuesta3";
            this.btnRespuesta3.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta3.TabIndex = 2;
            this.btnRespuesta3.Text = "Respuesta3";
            this.btnRespuesta3.UseVisualStyleBackColor = true;
            // 
            // btnRespuesta4
            // 
            this.btnRespuesta4.Location = new System.Drawing.Point(32, 308);
            this.btnRespuesta4.Name = "btnRespuesta4";
            this.btnRespuesta4.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta4.TabIndex = 3;
            this.btnRespuesta4.Text = "Respuesta4";
            this.btnRespuesta4.UseVisualStyleBackColor = true;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(43, 92);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(50, 13);
            this.lblPregunta.TabIndex = 4;
            this.lblPregunta.Text = "Pregunta";
            // 
            // frmPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 402);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnRespuesta4);
            this.Controls.Add(this.btnRespuesta3);
            this.Controls.Add(this.btnRespuesta2);
            this.Controls.Add(this.btnRespuesta1);
            this.Name = "frmPreguntas";
            this.Text = "frmPreguntas";
            this.Load += new System.EventHandler(this.frmPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRespuesta1;
        private System.Windows.Forms.Button btnRespuesta2;
        private System.Windows.Forms.Button btnRespuesta3;
        private System.Windows.Forms.Button btnRespuesta4;
        private System.Windows.Forms.Label lblPregunta;

    }
}