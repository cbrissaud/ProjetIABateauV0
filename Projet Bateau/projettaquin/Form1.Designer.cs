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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textTempsParcours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(208, 383);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 244);
            this.listBox1.TabIndex = 3;
            // 
            // labelcountopen
            // 
            this.labelcountopen.AutoSize = true;
            this.labelcountopen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountopen.Location = new System.Drawing.Point(181, 272);
            this.labelcountopen.Name = "labelcountopen";
            this.labelcountopen.Size = new System.Drawing.Size(0, 26);
            this.labelcountopen.TabIndex = 4;
            // 
            // labelcountclosed
            // 
            this.labelcountclosed.AutoSize = true;
            this.labelcountclosed.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountclosed.Location = new System.Drawing.Point(181, 225);
            this.labelcountclosed.Name = "labelcountclosed";
            this.labelcountclosed.Size = new System.Drawing.Size(0, 26);
            this.labelcountclosed.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(887, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(171, 149);
            this.treeView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(873, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arbre de recherche";
            // 
            // labelsolution
            // 
            this.labelsolution.AutoSize = true;
            this.labelsolution.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsolution.Location = new System.Drawing.Point(181, 174);
            this.labelsolution.Name = "labelsolution";
            this.labelsolution.Size = new System.Drawing.Size(0, 26);
            this.labelsolution.TabIndex = 8;
            // 
            // CasAButton
            // 
            this.CasAButton.BackColor = System.Drawing.Color.SlateGray;
            this.CasAButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasAButton.Location = new System.Drawing.Point(26, 360);
            this.CasAButton.Name = "CasAButton";
            this.CasAButton.Size = new System.Drawing.Size(128, 47);
            this.CasAButton.TabIndex = 0;
            this.CasAButton.Text = "Résoudre cas A";
            this.CasAButton.UseVisualStyleBackColor = false;
            this.CasAButton.Click += new System.EventHandler(this.CasAButtun_Click);
            // 
            // CasBButton
            // 
            this.CasBButton.BackColor = System.Drawing.Color.SlateGray;
            this.CasBButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasBButton.Location = new System.Drawing.Point(26, 459);
            this.CasBButton.Name = "CasBButton";
            this.CasBButton.Size = new System.Drawing.Size(128, 48);
            this.CasBButton.TabIndex = 9;
            this.CasBButton.Text = "Resoudre cas B";
            this.CasBButton.UseVisualStyleBackColor = false;
            this.CasBButton.Click += new System.EventHandler(this.CasBButton_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(26, 571);
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
            this.pictureBox1.Location = new System.Drawing.Point(822, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(65, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 57);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Projet d\'Intelligence Artitficielle";
            // 
            // PasBox
            // 
            this.PasBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PasBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasBox.Location = new System.Drawing.Point(597, 543);
            this.PasBox.Name = "PasBox";
            this.PasBox.Size = new System.Drawing.Size(60, 26);
            this.PasBox.TabIndex = 13;
            // 
            // ChronoBox
            // 
            this.ChronoBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChronoBox.Location = new System.Drawing.Point(554, 472);
            this.ChronoBox.Name = "ChronoBox";
            this.ChronoBox.Size = new System.Drawing.Size(160, 25);
            this.ChronoBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(488, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Temps de parcours du bateau en heures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(518, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chronomètre : Temps d\'éxécution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pas";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textTempsParcours
            // 
            this.textTempsParcours.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTempsParcours.Location = new System.Drawing.Point(554, 383);
            this.textTempsParcours.Name = "textTempsParcours";
            this.textTempsParcours.Size = new System.Drawing.Size(160, 26);
            this.textTempsParcours.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Noeuds parcourus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::projettaquin.Properties.Resources.fond_horizon_technologique_futuriste_23_2148288341;
            this.ClientSize = new System.Drawing.Size(1162, 757);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTempsParcours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ForeColor = System.Drawing.SystemColors.Window;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textTempsParcours;
        private System.Windows.Forms.Label label6;
    }
}

