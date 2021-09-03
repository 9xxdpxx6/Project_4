using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using LibForProj;

namespace Project_4
{
    public partial class FStart : Form
    {
        readonly FCalc fc = new FCalc();

        //инициализация массива строк (для выбора способа оплаты)
        string[] payment = { "Онлайн", "При получении", "В рассрочку" };
        public FStart()
        {
            InitializeComponent();
            for(int i = 0; i<payment.Length; i++)
            {
                combPayment.Items.Add(payment[i]);
            }
        }
       
        // выход из приложения
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //вызов формы "Помощь"
        private void btnHelp_Click(object sender, EventArgs e)
        {
            FHelp fh = new FHelp();
            fh.ShowDialog();
        }

        //вызов формы "О нас"
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FAboutUs fau = new FAboutUs();
            fau.ShowDialog();
        }

        //сброс суммы
        private void btnReset_Click(object sender, EventArgs e)
        {
            cbDelivery.Checked = false;
            cbInstall.Checked = false;
            cbProtection.Checked = false;
            Quantities.Sum = 0;
            lCurrentPrice.Text = "Текущая цена: ";
        }

        // покупка
        public void btnBuy_Click(object sender, EventArgs e)
        {
            Purchase.IsNotAnyChecked();
            //проверка входных данных на их наличие
            if (rbPerson.Checked)
                if (Purchase.IsValidName(tbName, lName) & Purchase.IsValidSurName(tbSurname) & Purchase.IsValidPhone(mtbPhone, lPhone) & Purchase.IsValidEmail(tbEmail) & Purchase.IsValidPayment(combPayment) & Purchase.FlagGlass)
                        Purchase.SaveCheck(tbName, tbSurname, mtbPhone, tbEmail);
            if (rbEntity.Checked)
                if (Purchase.IsValidName(tbName, lName) & Purchase.IsValidFax(mtbPhone, lPhone) & Purchase.IsValidEmail(tbEmail) & Purchase.IsValidPayment(combPayment) & Purchase.FlagGlass)
                        Purchase.SaveCheck(tbName, mtbPhone, tbEmail);
        }

        //данные покупателя,если юрлицо
        private void rbEntity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEntity.Checked)
            {
                lName.Text = "Название организации";
                lPhone.Text = "Факс";
                mtbPhone.Mask = "0-000-0000000";
                mtbPhone.Text = "";
                mtbPhone.ForeColor = SystemColors.WindowText;
                tbSurname.Visible = false;
                lSurname.Visible = false;
                gbCustomer.Height = 163;
                lPhone.Location = new Point (6, 85);
                mtbPhone.Location = new Point (133, 92);
                lEmail.Location = new Point(6, 121);
                tbEmail.Location = new Point(133, 129);
                tbEmail.Text = "";
                tbName.Text = "";
                tbSurname.Text = "";
                combPayment.ForeColor = SystemColors.WindowText;
            }
        }

        //данные покупателя,если физлицо
        private void rbPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerson.Checked)
            {
                lName.Text = "Имя";
                lPhone.Text = "Телефон";
                mtbPhone.Mask = "+7(000) 000-00-00";
                mtbPhone.Text = "";
                mtbPhone.ForeColor = SystemColors.WindowText;
                tbSurname.Visible = true;
                lSurname.Visible = true;
                gbCustomer.Height = 202;
                lPhone.Location = new Point(6, 124);
                mtbPhone.Location = new Point(133, 130);
                lEmail.Location = new Point(6, 162);
                tbEmail.Location = new Point(133, 167);
                tbEmail.Text = "";
                tbName.Text = "";
                combPayment.ForeColor = SystemColors.WindowText;
            }
        }

        //доп услуги
        private void cbProtection_CheckStateChanged(object sender, EventArgs e)
        {
            lCurrentPrice.Text = Services.AddToSum(cbProtection.Checked, lCurrentPrice.Text, 999);
        }
        private void cbInstall_CheckStateChanged(object sender, EventArgs e)
        {
            lCurrentPrice.Text = Services.AddToSum(cbInstall.Checked, lCurrentPrice.Text, 1499);
        }
        private void cbDelivery_CheckStateChanged(object sender, EventArgs e)
        {
            lCurrentPrice.Text = Services.AddToSum(cbDelivery.Checked, lCurrentPrice.Text, 1099);
        }
       
        //привязка label к textbox
        private void lName_Click(object sender, EventArgs e)
        {
            Design.SetLabelAction(tbName);
        }
        private void lSurname_Click(object sender, EventArgs e)
        {
            Design.SetLabelAction(tbSurname);
        }
        private void lPhone_Click(object sender, EventArgs e)
        {
            Design.SetLabelAction(mtbPhone, rbPerson);
        }
        private void lEmail_Click(object sender, EventArgs e)
        {
            Design.SetLabelAction(tbEmail);
        }

        //переход в калькулятор
        private void btnGlassSimple_Click(object sender, EventArgs e)
        {
            Purchase.IsBtnGlassChecked(1452, fc, this);
        }
        private void btnGlassMultifunctional_Click(object sender, EventArgs e)
        {
            Purchase.IsBtnGlassChecked(2310, fc, this);
        }
        private void btnGlassMatt_Click(object sender, EventArgs e)
        {
            Purchase.IsBtnGlassChecked(2475, fc, this);
        }
        private void btnGlassDouble_Click(object sender, EventArgs e)
        {
            Purchase.IsBtnGlassChecked(3000, fc, this);
        }
        private void btnGlassToned_Click(object sender, EventArgs e)
        {
            Purchase.IsBtnGlassChecked(2310, fc, this);
        }
        private void btnGlassEnergySaving_Click(object sender, EventArgs e)
        {
            Purchase.IsBtnGlassChecked(1815, fc, this);
        }

        //Hover на label'ы под кнопками стеклопакетов
        private void btnGlassSimple_MouseHover(object sender, EventArgs e)
        {
            Design.SetGlassLabelHover(lGlassSimple, "1 452 руб./кв.м");
        }
        private void btnGlassSimple_MouseLeave(object sender, EventArgs e)
        {
            Design.SetGlassLabelLeave(lGlassSimple, "Однокамерный стеклопакет 24 мм");
        }
        private void btnGlassMultifunctional_MouseHover(object sender, EventArgs e)
        {
            Design.SetGlassLabelHover(lGlassMultifunctional, "2 310 руб./кв.м");
        }
        private void btnGlassMultifunctional_MouseLeave(object sender, EventArgs e)
        {
            Design.SetGlassLabelLeave(lGlassMultifunctional, "Однокамерный мультифункциональный стеклопакет 24 мм");
        }
        private void btnGlassMatt_MouseHover(object sender, EventArgs e)
        {
            Design.SetGlassLabelHover(lGlassMatt, "2 475 руб./кв.м");
        }
        private void btnGlassMatt_MouseLeave(object sender, EventArgs e)
        {
            Design.SetGlassLabelLeave(lGlassMatt, "Однокамерный матовый стеклопакет 24 мм");
        }
        private void btnGlassDouble_MouseHover(object sender, EventArgs e)
        {
            Design.SetGlassLabelHover(lGlassDouble, "3 000 руб./кв.м");
        }
        private void btnGlassDouble_MouseLeave(object sender, EventArgs e)
        {
            Design.SetGlassLabelLeave(lGlassDouble, "Стеклопакет двухкамерный");
        }
        private void btnGlassToned_MouseHover(object sender, EventArgs e)
        {
            Design.SetGlassLabelHover(lGlassToned, "2 310 руб./кв.м");
        }
        private void btnGlassToned_MouseLeave(object sender, EventArgs e)
        {
            Design.SetGlassLabelLeave(lGlassToned, "Однокамерный стеклопакет тонированный 24 мм");
        }
        private void btnGlassEnergySaving_MouseHover(object sender, EventArgs e)
        {
            Design.SetGlassLabelHover(lGlassEnergySaving, "1 815 руб./кв.м");
        }
        private void btnGlassEnergySaving_MouseLeave(object sender, EventArgs e)
        {
            Design.SetGlassLabelLeave(lGlassEnergySaving, "Однокамерный стеклопакет с энергосбережением 24 мм");
        }

        //возврат цвета comboBox'у
        private void cbPayment_Click(object sender, EventArgs e)
        {
            combPayment.ForeColor = SystemColors.WindowText;
        }

        //сброс текста у tb/mtb при нажатии на него
        private void tbName_Click(object sender, EventArgs e)
        {
            Design.SetTextBoxAction(tbName);
        }
        private void tbSurname_Click(object sender, EventArgs e)
        {
            Design.SetTextBoxAction(tbSurname);
        }
        private void mtbPhone_Click(object sender, EventArgs e)
        {
            Design.SetTextBoxAction(mtbPhone, rbPerson);
        }
        private void tbEmail_Click(object sender, EventArgs e)
        {
            Design.SetTextBoxAction(tbEmail);
        }
    }
}
