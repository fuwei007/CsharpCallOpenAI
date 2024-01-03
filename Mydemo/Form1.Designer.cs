namespace Mydemo
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
            txtAssistantName = new TextBox();
            btnCreateAssistant = new Button();
            lblAssistantId = new Label();
            btnStart = new Button();
            lblTheadId = new Label();
            txtQuestion = new TextBox();
            btnAsk = new Button();
            lblRunId = new Label();
            btnCheckStatus = new Button();
            btnGetResult = new Button();
            SuspendLayout();
            // 
            // txtAssistantName
            // 
            txtAssistantName.Location = new Point(17, 31);
            txtAssistantName.Name = "txtAssistantName";
            txtAssistantName.Size = new Size(183, 23);
            txtAssistantName.TabIndex = 0;
            // 
            // btnCreateAssistant
            // 
            btnCreateAssistant.Location = new Point(220, 31);
            btnCreateAssistant.Name = "btnCreateAssistant";
            btnCreateAssistant.Size = new Size(100, 23);
            btnCreateAssistant.TabIndex = 1;
            btnCreateAssistant.Text = "Create";
            btnCreateAssistant.UseVisualStyleBackColor = true;
            btnCreateAssistant.Click += btnCreateAssistant_Click;
            // 
            // lblAssistantId
            // 
            lblAssistantId.AutoSize = true;
            lblAssistantId.Location = new Point(323, 34);
            lblAssistantId.Name = "lblAssistantId";
            lblAssistantId.Size = new Size(0, 15);
            lblAssistantId.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(220, 83);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTheadId
            // 
            lblTheadId.AutoSize = true;
            lblTheadId.Location = new Point(320, 86);
            lblTheadId.Name = "lblTheadId";
            lblTheadId.Size = new Size(0, 15);
            lblTheadId.TabIndex = 4;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(17, 115);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(183, 23);
            txtQuestion.TabIndex = 5;
            // 
            // btnAsk
            // 
            btnAsk.Location = new Point(220, 115);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(100, 23);
            btnAsk.TabIndex = 6;
            btnAsk.Text = "Ask";
            btnAsk.UseVisualStyleBackColor = true;
            btnAsk.Click += btnAsk_Click;
            // 
            // lblRunId
            // 
            lblRunId.AutoSize = true;
            lblRunId.Location = new Point(322, 120);
            lblRunId.Name = "lblRunId";
            lblRunId.Size = new Size(0, 15);
            lblRunId.TabIndex = 7;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.Location = new Point(220, 160);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(100, 23);
            btnCheckStatus.TabIndex = 8;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = true;
            btnCheckStatus.Click += btnCheckStatus_Click;
            // 
            // btnGetResult
            // 
            btnGetResult.Location = new Point(220, 208);
            btnGetResult.Name = "btnGetResult";
            btnGetResult.Size = new Size(100, 23);
            btnGetResult.TabIndex = 9;
            btnGetResult.Text = "Get Result";
            btnGetResult.UseVisualStyleBackColor = true;
            btnGetResult.Click += btnGetResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetResult);
            Controls.Add(btnCheckStatus);
            Controls.Add(lblRunId);
            Controls.Add(btnAsk);
            Controls.Add(txtQuestion);
            Controls.Add(lblTheadId);
            Controls.Add(btnStart);
            Controls.Add(lblAssistantId);
            Controls.Add(btnCreateAssistant);
            Controls.Add(txtAssistantName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAssistantName;
        private Button btnCreateAssistant;
        private Label lblAssistantId;
        private Button btnStart;
        private Label lblTheadId;
        private TextBox txtQuestion;
        private Button btnAsk;
        private Label lblRunId;
        private Button btnCheckStatus;
        private Button btnGetResult;
    }
}
