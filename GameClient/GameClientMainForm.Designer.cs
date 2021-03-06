﻿namespace GameClient
{
    partial class GameClientMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameClientMainForm));
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGameBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGamePause = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRanking = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGame,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemAbout});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1232, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemGame
            // 
            this.toolStripMenuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGameBegin,
            this.ToolStripMenuItemGamePause,
            this.toolStripMenuItemQuit,
            this.ToolStripMenuItemRanking});
            this.toolStripMenuItemGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemGame.Image")));
            this.toolStripMenuItemGame.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItemGame.Name = "toolStripMenuItemGame";
            this.toolStripMenuItemGame.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItemGame.Text = "游戏";
            // 
            // ToolStripMenuItemGameBegin
            // 
            this.ToolStripMenuItemGameBegin.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripMenuItemGameBegin.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemGameBegin.Image")));
            this.ToolStripMenuItemGameBegin.ImageTransparentColor = System.Drawing.Color.White;
            this.ToolStripMenuItemGameBegin.Name = "ToolStripMenuItemGameBegin";
            this.ToolStripMenuItemGameBegin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.ToolStripMenuItemGameBegin.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItemGameBegin.Text = "开始";
            this.ToolStripMenuItemGameBegin.Click += new System.EventHandler(this.ToolStripMenuItemGameBegin_Click);
            // 
            // ToolStripMenuItemGamePause
            // 
            this.ToolStripMenuItemGamePause.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemGamePause.Image")));
            this.ToolStripMenuItemGamePause.Name = "ToolStripMenuItemGamePause";
            this.ToolStripMenuItemGamePause.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ToolStripMenuItemGamePause.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItemGamePause.Text = "暂停";
            this.ToolStripMenuItemGamePause.Click += new System.EventHandler(this.ToolStripMenuItemGamePause_Click);
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemQuit.Image")));
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItemQuit.Text = "退出";
            this.toolStripMenuItemQuit.Click += new System.EventHandler(this.ToolStripMenuItemQuit_Click);
            // 
            // ToolStripMenuItemRanking
            // 
            this.ToolStripMenuItemRanking.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemRanking.Image")));
            this.ToolStripMenuItemRanking.Name = "ToolStripMenuItemRanking";
            this.ToolStripMenuItemRanking.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ToolStripMenuItemRanking.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItemRanking.Text = "高分榜";
            this.ToolStripMenuItemRanking.Click += new System.EventHandler(this.ToolStripMenuItemRanking_Click);
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSetting.Image")));
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(73, 24);
            this.ToolStripMenuItemSetting.Text = "设置";
            this.ToolStripMenuItemSetting.Click += new System.EventHandler(this.ToolStripMenuItemSetting_Click);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemAbout.Image")));
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(73, 24);
            this.ToolStripMenuItemAbout.Text = "关于";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // panelPaint
            // 
            this.panelPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaint.Location = new System.Drawing.Point(0, 28);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(1232, 575);
            this.panelPaint.TabIndex = 2;
            this.panelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaint_Paint);
            // 
            // timerMove
            // 
            this.timerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // GameClientMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.menuStripMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "GameClientMainForm";
            this.Text = "Eat!Eat!!Eat!!!";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGame;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGameBegin;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGamePause;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRanking;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.Timer timerMove;
    }
}

