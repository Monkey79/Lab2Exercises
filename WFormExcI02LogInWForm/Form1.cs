using System.Diagnostics;
using WFormExcI02LogInLib;

namespace WFormExcI02LogInWForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grb_login_Enter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            CreateEntrantAndSubmit();
        }

        //crea ingresante con sus cursos
        private void CreateEntrantAndSubmit()
        {
            string name = (grb_login.Controls["txb_name"] as TextBox).Text;
            string address = (grb_login.Controls["txb_address"] as TextBox).Text;
            int age = (int)(grb_login.Controls["ndw_age"] as NumericUpDown).Value;
            string gender = "";


            if (((RadioButton)grb_gender.Controls["rbt_male"]).Checked)
                gender = "male";
            else if (((RadioButton)grb_gender.Controls["rbt_female"]).Checked)
                gender = "female";
            else if (((RadioButton)grb_gender.Controls["rbt_nobinary"]).Checked)
                gender = "not-binary";

            /*foreach (Control item in grb_courses.Controls) { 
                if(item is CheckBox && ( ((CheckBox)item).Checked )            
            }*/
            List<Course> courses = new List<Course>();
            if (((CheckBox)(grb_courses.Controls["cbx_csharp"])).Checked)
                courses.Add(new Course(Course.C_SHARP, "course csharp"));
            if (((CheckBox)(grb_courses.Controls["cbx_cplus"])).Checked)
                courses.Add(new Course(Course.C_PLUS, "course cplusplus"));
            if (((CheckBox)(grb_courses.Controls["cbx_jscript"])).Checked)
                courses.Add(new Course(Course.J_SCRIPT, "course java script"));

            string country = (string)lbx_countries.SelectedItem;
            Entrant entrant = new Entrant(courses, address, age, gender, name, country);

            MessageBox.Show(entrant.ToString());

        }

        private void Form1_Load(object sender, EventArgs e) {
            Console.WriteLine("---FORMA LOAD-----");
        }
    }
}