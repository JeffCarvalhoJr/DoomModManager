namespace Doom_Mod_Manager
{
    partial class MainForm
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
            this.LSTBOX_ModList = new System.Windows.Forms.ListBox();
            this.LBL_ModList = new System.Windows.Forms.Label();
            this.BTN_AddMod = new System.Windows.Forms.Button();
            this.BTN_RemoveMod = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL_Profile = new System.Windows.Forms.Label();
            this.BTN_AddProfile = new System.Windows.Forms.Button();
            this.BTN_RemoveProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_UnloadMod = new System.Windows.Forms.Button();
            this.LBL_DoomEngine = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BTN_AddDoomEngine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LSTBOX_LoadOrder = new System.Windows.Forms.ListBox();
            this.BTN_RemoveDoomEngine = new System.Windows.Forms.Button();
            this.BTN_RunDoom = new System.Windows.Forms.Button();
            this.BTN_SaveProfile = new System.Windows.Forms.Button();
            this.BTN_DeleteProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LSTBOX_ModList
            // 
            this.LSTBOX_ModList.FormattingEnabled = true;
            this.LSTBOX_ModList.ItemHeight = 15;
            this.LSTBOX_ModList.Location = new System.Drawing.Point(186, 107);
            this.LSTBOX_ModList.Name = "LSTBOX_ModList";
            this.LSTBOX_ModList.Size = new System.Drawing.Size(220, 244);
            this.LSTBOX_ModList.TabIndex = 0;
            // 
            // LBL_ModList
            // 
            this.LBL_ModList.AutoSize = true;
            this.LBL_ModList.Location = new System.Drawing.Point(264, 89);
            this.LBL_ModList.Name = "LBL_ModList";
            this.LBL_ModList.Size = new System.Drawing.Size(53, 15);
            this.LBL_ModList.TabIndex = 1;
            this.LBL_ModList.Text = "Mod List";
            // 
            // BTN_AddMod
            // 
            this.BTN_AddMod.Location = new System.Drawing.Point(186, 367);
            this.BTN_AddMod.Name = "BTN_AddMod";
            this.BTN_AddMod.Size = new System.Drawing.Size(100, 45);
            this.BTN_AddMod.TabIndex = 2;
            this.BTN_AddMod.Text = "Add Mod";
            this.BTN_AddMod.UseVisualStyleBackColor = true;
            // 
            // BTN_RemoveMod
            // 
            this.BTN_RemoveMod.Location = new System.Drawing.Point(306, 367);
            this.BTN_RemoveMod.Name = "BTN_RemoveMod";
            this.BTN_RemoveMod.Size = new System.Drawing.Size(100, 45);
            this.BTN_RemoveMod.TabIndex = 2;
            this.BTN_RemoveMod.Text = "Remove Mod";
            this.BTN_RemoveMod.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // LBL_Profile
            // 
            this.LBL_Profile.AutoSize = true;
            this.LBL_Profile.Location = new System.Drawing.Point(264, 9);
            this.LBL_Profile.Name = "LBL_Profile";
            this.LBL_Profile.Size = new System.Drawing.Size(41, 15);
            this.LBL_Profile.TabIndex = 4;
            this.LBL_Profile.Text = "Profile";
            // 
            // BTN_AddProfile
            // 
            this.BTN_AddProfile.Location = new System.Drawing.Point(186, 56);
            this.BTN_AddProfile.Name = "BTN_AddProfile";
            this.BTN_AddProfile.Size = new System.Drawing.Size(100, 25);
            this.BTN_AddProfile.TabIndex = 6;
            this.BTN_AddProfile.Text = "Add Profile";
            this.BTN_AddProfile.UseVisualStyleBackColor = true;
            // 
            // BTN_RemoveProfile
            // 
            this.BTN_RemoveProfile.Location = new System.Drawing.Point(306, 56);
            this.BTN_RemoveProfile.Name = "BTN_RemoveProfile";
            this.BTN_RemoveProfile.Size = new System.Drawing.Size(100, 25);
            this.BTN_RemoveProfile.TabIndex = 6;
            this.BTN_RemoveProfile.Text = "Remove Profile";
            this.BTN_RemoveProfile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTN_UnloadMod
            // 
            this.BTN_UnloadMod.Location = new System.Drawing.Point(412, 247);
            this.BTN_UnloadMod.Name = "BTN_UnloadMod";
            this.BTN_UnloadMod.Size = new System.Drawing.Size(39, 23);
            this.BTN_UnloadMod.TabIndex = 7;
            this.BTN_UnloadMod.Text = "<-";
            this.BTN_UnloadMod.UseVisualStyleBackColor = true;
            // 
            // LBL_DoomEngine
            // 
            this.LBL_DoomEngine.AutoSize = true;
            this.LBL_DoomEngine.Location = new System.Drawing.Point(522, 9);
            this.LBL_DoomEngine.Name = "LBL_DoomEngine";
            this.LBL_DoomEngine.Size = new System.Drawing.Size(79, 15);
            this.LBL_DoomEngine.TabIndex = 8;
            this.LBL_DoomEngine.Text = "Doom Engine";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(457, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // BTN_AddDoomEngine
            // 
            this.BTN_AddDoomEngine.Location = new System.Drawing.Point(457, 56);
            this.BTN_AddDoomEngine.Name = "BTN_AddDoomEngine";
            this.BTN_AddDoomEngine.Size = new System.Drawing.Size(78, 25);
            this.BTN_AddDoomEngine.TabIndex = 6;
            this.BTN_AddDoomEngine.Text = "Add";
            this.BTN_AddDoomEngine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load Order";
            // 
            // LSTBOX_LoadOrder
            // 
            this.LSTBOX_LoadOrder.FormattingEnabled = true;
            this.LSTBOX_LoadOrder.ItemHeight = 15;
            this.LSTBOX_LoadOrder.Location = new System.Drawing.Point(457, 107);
            this.LSTBOX_LoadOrder.Name = "LSTBOX_LoadOrder";
            this.LSTBOX_LoadOrder.Size = new System.Drawing.Size(220, 244);
            this.LSTBOX_LoadOrder.TabIndex = 0;
            // 
            // BTN_RemoveDoomEngine
            // 
            this.BTN_RemoveDoomEngine.Location = new System.Drawing.Point(599, 56);
            this.BTN_RemoveDoomEngine.Name = "BTN_RemoveDoomEngine";
            this.BTN_RemoveDoomEngine.Size = new System.Drawing.Size(78, 25);
            this.BTN_RemoveDoomEngine.TabIndex = 6;
            this.BTN_RemoveDoomEngine.Text = "Remove";
            this.BTN_RemoveDoomEngine.UseVisualStyleBackColor = true;
            // 
            // BTN_RunDoom
            // 
            this.BTN_RunDoom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_RunDoom.Location = new System.Drawing.Point(457, 367);
            this.BTN_RunDoom.Name = "BTN_RunDoom";
            this.BTN_RunDoom.Size = new System.Drawing.Size(220, 45);
            this.BTN_RunDoom.TabIndex = 10;
            this.BTN_RunDoom.Text = "Run";
            this.BTN_RunDoom.UseVisualStyleBackColor = true; 
            // 
            // BTN_SaveProfile
            // 
            this.BTN_SaveProfile.Location = new System.Drawing.Point(12, 27);
            this.BTN_SaveProfile.Name = "BTN_SaveProfile";
            this.BTN_SaveProfile.Size = new System.Drawing.Size(168, 23);
            this.BTN_SaveProfile.TabIndex = 11;
            this.BTN_SaveProfile.Text = "Save Profile";
            this.BTN_SaveProfile.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteProfile
            // 
            this.BTN_DeleteProfile.Location = new System.Drawing.Point(12, 56);
            this.BTN_DeleteProfile.Name = "BTN_DeleteProfile";
            this.BTN_DeleteProfile.Size = new System.Drawing.Size(168, 23);
            this.BTN_DeleteProfile.TabIndex = 11;
            this.BTN_DeleteProfile.Text = "Delete Profile";
            this.BTN_DeleteProfile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 424);
            this.Controls.Add(this.BTN_DeleteProfile);
            this.Controls.Add(this.BTN_SaveProfile);
            this.Controls.Add(this.BTN_RunDoom);
            this.Controls.Add(this.BTN_RemoveDoomEngine);
            this.Controls.Add(this.LSTBOX_LoadOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_AddDoomEngine);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LBL_DoomEngine);
            this.Controls.Add(this.BTN_UnloadMod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_RemoveProfile);
            this.Controls.Add(this.BTN_AddProfile);
            this.Controls.Add(this.LBL_Profile);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTN_RemoveMod);
            this.Controls.Add(this.BTN_AddMod);
            this.Controls.Add(this.LBL_ModList);
            this.Controls.Add(this.LSTBOX_ModList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DOOM Mod Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSTBOX_ModList;
        private System.Windows.Forms.Label LBL_ModList;
        private System.Windows.Forms.Button BTN_AddMod;
        private System.Windows.Forms.Button BTN_RemoveMod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL_Profile;
        private System.Windows.Forms.Button BTN_AddProfile;
        private System.Windows.Forms.Button BTN_RemoveProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_UnloadMod;
        private System.Windows.Forms.Label LBL_DoomEngine;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BTN_AddDoomEngine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LSTBOX_LoadOrder;
        private System.Windows.Forms.Button BTN_RemoveDoomEngine;
        private System.Windows.Forms.Button BTN_RunDoom;
        private System.Windows.Forms.Button BTN_SaveProfile;
        private System.Windows.Forms.Button BTN_DeleteProfile;
    }
}

