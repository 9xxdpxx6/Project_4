
namespace Project_4
{
    partial class FAboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAboutUs));
            this.btnClose = new System.Windows.Forms.Button();
            this.lTop = new System.Windows.Forms.Label();
            this.lFabric = new System.Windows.Forms.Label();
            this.lProduction = new System.Windows.Forms.Label();
            this.lComponents = new System.Windows.Forms.Label();
            this.lWarranty = new System.Windows.Forms.Label();
            this.lProductionDescription = new System.Windows.Forms.Label();
            this.lFabricDescription = new System.Windows.Forms.Label();
            this.lComponentsDescription = new System.Windows.Forms.Label();
            this.lWarrantyDescription = new System.Windows.Forms.Label();
            this.pbWarranty = new System.Windows.Forms.PictureBox();
            this.pbComponents = new System.Windows.Forms.PictureBox();
            this.pbProduction = new System.Windows.Forms.PictureBox();
            this.pbFabric = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFabric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(328, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lTop
            // 
            this.lTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTop.AutoSize = true;
            this.lTop.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTop.ForeColor = System.Drawing.Color.Red;
            this.lTop.Location = new System.Drawing.Point(188, 9);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(357, 28);
            this.lTop.TabIndex = 1;
            this.lTop.Text = "ПОЧЕМУ С НАМИ ВЫГОДНО?";
            this.lTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lFabric
            // 
            this.lFabric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lFabric.AutoSize = true;
            this.lFabric.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFabric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lFabric.Location = new System.Drawing.Point(22, 114);
            this.lFabric.Name = "lFabric";
            this.lFabric.Size = new System.Drawing.Size(308, 23);
            this.lFabric.TabIndex = 2;
            this.lFabric.Text = "СОБСТВЕННОЕ ПРОИЗВОДСТВО\r\n";
            this.lFabric.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lProduction
            // 
            this.lProduction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lProduction.AutoSize = true;
            this.lProduction.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lProduction.Location = new System.Drawing.Point(409, 114);
            this.lProduction.Name = "lProduction";
            this.lProduction.Size = new System.Drawing.Size(224, 23);
            this.lProduction.TabIndex = 3;
            this.lProduction.Text = "ИЗГОТОВИМ ЗА 7 ДНЕЙ\r\n";
            this.lProduction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lComponents
            // 
            this.lComponents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lComponents.AutoSize = true;
            this.lComponents.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lComponents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lComponents.Location = new System.Drawing.Point(22, 348);
            this.lComponents.Name = "lComponents";
            this.lComponents.Size = new System.Drawing.Size(292, 23);
            this.lComponents.TabIndex = 4;
            this.lComponents.Text = "КАЧЕСТВЕННЫЕ КОМПОНЕНТЫ\r\n";
            this.lComponents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lWarranty
            // 
            this.lWarranty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lWarranty.AutoSize = true;
            this.lWarranty.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWarranty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lWarranty.Location = new System.Drawing.Point(409, 348);
            this.lWarranty.Name = "lWarranty";
            this.lWarranty.Size = new System.Drawing.Size(309, 23);
            this.lWarranty.TabIndex = 5;
            this.lWarranty.Text = "ГАРАНТИЙНОЕ ОБСЛУЖИВАНИЕ\r\n";
            this.lWarranty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lProductionDescription
            // 
            this.lProductionDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lProductionDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProductionDescription.Location = new System.Drawing.Point(409, 153);
            this.lProductionDescription.Name = "lProductionDescription";
            this.lProductionDescription.Size = new System.Drawing.Size(259, 99);
            this.lProductionDescription.TabIndex = 7;
            this.lProductionDescription.Text = "Мы постоянно совершенствуем производственные процессы и придерживаемся и стремимс" +
    "я к жесткому соблюдению сроков. Стандартный срок изготовления окна всего 7 дней!" +
    "";
            // 
            // lFabricDescription
            // 
            this.lFabricDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lFabricDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFabricDescription.Location = new System.Drawing.Point(22, 153);
            this.lFabricDescription.Name = "lFabricDescription";
            this.lFabricDescription.Size = new System.Drawing.Size(259, 99);
            this.lFabricDescription.TabIndex = 6;
            this.lFabricDescription.Text = "Наше отличие от большинства оконных компаний — собственное автоматизированное про" +
    "изводство. Мы работаем без посредников и предлагаем исключительно качественный п" +
    "родукт по доступной цене.";
            // 
            // lComponentsDescription
            // 
            this.lComponentsDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lComponentsDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lComponentsDescription.Location = new System.Drawing.Point(22, 387);
            this.lComponentsDescription.Name = "lComponentsDescription";
            this.lComponentsDescription.Size = new System.Drawing.Size(259, 99);
            this.lComponentsDescription.TabIndex = 8;
            this.lComponentsDescription.Text = "Только лучшие компоненты для окон, мы не экономим на \"невидимых\" клиенту элемента" +
    "х окна. Сотрудничаем только с проверенными и известными производителями.";
            // 
            // lWarrantyDescription
            // 
            this.lWarrantyDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lWarrantyDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWarrantyDescription.Location = new System.Drawing.Point(409, 387);
            this.lWarrantyDescription.Name = "lWarrantyDescription";
            this.lWarrantyDescription.Size = new System.Drawing.Size(259, 99);
            this.lWarrantyDescription.TabIndex = 9;
            this.lWarrantyDescription.Text = "На протяжении всего срока гарантии вы получаете пакет сервисной поддержки бесплат" +
    "но. Мы хотим, чтобы вы всегда были уверены в качестве окон и нашей готовности по" +
    "мочь.";
            // 
            // pbWarranty
            // 
            this.pbWarranty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbWarranty.BackgroundImage = global::Project_4.Properties.Resources.cash1;
            this.pbWarranty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbWarranty.Location = new System.Drawing.Point(412, 295);
            this.pbWarranty.Name = "pbWarranty";
            this.pbWarranty.Size = new System.Drawing.Size(63, 50);
            this.pbWarranty.TabIndex = 13;
            this.pbWarranty.TabStop = false;
            // 
            // pbComponents
            // 
            this.pbComponents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbComponents.BackgroundImage = global::Project_4.Properties.Resources.quality;
            this.pbComponents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbComponents.Location = new System.Drawing.Point(25, 295);
            this.pbComponents.Name = "pbComponents";
            this.pbComponents.Size = new System.Drawing.Size(64, 50);
            this.pbComponents.TabIndex = 12;
            this.pbComponents.TabStop = false;
            // 
            // pbProduction
            // 
            this.pbProduction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbProduction.BackgroundImage = global::Project_4.Properties.Resources._7days;
            this.pbProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProduction.Location = new System.Drawing.Point(412, 61);
            this.pbProduction.Name = "pbProduction";
            this.pbProduction.Size = new System.Drawing.Size(63, 50);
            this.pbProduction.TabIndex = 11;
            this.pbProduction.TabStop = false;
            // 
            // pbFabric
            // 
            this.pbFabric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbFabric.BackgroundImage = global::Project_4.Properties.Resources.Fabric1;
            this.pbFabric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFabric.Location = new System.Drawing.Point(26, 61);
            this.pbFabric.Name = "pbFabric";
            this.pbFabric.Size = new System.Drawing.Size(63, 50);
            this.pbFabric.TabIndex = 10;
            this.pbFabric.TabStop = false;
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 547);
            this.Controls.Add(this.pbWarranty);
            this.Controls.Add(this.pbComponents);
            this.Controls.Add(this.pbProduction);
            this.Controls.Add(this.pbFabric);
            this.Controls.Add(this.lWarrantyDescription);
            this.Controls.Add(this.lComponentsDescription);
            this.Controls.Add(this.lProductionDescription);
            this.Controls.Add(this.lFabricDescription);
            this.Controls.Add(this.lWarranty);
            this.Controls.Add(this.lComponents);
            this.Controls.Add(this.lProduction);
            this.Controls.Add(this.lFabric);
            this.Controls.Add(this.lTop);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "FormAboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О нас";
            ((System.ComponentModel.ISupportInitialize)(this.pbWarranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFabric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lTop;
        private System.Windows.Forms.Label lFabric;
        private System.Windows.Forms.Label lProduction;
        private System.Windows.Forms.Label lComponents;
        private System.Windows.Forms.Label lWarranty;
        private System.Windows.Forms.Label lProductionDescription;
        private System.Windows.Forms.Label lFabricDescription;
        private System.Windows.Forms.Label lComponentsDescription;
        private System.Windows.Forms.Label lWarrantyDescription;
        private System.Windows.Forms.PictureBox pbFabric;
        private System.Windows.Forms.PictureBox pbProduction;
        private System.Windows.Forms.PictureBox pbComponents;
        private System.Windows.Forms.PictureBox pbWarranty;
    }
}