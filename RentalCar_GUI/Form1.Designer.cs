
namespace RentalCar_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Auto = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Napidij = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_Mikortol = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Meddig = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Fizetendo = new System.Windows.Forms.NumericUpDown();
            this.button_Rogzit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Napidij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetendo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Napidíj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(94, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mikortól";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(95, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Meddig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(75, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fizetendő";
            // 
            // comboBox_Auto
            // 
            this.comboBox_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Auto.FormattingEnabled = true;
            this.comboBox_Auto.Location = new System.Drawing.Point(228, 61);
            this.comboBox_Auto.Name = "comboBox_Auto";
            this.comboBox_Auto.Size = new System.Drawing.Size(275, 30);
            this.comboBox_Auto.TabIndex = 5;
            this.comboBox_Auto.SelectedIndexChanged += new System.EventHandler(this.comboBox_Auto_SelectedIndexChanged);
            // 
            // numericUpDown_Napidij
            // 
            this.numericUpDown_Napidij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Napidij.Location = new System.Drawing.Point(228, 116);
            this.numericUpDown_Napidij.Name = "numericUpDown_Napidij";
            this.numericUpDown_Napidij.Size = new System.Drawing.Size(200, 28);
            this.numericUpDown_Napidij.TabIndex = 6;
            this.numericUpDown_Napidij.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker_Mikortol
            // 
            this.dateTimePicker_Mikortol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_Mikortol.Location = new System.Drawing.Point(228, 164);
            this.dateTimePicker_Mikortol.MinDate = new System.DateTime(2022, 4, 25, 12, 31, 45, 0);
            this.dateTimePicker_Mikortol.Name = "dateTimePicker_Mikortol";
            this.dateTimePicker_Mikortol.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_Mikortol.TabIndex = 7;
            this.dateTimePicker_Mikortol.Value = new System.DateTime(2022, 4, 25, 12, 31, 45, 0);
            // 
            // dateTimePicker_Meddig
            // 
            this.dateTimePicker_Meddig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_Meddig.Location = new System.Drawing.Point(228, 218);
            this.dateTimePicker_Meddig.Name = "dateTimePicker_Meddig";
            this.dateTimePicker_Meddig.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_Meddig.TabIndex = 8;
            // 
            // numericUpDown_Fizetendo
            // 
            this.numericUpDown_Fizetendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Fizetendo.Location = new System.Drawing.Point(228, 268);
            this.numericUpDown_Fizetendo.Name = "numericUpDown_Fizetendo";
            this.numericUpDown_Fizetendo.Size = new System.Drawing.Size(200, 28);
            this.numericUpDown_Fizetendo.TabIndex = 9;
            this.numericUpDown_Fizetendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Rogzit
            // 
            this.button_Rogzit.Location = new System.Drawing.Point(228, 343);
            this.button_Rogzit.Name = "button_Rogzit";
            this.button_Rogzit.Size = new System.Drawing.Size(275, 38);
            this.button_Rogzit.TabIndex = 10;
            this.button_Rogzit.Text = "Rögzít";
            this.button_Rogzit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Rogzit);
            this.Controls.Add(this.numericUpDown_Fizetendo);
            this.Controls.Add(this.dateTimePicker_Meddig);
            this.Controls.Add(this.dateTimePicker_Mikortol);
            this.Controls.Add(this.numericUpDown_Napidij);
            this.Controls.Add(this.comboBox_Auto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Autó kölcsönzés";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Napidij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetendo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Auto;
        private System.Windows.Forms.NumericUpDown numericUpDown_Napidij;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Mikortol;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Meddig;
        private System.Windows.Forms.NumericUpDown numericUpDown_Fizetendo;
        private System.Windows.Forms.Button button_Rogzit;
    }
}

