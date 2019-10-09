namespace CashRegisterSummative
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.popcornLabel = new System.Windows.Forms.Label();
            this.largeDrinkLabel = new System.Windows.Forms.Label();
            this.ticketInput = new System.Windows.Forms.TextBox();
            this.popcornInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptLabel2 = new System.Windows.Forms.Label();
            this.receiptLabel3 = new System.Windows.Forms.Label();
            this.receiptLabel4 = new System.Windows.Forms.Label();
            this.receiptTitleLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(266, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "McNab Movies";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(92, 92);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(72, 18);
            this.ticketLabel.TabIndex = 1;
            this.ticketLabel.Text = "Tickets:";
            // 
            // popcornLabel
            // 
            this.popcornLabel.AutoSize = true;
            this.popcornLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popcornLabel.Location = new System.Drawing.Point(44, 130);
            this.popcornLabel.Name = "popcornLabel";
            this.popcornLabel.Size = new System.Drawing.Size(120, 18);
            this.popcornLabel.TabIndex = 2;
            this.popcornLabel.Text = "Large Popcorn:";
            // 
            // largeDrinkLabel
            // 
            this.largeDrinkLabel.AutoSize = true;
            this.largeDrinkLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeDrinkLabel.Location = new System.Drawing.Point(60, 168);
            this.largeDrinkLabel.Name = "largeDrinkLabel";
            this.largeDrinkLabel.Size = new System.Drawing.Size(104, 18);
            this.largeDrinkLabel.TabIndex = 3;
            this.largeDrinkLabel.Text = "Large Drink:";
            // 
            // ticketInput
            // 
            this.ticketInput.Location = new System.Drawing.Point(161, 92);
            this.ticketInput.Name = "ticketInput";
            this.ticketInput.Size = new System.Drawing.Size(44, 20);
            this.ticketInput.TabIndex = 4;
            this.ticketInput.Text = "0";
            // 
            // popcornInput
            // 
            this.popcornInput.Location = new System.Drawing.Point(161, 127);
            this.popcornInput.Name = "popcornInput";
            this.popcornInput.Size = new System.Drawing.Size(44, 20);
            this.popcornInput.TabIndex = 5;
            this.popcornInput.Text = "0";
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(161, 168);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(44, 20);
            this.drinkInput.TabIndex = 6;
            this.drinkInput.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(47, 218);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(181, 43);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(26, 302);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(80, 18);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.Color.White;
            this.subTotalOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(128, 302);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(77, 35);
            this.subTotalOutput.TabIndex = 9;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(26, 358);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(32, 18);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(26, 405);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 18);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(128, 358);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(77, 23);
            this.taxOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(128, 405);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(77, 23);
            this.totalOutput.TabIndex = 13;
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.Location = new System.Drawing.Point(17, 457);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(277, 11);
            this.blackLabel.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 497);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(145, 23);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Amount Tendered:";
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.Location = new System.Drawing.Point(51, 540);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(177, 37);
            this.calculateChangeButton.TabIndex = 17;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.CalculateChangeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(29, 53);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(249, 23);
            this.outputLabel.TabIndex = 18;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(20, 53);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 19);
            this.messageLabel.TabIndex = 19;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 612);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(64, 18);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.White;
            this.changeOutput.Location = new System.Drawing.Point(92, 612);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(72, 23);
            this.changeOutput.TabIndex = 21;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(150, 497);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 22;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(31, 663);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(219, 43);
            this.printButton.TabIndex = 23;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.Black;
            this.receiptLabel.Location = new System.Drawing.Point(408, 27);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(10, 536);
            this.receiptLabel.TabIndex = 24;
            // 
            // receiptLabel2
            // 
            this.receiptLabel2.BackColor = System.Drawing.Color.Black;
            this.receiptLabel2.Location = new System.Drawing.Point(408, 27);
            this.receiptLabel2.Name = "receiptLabel2";
            this.receiptLabel2.Size = new System.Drawing.Size(347, 10);
            this.receiptLabel2.TabIndex = 25;
            // 
            // receiptLabel3
            // 
            this.receiptLabel3.BackColor = System.Drawing.Color.Black;
            this.receiptLabel3.Location = new System.Drawing.Point(745, 27);
            this.receiptLabel3.Name = "receiptLabel3";
            this.receiptLabel3.Size = new System.Drawing.Size(10, 532);
            this.receiptLabel3.TabIndex = 26;
            // 
            // receiptLabel4
            // 
            this.receiptLabel4.BackColor = System.Drawing.Color.Black;
            this.receiptLabel4.Location = new System.Drawing.Point(411, 552);
            this.receiptLabel4.Name = "receiptLabel4";
            this.receiptLabel4.Size = new System.Drawing.Size(344, 11);
            this.receiptLabel4.TabIndex = 27;
            // 
            // receiptTitleLabel
            // 
            this.receiptTitleLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTitleLabel.Location = new System.Drawing.Point(464, 53);
            this.receiptTitleLabel.Name = "receiptTitleLabel";
            this.receiptTitleLabel.Size = new System.Drawing.Size(236, 26);
            this.receiptTitleLabel.TabIndex = 28;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(458, 592);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(242, 58);
            this.newOrderButton.TabIndex = 29;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(789, 718);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptTitleLabel);
            this.Controls.Add(this.receiptLabel4);
            this.Controls.Add(this.receiptLabel3);
            this.Controls.Add(this.receiptLabel2);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.popcornInput);
            this.Controls.Add(this.ticketInput);
            this.Controls.Add(this.largeDrinkLabel);
            this.Controls.Add(this.popcornLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "CashRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label popcornLabel;
        private System.Windows.Forms.Label largeDrinkLabel;
        private System.Windows.Forms.TextBox ticketInput;
        private System.Windows.Forms.TextBox popcornInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label receiptLabel2;
        private System.Windows.Forms.Label receiptLabel3;
        private System.Windows.Forms.Label receiptLabel4;
        private System.Windows.Forms.Label receiptTitleLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

