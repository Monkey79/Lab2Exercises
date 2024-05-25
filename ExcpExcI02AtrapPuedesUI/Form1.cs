using ExcpExcI02AtrapPuedesLibs;
using ExcpExcI02AtrapPuedesLibs.CustomExcp;
using System.Diagnostics;
using System.Text;

namespace ExcpExcI02AtrapPuedesUI
{
    public partial class Form1 : Form
    {
        private int lit;
        private int kms;
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {
            try {
                CheckKmLtInputs();
                CalcularKmLitros();
                DivideKmsByLit(lit, kms);
            }catch (ParametrosVaciosException ex) {
                rtx_calculo.Text = ex.Message;
                ResetTextBoxs();
            }catch(ParseoException ex1){
                rtx_calculo.Text = ex1.Message;
                ResetTextBoxs();
            }            
        }

        private void DivideKmsByLit(int lit, int kms) {
            float rsl = Calculador.Calcular(kms,lit);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El resultado de dividir kms={kms} por litros={lit} es={rsl}");
            rtx_calculo.Text = sb.ToString();
        }

        private void CheckKmLtInputs(){
            if(txb_km.TextLength<=0 || txb_litros.Text.Length <= 0) 
                throw new ParametrosVaciosException(ParametrosVaciosException.EMPTY_MSSG,null);
            
        }
        private void CalcularKmLitros() {      
            CustomParser.ParseFromUnsignedStrToInt(txb_litros.Text,out lit);
            CustomParser.ParseFromUnsignedStrToInt(txb_km.Text, out kms);
        }
        private void ResetTextBoxs() {
            txb_km.Text = string.Empty;
            txb_litros.Text = string.Empty;
        }
    }
}