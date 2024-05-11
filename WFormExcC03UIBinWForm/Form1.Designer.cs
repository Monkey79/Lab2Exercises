namespace WFormExcC03UIBinWForm
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
            grb_binToDec = new GroupBox();
            txb_binToDecB = new TextBox();
            btn_binToDec = new Button();
            txb_binToDecA = new TextBox();
            lbl_binToDec = new Label();
            grb_decToBin = new GroupBox();
            txb_decToBinB = new TextBox();
            btn_decToBin = new Button();
            txb_decToBinA = new TextBox();
            lbl_decToBin = new Label();
            grb_binToDec.SuspendLayout();
            grb_decToBin.SuspendLayout();
            SuspendLayout();
            // 
            // grb_binToDec
            // 
            grb_binToDec.Controls.Add(txb_binToDecB);
            grb_binToDec.Controls.Add(btn_binToDec);
            grb_binToDec.Controls.Add(txb_binToDecA);
            grb_binToDec.Controls.Add(lbl_binToDec);
            grb_binToDec.Location = new Point(25, 50);
            grb_binToDec.Name = "grb_binToDec";
            grb_binToDec.Size = new Size(744, 100);
            grb_binToDec.TabIndex = 0;
            grb_binToDec.TabStop = false;
            grb_binToDec.Text = "BinToDec";
            // 
            // txb_binToDecB
            // 
            txb_binToDecB.Location = new Point(439, 43);
            txb_binToDecB.Name = "txb_binToDecB";
            txb_binToDecB.Size = new Size(233, 26);
            txb_binToDecB.TabIndex = 3;
            // 
            // btn_binToDec
            // 
            btn_binToDec.Location = new Point(324, 44);
            btn_binToDec.Name = "btn_binToDec";
            btn_binToDec.Size = new Size(109, 25);
            btn_binToDec.TabIndex = 2;
            btn_binToDec.Text = "-->";
            btn_binToDec.UseVisualStyleBackColor = true;
            btn_binToDec.Click += btn_binToDec_Click;
            // 
            // txb_binToDecA
            // 
            txb_binToDecA.Location = new Point(135, 43);
            txb_binToDecA.Name = "txb_binToDecA";
            txb_binToDecA.Size = new Size(183, 26);
            txb_binToDecA.TabIndex = 1;
            // 
            // lbl_binToDec
            // 
            lbl_binToDec.AutoSize = true;
            lbl_binToDec.Location = new Point(8, 46);
            lbl_binToDec.Name = "lbl_binToDec";
            lbl_binToDec.Size = new Size(121, 19);
            lbl_binToDec.TabIndex = 0;
            lbl_binToDec.Text = "Binario a Decimal :";
            // 
            // grb_decToBin
            // 
            grb_decToBin.Controls.Add(txb_decToBinB);
            grb_decToBin.Controls.Add(btn_decToBin);
            grb_decToBin.Controls.Add(txb_decToBinA);
            grb_decToBin.Controls.Add(lbl_decToBin);
            grb_decToBin.Location = new Point(33, 184);
            grb_decToBin.Name = "grb_decToBin";
            grb_decToBin.Size = new Size(736, 100);
            grb_decToBin.TabIndex = 1;
            grb_decToBin.TabStop = false;
            grb_decToBin.Text = "DecToBin";
            // 
            // txb_decToBinB
            // 
            txb_decToBinB.AcceptsReturn = true;
            txb_decToBinB.Location = new Point(439, 39);
            txb_decToBinB.Name = "txb_decToBinB";
            txb_decToBinB.Size = new Size(228, 26);
            txb_decToBinB.TabIndex = 3;
            // 
            // btn_decToBin
            // 
            btn_decToBin.Location = new Point(325, 39);
            btn_decToBin.Name = "btn_decToBin";
            btn_decToBin.Size = new Size(103, 27);
            btn_decToBin.TabIndex = 2;
            btn_decToBin.Text = "-->";
            btn_decToBin.UseVisualStyleBackColor = true;
            btn_decToBin.Click += btn_decToBin_Click;
            // 
            // txb_decToBinA
            // 
            txb_decToBinA.Location = new Point(126, 40);
            txb_decToBinA.Name = "txb_decToBinA";
            txb_decToBinA.Size = new Size(193, 26);
            txb_decToBinA.TabIndex = 1;
            // 
            // lbl_decToBin
            // 
            lbl_decToBin.AutoSize = true;
            lbl_decToBin.Location = new Point(6, 39);
            lbl_decToBin.Name = "lbl_decToBin";
            lbl_decToBin.Size = new Size(117, 19);
            lbl_decToBin.TabIndex = 0;
            lbl_decToBin.Text = "Decimal a Binario:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 301);
            Controls.Add(grb_decToBin);
            Controls.Add(grb_binToDec);
            Name = "Form1";
            Text = "Form1";
            grb_binToDec.ResumeLayout(false);
            grb_binToDec.PerformLayout();
            grb_decToBin.ResumeLayout(false);
            grb_decToBin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_binToDec;
        private GroupBox grb_decToBin;
        private Button btn_binToDec;
        private TextBox txb_binToDecA;
        private Label lbl_binToDec;
        private Label lbl_decToBin;
        private TextBox txb_binToDecB;
        private TextBox txb_decToBinA;
        private TextBox txb_decToBinB;
        private Button btn_decToBin;
    }
}