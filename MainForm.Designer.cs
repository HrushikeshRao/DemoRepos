namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.txtMailID = new System.Windows.Forms.TextBox();
            this.btnGetEmail = new System.Windows.Forms.Button();
            this.emailsDataGridView = new System.Windows.Forms.DataGridView();
            this.clnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAttachments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.emailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMailID
            // 
            this.txtMailID.Location = new System.Drawing.Point(118, 23);
            this.txtMailID.Name = "txtMailID";
            this.txtMailID.Size = new System.Drawing.Size(395, 20);
            this.txtMailID.TabIndex = 0;
            this.txtMailID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGetEmail
            // 
            this.btnGetEmail.Location = new System.Drawing.Point(545, 23);
            this.btnGetEmail.Name = "btnGetEmail";
            this.btnGetEmail.Size = new System.Drawing.Size(75, 23);
            this.btnGetEmail.TabIndex = 1;
            this.btnGetEmail.Text = "Get Mail";
            this.btnGetEmail.UseVisualStyleBackColor = true;
            this.btnGetEmail.Click += new System.EventHandler(this.btnGetEmail_Click);
            // 
            // emailsDataGridView
            // 
            this.emailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFrom,
            this.clnSubject,
            this.clnBody,
            this.clnAttachments});
            this.emailsDataGridView.Location = new System.Drawing.Point(13, 70);
            this.emailsDataGridView.Name = "emailsDataGridView";
            this.emailsDataGridView.Size = new System.Drawing.Size(775, 368);
            this.emailsDataGridView.TabIndex = 2;
            // 
            // clnFrom
            // 
            this.clnFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnFrom.HeaderText = "From";
            this.clnFrom.Name = "clnFrom";
            this.clnFrom.ReadOnly = true;
            this.clnFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clnSubject
            // 
            this.clnSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnSubject.HeaderText = "Subject";
            this.clnSubject.Name = "clnSubject";
            this.clnSubject.ReadOnly = true;
            // 
            // clnBody
            // 
            this.clnBody.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnBody.HeaderText = "Body";
            this.clnBody.Name = "clnBody";
            this.clnBody.ReadOnly = true;
            // 
            // clnAttachments
            // 
            this.clnAttachments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnAttachments.HeaderText = "Attachments";
            this.clnAttachments.Name = "clnAttachments";
            this.clnAttachments.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailsDataGridView);
            this.Controls.Add(this.btnGetEmail);
            this.Controls.Add(this.txtMailID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Mail Box";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailID;
        private System.Windows.Forms.Button btnGetEmail;
        private System.Windows.Forms.DataGridView emailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAttachments;
    }
}