namespace Log_in_System
{
    partial class DisplayOrder
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tblOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDisplayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDisplayDataSet = new Log_in_System.OrderDisplayDataSet();
            this.tblOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderTableAdapter = new Log_in_System.OrderDisplayDataSetTableAdapters.tblOrderTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplayDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display All Order";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(557, 428);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(104, 52);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Back To Main Page";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tblOrderBindingSource1
            // 
            this.tblOrderBindingSource1.DataMember = "tblOrder";
            this.tblOrderBindingSource1.DataSource = this.orderDisplayDataSetBindingSource;
            // 
            // orderDisplayDataSetBindingSource
            // 
            this.orderDisplayDataSetBindingSource.DataSource = this.orderDisplayDataSet;
            this.orderDisplayDataSetBindingSource.Position = 0;
            // 
            // orderDisplayDataSet
            // 
            this.orderDisplayDataSet.DataSetName = "OrderDisplayDataSet";
            this.orderDisplayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrderBindingSource
            // 
            this.tblOrderBindingSource.DataMember = "tblOrder";
            this.tblOrderBindingSource.DataSource = this.orderDisplayDataSetBindingSource;
            // 
            // tblOrderTableAdapter
            // 
            this.tblOrderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(27, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DisplayOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Log_in_System.Properties.Resources._20525134;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayOrder";
            this.Text = "All Orders";
            this.Load += new System.EventHandler(this.DisplayOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplayDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.BindingSource orderDisplayDataSetBindingSource;
        private OrderDisplayDataSet orderDisplayDataSet;
        private System.Windows.Forms.BindingSource tblOrderBindingSource;
        private OrderDisplayDataSetTableAdapters.tblOrderTableAdapter tblOrderTableAdapter;
        private System.Windows.Forms.BindingSource tblOrderBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}