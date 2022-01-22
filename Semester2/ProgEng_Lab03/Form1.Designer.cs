
namespace ProgEng_Lab03
{
    partial class Form1
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
            this.lRows = new System.Windows.Forms.Label();
            this.lColls = new System.Windows.Forms.Label();
            this.eRows = new System.Windows.Forms.TextBox();
            this.eColls = new System.Windows.Forms.TextBox();
            this.btnSetRowsColls = new System.Windows.Forms.Button();
            this.btnGoSolve = new System.Windows.Forms.Button();
            this.GV1 = new System.Windows.Forms.DataGridView();
            this.lOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).BeginInit();
            this.SuspendLayout();
            // 
            // lRows
            // 
            this.lRows.AutoSize = true;
            this.lRows.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRows.Location = new System.Drawing.Point(38, 31);
            this.lRows.Name = "lRows";
            this.lRows.Size = new System.Drawing.Size(63, 30);
            this.lRows.TabIndex = 0;
            this.lRows.Text = "Rows";
            // 
            // lColls
            // 
            this.lColls.AutoSize = true;
            this.lColls.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lColls.Location = new System.Drawing.Point(38, 89);
            this.lColls.Name = "lColls";
            this.lColls.Size = new System.Drawing.Size(59, 30);
            this.lColls.TabIndex = 1;
            this.lColls.Text = "Colls";
            // 
            // eRows
            // 
            this.eRows.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eRows.Location = new System.Drawing.Point(132, 25);
            this.eRows.Name = "eRows";
            this.eRows.Size = new System.Drawing.Size(100, 36);
            this.eRows.TabIndex = 2;
            // 
            // eColls
            // 
            this.eColls.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eColls.Location = new System.Drawing.Point(132, 83);
            this.eColls.Name = "eColls";
            this.eColls.Size = new System.Drawing.Size(100, 36);
            this.eColls.TabIndex = 3;
            // 
            // btnSetRowsColls
            // 
            this.btnSetRowsColls.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetRowsColls.Location = new System.Drawing.Point(260, 25);
            this.btnSetRowsColls.Name = "btnSetRowsColls";
            this.btnSetRowsColls.Size = new System.Drawing.Size(111, 94);
            this.btnSetRowsColls.TabIndex = 4;
            this.btnSetRowsColls.Text = "Set Rows Colls";
            this.btnSetRowsColls.UseVisualStyleBackColor = true;
            this.btnSetRowsColls.Click += new System.EventHandler(this.btnSetRowsColls_Click);
            // 
            // btnGoSolve
            // 
            this.btnGoSolve.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoSolve.Location = new System.Drawing.Point(685, 381);
            this.btnGoSolve.Name = "btnGoSolve";
            this.btnGoSolve.Size = new System.Drawing.Size(103, 57);
            this.btnGoSolve.TabIndex = 5;
            this.btnGoSolve.Text = "GO!";
            this.btnGoSolve.UseVisualStyleBackColor = true;
            this.btnGoSolve.Click += new System.EventHandler(this.btnGoSolve_Click);
            // 
            // GV1
            // 
            this.GV1.AllowUserToAddRows = false;
            this.GV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV1.Location = new System.Drawing.Point(56, 156);
            this.GV1.Name = "GV1";
            this.GV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GV1.RowTemplate.Height = 25;
            this.GV1.Size = new System.Drawing.Size(524, 245);
            this.GV1.TabIndex = 6;
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOutput.Location = new System.Drawing.Point(403, 57);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(194, 30);
            this.lOutput.TabIndex = 7;
            this.lOutput.Text = "Здесь будет ответ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.GV1);
            this.Controls.Add(this.btnGoSolve);
            this.Controls.Add(this.btnSetRowsColls);
            this.Controls.Add(this.eColls);
            this.Controls.Add(this.eRows);
            this.Controls.Add(this.lColls);
            this.Controls.Add(this.lRows);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRows;
        private System.Windows.Forms.Label lColls;
        private System.Windows.Forms.TextBox eRows;
        private System.Windows.Forms.TextBox eColls;
        private System.Windows.Forms.Button btnSetRowsColls;
        private System.Windows.Forms.Button btnGoSolve;
        private System.Windows.Forms.DataGridView GV1;
        private System.Windows.Forms.Label lOutput;
    }
}

