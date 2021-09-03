using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkings;
using System.Windows.Forms;
using System.Drawing;

namespace LibForProj
{
    public class Calc
    {
        // высисление
        public static double GetCalc(TextBox tbLength, TextBox tbHeight, NumericUpDown nud)
        {
            return Quantities.Sum += Math.Round((Convert.ToDouble(tbLength.Text) * Convert.ToDouble(tbHeight.Text) / 10000 * Convert.ToDouble(nud.Value) * Quantities.Price), 2);
        }

        // выбран ли хоть один тип окна
        public static bool IsAnyTypeChecked(CheckBox cbSL, CheckBox cbDL, CheckBox cbTL, CheckBox cbBalc)
        {
            if (cbSL.Checked || cbDL.Checked || cbTL.Checked || cbBalc.Checked)
            {
                Purchase.FlagGlass = true;
                return true;
            }
            else
            {
                MessageBox.Show($"Выберите тип окна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Purchase.FlagGlass = false;
                return false;
            }
        }

        // верны ли входные данные
        public static bool AreValidValues(TextBox tbLength, TextBox tbHeight)
        {
            if (Checking.ValidCharFound(tbLength.Text) && Checking.ValidCharFound(tbHeight.Text))
            {
                if (tbLength.Text != null && Convert.ToDouble(tbLength.Text) != 0 && tbHeight != null && Convert.ToDouble(tbHeight.Text) != 0)
                {
                    Purchase.FlagGlass = true;
                    return true;
                }
                else
                {
                    tbLength.Text = "Введите длину проёма";
                    tbLength.ForeColor = Color.Red;
                    tbHeight.Text = "Введите ширину проёма";
                    tbHeight.ForeColor = Color.Red;
                    Purchase.FlagGlass = false;
                    return false;
                }
            }
            else
            {
                tbLength.Text = "Введите длину проёма";
                tbLength.ForeColor = Color.Red;
                tbHeight.Text = "Введите ширину проёма";
                tbHeight.ForeColor = Color.Red;
                Purchase.FlagGlass = false;
                return false;
            }
        }
    }
}
