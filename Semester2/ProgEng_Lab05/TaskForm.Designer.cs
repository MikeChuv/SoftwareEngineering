
namespace ProgEng_Lab05
{
    partial class TaskForm
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
            this.selectTaskGB = new System.Windows.Forms.GroupBox();
            this.sumTask = new System.Windows.Forms.RadioButton();
            this.eqTask = new System.Windows.Forms.RadioButton();
            this.btnConfirmTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.selectTaskGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectTaskGB
            // 
            this.selectTaskGB.Controls.Add(this.sumTask);
            this.selectTaskGB.Controls.Add(this.eqTask);
            this.selectTaskGB.Location = new System.Drawing.Point(12, 12);
            this.selectTaskGB.Name = "selectTaskGB";
            this.selectTaskGB.Size = new System.Drawing.Size(575, 135);
            this.selectTaskGB.TabIndex = 0;
            this.selectTaskGB.TabStop = false;
            this.selectTaskGB.Text = "Выберите задачу";
            // 
            // sumTask
            // 
            this.sumTask.AutoSize = true;
            this.sumTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumTask.Location = new System.Drawing.Point(7, 78);
            this.sumTask.Name = "sumTask";
            this.sumTask.Size = new System.Drawing.Size(503, 25);
            this.sumTask.TabIndex = 1;
            this.sumTask.TabStop = true;
            this.sumTask.Text = "Найти индексы элемента массива с наибольшей суммой его цифр";
            this.sumTask.UseVisualStyleBackColor = true;
            // 
            // eqTask
            // 
            this.eqTask.AutoSize = true;
            this.eqTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eqTask.Location = new System.Drawing.Point(7, 34);
            this.eqTask.Name = "eqTask";
            this.eqTask.Size = new System.Drawing.Size(543, 25);
            this.eqTask.TabIndex = 0;
            this.eqTask.TabStop = true;
            this.eqTask.Text = "Найти  индексы  первого  элемента  массива,  равного заданному числу";
            this.eqTask.UseVisualStyleBackColor = true;
            // 
            // btnConfirmTask
            // 
            this.btnConfirmTask.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmTask.Location = new System.Drawing.Point(48, 270);
            this.btnConfirmTask.Name = "btnConfirmTask";
            this.btnConfirmTask.Size = new System.Drawing.Size(109, 58);
            this.btnConfirmTask.TabIndex = 1;
            this.btnConfirmTask.Text = "OK";
            this.btnConfirmTask.UseVisualStyleBackColor = true;
            this.btnConfirmTask.Click += new System.EventHandler(this.btnConfirmTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(478, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 52);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 365);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmTask);
            this.Controls.Add(this.selectTaskGB);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.selectTaskGB.ResumeLayout(false);
            this.selectTaskGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectTaskGB;
        private System.Windows.Forms.Button btnConfirmTask;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.RadioButton sumTask;
        public System.Windows.Forms.RadioButton eqTask;
    }
}