namespace projettaquin
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelcountopen = new System.Windows.Forms.Label();
            this.labelcountclosed = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelsolution = new System.Windows.Forms.Label();
            this.CasAButton = new System.Windows.Forms.Button();
            this.CasBButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasBox = new System.Windows.Forms.TextBox();
            this.ChronoBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(146, 315);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 324);
            this.listBox1.TabIndex = 3;
            // 
            // labelcountopen
            // 
            this.labelcountopen.AutoSize = true;
            this.labelcountopen.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountopen.Location = new System.Drawing.Point(529, 510);
            this.labelcountopen.Name = "labelcountopen";
            this.labelcountopen.Size = new System.Drawing.Size(0, 21);
            this.labelcountopen.TabIndex = 4;
            // 
            // labelcountclosed
            // 
            this.labelcountclosed.AutoSize = true;
            this.labelcountclosed.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountclosed.Location = new System.Drawing.Point(529, 440);
            this.labelcountclosed.Name = "labelcountclosed";
            this.labelcountclosed.Size = new System.Drawing.Size(0, 21);
            this.labelcountclosed.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(790, 108);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(337, 149);
            this.treeView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(851, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arbre de recherche";
            // 
            // labelsolution
            // 
            this.labelsolution.AutoSize = true;
            this.labelsolution.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsolution.Location = new System.Drawing.Point(529, 358);
            this.labelsolution.Name = "labelsolution";
            this.labelsolution.Size = new System.Drawing.Size(0, 21);
            this.labelsolution.TabIndex = 8;
            // 
            // CasAButton
            // 
            this.CasAButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CasAButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasAButton.Location = new System.Drawing.Point(12, 346);
            this.CasAButton.Name = "CasAButton";
            this.CasAButton.Size = new System.Drawing.Size(128, 47);
            this.CasAButton.TabIndex = 0;
            this.CasAButton.Text = "Résoudre cas A";
            this.CasAButton.UseVisualStyleBackColor = false;
            this.CasAButton.Click += new System.EventHandler(this.CasAButtun_Click);
            // 
            // CasBButton
            // 
            this.CasBButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CasBButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasBButton.Location = new System.Drawing.Point(12, 427);
            this.CasBButton.Name = "CasBButton";
            this.CasBButton.Size = new System.Drawing.Size(128, 48);
            this.CasBButton.TabIndex = 9;
            this.CasBButton.Text = "Resoudre cas B";
            this.CasBButton.UseVisualStyleBackColor = false;
            this.CasBButton.Click += new System.EventHandler(this.CasBButton_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Rédoudre cas C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::projettaquin.Properties.Resources.structure_de_connexion_r_seau_fond_abstrait_technologie_futuriste_rendu_d_num_rique_grandes_donn_es_145778385__1_;
            this.pictureBox1.Image = global::projettaquin.Properties.Resources.top_vue_mer_bleu_calme_1122_647;
            this.pictureBox1.Location = new System.Drawing.Point(804, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(71, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 76);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Projet d\'Intelligence Artitficielle";
            // 
            // PasBox
            // 
            this.PasBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PasBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasBox.Location = new System.Drawing.Point(287, 210);
            this.PasBox.Name = "PasBox";
            this.PasBox.Size = new System.Drawing.Size(60, 26);
            this.PasBox.TabIndex = 13;
            // 
            // ChronoBox
            // 
            this.ChronoBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChronoBox.Location = new System.Drawing.Point(211, 162);
            this.ChronoBox.Name = "ChronoBox";
            this.ChronoBox.Size = new System.Drawing.Size(219, 25);
            this.ChronoBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::projettaquin.Properties.Resources.fond_horizon_technologique_futuriste_23_2148288341;
            this.ClientSize = new System.Drawing.Size(1162, 757);
            this.Controls.Add(this.ChronoBox);
            this.Controls.Add(this.PasBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CasBButton);
            this.Controls.Add(this.labelsolution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelcountclosed);
            this.Controls.Add(this.labelcountopen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CasAButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelcountopen;
        private System.Windows.Forms.Label labelcountclosed;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelsolution;
        private System.Windows.Forms.Button CasAButton;
        private System.Windows.Forms.Button CasBButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PasBox;
        private System.Windows.Forms.TextBox ChronoBox;
    }
}

