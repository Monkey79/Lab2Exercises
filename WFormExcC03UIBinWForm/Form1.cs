using WFormExcC03UIBinLib;

namespace WFormExcC03UIBinWForm
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void btn_binToDec_Click(object sender, EventArgs e)
        {
            string decText = grb_binToDec.Controls["txb_binToDecA"].Text;
            bool prsRsl;
            int prsNm;
            prsRsl = int.TryParse(decText, out prsNm);
            if (prsRsl)
            {
                grb_binToDec.Controls["txb_binToDecB"].Text = Converter.ConvertBinaryToDecimal(prsNm);
            }

        }

        private void btn_decToBin_Click(object sender, EventArgs e)
        {
            string decText = grb_decToBin.Controls["txb_decToBinA"].Text;
            bool prsRsl;
            int prsNm;
            prsRsl = int.TryParse(decText, out prsNm);
            if (prsRsl) {
                grb_decToBin.Controls["txb_decToBinB"].Text = Converter.ConvertDecimalToBinary(prsNm);
            }

        }
    }
}