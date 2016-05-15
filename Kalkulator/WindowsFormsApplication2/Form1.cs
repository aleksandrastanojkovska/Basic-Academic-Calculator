using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Kalkulator : Form
    {
        double total1 = 0;
        double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btnPlus_DoubleClick(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            } 
            else
            {
                txtDisplay.Clear();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (plusButtonClicked == true)
                {
                    total2 = total1 + double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                }
                else if (minusButtonClicked == true)
                {
                    total2 = total1 - double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                }
                else if (multiplyButtonClicked == true)
                {
                    total2 = total1 * double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                }
                else if (divideButtonClicked == true)
                {
                    total2 = total1 / double.Parse(txtDisplay.Text);
                    txtDisplay.Text = total2.ToString();
                }
                else
                {
                    txtDisplay.Clear();
                }

                total1 = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            total1 = 0;
            txtDisplay.Clear();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //dolzhinata ili da e razlichna od 1 ili ako e ednakva na 1 toa da ne e znakot 0, 00 na pochetok da nema
            if (txtDisplay.Text != "0" || txtDisplay.Text.Length != 1)
            {
                txtDisplay.Text = txtDisplay.Text + btnZero.Text;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "" && !txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
            }
        }

        private void btnMinus_DoubleClick(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (minusButtonClicked == false && txtDisplay.Text != "")
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            }
            else
            {
                txtDisplay.Clear();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (multiplyButtonClicked == false && txtDisplay.Text != "")
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                minusButtonClicked = false;
                plusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
            }
            else
            {
                txtDisplay.Clear();
            }
        }

        private void btnMultiply_DoubleClick(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnDivide_DoubleClick(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (divideButtonClicked == false && txtDisplay.Text != "")
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                minusButtonClicked = false;
                plusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;
            }
            else
            {
                txtDisplay.Clear();
            }
        }

        private void bckSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void acadCalcPanel_Click(object sender, EventArgs e)
        {
            academic.Visible = true;
            basic.Visible = false;
        }

        private void basCalcPanel_Click(object sender, EventArgs e)
        {
            basic.Visible = true;
            academic.Visible = false;
        }

        private void basic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void academic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnplusorminus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (txtDisplay.Text.Contains("-"))
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
                }
                else
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
        }

        private void blueBase_Click(object sender, EventArgs e)
        {
            academic.BackColor = Color.FromName("CornflowerBlue");
            basic.BackColor = Color.FromName("LightSteelBlue");
        }

        private void redBase_Click(object sender, EventArgs e)
        {
            academic.BackColor = Color.FromName("Thistle");
            basic.BackColor = Color.FromName("PaleVioletRed");
        }

        private void greenBase_Click(object sender, EventArgs e)
        {
            academic.BackColor = Color.FromName("DarkOliveGreen");
            basic.BackColor = Color.FromName("OliveDrab");
        }

        private void yellowBase_Click(object sender, EventArgs e)
        {
            academic.BackColor = Color.FromName("Khaki");
            basic.BackColor = Color.FromName("Orange");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtDisplay.Undo();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtDisplay.Paste();
        }

        private void btnCpy_Click(object sender, EventArgs e)
        {
            txtDisplay.Copy();
        }

        private void btnInMem_Click(object sender, EventArgs e)
        {
            txtDisplay.Cut();
        }

        private void btnMemOut_Click(object sender, EventArgs e)
        {
            txtDisplay.Paste();
        }

        //
        //AKADEMSKI KALKULATOR
        //

        int sign_Indicator = 0;
        double variable1;
        double variable2;
        int additionPart = 0;
        int subbtractionPart = 0;
        int multiplicationPart = 0;
        int divisionPart = 0;
        int modBit = 0;
        Boolean fl = false; 

	

        private void calculate()
        { //funkcija za presmetuvanje
            if (txtInput.Text != ".")
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                if (fl == false)
                {
                    variable1 = variable2;
                }
                else if (additionPart == 1)
                {
                    variable1 = variable1 + variable2;
                }
                else if (subbtractionPart == 1)
                {
                    variable1 = variable1 - variable2;
                }
                else if (multiplicationPart == 1)
                {
                    variable1 = variable1 * variable2;
                }
                else if (divisionPart == 1)
                {
                    variable1 = variable1 / variable2;
                }
                else if (modBit == 1)
                {

                    variable2 = Convert.ToInt32(txtInput.Text);
                    variable1 = Convert.ToInt32(variable1 % variable2);
                }

                else
                {
                    variable1 = variable2;
                }
                txtInput.Text = Convert.ToString(variable1);

            }
        }

        private void reset_SignBits()
        {
            additionPart = 0;
            subbtractionPart = 0;
            multiplicationPart = 0;
            divisionPart = 0;
            modBit = 0;
            fl = false;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "" && !txtInput.Text.Contains("."))
            {
                txtInput.Text = txtInput.Text + btnDot.Text;
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            sign_Indicator = 0;
            variable1 = 0;
            variable2 = 0;
            reset_SignBits();
        }

        private void btnBckSpc_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
            }
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                additionPart = 1;
                sign_Indicator = 1;
            }
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                subbtractionPart = 1;
                sign_Indicator = 1;
            }
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                multiplicationPart = 1;
                sign_Indicator = 1;
            }
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                divisionPart = 1;
                sign_Indicator = 1;
            }
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
        }

        private void bFactoriel_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtInput.Text); i++)
                {
                    fact = fact * i;
                }
                txtInput.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b1ofXth_Click(object sender, EventArgs e)
        {
            txtInput.Text = (1 / Convert.ToDouble(txtInput.Text)).ToString();
        }

        private void bPi_Click(object sender, EventArgs e)
        {
            txtInput.Text = "3.141592654";
        }

        //calculating squareroot
        private void bSqRt_Click(object sender, EventArgs e)
        {
            double res, pom;
            pom = Convert.ToDouble(txtInput.Text);
            res = Math.Sqrt(pom);
            txtInput.Text = Convert.ToString(res);
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Log(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bLog10_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Log10(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bMod_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign_Indicator = 1;
            }
        }

        private void bExpX_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Exp(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //calculating x raise to power 2
        private void bPow2_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                txtInput.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * Convert.ToDouble(txtInput.Text));
            }
            sign_Indicator = 1;
        }

        //calculating x raise to power 3
        private void bPow3_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                txtInput.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * Convert.ToDouble(txtInput.Text) * Convert.ToDouble(txtInput.Text));
            }
            sign_Indicator = 1;
        }

        private void bPowY_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                string pom;
                pom = txtInput.Text;
                txtInput.Text = "";
                txtInput.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(pom), Convert.ToDouble(txtInput.Text)));
            }
            sign_Indicator = 1;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Sin(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Cos(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Tan(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Asin(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Acos(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double pom;
                    pom = Math.Atan(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(pom);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                if (txtInput.Text.Contains("-"))
                {
                    txtInput.Text = txtInput.Text.Remove(0, 1);
                }
                else
                {
                    txtInput.Text = "-" + txtInput.Text;
                }
            }
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                txtInput.Copy();
            }
        }

        double reserve = 0;
        private void btnCut_Click(object sender, EventArgs e)
        {
            reserve = double.Parse(txtDisplay.Text);
            txtInput.Cut();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                txtInput.Paste();
                Clipboard.Clear();
            }
        }

        private void bUndo_Click(object sender, EventArgs e)
        {
            if (txtInput.CanUndo == true)
            {
                txtInput.Undo();
                txtInput.ClearUndo();
            }
        }


        private void bReturn_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text = reserve.ToString();
        }
    }
}
