namespace A_Presentacion
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
            this.rtxtListA = new System.Windows.Forms.RichTextBox();
            this.rtxtListB = new System.Windows.Forms.RichTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rtxtListResult = new System.Windows.Forms.RichTextBox();
            this.txtCanA = new System.Windows.Forms.TextBox();
            this.txtCanB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // rtxtListA
            // 
            this.rtxtListA.Location = new System.Drawing.Point(102, 68);
            this.rtxtListA.Name = "rtxtListA";
            this.rtxtListA.Size = new System.Drawing.Size(351, 66);
            this.rtxtListA.TabIndex = 2;
            this.rtxtListA.Text = "";
            // 
            // rtxtListB
            // 
            this.rtxtListB.Location = new System.Drawing.Point(102, 197);
            this.rtxtListB.Name = "rtxtListB";
            this.rtxtListB.Size = new System.Drawing.Size(351, 66);
            this.rtxtListB.TabIndex = 4;
            this.rtxtListB.Text = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(234, 285);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar Nros";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rtxtListResult
            // 
            this.rtxtListResult.Location = new System.Drawing.Point(102, 327);
            this.rtxtListResult.Name = "rtxtListResult";
            this.rtxtListResult.Size = new System.Drawing.Size(351, 66);
            this.rtxtListResult.TabIndex = 0;
            this.rtxtListResult.Text = "";
            // 
            // txtCanA
            // 
            this.txtCanA.Location = new System.Drawing.Point(102, 42);
            this.txtCanA.Name = "txtCanA";
            this.txtCanA.Size = new System.Drawing.Size(46, 20);
            this.txtCanA.TabIndex = 1;
            // 
            // txtCanB
            // 
            this.txtCanB.Location = new System.Drawing.Point(102, 171);
            this.txtCanB.Name = "txtCanB";
            this.txtCanB.Size = new System.Drawing.Size(46, 20);
            this.txtCanB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Listado A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Listado B:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 412);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCanB);
            this.Controls.Add(this.txtCanA);
            this.Controls.Add(this.rtxtListResult);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rtxtListB);
            this.Controls.Add(this.rtxtListA);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Missing Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtListA;
        private System.Windows.Forms.RichTextBox rtxtListB;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox rtxtListResult;
        private System.Windows.Forms.TextBox txtCanA;
        private System.Windows.Forms.TextBox txtCanB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

