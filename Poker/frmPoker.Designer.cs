namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.txtTotalFunds = new System.Windows.Forms.TextBox();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblTotalFunds = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.grpBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(12, 12);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(485, 160);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(12, 266);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(485, 80);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(252, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(223, 36);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(164, 28);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 36);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(94, 28);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(64, 36);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Enabled = false;
            this.btnDealCard.Location = new System.Drawing.Point(21, 28);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(67, 36);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpBet
            // 
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.txtBetAmount);
            this.grpBet.Controls.Add(this.txtTotalFunds);
            this.grpBet.Controls.Add(this.lblBetAmount);
            this.grpBet.Controls.Add(this.lblTotalFunds);
            this.grpBet.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBet.Location = new System.Drawing.Point(12, 180);
            this.grpBet.Name = "grpBet";
            this.grpBet.Size = new System.Drawing.Size(485, 80);
            this.grpBet.TabIndex = 4;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(393, 28);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(82, 36);
            this.btnBet.TabIndex = 8;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(273, 33);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(114, 29);
            this.txtBetAmount.TabIndex = 7;
            this.txtBetAmount.Text = "500";
            // 
            // txtTotalFunds
            // 
            this.txtTotalFunds.Location = new System.Drawing.Point(74, 33);
            this.txtTotalFunds.Name = "txtTotalFunds";
            this.txtTotalFunds.ReadOnly = true;
            this.txtTotalFunds.Size = new System.Drawing.Size(114, 29);
            this.txtTotalFunds.TabIndex = 6;
            this.txtTotalFunds.Text = "1000000";
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(194, 36);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(73, 20);
            this.lblBetAmount.TabIndex = 5;
            this.lblBetAmount.Text = "押注金額";
            // 
            // lblTotalFunds
            // 
            this.lblTotalFunds.AutoSize = true;
            this.lblTotalFunds.Location = new System.Drawing.Point(11, 36);
            this.lblTotalFunds.Name = "lblTotalFunds";
            this.lblTotalFunds.Size = new System.Drawing.Size(57, 20);
            this.lblTotalFunds.TabIndex = 4;
            this.lblTotalFunds.Text = "總資金";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 357);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpButton.ResumeLayout(false);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblTotalFunds;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.TextBox txtTotalFunds;
    }
}