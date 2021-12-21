namespace RadioButton
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
            this.gbVrstaPrijevoza = new System.Windows.Forms.GroupBox();
            this.rbAvion = new System.Windows.Forms.RadioButton();
            this.rbAutobus = new System.Windows.Forms.RadioButton();
            this.rbVlastiti = new System.Windows.Forms.RadioButton();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbVrstaPrijevoza.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVrstaPrijevoza
            // 
            this.gbVrstaPrijevoza.Controls.Add(this.rbVlastiti);
            this.gbVrstaPrijevoza.Controls.Add(this.rbAutobus);
            this.gbVrstaPrijevoza.Controls.Add(this.rbAvion);
            this.gbVrstaPrijevoza.Location = new System.Drawing.Point(278, 95);
            this.gbVrstaPrijevoza.Name = "gbVrstaPrijevoza";
            this.gbVrstaPrijevoza.Size = new System.Drawing.Size(210, 100);
            this.gbVrstaPrijevoza.TabIndex = 0;
            this.gbVrstaPrijevoza.TabStop = false;
            this.gbVrstaPrijevoza.Text = "Odaberi vrstu prijevoza";
            this.gbVrstaPrijevoza.Enter += new System.EventHandler(this.gbVrstaPrijevoza_Enter);
            // 
            // rbAvion
            // 
            this.rbAvion.AutoSize = true;
            this.rbAvion.Location = new System.Drawing.Point(6, 19);
            this.rbAvion.Name = "rbAvion";
            this.rbAvion.Size = new System.Drawing.Size(52, 17);
            this.rbAvion.TabIndex = 0;
            this.rbAvion.TabStop = true;
            this.rbAvion.Text = "Avion";
            this.rbAvion.UseVisualStyleBackColor = true;
            // 
            // rbAutobus
            // 
            this.rbAutobus.AutoSize = true;
            this.rbAutobus.Location = new System.Drawing.Point(6, 42);
            this.rbAutobus.Name = "rbAutobus";
            this.rbAutobus.Size = new System.Drawing.Size(64, 17);
            this.rbAutobus.TabIndex = 1;
            this.rbAutobus.TabStop = true;
            this.rbAutobus.Text = "Autobus";
            this.rbAutobus.UseVisualStyleBackColor = true;
            // 
            // rbVlastiti
            // 
            this.rbVlastiti.AutoSize = true;
            this.rbVlastiti.Location = new System.Drawing.Point(6, 65);
            this.rbVlastiti.Name = "rbVlastiti";
            this.rbVlastiti.Size = new System.Drawing.Size(94, 17);
            this.rbVlastiti.TabIndex = 2;
            this.rbVlastiti.TabStop = true;
            this.rbVlastiti.Text = "Vlastiti prijevoz";
            this.rbVlastiti.UseVisualStyleBackColor = true;
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.Location = new System.Drawing.Point(346, 222);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(75, 27);
            this.buttonRezerviraj.TabIndex = 1;
            this.buttonRezerviraj.Text = "Rezerviraj";
            this.buttonRezerviraj.UseVisualStyleBackColor = true;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 100);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.gbVrstaPrijevoza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVrstaPrijevoza.ResumeLayout(false);
            this.gbVrstaPrijevoza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVrstaPrijevoza;
        private System.Windows.Forms.RadioButton rbVlastiti;
        private System.Windows.Forms.RadioButton rbAutobus;
        private System.Windows.Forms.RadioButton rbAvion;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.TextBox textBox1;
    }
}

