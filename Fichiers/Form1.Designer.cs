
namespace Fichiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFichiers = new System.Windows.Forms.ListBox();
            this.lstSelection = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnTout = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.lblFichiers = new System.Windows.Forms.Label();
            this.lblFicSelec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichiers du dossier :";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(153, 12);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(98, 25);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fichiers sélectionnés :";
            // 
            // lstFichiers
            // 
            this.lstFichiers.FormattingEnabled = true;
            this.lstFichiers.ItemHeight = 16;
            this.lstFichiers.Location = new System.Drawing.Point(15, 45);
            this.lstFichiers.Name = "lstFichiers";
            this.lstFichiers.ScrollAlwaysVisible = true;
            this.lstFichiers.Size = new System.Drawing.Size(236, 260);
            this.lstFichiers.TabIndex = 3;
            // 
            // lstSelection
            // 
            this.lstSelection.FormattingEnabled = true;
            this.lstSelection.ItemHeight = 16;
            this.lstSelection.Location = new System.Drawing.Point(338, 45);
            this.lstSelection.Name = "lstSelection";
            this.lstSelection.Size = new System.Drawing.Size(245, 260);
            this.lstSelection.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Location = new System.Drawing.Point(257, 100);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 68);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnTout
            // 
            this.btnTout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTout.BackgroundImage")));
            this.btnTout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTout.Location = new System.Drawing.Point(257, 174);
            this.btnTout.Name = "btnTout";
            this.btnTout.Size = new System.Drawing.Size(75, 70);
            this.btnTout.TabIndex = 6;
            this.btnTout.UseVisualStyleBackColor = true;
            this.btnTout.Click += new System.EventHandler(this.btnTout_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuppr.BackgroundImage")));
            this.btnSuppr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppr.Location = new System.Drawing.Point(589, 100);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 68);
            this.btnSuppr.TabIndex = 7;
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnVider
            // 
            this.btnVider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVider.BackgroundImage")));
            this.btnVider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVider.Location = new System.Drawing.Point(589, 174);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 70);
            this.btnVider.TabIndex = 8;
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblFichiers
            // 
            this.lblFichiers.AutoSize = true;
            this.lblFichiers.Location = new System.Drawing.Point(12, 326);
            this.lblFichiers.Name = "lblFichiers";
            this.lblFichiers.Size = new System.Drawing.Size(0, 17);
            this.lblFichiers.TabIndex = 9;
            // 
            // lblFicSelec
            // 
            this.lblFicSelec.AutoSize = true;
            this.lblFicSelec.Location = new System.Drawing.Point(335, 326);
            this.lblFicSelec.Name = "lblFicSelec";
            this.lblFicSelec.Size = new System.Drawing.Size(0, 17);
            this.lblFicSelec.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 367);
            this.Controls.Add(this.lblFicSelec);
            this.Controls.Add(this.lblFichiers);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnTout);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lstSelection);
            this.Controls.Add(this.lstFichiers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fichiers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFichiers;
        private System.Windows.Forms.ListBox lstSelection;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnTout;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblFichiers;
        private System.Windows.Forms.Label lblFicSelec;
    }
}

