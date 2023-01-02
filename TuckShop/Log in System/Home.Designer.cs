namespace Log_in_System
{
    partial class frm_Home
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
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Log_User = new System.Windows.Forms.Label();
            this.btn_Add_New_User = new System.Windows.Forms.Button();
            this.btnorderdisplay = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btndisplayregister = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Log_Out.ForeColor = System.Drawing.Color.White;
            this.btn_Log_Out.Location = new System.Drawing.Point(705, 470);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(104, 37);
            this.btn_Log_Out.TabIndex = 0;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Log_User
            // 
            this.lbl_Log_User.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Log_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Log_User.Location = new System.Drawing.Point(233, 62);
            this.lbl_Log_User.Name = "lbl_Log_User";
            this.lbl_Log_User.Size = new System.Drawing.Size(168, 41);
            this.lbl_Log_User.TabIndex = 1;
            this.lbl_Log_User.Text = "Welcome: ";
            this.lbl_Log_User.Click += new System.EventHandler(this.lbl_Log_User_Click);
            // 
            // btn_Add_New_User
            // 
            this.btn_Add_New_User.BackColor = System.Drawing.Color.Navy;
            this.btn_Add_New_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Add_New_User.ForeColor = System.Drawing.Color.White;
            this.btn_Add_New_User.Location = new System.Drawing.Point(224, 253);
            this.btn_Add_New_User.Name = "btn_Add_New_User";
            this.btn_Add_New_User.Size = new System.Drawing.Size(164, 72);
            this.btn_Add_New_User.TabIndex = 0;
            this.btn_Add_New_User.Text = "Edition User";
            this.btn_Add_New_User.UseVisualStyleBackColor = false;
            this.btn_Add_New_User.Click += new System.EventHandler(this.btn_Add_New_User_Click);
            // 
            // btnorderdisplay
            // 
            this.btnorderdisplay.BackColor = System.Drawing.Color.Navy;
            this.btnorderdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnorderdisplay.ForeColor = System.Drawing.Color.White;
            this.btnorderdisplay.Location = new System.Drawing.Point(21, 253);
            this.btnorderdisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnorderdisplay.Name = "btnorderdisplay";
            this.btnorderdisplay.Size = new System.Drawing.Size(149, 72);
            this.btnorderdisplay.TabIndex = 2;
            this.btnorderdisplay.Text = "Display All Orders";
            this.btnorderdisplay.UseVisualStyleBackColor = false;
            this.btnorderdisplay.Click += new System.EventHandler(this.btnorderdisplay_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Navy;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnorder.ForeColor = System.Drawing.Color.White;
            this.btnorder.Location = new System.Drawing.Point(451, 253);
            this.btnorder.Margin = new System.Windows.Forms.Padding(2);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(149, 72);
            this.btnorder.TabIndex = 3;
            this.btnorder.Text = "Make Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btndisplayregister
            // 
            this.btndisplayregister.BackColor = System.Drawing.Color.Navy;
            this.btndisplayregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btndisplayregister.ForeColor = System.Drawing.Color.White;
            this.btndisplayregister.Location = new System.Drawing.Point(660, 253);
            this.btndisplayregister.Margin = new System.Windows.Forms.Padding(2);
            this.btndisplayregister.Name = "btndisplayregister";
            this.btndisplayregister.Size = new System.Drawing.Size(149, 72);
            this.btndisplayregister.TabIndex = 4;
            this.btndisplayregister.Text = "Display User Register";
            this.btndisplayregister.UseVisualStyleBackColor = false;
            this.btndisplayregister.Click += new System.EventHandler(this.btndisplayregister_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(345, 352);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 72);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Particular Order";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnUpdDel_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Log_in_System.Properties.Resources.wp2733173;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 535);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btndisplayregister);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnorderdisplay);
            this.Controls.Add(this.lbl_Log_User);
            this.Controls.Add(this.btn_Add_New_User);
            this.Controls.Add(this.btn_Log_Out);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Log_User;
        private System.Windows.Forms.Button btn_Add_New_User;
        private System.Windows.Forms.Button btnorderdisplay;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btndisplayregister;
        private System.Windows.Forms.Button btnSearch;
    }
}