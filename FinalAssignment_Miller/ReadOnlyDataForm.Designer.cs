
namespace FinalAssignment_Miller
{
    partial class ReadOnlyDataForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditNameButton = new System.Windows.Forms.Button();
            this.EditAddressButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EditNameButton
            // 
            this.EditNameButton.Enabled = false;
            this.EditNameButton.Location = new System.Drawing.Point(12, 12);
            this.EditNameButton.Name = "EditNameButton";
            this.EditNameButton.Size = new System.Drawing.Size(391, 39);
            this.EditNameButton.TabIndex = 1;
            this.EditNameButton.Text = "Edit Name";
            this.EditNameButton.UseVisualStyleBackColor = true;
            this.EditNameButton.Click += new System.EventHandler(this.EditNameButton_Click);
            // 
            // EditAddressButton
            // 
            this.EditAddressButton.Enabled = false;
            this.EditAddressButton.Location = new System.Drawing.Point(409, 12);
            this.EditAddressButton.Name = "EditAddressButton";
            this.EditAddressButton.Size = new System.Drawing.Size(379, 39);
            this.EditAddressButton.TabIndex = 2;
            this.EditAddressButton.Text = "Edit Address";
            this.EditAddressButton.UseVisualStyleBackColor = true;
            this.EditAddressButton.Click += new System.EventHandler(this.EditAddressButton_Click);
            // 
            // ReadOnlyDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditAddressButton);
            this.Controls.Add(this.EditNameButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReadOnlyDataForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditNameButton;
        private System.Windows.Forms.Button EditAddressButton;
    }
}

