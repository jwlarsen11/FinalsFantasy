namespace FinalsFantasy
{
    partial class FinalsFantasyGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionBox = new System.Windows.Forms.GroupBox();
            this.PartyInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Attack = new System.Windows.Forms.Button();
            this.Defend = new System.Windows.Forms.Button();
            this.Special = new System.Windows.Forms.Button();
            this.ActionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 248);
            this.panel1.TabIndex = 0;
            // 
            // ActionBox
            // 
            this.ActionBox.Controls.Add(this.Special);
            this.ActionBox.Controls.Add(this.Defend);
            this.ActionBox.Controls.Add(this.Attack);
            this.ActionBox.Location = new System.Drawing.Point(0, 253);
            this.ActionBox.Name = "ActionBox";
            this.ActionBox.Size = new System.Drawing.Size(167, 188);
            this.ActionBox.TabIndex = 1;
            this.ActionBox.TabStop = false;
            this.ActionBox.Text = "Actions";
            // 
            // PartyInfo
            // 
            this.PartyInfo.Location = new System.Drawing.Point(175, 256);
            this.PartyInfo.Name = "PartyInfo";
            this.PartyInfo.Size = new System.Drawing.Size(285, 183);
            this.PartyInfo.TabIndex = 2;
            this.PartyInfo.TabStop = false;
            this.PartyInfo.Text = "Party";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(473, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(5, 21);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(150, 41);
            this.Attack.TabIndex = 0;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            // 
            // Defend
            // 
            this.Defend.Location = new System.Drawing.Point(5, 72);
            this.Defend.Name = "Defend";
            this.Defend.Size = new System.Drawing.Size(150, 44);
            this.Defend.TabIndex = 1;
            this.Defend.Text = "Defend";
            this.Defend.UseVisualStyleBackColor = true;
            // 
            // Special
            // 
            this.Special.Location = new System.Drawing.Point(5, 135);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(150, 39);
            this.Special.TabIndex = 2;
            this.Special.Text = "Special";
            this.Special.UseVisualStyleBackColor = true;
            // 
            // FinalsFantasyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PartyInfo);
            this.Controls.Add(this.ActionBox);
            this.Controls.Add(this.panel1);
            this.Name = "FinalsFantasyGUI";
            this.Text = "Finals Fantasy";
            this.ActionBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox ActionBox;
        private Button Special;
        private Button Defend;
        private Button Attack;
        private GroupBox PartyInfo;
        private GroupBox groupBox1;
    }
}