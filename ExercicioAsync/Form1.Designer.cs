namespace ExercicioAsync
{
    partial class frmCalculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbInput = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOutPayCheck = new System.Windows.Forms.Label();
            this.lblOutTaxes = new System.Windows.Forms.Label();
            this.lblOutRevenue = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblExecTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(85, 91);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(370, 23);
            this.txbInput.TabIndex = 0;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Location = new System.Drawing.Point(85, 46);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(117, 15);
            this.lbl01.TabIndex = 1;
            this.lbl01.Text = "Digite o salario bruto";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(591, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folha de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Impostos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Despesas";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(493, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblOutPayCheck
            // 
            this.lblOutPayCheck.AutoSize = true;
            this.lblOutPayCheck.Location = new System.Drawing.Point(493, 169);
            this.lblOutPayCheck.Name = "lblOutPayCheck";
            this.lblOutPayCheck.Size = new System.Drawing.Size(0, 15);
            this.lblOutPayCheck.TabIndex = 8;
            this.lblOutPayCheck.Click += new System.EventHandler(this.lblOutPayCheck_Click);
            // 
            // lblOutTaxes
            // 
            this.lblOutTaxes.AutoSize = true;
            this.lblOutTaxes.Location = new System.Drawing.Point(494, 203);
            this.lblOutTaxes.Name = "lblOutTaxes";
            this.lblOutTaxes.Size = new System.Drawing.Size(0, 15);
            this.lblOutTaxes.TabIndex = 9;
            // 
            // lblOutRevenue
            // 
            this.lblOutRevenue.AutoSize = true;
            this.lblOutRevenue.Location = new System.Drawing.Point(493, 237);
            this.lblOutRevenue.Name = "lblOutRevenue";
            this.lblOutRevenue.Size = new System.Drawing.Size(0, 15);
            this.lblOutRevenue.TabIndex = 10;
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Location = new System.Drawing.Point(493, 271);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(0, 15);
            this.lblExpenses.TabIndex = 11;
            // 
            // lblExecTime
            // 
            this.lblExecTime.AutoSize = true;
            this.lblExecTime.Location = new System.Drawing.Point(591, 73);
            this.lblExecTime.Name = "lblExecTime";
            this.lblExecTime.Size = new System.Drawing.Size(31, 15);
            this.lblExecTime.TabIndex = 12;
            this.lblExecTime.Text = "time";
            // 
            // frmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExecTime);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblOutRevenue);
            this.Controls.Add(this.lblOutTaxes);
            this.Controls.Add(this.lblOutPayCheck);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.txbInput);
            this.Name = "frmCalculos";
            this.Text = "Calculos Async";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbInput;
        private Label lbl01;
        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblStatus;
        private Label lblOutPayCheck;
        private Label lblOutTaxes;
        private Label lblOutRevenue;
        private Label lblExpenses;
        private Label lblExecTime;
    }
}