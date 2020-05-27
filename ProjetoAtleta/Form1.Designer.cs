namespace ProjetoAtleta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_IMC = new System.Windows.Forms.TextBox();
            this.lbl_IMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nome:";
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Location = new System.Drawing.Point(12, 45);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(107, 13);
            this.lbl_birth.TabIndex = 1;
            this.lbl_birth.Text = "Data de Nascimento:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(12, 75);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(37, 13);
            this.lbl_height.TabIndex = 2;
            this.lbl_height.Text = "Altura:";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(118, 221);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(37, 13);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Idade:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(130, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(139, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(130, 72);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(139, 20);
            this.txt_height.TabIndex = 6;
            // 
            // dtp_birth
            // 
            this.dtp_birth.Checked = false;
            this.dtp_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birth.Location = new System.Drawing.Point(130, 39);
            this.dtp_birth.MaxDate = new System.DateTime(2020, 5, 25, 0, 0, 0, 0);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(139, 20);
            this.dtp_birth.TabIndex = 7;
            this.dtp_birth.Value = new System.DateTime(2020, 5, 25, 0, 0, 0, 0);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(15, 136);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(255, 38);
            this.btn_set.TabIndex = 8;
            this.btn_set.Text = "ENVIAR dados";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(15, 180);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(255, 38);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(130, 105);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(139, 20);
            this.txt_weight.TabIndex = 11;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(12, 108);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(34, 13);
            this.lbl_weight.TabIndex = 10;
            this.lbl_weight.Text = "Peso:";
            // 
            // txt_age
            // 
            this.txt_age.Enabled = false;
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(94, 237);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(85, 31);
            this.txt_age.TabIndex = 12;
            this.txt_age.Text = "0";
            this.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IMC
            // 
            this.txt_IMC.Enabled = false;
            this.txt_IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IMC.Location = new System.Drawing.Point(94, 287);
            this.txt_IMC.Name = "txt_IMC";
            this.txt_IMC.Size = new System.Drawing.Size(85, 31);
            this.txt_IMC.TabIndex = 14;
            this.txt_IMC.Text = "0";
            this.txt_IMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_IMC
            // 
            this.lbl_IMC.AutoSize = true;
            this.lbl_IMC.Location = new System.Drawing.Point(120, 271);
            this.lbl_IMC.Name = "lbl_IMC";
            this.lbl_IMC.Size = new System.Drawing.Size(32, 13);
            this.lbl_IMC.TabIndex = 13;
            this.lbl_IMC.Text = "FMC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 324);
            this.Controls.Add(this.txt_IMC);
            this.Controls.Add(this.lbl_IMC);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.dtp_birth);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_IMC;
        private System.Windows.Forms.Label lbl_IMC;
    }
}

