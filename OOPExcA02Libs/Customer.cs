using System.Text;

namespace OOPExcA02Libs
{
    public class Customer
    {
        private string address;
        private string name;
        private string surname;
        private string phone;

        private Pet[] pets;

        public Customer(string address, string name, string surname, string phone, Pet[] pets = null) {
            this.address = address;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.Pets = pets;
        }

        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public Pet[] Pets { get => pets; set => pets = value; }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cliente.nombre {name}");            
            stringBuilder.AppendLine($"Cliente.apellido {surname}");            
            stringBuilder.AppendLine($"Cliente.domicilio {address}");            
            stringBuilder.AppendLine($"Cliente.telefono {phone}");          

            return stringBuilder.ToString();
        }

       
    }
}