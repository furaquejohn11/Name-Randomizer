
namespace Name_Randomizer
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumOfGroups = new System.Windows.Forms.TextBox();
            this.equallyYes = new System.Windows.Forms.CheckBox();
            this.equallyNo = new System.Windows.Forms.CheckBox();
            this.txtNumOfMembers = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.txtException = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlException = new System.Windows.Forms.Panel();
            this.pnlException.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(316, 314);
            this.textBox1.TabIndex = 0;
            // 
            // listBoxName
            // 
            this.listBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 16;
            this.listBoxName.Location = new System.Drawing.Point(490, 46);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(316, 308);
            this.listBoxName.TabIndex = 1;
            this.listBoxName.SelectedIndexChanged += new System.EventHandler(this.listBoxName_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(346, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(346, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 51);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(607, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Groups: ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Members Per Group:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CWTS Mode?:";
            // 
            // txtNumOfGroups
            // 
            this.txtNumOfGroups.Location = new System.Drawing.Point(140, 389);
            this.txtNumOfGroups.Name = "txtNumOfGroups";
            this.txtNumOfGroups.Size = new System.Drawing.Size(71, 20);
            this.txtNumOfGroups.TabIndex = 10;
            this.txtNumOfGroups.Visible = false;
            this.txtNumOfGroups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOfGroups_KeyPress);
            // 
            // equallyYes
            // 
            this.equallyYes.AutoSize = true;
            this.equallyYes.Location = new System.Drawing.Point(136, 426);
            this.equallyYes.Name = "equallyYes";
            this.equallyYes.Size = new System.Drawing.Size(44, 17);
            this.equallyYes.TabIndex = 11;
            this.equallyYes.Text = "Yes";
            this.equallyYes.UseVisualStyleBackColor = true;
            this.equallyYes.CheckedChanged += new System.EventHandler(this.equallyYes_CheckedChanged);
            // 
            // equallyNo
            // 
            this.equallyNo.AutoSize = true;
            this.equallyNo.Location = new System.Drawing.Point(186, 426);
            this.equallyNo.Name = "equallyNo";
            this.equallyNo.Size = new System.Drawing.Size(40, 17);
            this.equallyNo.TabIndex = 12;
            this.equallyNo.Text = "No";
            this.equallyNo.UseVisualStyleBackColor = true;
            this.equallyNo.CheckedChanged += new System.EventHandler(this.equallyNo_CheckedChanged);
            // 
            // txtNumOfMembers
            // 
            this.txtNumOfMembers.Location = new System.Drawing.Point(197, 459);
            this.txtNumOfMembers.Name = "txtNumOfMembers";
            this.txtNumOfMembers.Size = new System.Drawing.Size(49, 20);
            this.txtNumOfMembers.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 51);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(785, 528);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(92, 51);
            this.btnRandom.TabIndex = 15;
            this.btnRandom.Text = "Random Now";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(812, 46);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(92, 51);
            this.btnDeleteAll.TabIndex = 16;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // txtException
            // 
            this.txtException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtException.Location = new System.Drawing.Point(15, 40);
            this.txtException.Multiline = true;
            this.txtException.Name = "txtException";
            this.txtException.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtException.Size = new System.Drawing.Size(316, 171);
            this.txtException.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(82, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "6AM Exception List";
            // 
            // pnlException
            // 
            this.pnlException.Controls.Add(this.txtException);
            this.pnlException.Controls.Add(this.label6);
            this.pnlException.Location = new System.Drawing.Point(289, 368);
            this.pnlException.Name = "pnlException";
            this.pnlException.Size = new System.Drawing.Size(347, 215);
            this.pnlException.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 591);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNumOfMembers);
            this.Controls.Add(this.equallyNo);
            this.Controls.Add(this.equallyYes);
            this.Controls.Add(this.txtNumOfGroups);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlException);
            this.MaximumSize = new System.Drawing.Size(929, 630);
            this.MinimumSize = new System.Drawing.Size(929, 630);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnlException.ResumeLayout(false);
            this.pnlException.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumOfGroups;
        private System.Windows.Forms.CheckBox equallyYes;
        private System.Windows.Forms.CheckBox equallyNo;
        private System.Windows.Forms.TextBox txtNumOfMembers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.TextBox txtException;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlException;
    }
}

