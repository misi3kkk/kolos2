
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kobieta = new System.Windows.Forms.RadioButton();
            this.men = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aktywnosc = new System.Windows.Forms.ComboBox();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            this.SuspendLayout();
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.Location = new System.Drawing.Point(60, 44);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(32, 19);
            this.kobieta.TabIndex = 0;
            this.kobieta.TabStop = true;
            this.kobieta.Text = "K";
            this.kobieta.UseVisualStyleBackColor = true;
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(149, 44);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(36, 19);
            this.men.TabIndex = 1;
            this.men.TabStop = true;
            this.men.Text = "M";
            this.men.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wiek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wzrost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Poziom aktywnośći fizycznej";
            // 
            // aktywnosc
            // 
            this.aktywnosc.FormattingEnabled = true;
            this.aktywnosc.Items.AddRange(new object[] {
            "Brak aktywności",
            "Bardzo lekka aktywność (1 dzień w tygodniu)",
            "Lekka aktywność (2-3 dni w tygodniu)",
            "Średnia aktywność (4-5  dni w tygodniu)",
            "Duża aktywność (codziennie)",
            "Bardzo duża aktywność "});
            this.aktywnosc.Location = new System.Drawing.Point(182, 295);
            this.aktywnosc.Name = "aktywnosc";
            this.aktywnosc.Size = new System.Drawing.Size(157, 23);
            this.aktywnosc.TabIndex = 6;
            this.aktywnosc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(79, 113);
            this.wiek.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.wiek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(120, 23);
            this.wiek.TabIndex = 7;
            this.wiek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wiek.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(79, 147);
            this.waga.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(120, 23);
            this.waga.TabIndex = 8;
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(79, 181);
            this.wzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(120, 23);
            this.wzrost.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zapisz i Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.aktywnosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.men);
            this.Controls.Add(this.kobieta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton kobieta;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox aktywnosc;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown waga;
        private System.Windows.Forms.NumericUpDown wiek;
        private System.Windows.Forms.NumericUpDown wzrost;
    }
}

