using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibForProj;

namespace Project_4
{
    public partial class FCalc : Form
    {
        public FCalc()
        {
            InitializeComponent();
        }
       
        // вкл/выкл нумериков
        private void cbSingleLeaf_CheckedChanged(object sender, EventArgs e)
        {
            Design.SetNudAction(nudSingleLeaf, cbSingleLeaf);
        }
        private void cbDoubleLeaf_CheckedChanged(object sender, EventArgs e)
        {
            Design.SetNudAction(nudDoubleLeaf, cbDoubleLeaf);
        }
        private void cbTripleLeaf_CheckedChanged(object sender, EventArgs e)
        {
            Design.SetNudAction(nudTripleLeaf, cbTripleLeaf);
        }
        private void cbBalconyBlock_CheckedChanged(object sender, EventArgs e)
        {
            Design.SetNudAction(nudBalc, cbBalconyBlock);
        }

        // при нажатии ла label
        private void lLength_Click(object sender, EventArgs e)
        {
            Design.SetLabelAction(tbLength);
        }
        private void lHeight_Click(object sender, EventArgs e)
        {
            Design.SetLabelAction(tbHeight);
        }

        // при нажатии на textBox
        private void tbLength_Click(object sender, EventArgs e)
        {
            Design.SetTextBoxAction(tbLength);
        }
        private void tbWidth_Click(object sender, EventArgs e)
        {
            Design.SetTextBoxAction(tbHeight);
        }

        // блок с вычислениями
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Calc.AreValidValues(tbLength, tbHeight))
                if (Calc.IsAnyTypeChecked(cbSingleLeaf, cbDoubleLeaf, cbTripleLeaf, cbBalconyBlock))
                {
                    if (cbSingleLeaf.Checked)
                        Calc.GetCalc(tbLength, tbHeight, nudSingleLeaf);
                    if (cbDoubleLeaf.Checked)
                        Calc.GetCalc(tbLength, tbHeight, nudDoubleLeaf);
                    if (cbTripleLeaf.Checked)
                        Calc.GetCalc(tbLength, tbHeight, nudTripleLeaf);
                    if (cbBalconyBlock.Checked)
                        Calc.GetCalc(tbLength, tbHeight, nudBalc);
                    FStart fs = Owner as FStart;
                    fs.lCurrentPrice.Text = "Текущая цена: " + Quantities.Sum.ToString();
                    fs.lCurrentPrice.Refresh();
                    Close();
                }
        }
    }
}
