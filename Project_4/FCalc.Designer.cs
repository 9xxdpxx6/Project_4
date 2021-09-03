
namespace Project_4
{
    partial class FCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalc));
            this.lLength = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.cbSingleLeaf = new System.Windows.Forms.CheckBox();
            this.cbDoubleLeaf = new System.Windows.Forms.CheckBox();
            this.cbTripleLeaf = new System.Windows.Forms.CheckBox();
            this.gbWindowType = new System.Windows.Forms.GroupBox();
            this.nudBalc = new System.Windows.Forms.NumericUpDown();
            this.nudTripleLeaf = new System.Windows.Forms.NumericUpDown();
            this.nudDoubleLeaf = new System.Windows.Forms.NumericUpDown();
            this.nudSingleLeaf = new System.Windows.Forms.NumericUpDown();
            this.cbBalconyBlock = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbWindowType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripleLeaf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoubleLeaf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSingleLeaf)).BeginInit();
            this.SuspendLayout();
            // 
            // lLength
            // 
            this.lLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLength.Location = new System.Drawing.Point(12, 8);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(218, 32);
            this.lLength.TabIndex = 0;
            this.lLength.Text = "Введите длину проёма (в см)";
            this.lLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLength.Click += new System.EventHandler(this.lLength_Click);
            // 
            // lHeight
            // 
            this.lHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lHeight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHeight.Location = new System.Drawing.Point(12, 42);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(218, 36);
            this.lHeight.TabIndex = 1;
            this.lHeight.Text = "Введите Высоту проёма (в см)";
            this.lHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lHeight.Click += new System.EventHandler(this.lHeight_Click);
            // 
            // tbLength
            // 
            this.tbLength.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLength.Location = new System.Drawing.Point(239, 15);
            this.tbLength.MaxLength = 10;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(173, 21);
            this.tbLength.TabIndex = 2;
            this.tbLength.Click += new System.EventHandler(this.tbLength_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHeight.Location = new System.Drawing.Point(239, 51);
            this.tbHeight.MaxLength = 10;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(173, 21);
            this.tbHeight.TabIndex = 3;
            this.tbHeight.Click += new System.EventHandler(this.tbWidth_Click);
            // 
            // cbSingleLeaf
            // 
            this.cbSingleLeaf.AutoSize = true;
            this.cbSingleLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSingleLeaf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSingleLeaf.Location = new System.Drawing.Point(6, 28);
            this.cbSingleLeaf.Name = "cbSingleLeaf";
            this.cbSingleLeaf.Size = new System.Drawing.Size(134, 21);
            this.cbSingleLeaf.TabIndex = 4;
            this.cbSingleLeaf.Text = "Одностворчатые";
            this.cbSingleLeaf.UseVisualStyleBackColor = true;
            this.cbSingleLeaf.CheckedChanged += new System.EventHandler(this.cbSingleLeaf_CheckedChanged);
            // 
            // cbDoubleLeaf
            // 
            this.cbDoubleLeaf.AutoSize = true;
            this.cbDoubleLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoubleLeaf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDoubleLeaf.Location = new System.Drawing.Point(6, 63);
            this.cbDoubleLeaf.Name = "cbDoubleLeaf";
            this.cbDoubleLeaf.Size = new System.Drawing.Size(120, 21);
            this.cbDoubleLeaf.TabIndex = 5;
            this.cbDoubleLeaf.Text = "Двустворчатые";
            this.cbDoubleLeaf.UseVisualStyleBackColor = true;
            this.cbDoubleLeaf.CheckedChanged += new System.EventHandler(this.cbDoubleLeaf_CheckedChanged);
            // 
            // cbTripleLeaf
            // 
            this.cbTripleLeaf.AutoSize = true;
            this.cbTripleLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTripleLeaf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTripleLeaf.Location = new System.Drawing.Point(6, 98);
            this.cbTripleLeaf.Name = "cbTripleLeaf";
            this.cbTripleLeaf.Size = new System.Drawing.Size(126, 21);
            this.cbTripleLeaf.TabIndex = 6;
            this.cbTripleLeaf.Text = "Трёхстворчатые";
            this.cbTripleLeaf.UseVisualStyleBackColor = true;
            this.cbTripleLeaf.CheckedChanged += new System.EventHandler(this.cbTripleLeaf_CheckedChanged);
            // 
            // gbWindowType
            // 
            this.gbWindowType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbWindowType.Controls.Add(this.nudBalc);
            this.gbWindowType.Controls.Add(this.nudTripleLeaf);
            this.gbWindowType.Controls.Add(this.nudDoubleLeaf);
            this.gbWindowType.Controls.Add(this.nudSingleLeaf);
            this.gbWindowType.Controls.Add(this.cbBalconyBlock);
            this.gbWindowType.Controls.Add(this.cbSingleLeaf);
            this.gbWindowType.Controls.Add(this.cbTripleLeaf);
            this.gbWindowType.Controls.Add(this.cbDoubleLeaf);
            this.gbWindowType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWindowType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbWindowType.Location = new System.Drawing.Point(15, 98);
            this.gbWindowType.Name = "gbWindowType";
            this.gbWindowType.Size = new System.Drawing.Size(215, 165);
            this.gbWindowType.TabIndex = 7;
            this.gbWindowType.TabStop = false;
            this.gbWindowType.Text = "Какой тип окна нужен?";
            // 
            // nudBalc
            // 
            this.nudBalc.Location = new System.Drawing.Point(150, 132);
            this.nudBalc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBalc.Name = "nudBalc";
            this.nudBalc.Size = new System.Drawing.Size(47, 23);
            this.nudBalc.TabIndex = 11;
            this.nudBalc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBalc.Visible = false;
            // 
            // nudTripleLeaf
            // 
            this.nudTripleLeaf.Location = new System.Drawing.Point(150, 97);
            this.nudTripleLeaf.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTripleLeaf.Name = "nudTripleLeaf";
            this.nudTripleLeaf.Size = new System.Drawing.Size(47, 23);
            this.nudTripleLeaf.TabIndex = 10;
            this.nudTripleLeaf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTripleLeaf.Visible = false;
            // 
            // nudDoubleLeaf
            // 
            this.nudDoubleLeaf.Location = new System.Drawing.Point(150, 62);
            this.nudDoubleLeaf.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDoubleLeaf.Name = "nudDoubleLeaf";
            this.nudDoubleLeaf.Size = new System.Drawing.Size(47, 23);
            this.nudDoubleLeaf.TabIndex = 9;
            this.nudDoubleLeaf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDoubleLeaf.Visible = false;
            // 
            // nudSingleLeaf
            // 
            this.nudSingleLeaf.Location = new System.Drawing.Point(150, 27);
            this.nudSingleLeaf.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSingleLeaf.Name = "nudSingleLeaf";
            this.nudSingleLeaf.Size = new System.Drawing.Size(47, 23);
            this.nudSingleLeaf.TabIndex = 8;
            this.nudSingleLeaf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSingleLeaf.Visible = false;
            // 
            // cbBalconyBlock
            // 
            this.cbBalconyBlock.AutoSize = true;
            this.cbBalconyBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBalconyBlock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBalconyBlock.Location = new System.Drawing.Point(6, 133);
            this.cbBalconyBlock.Name = "cbBalconyBlock";
            this.cbBalconyBlock.Size = new System.Drawing.Size(132, 21);
            this.cbBalconyBlock.TabIndex = 7;
            this.cbBalconyBlock.Text = "Балконный блок";
            this.cbBalconyBlock.UseVisualStyleBackColor = true;
            this.cbBalconyBlock.CheckedChanged += new System.EventHandler(this.cbBalconyBlock_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.SystemColors.Control;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(250, 280);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(162, 33);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 316);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbWindowType);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lLength);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.gbWindowType.ResumeLayout(false);
            this.gbWindowType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripleLeaf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoubleLeaf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSingleLeaf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLength;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.CheckBox cbSingleLeaf;
        private System.Windows.Forms.CheckBox cbDoubleLeaf;
        private System.Windows.Forms.CheckBox cbTripleLeaf;
        private System.Windows.Forms.GroupBox gbWindowType;
        private System.Windows.Forms.CheckBox cbBalconyBlock;
        private System.Windows.Forms.NumericUpDown nudBalc;
        private System.Windows.Forms.NumericUpDown nudTripleLeaf;
        private System.Windows.Forms.NumericUpDown nudDoubleLeaf;
        private System.Windows.Forms.NumericUpDown nudSingleLeaf;
        private System.Windows.Forms.Button btnOk;
    }
}