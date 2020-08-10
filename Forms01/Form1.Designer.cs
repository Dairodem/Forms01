namespace Forms01
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.lbMijnLijst = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFullList = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbNamenLijst = new System.Windows.Forms.ListBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbVoornamen = new System.Windows.Forms.ComboBox();
            this.btnShowName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(21, 49);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(165, 26);
            this.txtInput1.TabIndex = 1;
            this.txtInput1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(201, 49);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(100, 26);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // lbMijnLijst
            // 
            this.lbMijnLijst.FormattingEnabled = true;
            this.lbMijnLijst.ItemHeight = 16;
            this.lbMijnLijst.Location = new System.Drawing.Point(21, 92);
            this.lbMijnLijst.Name = "lbMijnLijst";
            this.lbMijnLijst.Size = new System.Drawing.Size(280, 132);
            this.lbMijnLijst.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(327, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 471);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbFullList
            // 
            this.cbFullList.FormattingEnabled = true;
            this.cbFullList.Location = new System.Drawing.Point(25, 310);
            this.cbFullList.Name = "cbFullList";
            this.cbFullList.Size = new System.Drawing.Size(161, 24);
            this.cbFullList.TabIndex = 5;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(201, 310);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(100, 26);
            this.btnVerwijder.TabIndex = 6;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lbNamenLijst
            // 
            this.lbNamenLijst.FormattingEnabled = true;
            this.lbNamenLijst.ItemHeight = 16;
            this.lbNamenLijst.Location = new System.Drawing.Point(591, 12);
            this.lbNamenLijst.Name = "lbNamenLijst";
            this.lbNamenLijst.Size = new System.Drawing.Size(155, 180);
            this.lbNamenLijst.TabIndex = 7;
            this.lbNamenLijst.SelectedIndexChanged += new System.EventHandler(this.lbNamenLijst_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(591, 258);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(155, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(591, 213);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(155, 22);
            this.txtFilter.TabIndex = 9;
            // 
            // cbVoornamen
            // 
            this.cbVoornamen.FormattingEnabled = true;
            this.cbVoornamen.Location = new System.Drawing.Point(585, 360);
            this.cbVoornamen.Name = "cbVoornamen";
            this.cbVoornamen.Size = new System.Drawing.Size(161, 24);
            this.cbVoornamen.TabIndex = 11;
            this.cbVoornamen.SelectedIndexChanged += new System.EventHandler(this.cbVoornamen_SelectedIndexChanged);
            // 
            // btnShowName
            // 
            this.btnShowName.Location = new System.Drawing.Point(585, 391);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(161, 23);
            this.btnShowName.TabIndex = 12;
            this.btnShowName.Text = "Toon Naam";
            this.btnShowName.UseVisualStyleBackColor = true;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Oefening 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowName);
            this.Controls.Add(this.cbVoornamen);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lbNamenLijst);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.cbFullList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMijnLijst);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.txtInput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsOefeningen01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.ListBox lbMijnLijst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFullList;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListBox lbNamenLijst;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbVoornamen;
        private System.Windows.Forms.Button btnShowName;
        private System.Windows.Forms.Label label1;
    }
}

