
namespace _0407muveletek
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
            this.ujBT = new System.Windows.Forms.Button();
            this.feladatTB = new System.Windows.Forms.TextBox();
            this.valaszTB = new System.Windows.Forms.TextBox();
            this.ellBT = new System.Windows.Forms.Button();
            this.visszajelTB = new System.Windows.Forms.TextBox();
            this.valaszLB = new System.Windows.Forms.Label();
            this.feladatLB = new System.Windows.Forms.Label();
            this.statLB = new System.Windows.Forms.ListBox();
            this.megoldasBT = new System.Windows.Forms.Button();
            this.muveletekCB = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ujBT
            // 
            this.ujBT.Location = new System.Drawing.Point(272, 62);
            this.ujBT.Name = "ujBT";
            this.ujBT.Size = new System.Drawing.Size(100, 23);
            this.ujBT.TabIndex = 1;
            this.ujBT.Text = "Új Kérdés";
            this.ujBT.UseVisualStyleBackColor = true;
            this.ujBT.Click += new System.EventHandler(this.ujBT_Click);
            // 
            // feladatTB
            // 
            this.feladatTB.Cursor = System.Windows.Forms.Cursors.No;
            this.feladatTB.Location = new System.Drawing.Point(45, 146);
            this.feladatTB.Name = "feladatTB";
            this.feladatTB.ReadOnly = true;
            this.feladatTB.Size = new System.Drawing.Size(179, 22);
            this.feladatTB.TabIndex = 4;
            this.feladatTB.Text = "12 + 37 =";
            // 
            // valaszTB
            // 
            this.valaszTB.Location = new System.Drawing.Point(45, 222);
            this.valaszTB.Name = "valaszTB";
            this.valaszTB.Size = new System.Drawing.Size(100, 22);
            this.valaszTB.TabIndex = 5;
            this.valaszTB.Text = "49";
            // 
            // ellBT
            // 
            this.ellBT.Location = new System.Drawing.Point(175, 221);
            this.ellBT.Name = "ellBT";
            this.ellBT.Size = new System.Drawing.Size(83, 23);
            this.ellBT.TabIndex = 6;
            this.ellBT.Text = "Ellenörzés";
            this.ellBT.UseVisualStyleBackColor = true;
            this.ellBT.Click += new System.EventHandler(this.ellBT_Click);
            // 
            // visszajelTB
            // 
            this.visszajelTB.Location = new System.Drawing.Point(272, 146);
            this.visszajelTB.Name = "visszajelTB";
            this.visszajelTB.ReadOnly = true;
            this.visszajelTB.Size = new System.Drawing.Size(100, 22);
            this.visszajelTB.TabIndex = 7;
            this.visszajelTB.Text = "Jó megoldás";
            // 
            // valaszLB
            // 
            this.valaszLB.AutoSize = true;
            this.valaszLB.Location = new System.Drawing.Point(42, 198);
            this.valaszLB.Name = "valaszLB";
            this.valaszLB.Size = new System.Drawing.Size(50, 17);
            this.valaszLB.TabIndex = 8;
            this.valaszLB.Text = "Válasz";
            // 
            // feladatLB
            // 
            this.feladatLB.AutoSize = true;
            this.feladatLB.Location = new System.Drawing.Point(42, 122);
            this.feladatLB.Name = "feladatLB";
            this.feladatLB.Size = new System.Drawing.Size(59, 17);
            this.feladatLB.TabIndex = 9;
            this.feladatLB.Text = "Feladat:";
            // 
            // statLB
            // 
            this.statLB.ItemHeight = 16;
            this.statLB.Items.AddRange(new object[] {
            "Statisztika:",
            "összeadás:\t10 / 10",
            "kivonás:\t\t10 / 6",
            "Szorzás:\t\t10 / 10",
            "Osztás:\t\t10 / 4",
            "Összesen:\t40 / 30"});
            this.statLB.Location = new System.Drawing.Point(442, 61);
            this.statLB.Name = "statLB";
            this.statLB.Size = new System.Drawing.Size(183, 132);
            this.statLB.TabIndex = 11;
            // 
            // megoldasBT
            // 
            this.megoldasBT.Location = new System.Drawing.Point(282, 221);
            this.megoldasBT.Name = "megoldasBT";
            this.megoldasBT.Size = new System.Drawing.Size(90, 23);
            this.megoldasBT.TabIndex = 12;
            this.megoldasBT.Text = "Megoldás";
            this.megoldasBT.UseVisualStyleBackColor = true;
            // 
            // muveletekCB
            // 
            this.muveletekCB.FormattingEnabled = true;
            this.muveletekCB.Items.AddRange(new object[] {
            "Összeadás",
            "Kivonás",
            "Szorzás",
            "Osztás"});
            this.muveletekCB.Location = new System.Drawing.Point(45, 61);
            this.muveletekCB.Name = "muveletekCB";
            this.muveletekCB.Size = new System.Drawing.Size(121, 24);
            this.muveletekCB.TabIndex = 0;
            this.muveletekCB.Text = "Müveletek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 362);
            this.Controls.Add(this.megoldasBT);
            this.Controls.Add(this.statLB);
            this.Controls.Add(this.feladatLB);
            this.Controls.Add(this.valaszLB);
            this.Controls.Add(this.visszajelTB);
            this.Controls.Add(this.ellBT);
            this.Controls.Add(this.valaszTB);
            this.Controls.Add(this.feladatTB);
            this.Controls.Add(this.ujBT);
            this.Controls.Add(this.muveletekCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ujBT;
        private System.Windows.Forms.TextBox feladatTB;
        private System.Windows.Forms.TextBox valaszTB;
        private System.Windows.Forms.Button ellBT;
        private System.Windows.Forms.TextBox visszajelTB;
        private System.Windows.Forms.Label valaszLB;
        private System.Windows.Forms.Label feladatLB;
        private System.Windows.Forms.ListBox statLB;
        private System.Windows.Forms.Button megoldasBT;
        private System.Windows.Forms.ComboBox muveletekCB;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

