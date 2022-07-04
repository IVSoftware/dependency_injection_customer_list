
namespace DL
{
    partial class Main
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
            this.dataGridViewCust = new System.Windows.Forms.DataGridView();
            this.buttonMockQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCust
            // 
            this.dataGridViewCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCust.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCust.Name = "dataGridViewCust";
            this.dataGridViewCust.RowHeadersWidth = 62;
            this.dataGridViewCust.RowTemplate.Height = 33;
            this.dataGridViewCust.Size = new System.Drawing.Size(478, 202);
            this.dataGridViewCust.TabIndex = 0;
            // 
            // buttonMockQuery
            // 
            this.buttonMockQuery.Location = new System.Drawing.Point(0, 208);
            this.buttonMockQuery.Name = "buttonMockQuery";
            this.buttonMockQuery.Size = new System.Drawing.Size(183, 34);
            this.buttonMockQuery.TabIndex = 1;
            this.buttonMockQuery.Text = "Mock Query";
            this.buttonMockQuery.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonMockQuery);
            this.Controls.Add(this.dataGridViewCust);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCust;
        private System.Windows.Forms.Button buttonMockQuery;
    }
}

