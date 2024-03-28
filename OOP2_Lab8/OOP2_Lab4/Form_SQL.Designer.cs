
namespace OOP2_Lab4
{
    partial class Form_SQL
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
            this.textBox_Connect = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_AddSQL = new System.Windows.Forms.Button();
            this.button_UpdateSQL = new System.Windows.Forms.Button();
            this.button_DeleteSQL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Delete = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_BackLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Connect
            // 
            this.textBox_Connect.Location = new System.Drawing.Point(530, 16);
            this.textBox_Connect.Name = "textBox_Connect";
            this.textBox_Connect.Size = new System.Drawing.Size(329, 20);
            this.textBox_Connect.TabIndex = 1;
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Connect.Location = new System.Drawing.Point(530, 42);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(110, 46);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_AddSQL
            // 
            this.button_AddSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AddSQL.Location = new System.Drawing.Point(531, 116);
            this.button_AddSQL.Name = "button_AddSQL";
            this.button_AddSQL.Size = new System.Drawing.Size(109, 51);
            this.button_AddSQL.TabIndex = 3;
            this.button_AddSQL.Text = "Add";
            this.button_AddSQL.UseVisualStyleBackColor = true;
            this.button_AddSQL.Visible = false;
            this.button_AddSQL.Click += new System.EventHandler(this.button_AddSQL_Click);
            // 
            // button_UpdateSQL
            // 
            this.button_UpdateSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_UpdateSQL.Location = new System.Drawing.Point(531, 230);
            this.button_UpdateSQL.Name = "button_UpdateSQL";
            this.button_UpdateSQL.Size = new System.Drawing.Size(109, 51);
            this.button_UpdateSQL.TabIndex = 4;
            this.button_UpdateSQL.Text = "Update";
            this.button_UpdateSQL.UseVisualStyleBackColor = true;
            this.button_UpdateSQL.Visible = false;
            this.button_UpdateSQL.Click += new System.EventHandler(this.button_UpdateSQL_Click);
            // 
            // button_DeleteSQL
            // 
            this.button_DeleteSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_DeleteSQL.Location = new System.Drawing.Point(531, 287);
            this.button_DeleteSQL.Name = "button_DeleteSQL";
            this.button_DeleteSQL.Size = new System.Drawing.Size(109, 51);
            this.button_DeleteSQL.TabIndex = 5;
            this.button_DeleteSQL.Text = "Delete";
            this.button_DeleteSQL.UseVisualStyleBackColor = true;
            this.button_DeleteSQL.Visible = false;
            this.button_DeleteSQL.Click += new System.EventHandler(this.button_DeleteSQL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 326);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_Delete
            // 
            this.textBox_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Delete.Location = new System.Drawing.Point(646, 303);
            this.textBox_Delete.Name = "textBox_Delete";
            this.textBox_Delete.Size = new System.Drawing.Size(191, 22);
            this.textBox_Delete.TabIndex = 7;
            this.textBox_Delete.Visible = false;
            this.textBox_Delete.Enter += new System.EventHandler(this.textBox_Delete_Enter);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Search.Location = new System.Drawing.Point(531, 173);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(109, 51);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Search by Name";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Visible = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Search.Location = new System.Drawing.Point(646, 187);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(213, 22);
            this.textBox_Search.TabIndex = 8;
            this.textBox_Search.Visible = false;
            this.textBox_Search.Enter += new System.EventHandler(this.textBox_Search_Enter);
            // 
            // button_BackLogin
            // 
            this.button_BackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_BackLogin.Location = new System.Drawing.Point(13, 345);
            this.button_BackLogin.Name = "button_BackLogin";
            this.button_BackLogin.Size = new System.Drawing.Size(109, 51);
            this.button_BackLogin.TabIndex = 9;
            this.button_BackLogin.Text = "Login";
            this.button_BackLogin.UseVisualStyleBackColor = true;
            this.button_BackLogin.Click += new System.EventHandler(this.button_BackLogin_Click);
            // 
            // Form_SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 420);
            this.Controls.Add(this.button_BackLogin);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_DeleteSQL);
            this.Controls.Add(this.button_UpdateSQL);
            this.Controls.Add(this.button_AddSQL);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_Connect);
            this.Name = "Form_SQL";
            this.Text = "Form_SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Connect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_AddSQL;
        private System.Windows.Forms.Button button_UpdateSQL;
        private System.Windows.Forms.Button button_DeleteSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Delete;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_BackLogin;
    }
}