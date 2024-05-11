namespace WFormExcI02LogInWForm
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
            grb_login = new GroupBox();
            lbl_age = new Label();
            ndw_age = new NumericUpDown();
            lbl_address = new Label();
            lbl_name = new Label();
            txb_address = new TextBox();
            txb_name = new TextBox();
            grb_gender = new GroupBox();
            rbt_nobinary = new RadioButton();
            rbt_female = new RadioButton();
            rbt_male = new RadioButton();
            grb_courses = new GroupBox();
            cbx_jscript = new CheckBox();
            cbx_cplus = new CheckBox();
            cbx_csharp = new CheckBox();
            lbx_countries = new ListBox();
            btn_submit = new Button();
            grb_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ndw_age).BeginInit();
            grb_gender.SuspendLayout();
            grb_courses.SuspendLayout();
            SuspendLayout();
            // 
            // grb_login
            // 
            grb_login.Controls.Add(lbl_age);
            grb_login.Controls.Add(ndw_age);
            grb_login.Controls.Add(lbl_address);
            grb_login.Controls.Add(lbl_name);
            grb_login.Controls.Add(txb_address);
            grb_login.Controls.Add(txb_name);
            grb_login.Location = new Point(12, 12);
            grb_login.Name = "grb_login";
            grb_login.Size = new Size(467, 118);
            grb_login.TabIndex = 0;
            grb_login.TabStop = false;
            grb_login.Text = "Detalles del usuario";
            grb_login.Enter += grb_login_Enter;
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(260, 35);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(42, 19);
            lbl_age.TabIndex = 5;
            lbl_age.Text = "edad:";
            // 
            // ndw_age
            // 
            ndw_age.Location = new Point(331, 29);
            ndw_age.Name = "ndw_age";
            ndw_age.Size = new Size(120, 26);
            ndw_age.TabIndex = 4;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(23, 73);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(66, 19);
            lbl_address.TabIndex = 3;
            lbl_address.Text = "direccion:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(16, 31);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(60, 19);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "nombre:";
            lbl_name.Click += label1_Click;
            // 
            // txb_address
            // 
            txb_address.Location = new Point(106, 71);
            txb_address.Name = "txb_address";
            txb_address.Size = new Size(100, 26);
            txb_address.TabIndex = 1;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(106, 27);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(100, 26);
            txb_name.TabIndex = 0;
            // 
            // grb_gender
            // 
            grb_gender.Controls.Add(rbt_nobinary);
            grb_gender.Controls.Add(rbt_female);
            grb_gender.Controls.Add(rbt_male);
            grb_gender.Location = new Point(523, 16);
            grb_gender.Name = "grb_gender";
            grb_gender.Size = new Size(237, 114);
            grb_gender.TabIndex = 1;
            grb_gender.TabStop = false;
            grb_gender.Text = "Genero";
            // 
            // rbt_nobinary
            // 
            rbt_nobinary.AutoSize = true;
            rbt_nobinary.Location = new Point(82, 76);
            rbt_nobinary.Name = "rbt_nobinary";
            rbt_nobinary.Size = new Size(89, 23);
            rbt_nobinary.TabIndex = 2;
            rbt_nobinary.TabStop = true;
            rbt_nobinary.Text = "no binario";
            rbt_nobinary.UseVisualStyleBackColor = true;
            // 
            // rbt_female
            // 
            rbt_female.AutoSize = true;
            rbt_female.Location = new Point(82, 49);
            rbt_female.Name = "rbt_female";
            rbt_female.Size = new Size(84, 23);
            rbt_female.TabIndex = 1;
            rbt_female.TabStop = true;
            rbt_female.Text = "femenino";
            rbt_female.UseVisualStyleBackColor = true;
            // 
            // rbt_male
            // 
            rbt_male.AutoSize = true;
            rbt_male.Location = new Point(82, 20);
            rbt_male.Name = "rbt_male";
            rbt_male.Size = new Size(88, 23);
            rbt_male.TabIndex = 0;
            rbt_male.TabStop = true;
            rbt_male.Text = "masculino";
            rbt_male.UseVisualStyleBackColor = true;
            // 
            // grb_courses
            // 
            grb_courses.Controls.Add(cbx_jscript);
            grb_courses.Controls.Add(cbx_cplus);
            grb_courses.Controls.Add(cbx_csharp);
            grb_courses.Location = new Point(523, 156);
            grb_courses.Name = "grb_courses";
            grb_courses.Size = new Size(197, 100);
            grb_courses.TabIndex = 2;
            grb_courses.TabStop = false;
            grb_courses.Text = "Cursos";
            // 
            // cbx_jscript
            // 
            cbx_jscript.AutoSize = true;
            cbx_jscript.Location = new Point(45, 75);
            cbx_jscript.Name = "cbx_jscript";
            cbx_jscript.Size = new Size(88, 23);
            cbx_jscript.TabIndex = 2;
            cbx_jscript.Text = "JavaScript";
            cbx_jscript.UseVisualStyleBackColor = true;
            // 
            // cbx_cplus
            // 
            cbx_cplus.AutoSize = true;
            cbx_cplus.Location = new Point(45, 50);
            cbx_cplus.Name = "cbx_cplus";
            cbx_cplus.Size = new Size(57, 23);
            cbx_cplus.TabIndex = 1;
            cbx_cplus.Text = "C++";
            cbx_cplus.UseVisualStyleBackColor = true;
            // 
            // cbx_csharp
            // 
            cbx_csharp.AutoSize = true;
            cbx_csharp.Location = new Point(44, 26);
            cbx_csharp.Name = "cbx_csharp";
            cbx_csharp.Size = new Size(45, 23);
            cbx_csharp.TabIndex = 0;
            cbx_csharp.Text = "C#";
            cbx_csharp.UseVisualStyleBackColor = true;
            // 
            // lbx_countries
            // 
            lbx_countries.FormattingEnabled = true;
            lbx_countries.ItemHeight = 19;
            lbx_countries.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lbx_countries.Location = new Point(23, 178);
            lbx_countries.Name = "lbx_countries";
            lbx_countries.Size = new Size(120, 80);
            lbx_countries.TabIndex = 3;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(529, 271);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 33);
            btn_submit.TabIndex = 4;
            btn_submit.Text = "Ingresar";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 328);
            Controls.Add(btn_submit);
            Controls.Add(lbx_countries);
            Controls.Add(grb_courses);
            Controls.Add(grb_gender);
            Controls.Add(grb_login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grb_login.ResumeLayout(false);
            grb_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ndw_age).EndInit();
            grb_gender.ResumeLayout(false);
            grb_gender.PerformLayout();
            grb_courses.ResumeLayout(false);
            grb_courses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_login;
        private TextBox txb_name;
        private TextBox txb_address;
        private Label lbl_name;
        private Label lbl_age;
        private NumericUpDown ndw_age;
        private Label lbl_address;
        private GroupBox grb_gender;
        private RadioButton rbt_nobinary;
        private RadioButton rbt_female;
        private RadioButton rbt_male;
        private GroupBox grb_courses;
        private CheckBox cbx_jscript;
        private CheckBox cbx_cplus;
        private CheckBox cbx_csharp;
        private ListBox lbx_countries;
        private Button btn_submit;
    }
}