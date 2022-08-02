
namespace day39_01
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INPUT_Name = new System.Windows.Forms.TextBox();
            this.INPUT_Age = new System.Windows.Forms.TextBox();
            this.BTN_Insert = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.INPUT_Nid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(350, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "나이";
            // 
            // INPUT_Name
            // 
            this.INPUT_Name.Location = new System.Drawing.Point(415, 45);
            this.INPUT_Name.Name = "INPUT_Name";
            this.INPUT_Name.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Name.TabIndex = 3;
            // 
            // INPUT_Age
            // 
            this.INPUT_Age.Location = new System.Drawing.Point(415, 78);
            this.INPUT_Age.Name = "INPUT_Age";
            this.INPUT_Age.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Age.TabIndex = 4;
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.Location = new System.Drawing.Point(12, 206);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(94, 29);
            this.BTN_Insert.TabIndex = 6;
            this.BTN_Insert.Text = "입력";
            this.BTN_Insert.UseVisualStyleBackColor = true;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Location = new System.Drawing.Point(137, 206);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(94, 29);
            this.BTN_Update.TabIndex = 7;
            this.BTN_Update.Text = "수정";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(268, 206);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(94, 29);
            this.BTN_Delete.TabIndex = 8;
            this.BTN_Delete.Text = "삭제";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // INPUT_Nid
            // 
            this.INPUT_Nid.Location = new System.Drawing.Point(415, 12);
            this.INPUT_Nid.Name = "INPUT_Nid";
            this.INPUT_Nid.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Nid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 251);
            this.Controls.Add(this.INPUT_Nid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.INPUT_Age);
            this.Controls.Add(this.INPUT_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INPUT_Name;
        private System.Windows.Forms.TextBox INPUT_Age;
        private System.Windows.Forms.Button BTN_Insert;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox INPUT_Nid;
    }
}

