
namespace OOP2_Lab4
{
    partial class Form_adminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_List = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.label_delete = new System.Windows.Forms.Label();
            this.label_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_List
            // 
            this.button_List.Location = new System.Drawing.Point(108, 273);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(130, 48);
            this.button_List.TabIndex = 1;
            this.button_List.Text = "List";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(281, 273);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(124, 48);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(450, 273);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(123, 48);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(371, 361);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(118, 48);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_delete
            // 
            this.textBox_delete.Location = new System.Drawing.Point(166, 376);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.Size = new System.Drawing.Size(100, 20);
            this.textBox_delete.TabIndex = 5;
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.Location = new System.Drawing.Point(105, 360);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(228, 13);
            this.label_delete.TabIndex = 6;
            this.label_delete.Text = "Write the ID of the user that you want to delete";
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(131, 399);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 13);
            this.label_warning.TabIndex = 7;
            // 
            // Form_adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_List);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_adminPanel";
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.Label label_warning;
    }
}