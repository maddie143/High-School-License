namespace Atestat
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareComenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.preparateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelDataSet = new Atestat.tabelDataSet();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new Atestat.tabelDataSetTableAdapters.ComandaTableAdapter();
            this.meniuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meniuTableAdapter = new Atestat.tabelDataSetTableAdapters.MeniuTableAdapter();
            this.nrcomandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nr_comandaTableAdapter = new Atestat.tabelDataSetTableAdapters.Nr_comandaTableAdapter();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new Atestat.tabelDataSetTableAdapters.PersonalTableAdapter();
            this.preparateTableAdapter = new Atestat.tabelDataSetTableAdapters.PreparateTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preparateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrcomandaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.comandaToolStripMenuItem,
            this.vizualizareComenziToolStripMenuItem,
            this.modificareComandaToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.meniuToolStripMenuItem.Text = "Meniu";
            this.meniuToolStripMenuItem.Click += new System.EventHandler(this.meniuToolStripMenuItem_Click);
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.comandaToolStripMenuItem.Text = "Comanda";
            this.comandaToolStripMenuItem.Click += new System.EventHandler(this.comandaToolStripMenuItem_Click);
            // 
            // vizualizareComenziToolStripMenuItem
            // 
            this.vizualizareComenziToolStripMenuItem.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.vizualizareComenziToolStripMenuItem.Name = "vizualizareComenziToolStripMenuItem";
            this.vizualizareComenziToolStripMenuItem.Size = new System.Drawing.Size(192, 29);
            this.vizualizareComenziToolStripMenuItem.Text = "Vizualizare comenzi";
            this.vizualizareComenziToolStripMenuItem.Click += new System.EventHandler(this.vizualizareComenziToolStripMenuItem_Click_1);
            // 
            // modificareComandaToolStripMenuItem
            // 
            this.modificareComandaToolStripMenuItem.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.modificareComandaToolStripMenuItem.Name = "modificareComandaToolStripMenuItem";
            this.modificareComandaToolStripMenuItem.Size = new System.Drawing.Size(196, 29);
            this.modificareComandaToolStripMenuItem.Text = "Modificare comanda";
            this.modificareComandaToolStripMenuItem.Click += new System.EventHandler(this.modificareComandaToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(289, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(289, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAROLA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.button1.Location = new System.Drawing.Point(338, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Intrare tura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.button2.Location = new System.Drawing.Point(338, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Iesire tura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // preparateBindingSource
            // 
            this.preparateBindingSource.DataMember = "Preparate";
            this.preparateBindingSource.DataSource = this.tabelDataSet;
            // 
            // tabelDataSet
            // 
            this.tabelDataSet.DataSetName = "tabelDataSet";
            this.tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandaBindingSource
            // 
            this.comandaBindingSource.DataMember = "Comanda";
            this.comandaBindingSource.DataSource = this.tabelDataSet;
            // 
            // comandaTableAdapter
            // 
            this.comandaTableAdapter.ClearBeforeFill = true;
            // 
            // meniuBindingSource
            // 
            this.meniuBindingSource.DataMember = "Meniu";
            this.meniuBindingSource.DataSource = this.tabelDataSet;
            // 
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // nrcomandaBindingSource
            // 
            this.nrcomandaBindingSource.DataMember = "Nr_comanda";
            this.nrcomandaBindingSource.DataSource = this.tabelDataSet;
            // 
            // nr_comandaTableAdapter
            // 
            this.nr_comandaTableAdapter.ClearBeforeFill = true;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.tabelDataSet;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // preparateTableAdapter
            // 
            this.preparateTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preparateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrcomandaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareComenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private tabelDataSet tabelDataSet;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private tabelDataSetTableAdapters.ComandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.BindingSource meniuBindingSource;
        private tabelDataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private System.Windows.Forms.BindingSource nrcomandaBindingSource;
        private tabelDataSetTableAdapters.Nr_comandaTableAdapter nr_comandaTableAdapter;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private tabelDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.BindingSource preparateBindingSource;
        private tabelDataSetTableAdapters.PreparateTableAdapter preparateTableAdapter;
    }
}

