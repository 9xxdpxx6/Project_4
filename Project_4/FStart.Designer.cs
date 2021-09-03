
namespace Project_4
{
    partial class FStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStart));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.rbEntity = new System.Windows.Forms.RadioButton();
            this.rbPerson = new System.Windows.Forms.RadioButton();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.cbInstall = new System.Windows.Forms.CheckBox();
            this.cbProtection = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.combPayment = new System.Windows.Forms.ComboBox();
            this.gbGlass = new System.Windows.Forms.GroupBox();
            this.lGlassEnergySaving = new System.Windows.Forms.Label();
            this.lGlassToned = new System.Windows.Forms.Label();
            this.lGlassDouble = new System.Windows.Forms.Label();
            this.lGlassMatt = new System.Windows.Forms.Label();
            this.lGlassMultifunctional = new System.Windows.Forms.Label();
            this.lGlassSimple = new System.Windows.Forms.Label();
            this.btnGlassEnergySaving = new System.Windows.Forms.Button();
            this.btnGlassToned = new System.Windows.Forms.Button();
            this.btnGlassDouble = new System.Windows.Forms.Button();
            this.btnGlassMatt = new System.Windows.Forms.Button();
            this.btnGlassMultifunctional = new System.Windows.Forms.Button();
            this.btnGlassSimple = new System.Windows.Forms.Button();
            this.lCurrentPrice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.gbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbGlass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.tbSurname);
            this.gbCustomer.Controls.Add(this.lSurname);
            this.gbCustomer.Controls.Add(this.mtbPhone);
            this.gbCustomer.Controls.Add(this.tbEmail);
            this.gbCustomer.Controls.Add(this.lEmail);
            this.gbCustomer.Controls.Add(this.lPhone);
            this.gbCustomer.Controls.Add(this.tbName);
            this.gbCustomer.Controls.Add(this.lName);
            this.gbCustomer.Controls.Add(this.rbEntity);
            this.gbCustomer.Controls.Add(this.rbPerson);
            this.gbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCustomer.Location = new System.Drawing.Point(12, 136);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(329, 202);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Данные покупателя";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(133, 93);
            this.tbSurname.MaxLength = 100;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(190, 23);
            this.tbSurname.TabIndex = 10;
            this.tbSurname.Click += new System.EventHandler(this.tbSurname_Click);
            // 
            // lSurname
            // 
            this.lSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lSurname.Location = new System.Drawing.Point(6, 81);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(121, 38);
            this.lSurname.TabIndex = 9;
            this.lSurname.Text = "Фамилия";
            this.lSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lSurname.Click += new System.EventHandler(this.lSurname_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(133, 130);
            this.mtbPhone.Mask = "+7(000) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(190, 23);
            this.mtbPhone.TabIndex = 8;
            this.mtbPhone.Click += new System.EventHandler(this.mtbPhone_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(133, 167);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(190, 23);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            // 
            // lEmail
            // 
            this.lEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lEmail.Location = new System.Drawing.Point(6, 162);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(121, 28);
            this.lEmail.TabIndex = 6;
            this.lEmail.Text = "Email";
            this.lEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lEmail.Click += new System.EventHandler(this.lEmail_Click);
            // 
            // lPhone
            // 
            this.lPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPhone.Location = new System.Drawing.Point(6, 124);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(121, 30);
            this.lPhone.TabIndex = 4;
            this.lPhone.Text = "Телефон";
            this.lPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lPhone.Click += new System.EventHandler(this.lPhone_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(133, 55);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(190, 23);
            this.tbName.TabIndex = 3;
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            // 
            // lName
            // 
            this.lName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lName.Location = new System.Drawing.Point(6, 47);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(124, 34);
            this.lName.TabIndex = 2;
            this.lName.Text = "Имя";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lName.Click += new System.EventHandler(this.lName_Click);
            // 
            // rbEntity
            // 
            this.rbEntity.AutoSize = true;
            this.rbEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEntity.Location = new System.Drawing.Point(169, 19);
            this.rbEntity.Name = "rbEntity";
            this.rbEntity.Size = new System.Drawing.Size(154, 21);
            this.rbEntity.TabIndex = 1;
            this.rbEntity.Text = "Юридическое лицо";
            this.rbEntity.UseVisualStyleBackColor = true;
            this.rbEntity.CheckedChanged += new System.EventHandler(this.rbEntity_CheckedChanged);
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Checked = true;
            this.rbPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPerson.Location = new System.Drawing.Point(10, 19);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(140, 21);
            this.rbPerson.TabIndex = 0;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "Физическое лицо";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbPerson_CheckedChanged);
            // 
            // gbServices
            // 
            this.gbServices.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbServices.Controls.Add(this.cbDelivery);
            this.gbServices.Controls.Add(this.cbInstall);
            this.gbServices.Controls.Add(this.cbProtection);
            this.gbServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbServices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbServices.Location = new System.Drawing.Point(12, 363);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(329, 100);
            this.gbServices.TabIndex = 2;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Дополнительные услуги";
            // 
            // cbDelivery
            // 
            this.cbDelivery.Location = new System.Drawing.Point(9, 65);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(314, 24);
            this.cbDelivery.TabIndex = 2;
            this.cbDelivery.Text = "Доставка";
            this.cbDelivery.UseVisualStyleBackColor = true;
            this.cbDelivery.CheckStateChanged += new System.EventHandler(this.cbDelivery_CheckStateChanged);
            // 
            // cbInstall
            // 
            this.cbInstall.Location = new System.Drawing.Point(9, 42);
            this.cbInstall.Name = "cbInstall";
            this.cbInstall.Size = new System.Drawing.Size(314, 24);
            this.cbInstall.TabIndex = 1;
            this.cbInstall.Text = "Установка";
            this.cbInstall.UseVisualStyleBackColor = true;
            this.cbInstall.CheckStateChanged += new System.EventHandler(this.cbInstall_CheckStateChanged);
            // 
            // cbProtection
            // 
            this.cbProtection.Location = new System.Drawing.Point(9, 19);
            this.cbProtection.Name = "cbProtection";
            this.cbProtection.Size = new System.Drawing.Size(314, 24);
            this.cbProtection.TabIndex = 0;
            this.cbProtection.Text = "Защита от уличного шума";
            this.cbProtection.UseVisualStyleBackColor = true;
            this.cbProtection.CheckStateChanged += new System.EventHandler(this.cbProtection_CheckStateChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(12, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(266, 609);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 32);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(738, 609);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(115, 32);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbLogo.ErrorImage = null;
            this.pbLogo.Image = global::Project_4.Properties.Resources.StekloPackLong;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(264, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(351, 109);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // combPayment
            // 
            this.combPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combPayment.FormattingEnabled = true;
            this.combPayment.Location = new System.Drawing.Point(12, 488);
            this.combPayment.Name = "combPayment";
            this.combPayment.Size = new System.Drawing.Size(329, 25);
            this.combPayment.TabIndex = 7;
            this.combPayment.Text = "Выберите способ оплаты";
            this.combPayment.Click += new System.EventHandler(this.cbPayment_Click);
            // 
            // gbGlass
            // 
            this.gbGlass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGlass.Controls.Add(this.lGlassEnergySaving);
            this.gbGlass.Controls.Add(this.lGlassToned);
            this.gbGlass.Controls.Add(this.lGlassDouble);
            this.gbGlass.Controls.Add(this.lGlassMatt);
            this.gbGlass.Controls.Add(this.lGlassMultifunctional);
            this.gbGlass.Controls.Add(this.lGlassSimple);
            this.gbGlass.Controls.Add(this.btnGlassEnergySaving);
            this.gbGlass.Controls.Add(this.btnGlassToned);
            this.gbGlass.Controls.Add(this.btnGlassDouble);
            this.gbGlass.Controls.Add(this.btnGlassMatt);
            this.gbGlass.Controls.Add(this.btnGlassMultifunctional);
            this.gbGlass.Controls.Add(this.btnGlassSimple);
            this.gbGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGlass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGlass.Location = new System.Drawing.Point(406, 136);
            this.gbGlass.Name = "gbGlass";
            this.gbGlass.Size = new System.Drawing.Size(447, 377);
            this.gbGlass.TabIndex = 8;
            this.gbGlass.TabStop = false;
            this.gbGlass.Text = "Выберите подхлдящий  стеклопакет";
            // 
            // lGlassEnergySaving
            // 
            this.lGlassEnergySaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGlassEnergySaving.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGlassEnergySaving.Location = new System.Drawing.Point(292, 320);
            this.lGlassEnergySaving.Name = "lGlassEnergySaving";
            this.lGlassEnergySaving.Size = new System.Drawing.Size(149, 54);
            this.lGlassEnergySaving.TabIndex = 11;
            this.lGlassEnergySaving.Text = "Однокамерный стеклопакет с энерго-\r\nсбережением 24 мм";
            this.lGlassEnergySaving.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lGlassToned
            // 
            this.lGlassToned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGlassToned.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGlassToned.Location = new System.Drawing.Point(159, 320);
            this.lGlassToned.Name = "lGlassToned";
            this.lGlassToned.Size = new System.Drawing.Size(127, 51);
            this.lGlassToned.TabIndex = 10;
            this.lGlassToned.Text = "Однокамерный стеклопакет тонированный 24 мм";
            this.lGlassToned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lGlassDouble
            // 
            this.lGlassDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGlassDouble.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGlassDouble.Location = new System.Drawing.Point(15, 320);
            this.lGlassDouble.Name = "lGlassDouble";
            this.lGlassDouble.Size = new System.Drawing.Size(118, 51);
            this.lGlassDouble.TabIndex = 9;
            this.lGlassDouble.Text = "Стеклопакет двухкамерный";
            this.lGlassDouble.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lGlassMatt
            // 
            this.lGlassMatt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGlassMatt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGlassMatt.Location = new System.Drawing.Point(308, 145);
            this.lGlassMatt.Name = "lGlassMatt";
            this.lGlassMatt.Size = new System.Drawing.Size(123, 53);
            this.lGlassMatt.TabIndex = 8;
            this.lGlassMatt.Text = "Однокамерный матовый стеклопакет 24 мм";
            this.lGlassMatt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lGlassMultifunctional
            // 
            this.lGlassMultifunctional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGlassMultifunctional.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGlassMultifunctional.Location = new System.Drawing.Point(150, 145);
            this.lGlassMultifunctional.Name = "lGlassMultifunctional";
            this.lGlassMultifunctional.Size = new System.Drawing.Size(152, 53);
            this.lGlassMultifunctional.TabIndex = 7;
            this.lGlassMultifunctional.Text = "Однокамерный мультифункциональный стеклопакет 24 мм";
            this.lGlassMultifunctional.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lGlassSimple
            // 
            this.lGlassSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGlassSimple.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGlassSimple.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lGlassSimple.Location = new System.Drawing.Point(15, 145);
            this.lGlassSimple.Name = "lGlassSimple";
            this.lGlassSimple.Size = new System.Drawing.Size(118, 42);
            this.lGlassSimple.TabIndex = 6;
            this.lGlassSimple.Text = "Однокамерный стеклопакет 24 мм";
            this.lGlassSimple.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGlassEnergySaving
            // 
            this.btnGlassEnergySaving.BackgroundImage = global::Project_4.Properties.Resources._1camenerg24;
            this.btnGlassEnergySaving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlassEnergySaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassEnergySaving.Location = new System.Drawing.Point(311, 201);
            this.btnGlassEnergySaving.Name = "btnGlassEnergySaving";
            this.btnGlassEnergySaving.Size = new System.Drawing.Size(115, 115);
            this.btnGlassEnergySaving.TabIndex = 5;
            this.btnGlassEnergySaving.UseVisualStyleBackColor = true;
            this.btnGlassEnergySaving.Click += new System.EventHandler(this.btnGlassEnergySaving_Click);
            this.btnGlassEnergySaving.MouseLeave += new System.EventHandler(this.btnGlassEnergySaving_MouseLeave);
            this.btnGlassEnergySaving.MouseHover += new System.EventHandler(this.btnGlassEnergySaving_MouseHover);
            // 
            // btnGlassToned
            // 
            this.btnGlassToned.BackgroundImage = global::Project_4.Properties.Resources._1camtonir24;
            this.btnGlassToned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlassToned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassToned.Location = new System.Drawing.Point(164, 201);
            this.btnGlassToned.Name = "btnGlassToned";
            this.btnGlassToned.Size = new System.Drawing.Size(115, 115);
            this.btnGlassToned.TabIndex = 4;
            this.btnGlassToned.UseVisualStyleBackColor = true;
            this.btnGlassToned.Click += new System.EventHandler(this.btnGlassToned_Click);
            this.btnGlassToned.MouseLeave += new System.EventHandler(this.btnGlassToned_MouseLeave);
            this.btnGlassToned.MouseHover += new System.EventHandler(this.btnGlassToned_MouseHover);
            // 
            // btnGlassDouble
            // 
            this.btnGlassDouble.BackgroundImage = global::Project_4.Properties.Resources._2cam;
            this.btnGlassDouble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlassDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassDouble.Location = new System.Drawing.Point(18, 201);
            this.btnGlassDouble.Name = "btnGlassDouble";
            this.btnGlassDouble.Size = new System.Drawing.Size(115, 115);
            this.btnGlassDouble.TabIndex = 3;
            this.btnGlassDouble.UseVisualStyleBackColor = true;
            this.btnGlassDouble.Click += new System.EventHandler(this.btnGlassDouble_Click);
            this.btnGlassDouble.MouseLeave += new System.EventHandler(this.btnGlassDouble_MouseLeave);
            this.btnGlassDouble.MouseHover += new System.EventHandler(this.btnGlassDouble_MouseHover);
            // 
            // btnGlassMatt
            // 
            this.btnGlassMatt.BackgroundImage = global::Project_4.Properties.Resources._1cammat24mm;
            this.btnGlassMatt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlassMatt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassMatt.Location = new System.Drawing.Point(311, 27);
            this.btnGlassMatt.Name = "btnGlassMatt";
            this.btnGlassMatt.Size = new System.Drawing.Size(115, 115);
            this.btnGlassMatt.TabIndex = 2;
            this.btnGlassMatt.UseVisualStyleBackColor = true;
            this.btnGlassMatt.Click += new System.EventHandler(this.btnGlassMatt_Click);
            this.btnGlassMatt.MouseLeave += new System.EventHandler(this.btnGlassMatt_MouseLeave);
            this.btnGlassMatt.MouseHover += new System.EventHandler(this.btnGlassMatt_MouseHover);
            // 
            // btnGlassMultifunctional
            // 
            this.btnGlassMultifunctional.BackgroundImage = global::Project_4.Properties.Resources._1cammult24;
            this.btnGlassMultifunctional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlassMultifunctional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassMultifunctional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGlassMultifunctional.Location = new System.Drawing.Point(164, 27);
            this.btnGlassMultifunctional.Name = "btnGlassMultifunctional";
            this.btnGlassMultifunctional.Size = new System.Drawing.Size(115, 115);
            this.btnGlassMultifunctional.TabIndex = 1;
            this.btnGlassMultifunctional.UseVisualStyleBackColor = true;
            this.btnGlassMultifunctional.Click += new System.EventHandler(this.btnGlassMultifunctional_Click);
            this.btnGlassMultifunctional.MouseLeave += new System.EventHandler(this.btnGlassMultifunctional_MouseLeave);
            this.btnGlassMultifunctional.MouseHover += new System.EventHandler(this.btnGlassMultifunctional_MouseHover);
            // 
            // btnGlassSimple
            // 
            this.btnGlassSimple.BackgroundImage = global::Project_4.Properties.Resources._1cam24mm;
            this.btnGlassSimple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlassSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassSimple.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGlassSimple.Location = new System.Drawing.Point(18, 27);
            this.btnGlassSimple.Name = "btnGlassSimple";
            this.btnGlassSimple.Size = new System.Drawing.Size(115, 115);
            this.btnGlassSimple.TabIndex = 0;
            this.btnGlassSimple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGlassSimple.UseVisualStyleBackColor = true;
            this.btnGlassSimple.Click += new System.EventHandler(this.btnGlassSimple_Click);
            this.btnGlassSimple.MouseLeave += new System.EventHandler(this.btnGlassSimple_MouseLeave);
            this.btnGlassSimple.MouseHover += new System.EventHandler(this.btnGlassSimple_MouseHover);
            // 
            // lCurrentPrice
            // 
            this.lCurrentPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentPrice.AutoSize = true;
            this.lCurrentPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lCurrentPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCurrentPrice.Location = new System.Drawing.Point(463, 570);
            this.lCurrentPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lCurrentPrice.Name = "lCurrentPrice";
            this.lCurrentPrice.Padding = new System.Windows.Forms.Padding(3);
            this.lCurrentPrice.Size = new System.Drawing.Size(113, 23);
            this.lCurrentPrice.TabIndex = 9;
            this.lCurrentPrice.Text = "Текущая цена: ";
            this.lCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(738, 565);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 32);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutUs.Location = new System.Drawing.Point(463, 609);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(75, 32);
            this.btnAboutUs.TabIndex = 11;
            this.btnAboutUs.Text = "О нас";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 653);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lCurrentPrice);
            this.Controls.Add(this.gbGlass);
            this.Controls.Add(this.combPayment);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.gbCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(881, 692);
            this.Name = "FStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StekloPack";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbGlass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.RadioButton rbEntity;
        private System.Windows.Forms.RadioButton rbPerson;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.CheckBox cbDelivery;
        private System.Windows.Forms.CheckBox cbInstall;
        private System.Windows.Forms.CheckBox cbProtection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox combPayment;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.GroupBox gbGlass;
        private System.Windows.Forms.Button btnGlassEnergySaving;
        private System.Windows.Forms.Button btnGlassToned;
        private System.Windows.Forms.Button btnGlassDouble;
        private System.Windows.Forms.Button btnGlassMatt;
        private System.Windows.Forms.Button btnGlassSimple;
        private System.Windows.Forms.Button btnGlassMultifunctional;
        private System.Windows.Forms.Label lGlassEnergySaving;
        private System.Windows.Forms.Label lGlassToned;
        private System.Windows.Forms.Label lGlassDouble;
        private System.Windows.Forms.Label lGlassMatt;
        private System.Windows.Forms.Label lGlassMultifunctional;
        private System.Windows.Forms.Label lGlassSimple;
        public System.Windows.Forms.Label lCurrentPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAboutUs;
    }
}

