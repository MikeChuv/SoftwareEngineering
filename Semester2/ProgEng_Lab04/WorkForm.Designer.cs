
namespace ProgEng_Lab04
{
    partial class WorkForm
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
            this.GV1 = new System.Windows.Forms.DataGridView();
            this.eRows = new System.Windows.Forms.TextBox();
            this.eColls = new System.Windows.Forms.TextBox();
            this.btnSetRowsColls = new System.Windows.Forms.Button();
            this.lAnswer = new System.Windows.Forms.Label();
            this.lTaskText = new System.Windows.Forms.Label();
            this.btnGoSolve = new System.Windows.Forms.Button();
            this.eNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).BeginInit();
            this.SuspendLayout();
            // 
            // GV1
            // 
            this.GV1.AllowUserToAddRows = false;
            this.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV1.Location = new System.Drawing.Point(38, 179);
            this.GV1.Name = "GV1";
            this.GV1.RowTemplate.Height = 25;
            this.GV1.Size = new System.Drawing.Size(356, 228);
            this.GV1.TabIndex = 0;
            // 
            // eRows
            // 
            this.eRows.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eRows.Location = new System.Drawing.Point(39, 82);
            this.eRows.Name = "eRows";
            this.eRows.Size = new System.Drawing.Size(98, 32);
            this.eRows.TabIndex = 1;
            this.eRows.Text = "Rows";
            // 
            // eColls
            // 
            this.eColls.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eColls.Location = new System.Drawing.Point(39, 133);
            this.eColls.Name = "eColls";
            this.eColls.Size = new System.Drawing.Size(98, 32);
            this.eColls.TabIndex = 2;
            this.eColls.Text = "Colls";
            // 
            // btnSetRowsColls
            // 
            this.btnSetRowsColls.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetRowsColls.Location = new System.Drawing.Point(163, 82);
            this.btnSetRowsColls.Name = "btnSetRowsColls";
            this.btnSetRowsColls.Size = new System.Drawing.Size(113, 83);
            this.btnSetRowsColls.TabIndex = 3;
            this.btnSetRowsColls.Text = "SET";
            this.btnSetRowsColls.UseVisualStyleBackColor = true;
            this.btnSetRowsColls.Click += new System.EventHandler(this.btnSetRowsColls_Click);
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAnswer.Location = new System.Drawing.Point(447, 179);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(62, 25);
            this.lAnswer.TabIndex = 4;
            this.lAnswer.Text = "Ответ";
            // 
            // lTaskText
            // 
            this.lTaskText.AutoSize = true;
            this.lTaskText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTaskText.Location = new System.Drawing.Point(63, 29);
            this.lTaskText.Name = "lTaskText";
            this.lTaskText.Size = new System.Drawing.Size(84, 25);
            this.lTaskText.TabIndex = 5;
            this.lTaskText.Text = "Задание";
            // 
            // btnGoSolve
            // 
            this.btnGoSolve.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoSolve.Location = new System.Drawing.Point(518, 333);
            this.btnGoSolve.Name = "btnGoSolve";
            this.btnGoSolve.Size = new System.Drawing.Size(172, 74);
            this.btnGoSolve.TabIndex = 6;
            this.btnGoSolve.Text = "GO!";
            this.btnGoSolve.UseVisualStyleBackColor = true;
            this.btnGoSolve.Click += new System.EventHandler(this.btnGoSolve_Click);
            // 
            // eNumber
            // 
            this.eNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eNumber.Location = new System.Drawing.Point(302, 82);
            this.eNumber.Name = "eNumber";
            this.eNumber.Size = new System.Drawing.Size(92, 32);
            this.eNumber.TabIndex = 7;
            this.eNumber.Text = "Число";
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.eNumber);
            this.Controls.Add(this.btnGoSolve);
            this.Controls.Add(this.lTaskText);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.btnSetRowsColls);
            this.Controls.Add(this.eColls);
            this.Controls.Add(this.eRows);
            this.Controls.Add(this.GV1);
            this.Name = "WorkForm";
            this.Text = "Работа с массивом";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkForm_FormClosed);
            this.Shown += new System.EventHandler(this.WorkForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eRows;
        private System.Windows.Forms.TextBox eColls;
        private System.Windows.Forms.Button btnSetRowsColls;
        public System.Windows.Forms.DataGridView GV1;
        private System.Windows.Forms.Label lAnswer;
        public System.Windows.Forms.Label lTaskText;
        private System.Windows.Forms.Button btnGoSolve;
        private System.Windows.Forms.TextBox eNumber;
    }
}