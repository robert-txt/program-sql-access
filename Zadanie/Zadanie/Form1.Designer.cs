namespace Zadanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExecute = new System.Windows.Forms.Button();
            this.dataGridViewAcces = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.checkConnection = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.labelCommandLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcces)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(379, 58);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Modyfikacja";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // dataGridViewAcces
            // 
            this.dataGridViewAcces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PersonName,
            this.PersonAge});
            this.dataGridViewAcces.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewAcces.Name = "dataGridViewAcces";
            this.dataGridViewAcces.Size = new System.Drawing.Size(347, 317);
            this.dataGridViewAcces.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Identyfikator";
            this.ID.Name = "ID";
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Imię";
            this.PersonName.Name = "PersonName";
            // 
            // PersonAge
            // 
            this.PersonAge.HeaderText = "Wiek";
            this.PersonAge.Name = "PersonAge";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(12, 29);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(442, 20);
            this.textBoxQuery.TabIndex = 2;
            this.textBoxQuery.Text = "np. insert into Dane (Imię, Wiek) values (\"Krystian\", \"77\") i kliknij Modyfikacja" +
    " lub select Miasto from Miejscowości i kliknij Zapytanie";
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(9, 388);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(37, 13);
            this.checkConnection.TabIndex = 3;
            this.checkConnection.Text = "Status";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(379, 116);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 59);
            this.buttonShowAll.TabIndex = 4;
            this.buttonShowAll.Text = "Pokaż tabelę \"Dane\"";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Location = new System.Drawing.Point(379, 87);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrieve.TabIndex = 5;
            this.buttonRetrieve.Text = "Zapytanie";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // labelCommandLine
            // 
            this.labelCommandLine.AutoSize = true;
            this.labelCommandLine.Location = new System.Drawing.Point(12, 10);
            this.labelCommandLine.Name = "labelCommandLine";
            this.labelCommandLine.Size = new System.Drawing.Size(112, 13);
            this.labelCommandLine.TabIndex = 6;
            this.labelCommandLine.Text = "Wpisz polecenie SQL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 401);
            this.Controls.Add(this.labelCommandLine);
            this.Controls.Add(this.buttonRetrieve);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.dataGridViewAcces);
            this.Controls.Add(this.buttonExecute);
            this.Name = "Form1";
            this.Text = "Zadanie rekrutacyjne";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView dataGridViewAcces;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonAge;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Label labelCommandLine;
    }
}

