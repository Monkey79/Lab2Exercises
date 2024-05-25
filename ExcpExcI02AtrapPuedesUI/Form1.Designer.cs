namespace ExcpExcI02AtrapPuedesUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbx_kmlitros = new GroupBox();
            btn_calcular = new Button();
            txb_litros = new TextBox();
            txb_km = new TextBox();
            label2 = new Label();
            label1 = new Label();
            rtx_calculo = new RichTextBox();
            gbx_kmlitros.SuspendLayout();
            SuspendLayout();
            // 
            // gbx_kmlitros
            // 
            gbx_kmlitros.Controls.Add(btn_calcular);
            gbx_kmlitros.Controls.Add(txb_litros);
            gbx_kmlitros.Controls.Add(txb_km);
            gbx_kmlitros.Controls.Add(label2);
            gbx_kmlitros.Controls.Add(label1);
            gbx_kmlitros.Location = new Point(12, 12);
            gbx_kmlitros.Name = "gbx_kmlitros";
            gbx_kmlitros.Size = new Size(248, 267);
            gbx_kmlitros.TabIndex = 0;
            gbx_kmlitros.TabStop = false;
            gbx_kmlitros.Text = "Calculador";
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(24, 214);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(197, 47);
            btn_calcular.TabIndex = 4;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txb_litros
            // 
            txb_litros.Location = new Point(26, 149);
            txb_litros.Name = "txb_litros";
            txb_litros.Size = new Size(195, 26);
            txb_litros.TabIndex = 3;
            // 
            // txb_km
            // 
            txb_km.Location = new Point(22, 66);
            txb_km.Name = "txb_km";
            txb_km.Size = new Size(199, 26);
            txb_km.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 1;
            label2.Text = "Litros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 0;
            label1.Text = "Kilometros";
            // 
            // rtx_calculo
            // 
            rtx_calculo.Location = new Point(277, 24);
            rtx_calculo.Name = "rtx_calculo";
            rtx_calculo.ReadOnly = true;
            rtx_calculo.Size = new Size(279, 249);
            rtx_calculo.TabIndex = 1;
            rtx_calculo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 346);
            Controls.Add(rtx_calculo);
            Controls.Add(gbx_kmlitros);
            Name = "Form1";
            Text = "Form1";
            gbx_kmlitros.ResumeLayout(false);
            gbx_kmlitros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbx_kmlitros;
        private Label label1;
        private TextBox txb_km;
        private Label label2;
        private TextBox txb_litros;
        private Button btn_calcular;
        private RichTextBox rtx_calculo;
    }
}