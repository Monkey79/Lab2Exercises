using System.Text;

namespace WFormExcI02LogInLib
{
    public class Entrant
    {
        private List<Course> courses;
        private string address;
        private int age;
        private string gender;
        private string name;
        private string country;

        public Entrant(List<Course> courses, string address, int age, string gender, string name, string country) {
            this.courses = courses;
            this.address = address;
            this.age = age;
            this.gender = gender;
            this.name = name;
            this.country = country;
        }

        public List<Course> Courses { get => courses; set => courses = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"ingresante.nombre={name}-ingresante.edad={age}-" +
                $"ingresante.domicilio={address}-ingresante.pais={country}-ingresante.genero={gender}-" +
                $"ingresante.cursos-");
            foreach (Course course in courses) {
                stringBuilder.Append(course.ToString());
            }
            return stringBuilder.ToString();
        }


    }
}