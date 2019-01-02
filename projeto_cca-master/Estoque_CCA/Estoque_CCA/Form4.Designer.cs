namespace Estoque_CCA
{
    partial class Form4
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
            System.Windows.Forms.Label dt_retornoLabel;
            System.Windows.Forms.Label caixaLabel;
            System.Windows.Forms.Label prontLabel;
            System.Windows.Forms.Label medicamentoLabel;
            System.Windows.Forms.Label qntLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.database1DataSet = new Estoque_CCA.Database1DataSet();
            this.sampleboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleboxTableAdapter = new Estoque_CCA.Database1DataSetTableAdapters.sampleboxTableAdapter();
            this.tableAdapterManager = new Estoque_CCA.Database1DataSetTableAdapters.TableAdapterManager();
            this.dt_retornoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.caixaTextBox = new System.Windows.Forms.TextBox();
            this.prontTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new Estoque_CCA.Database1DataSetTableAdapters.estoqueTableAdapter();
            this.medicamentoComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            dt_retornoLabel = new System.Windows.Forms.Label();
            caixaLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            medicamentoLabel = new System.Windows.Forms.Label();
            qntLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Fecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleboxBindingSource
            // 
            this.sampleboxBindingSource.DataMember = "samplebox";
            this.sampleboxBindingSource.DataSource = this.database1DataSet;
            // 
            // sampleboxTableAdapter
            // 
            this.sampleboxTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.sampleboxTableAdapter = this.sampleboxTableAdapter;
            this.tableAdapterManager.UpdateOrder = Estoque_CCA.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dt_retornoLabel
            // 
            dt_retornoLabel.AutoSize = true;
            dt_retornoLabel.Location = new System.Drawing.Point(8, 17);
            dt_retornoLabel.Name = "dt_retornoLabel";
            dt_retornoLabel.Size = new System.Drawing.Size(55, 13);
            dt_retornoLabel.TabIndex = 28;
            dt_retornoLabel.Text = "dt retorno:";
            // 
            // dt_retornoDateTimePicker
            // 
            this.dt_retornoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sampleboxBindingSource, "dt_retorno", true));
            this.dt_retornoDateTimePicker.Enabled = false;
            this.dt_retornoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_retornoDateTimePicker.Location = new System.Drawing.Point(69, 13);
            this.dt_retornoDateTimePicker.Name = "dt_retornoDateTimePicker";
            this.dt_retornoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dt_retornoDateTimePicker.TabIndex = 29;
            // 
            // caixaTextBox
            // 
            this.caixaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "caixa", true));
            this.caixaTextBox.Location = new System.Drawing.Point(70, 56);
            this.caixaTextBox.Name = "caixaTextBox";
            this.caixaTextBox.Size = new System.Drawing.Size(100, 20);
            this.caixaTextBox.TabIndex = 27;
            // 
            // caixaLabel
            // 
            caixaLabel.AutoSize = true;
            caixaLabel.Location = new System.Drawing.Point(8, 56);
            caixaLabel.Name = "caixaLabel";
            caixaLabel.Size = new System.Drawing.Size(35, 13);
            caixaLabel.TabIndex = 26;
            caixaLabel.Text = "caixa:";
            // 
            // prontTextBox
            // 
            this.prontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "pront", true));
            this.prontTextBox.Location = new System.Drawing.Point(227, 56);
            this.prontTextBox.Name = "prontTextBox";
            this.prontTextBox.Size = new System.Drawing.Size(100, 20);
            this.prontTextBox.TabIndex = 28;
            // 
            // prontLabel
            // 
            prontLabel.AutoSize = true;
            prontLabel.Location = new System.Drawing.Point(187, 59);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(34, 13);
            prontLabel.TabIndex = 27;
            prontLabel.Text = "pront:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(299, 138);
            this.dataGridView1.TabIndex = 30;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "status", true));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(347, 56);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 31;
            this.statusTextBox.Text = "Na Farmácia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.statusTextBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.caixaTextBox);
            this.panel1.Controls.Add(caixaLabel);
            this.panel1.Controls.Add(dt_retornoLabel);
            this.panel1.Controls.Add(this.prontTextBox);
            this.panel1.Controls.Add(this.dt_retornoDateTimePicker);
            this.panel1.Controls.Add(prontLabel);
            this.panel1.Location = new System.Drawing.Point(16, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 154);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            this.estoqueBindingSource.DataSource = this.database1DataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentoLabel
            // 
            medicamentoLabel.AutoSize = true;
            medicamentoLabel.Location = new System.Drawing.Point(22, 223);
            medicamentoLabel.Name = "medicamentoLabel";
            medicamentoLabel.Size = new System.Drawing.Size(114, 13);
            medicamentoLabel.TabIndex = 32;
            medicamentoLabel.Text = "Medicamento Utilizado";
            // 
            // medicamentoComboBox
            // 
            this.medicamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "medicamento", true));
            this.medicamentoComboBox.DataSource = this.estoqueBindingSource;
            this.medicamentoComboBox.DisplayMember = "medicamento";
            this.medicamentoComboBox.FormattingEnabled = true;
            this.medicamentoComboBox.Location = new System.Drawing.Point(25, 258);
            this.medicamentoComboBox.Name = "medicamentoComboBox";
            this.medicamentoComboBox.Size = new System.Drawing.Size(258, 21);
            this.medicamentoComboBox.TabIndex = 33;
            // 
            // qntLabel
            // 
            qntLabel.AutoSize = true;
            qntLabel.Location = new System.Drawing.Point(310, 258);
            qntLabel.Name = "qntLabel";
            qntLabel.Size = new System.Drawing.Size(68, 13);
            qntLabel.TabIndex = 33;
            qntLabel.Text = "Quantidade: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(384, 253);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 37;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 466);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(qntLabel);
            this.Controls.Add(medicamentoLabel);
            this.Controls.Add(this.medicamentoComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "Form4";
            this.Text = "Retorno";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource sampleboxBindingSource;
        private Database1DataSetTableAdapters.sampleboxTableAdapter sampleboxTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dt_retornoDateTimePicker;
        private System.Windows.Forms.TextBox caixaTextBox;
        private System.Windows.Forms.TextBox prontTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private System.Windows.Forms.ComboBox medicamentoComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}