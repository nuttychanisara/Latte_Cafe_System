namespace LatteCafe
{
    partial class formPayment
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
            this.buttonCash = new System.Windows.Forms.Button();
            this.buttonCreditCard = new System.Windows.Forms.Button();
            this.buttonPromptPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCash
            // 
            this.buttonCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonCash.Location = new System.Drawing.Point(30, 174);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(276, 77);
            this.buttonCash.TabIndex = 0;
            this.buttonCash.Text = "เงินสด";
            this.buttonCash.UseVisualStyleBackColor = true;
            // 
            // buttonCreditCard
            // 
            this.buttonCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonCreditCard.Location = new System.Drawing.Point(333, 174);
            this.buttonCreditCard.Name = "buttonCreditCard";
            this.buttonCreditCard.Size = new System.Drawing.Size(276, 77);
            this.buttonCreditCard.TabIndex = 0;
            this.buttonCreditCard.Text = "บัตรเคดิต";
            this.buttonCreditCard.UseVisualStyleBackColor = true;
            // 
            // buttonPromptPay
            // 
            this.buttonPromptPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPromptPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonPromptPay.Location = new System.Drawing.Point(632, 174);
            this.buttonPromptPay.Name = "buttonPromptPay";
            this.buttonPromptPay.Size = new System.Drawing.Size(276, 77);
            this.buttonPromptPay.TabIndex = 0;
            this.buttonPromptPay.Text = "พร้อมเพย์";
            this.buttonPromptPay.UseVisualStyleBackColor = true;
            // 
            // formPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.buttonPromptPay);
            this.Controls.Add(this.buttonCreditCard);
            this.Controls.Add(this.buttonCash);
            this.Name = "formPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตัวเลือกการชำระเงิน";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Button buttonCreditCard;
        private System.Windows.Forms.Button buttonPromptPay;
    }
}

