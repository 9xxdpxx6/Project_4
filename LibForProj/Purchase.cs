using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Checkings;
using System.IO;

namespace LibForProj
{
    public class Purchase
    {
        
        public static string SelectedPayment { get; set; }
        public static bool FlagGlass { get; set; } = false;

        // вызов калькулятора при нажатии на кнопку стеклопакета
        public static bool IsBtnGlassChecked(double glassPrice, Form formCalc, Form formStart)
        {
            Quantities.Price = glassPrice;
            formCalc.Owner = formStart;
            formCalc.ShowDialog();
            return FlagGlass;
        }

        // проверка нажатия хотя бы одной кнопки со стеклопакетом
        public static void IsNotAnyChecked()
        {
            if (!FlagGlass)
                MessageBox.Show("Выберите стеклопакет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // проверка имени
        public static bool IsValidName(TextBox tbName, Label lName)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                if (Checking.ValidSymFound(tbName.Text))
                {
                    //если все верно
                    return true;
                }
                else
                {
                    //если не введено
                    tbName.Text = $"{lName.Text} введено неверно";
                    tbName.ForeColor = Color.Red;
                    return false;
                }
            }
            else
            {
                //если введено неправильно
                tbName.Text = $"Введите {lName.Text}";
                tbName.ForeColor = Color.Red;
                return false;
            }
        }

        // проверка фамилии
        public static bool IsValidSurName(TextBox tbSurname)
        {
            if (!string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                if (Checking.ValidSymFound(tbSurname.Text))
                {
                    return true;
                }
                else
                {
                    //если не введено
                    tbSurname.Text = "Фамилия введена неверно";
                    tbSurname.ForeColor = Color.Red;
                    return false;
                }
            }
            else
            {
                //если введено неправильно
                tbSurname.Text = "Введите фамилию";
                tbSurname.ForeColor = Color.Red;
                return false;
            }
        }

        // проверка телефона
        public static bool IsValidPhone(MaskedTextBox mtbPhone, Label lPhone)
        {
            if (mtbPhone.Text.Length == 17)
            {
                return true;
            }
            else
            {
                mtbPhone.Mask = "";
                mtbPhone.Text = $"Заполните {lPhone.Text}";
                mtbPhone.ForeColor = Color.Red;
                return false;
            }
        }

        // проверка факса
        public static bool IsValidFax(MaskedTextBox mtbPhone, Label lPhone)
        {
            if (mtbPhone.Text.Length == 13)
            {
                return true;
            }
            else
            {
                mtbPhone.Mask = "";
                mtbPhone.Text = $"Заполните {lPhone.Text}";
                mtbPhone.ForeColor = Color.Red;
                return false;
            }
        }

        // проверка Email
        public static bool IsValidEmail(TextBox tbEmail)
        {
            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                if (Checking.ValidEmailFound(tbEmail.Text))
                {
                    return true;
                }
                else
                {
                    tbEmail.Text = "Email введен некорректно";
                    tbEmail.ForeColor = Color.Red;
                    return false;
                }
            }
            else
            {
                tbEmail.Text = "Введите Email";
                tbEmail.ForeColor = Color.Red;
                return false;
            }
        }

        // проверка выбора способа оплаты
        public static bool IsValidPayment(ComboBox combPayment)
        {
            switch (combPayment.SelectedIndex)
            {
                case 0:
                    SelectedPayment = "Онлайн";
                    return true;
                case 1:
                    SelectedPayment = "При получении";
                    return true;
                case 2:
                    SelectedPayment = "В рассрочку";
                    return true;
                default:
                    combPayment.Text = "Выберите способ оплаты";
                    combPayment.ForeColor = Color.Red;
                    return false;
            }
        }

        // сохранение чека в файл физлицо
        public static void SaveCheck(TextBox tbName, TextBox tbSurname, MaskedTextBox mtbPhone, TextBox tbEmail)
        {
            SaveFileDialog saveCheck = new SaveFileDialog();
            saveCheck.FileName = "Чек";
            saveCheck.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveCheck.Title = "Сохранить чек";
            if (saveCheck.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveCheck.FileName;
            File.WriteAllText(filename, "\t\t\t\t\tТоварный чек" + Environment.NewLine + Environment.NewLine +
                                        "ООО \"СтеклоПак\" 350072, г. Краснодар, ул. Красная, д.10/1" + Environment.NewLine +
                                        "По всем вопросам обращайтесь по адресу steclopack@gmail.com или по телефону +7(999) 123-45-67" + Environment.NewLine +
                                        "--------------------------------------------------------------------------------" + Environment.NewLine +
                                        "Заказчик: \t\t\t\t\t" + tbName.Text + " " + tbSurname.Text + Environment.NewLine +
                                        "Контакты заказчика: \t\t\t\t" + mtbPhone.Text + Environment.NewLine +
                                        "\t\t\t\t\t\t" + tbEmail.Text + Environment.NewLine +
                                        "Способ оплаты: \t\t\t\t\t" + SelectedPayment + Environment.NewLine +
                                        "--------------------------------------------------------------------------------" + Environment.NewLine +
                                        "К ОПЛАТЕ\t\t\t\t\t" + Quantities.Sum.ToString());
            MessageBox.Show("Чек успешно сохранен. Cпасибо за покупку!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // сохранение чека в файл юрлицо
        public static void SaveCheck(TextBox tbName, MaskedTextBox mtbPhone, TextBox tbEmail)
        {
            SaveFileDialog saveCheck = new SaveFileDialog();
            saveCheck.FileName = "Чек";
            saveCheck.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveCheck.Title = "Сохранить чек";
            if (saveCheck.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveCheck.FileName;
            File.WriteAllText(filename, "\t\t\t\t\tТоварный чек" + Environment.NewLine + Environment.NewLine +
                                        "ООО \"СтеклоПак\" 350072, г. Краснодар, ул. Красная, д.10/1" + Environment.NewLine +
                                        "По всем вопросам обращайтесь по адресу steclopack@gmail.com или по телефону +7(999) 123-45-67" + Environment.NewLine +
                                        "--------------------------------------------------------------------------------" + Environment.NewLine +
                                        "Заказчик: \t\t\t\t\t" + tbName.Text + " " + Environment.NewLine +
                                        "Контакты заказчика: \t\t\t\t" + mtbPhone.Text + Environment.NewLine +
                                        "\t\t\t\t\t\t" + tbEmail.Text + Environment.NewLine +
                                        "Способ оплаты: \t\t\t\t\t" + SelectedPayment + Environment.NewLine +
                                        "--------------------------------------------------------------------------------" + Environment.NewLine +
                                        "К ОПЛАТЕ\t\t\t\t\t" + Quantities.Sum.ToString());
            MessageBox.Show("Чек успешно сохранен. Cпасибо за покупку!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
