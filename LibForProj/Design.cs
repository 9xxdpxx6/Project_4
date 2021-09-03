using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibForProj
{
    public class Design
    {
        // при нажатии на label курсор устанавливается в начало textBox'а, значение textBox'а обнуляется, цвет меняется на чёрный
        public static void SetLabelAction(Control textBox)
        {
            textBox.Focus();
            textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;
        }

        // предыдущий для телефона/факса
        public static void SetLabelAction(MaskedTextBox mtbPhone, RadioButton rbPerson)
        {
            SetLabelAction(mtbPhone);
            if (rbPerson.Checked)
            {
                mtbPhone.Mask = "+7(000) 000-00-00";
            }
            else
            {
                mtbPhone.Mask = "0-000-0000000";
            }
        }

        // при нажатии на textBox значение textBox'а обнуляется, цвет меняется на чёрный
        public static void SetTextBoxAction(Control tbName)
        {
            tbName.Text = "";
            tbName.ForeColor = SystemColors.WindowText;
        }

        // предыдущий для телефона/факса
        public static void SetTextBoxAction(MaskedTextBox mtbPhone, RadioButton rbPerson)
        {
            SetTextBoxAction(mtbPhone);
            if (rbPerson.Checked)
            {
                mtbPhone.Mask = "+7(000) 000-00-00";
            }
            else
            {
                mtbPhone.Mask = "0-000-0000000";
            }
        }

        // текст и цвет label'а стеклопакета при наведении на кнопку стеклопакета
        public static void SetGlassLabelHover(Label lglass, string text)
        {
            lglass.ForeColor = Color.Green;
            lglass.Text = text;
        }

        // текст и цвет label'а стеклопакета, когда на него не наведён курсор
        public static void SetGlassLabelLeave(Label lglass, string text)
        {
            lglass.ForeColor = SystemColors.ControlText;
            lglass.Text = text;
        }

        // определяет виден ли numeric, в зависимости от checkBox'а
        public static void SetNudAction(NumericUpDown nud, CheckBox cb)
        {
            nud.Visible = true;
            if (!cb.Checked)
            {
                nud.Visible = false;
            }
        }
    }
}
