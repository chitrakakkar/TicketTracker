namespace Project_12_2
{
    partial class frmTicket
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
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.grpGuests = new System.Windows.Forms.GroupBox();
            this.lblEnterTickets = new System.Windows.Forms.Label();
            this.grpTickets = new System.Windows.Forms.GroupBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grpGuests.SuspendLayout();
            this.grpTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(12, 363);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 0;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(191, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(12, 198);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(254, 147);
            this.lstTickets.TabIndex = 2;
         
            // 
            // grpGuests
            // 
            this.grpGuests.Controls.Add(this.lblEnterTickets);
            this.grpGuests.Location = new System.Drawing.Point(13, 13);
            this.grpGuests.Name = "grpGuests";
            this.grpGuests.Size = new System.Drawing.Size(253, 47);
            this.grpGuests.TabIndex = 3;
            this.grpGuests.TabStop = false;
            this.grpGuests.Text = "Guests with the folowing tickets may now enter:";
            // 
            // lblEnterTickets
            // 
            this.lblEnterTickets.AutoSize = true;
            this.lblEnterTickets.Location = new System.Drawing.Point(27, 19);
            this.lblEnterTickets.Name = "lblEnterTickets";
            this.lblEnterTickets.Size = new System.Drawing.Size(17, 13);
            this.lblEnterTickets.TabIndex = 0;
            this.lblEnterTickets.Text = "xx";
            // 
            // grpTickets
            // 
            this.grpTickets.Controls.Add(this.btnIssue);
            this.grpTickets.Controls.Add(this.label4);
            this.grpTickets.Controls.Add(this.lblOutstanding);
            this.grpTickets.Controls.Add(this.label2);
            this.grpTickets.Controls.Add(this.lblTime);
            this.grpTickets.Location = new System.Drawing.Point(13, 66);
            this.grpTickets.Name = "grpTickets";
            this.grpTickets.Size = new System.Drawing.Size(253, 114);
            this.grpTickets.TabIndex = 4;
            this.grpTickets.TabStop = false;
            this.grpTickets.Text = "Ticket Availability";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(10, 74);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(123, 23);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue Ticket";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Next available entry:";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Location = new System.Drawing.Point(176, 25);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(17, 13);
            this.lblOutstanding.TabIndex = 4;
            this.lblOutstanding.Text = "xx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(176, 48);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(17, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "xx";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 398);
            this.Controls.Add(this.grpTickets);
            this.Controls.Add(this.grpGuests);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Name = "frmTicket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.frmTicket_TextChanged);
            this.grpGuests.ResumeLayout(false);
            this.grpGuests.PerformLayout();
            this.grpTickets.ResumeLayout(false);
            this.grpTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.GroupBox grpGuests;
        private System.Windows.Forms.Label lblEnterTickets;
        private System.Windows.Forms.GroupBox grpTickets;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

