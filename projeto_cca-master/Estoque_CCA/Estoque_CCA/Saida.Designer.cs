namespace Estoque_CCA
{
    partial class Saida
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
            System.Windows.Forms.Label salaLabel;
            System.Windows.Forms.Label caixaLabel;
            System.Windows.Forms.Label prontLabel;
            System.Windows.Forms.Label dt_saidaLabel;
            System.Windows.Forms.Label extraLabel;
            System.Windows.Forms.Label qntLabel;
            System.Windows.Forms.Label statusLabel;
            this.salaComboBox = new System.Windows.Forms.ComboBox();
            this.sampleboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Estoque_CCA.Database1DataSet();
            this.caixaTextBox = new System.Windows.Forms.TextBox();
            this.prontTextBox = new System.Windows.Forms.TextBox();
            this.dt_saidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qntNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.extraComboBox = new System.Windows.Forms.ComboBox();
            this.sampleboxTableAdapter = new Estoque_CCA.Database1DataSetTableAdapters.sampleboxTableAdapter();
            this.tableAdapterManager = new Estoque_CCA.Database1DataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            salaLabel = new System.Windows.Forms.Label();
            caixaLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            dt_saidaLabel = new System.Windows.Forms.Label();
            extraLabel = new System.Windows.Forms.Label();
            qntLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sampleboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salaLabel
            // 
            salaLabel.AutoSize = true;
            salaLabel.Location = new System.Drawing.Point(26, 68);
            salaLabel.Name = "salaLabel";
            salaLabel.Size = new System.Drawing.Size(29, 13);
            salaLabel.TabIndex = 3;
            salaLabel.Text = "sala:";
            // 
            // caixaLabel
            // 
            caixaLabel.AutoSize = true;
            caixaLabel.Location = new System.Drawing.Point(192, 68);
            caixaLabel.Name = "caixaLabel";
            caixaLabel.Size = new System.Drawing.Size(35, 13);
            caixaLabel.TabIndex = 5;
            caixaLabel.Text = "caixa:";
            // 
            // prontLabel
            // 
            prontLabel.AutoSize = true;
            prontLabel.Location = new System.Drawing.Point(318, 68);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(34, 13);
            prontLabel.TabIndex = 7;
            prontLabel.Text = "pront:";
            // 
            // dt_saidaLabel
            // 
            dt_saidaLabel.AutoSize = true;
            dt_saidaLabel.Location = new System.Drawing.Point(24, 3);
            dt_saidaLabel.Name = "dt_saidaLabel";
            dt_saidaLabel.Size = new System.Drawing.Size(57, 13);
            dt_saidaLabel.TabIndex = 9;
            dt_saidaLabel.Text = "Data Atual";
            // 
            // extraLabel
            // 
            extraLabel.AutoSize = true;
            extraLabel.Location = new System.Drawing.Point(26, 130);
            extraLabel.Name = "extraLabel";
            extraLabel.Size = new System.Drawing.Size(33, 13);
            extraLabel.TabIndex = 13;
            extraLabel.Text = "extra:";
            // 
            // qntLabel
            // 
            qntLabel.AutoSize = true;
            qntLabel.Location = new System.Drawing.Point(256, 161);
            qntLabel.Name = "qntLabel";
            qntLabel.Size = new System.Drawing.Size(25, 13);
            qntLabel.TabIndex = 15;
            qntLabel.Text = "qnt:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(372, 161);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 18;
            statusLabel.Text = "status:";
            // 
            // salaComboBox
            // 
            this.salaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "sala", true));
            this.salaComboBox.FormattingEnabled = true;
            this.salaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "Hemodinâmica",
            "Radiologia",
            "UMNI"});
            this.salaComboBox.Location = new System.Drawing.Point(29, 95);
            this.salaComboBox.Name = "salaComboBox";
            this.salaComboBox.Size = new System.Drawing.Size(127, 21);
            this.salaComboBox.TabIndex = 4;
            // 
            // sampleboxBindingSource
            // 
            this.sampleboxBindingSource.DataMember = "samplebox";
            this.sampleboxBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // caixaTextBox
            // 
            this.caixaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "caixa", true));
            this.caixaTextBox.Location = new System.Drawing.Point(195, 95);
            this.caixaTextBox.Name = "caixaTextBox";
            this.caixaTextBox.Size = new System.Drawing.Size(101, 20);
            this.caixaTextBox.TabIndex = 6;
            // 
            // prontTextBox
            // 
            this.prontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "pront", true));
            this.prontTextBox.Location = new System.Drawing.Point(321, 96);
            this.prontTextBox.Name = "prontTextBox";
            this.prontTextBox.Size = new System.Drawing.Size(98, 20);
            this.prontTextBox.TabIndex = 8;
            // 
            // dt_saidaDateTimePicker
            // 
            this.dt_saidaDateTimePicker.CustomFormat = "";
            this.dt_saidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sampleboxBindingSource, "dt_saida", true));
            this.dt_saidaDateTimePicker.Enabled = false;
            this.dt_saidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_saidaDateTimePicker.Location = new System.Drawing.Point(27, 28);
            this.dt_saidaDateTimePicker.Name = "dt_saidaDateTimePicker";
            this.dt_saidaDateTimePicker.Size = new System.Drawing.Size(93, 20);
            this.dt_saidaDateTimePicker.TabIndex = 10;
            this.dt_saidaDateTimePicker.Value = new System.DateTime(2019, 1, 1, 19, 14, 57, 0);
            // 
            // qntNumericUpDown
            // 
            this.qntNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sampleboxBindingSource, "qnt", true));
            this.qntNumericUpDown.Location = new System.Drawing.Point(288, 159);
            this.qntNumericUpDown.Name = "qntNumericUpDown";
            this.qntNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.qntNumericUpDown.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Na Farmácia",
            "Dispensado"});
            this.statusComboBox.Location = new System.Drawing.Point(428, 158);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 19;
            // 
            // extraComboBox
            // 
            this.extraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleboxBindingSource, "extra", true));
            this.extraComboBox.FormattingEnabled = true;
            this.extraComboBox.Items.AddRange(new object[] {
            "ALFENTANIL 0,5MG/ML 5 ML",
            "CETAMINA S 50MG/ML 2ML FRA-DEXTROCETAMINA",
            "CICLOPENTOLATO 1% SOL. OFTALM. FR",
            "CLORPROMAZINA 5 MG/ML 5 ML AMP",
            "CODEINA 30 MG - CMP",
            "DEXMEDETOMIDINA  100 MCG/ML  AMPOLA 2ML",
            "DIAZEPAM 10 MG COMP",
            "DIAZEPAM 5 MG COMP",
            "DIAZEPAM 5MG/ML 2 ML AMP",
            "DROPERIDOL 2,5MG/ML 1ML AMP",
            "FENITOINA 50 MG/ML 5 ML AMP",
            "FENTANIL 0,05 MG/ML AMP 2ML",
            "FENTANIL 0,05 MG/ML AMP 5 ML",
            "FENTANILA 0,05 MG/ML ESTÉRIL AMP 2ML EMBALAGEM",
            "FLUMAZENIL 0,5 MG/5ML INJ AMP",
            "HALOPERIDOL 5 MG/ML 1 ML AMP",
            "ISOFLURANO  FR 100 ML",
            "MIDAZOLAM 1 MG/ML AMP 5 ML",
            "MIDAZOLAM 5MG/ML 3 ML AMP",
            "MISOPROSTOL 200MCG COMP",
            "MORFINA  10 MG AMP 1 ML",
            "MORFINA 0,2MG/ML AMP 1ML EMBALAGEM ESTÉRIL",
            "MORFINA 1 MG/ML AMP EMBALAGEM ESTÉRIL",
            "NALOXONA 0.4 MG/ML AMP 1 ML",
            "PERFLUOROCTANO LÍQUIDO  FR DE 5 ML PARA CIRURGIAS ",
            "PETIDINA 50MG/ML AMP",
            "PROPOFOL 10 MG/ML 20 ML AMP",
            "PROPOFOL 10MG/ML  SERINGA DE 50 ML",
            "PROXIMETACAINA 0.5% COLIRIO FR 5 ML",
            "REMIFENTANILA 2MG AMPOLA",
            "SEVOFLURANO  FRASCO 250ML",
            "SILICONE LIQUIDO 1000UI  FR (OFTALMO)",
            "TIOPENTAL SODICO C/1 GR DE PO FR/AMP",
            "TRAMADOL 100 MG AMPOLA",
            "TRAMADOL 50 MG CAPSULA"});
            this.extraComboBox.Location = new System.Drawing.Point(29, 161);
            this.extraComboBox.Name = "extraComboBox";
            this.extraComboBox.Size = new System.Drawing.Size(206, 21);
            this.extraComboBox.TabIndex = 20;
            // 
            // sampleboxTableAdapter
            // 
            this.sampleboxTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.sampleboxTableAdapter = this.sampleboxTableAdapter;
            this.tableAdapterManager.UpdateOrder = Estoque_CCA.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.extraComboBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(salaLabel);
            this.Controls.Add(this.salaComboBox);
            this.Controls.Add(caixaLabel);
            this.Controls.Add(this.caixaTextBox);
            this.Controls.Add(prontLabel);
            this.Controls.Add(this.prontTextBox);
            this.Controls.Add(dt_saidaLabel);
            this.Controls.Add(this.dt_saidaDateTimePicker);
            this.Controls.Add(extraLabel);
            this.Controls.Add(qntLabel);
            this.Controls.Add(this.qntNumericUpDown);
            this.Name = "Saida";
            this.Text = "Saida";
            this.Load += new System.EventHandler(this.Saida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sampleboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource sampleboxBindingSource;
        private Database1DataSetTableAdapters.sampleboxTableAdapter sampleboxTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox salaComboBox;
        private System.Windows.Forms.TextBox caixaTextBox;
        private System.Windows.Forms.TextBox prontTextBox;
        private System.Windows.Forms.NumericUpDown qntNumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox extraComboBox;
        private System.Windows.Forms.DateTimePicker dt_saidaDateTimePicker;
        private System.Windows.Forms.Button button2;
    }
}