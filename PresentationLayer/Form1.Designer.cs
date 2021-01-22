﻿
namespace PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBoxTasks = new System.Windows.Forms.GroupBox();
            this.taskMenu = new System.Windows.Forms.MenuStrip();
            this.newTaskStatusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.flTaskStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxProjects = new System.Windows.Forms.GroupBox();
            this.projectMenu = new System.Windows.Forms.MenuStrip();
            this.newProjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.flProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxTasks.SuspendLayout();
            this.taskMenu.SuspendLayout();
            this.grpBoxProjects.SuspendLayout();
            this.projectMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTasks
            // 
            this.grpBoxTasks.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxTasks.Controls.Add(this.taskMenu);
            this.grpBoxTasks.Controls.Add(this.flTaskStatus);
            this.grpBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpBoxTasks.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxTasks.Location = new System.Drawing.Point(272, 64);
            this.grpBoxTasks.Name = "grpBoxTasks";
            this.grpBoxTasks.Size = new System.Drawing.Size(715, 396);
            this.grpBoxTasks.TabIndex = 4;
            this.grpBoxTasks.TabStop = false;
            this.grpBoxTasks.Text = "Atamalar";
            // 
            // taskMenu
            // 
            this.taskMenu.BackColor = System.Drawing.Color.Transparent;
            this.taskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskStatusMenu});
            this.taskMenu.Location = new System.Drawing.Point(3, 18);
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(709, 24);
            this.taskMenu.TabIndex = 10;
            this.taskMenu.Text = "Task Menu";
            // 
            // newTaskStatusMenu
            // 
            this.newTaskStatusMenu.BackColor = System.Drawing.Color.White;
            this.newTaskStatusMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newTaskStatusMenu.Name = "newTaskStatusMenu";
            this.newTaskStatusMenu.Size = new System.Drawing.Size(125, 20);
            this.newTaskStatusMenu.Text = "Yeni Atama Statüleri";
            this.newTaskStatusMenu.Click += new System.EventHandler(this.newTaskStatusMenu_Click);
            // 
            // flTaskStatus
            // 
            this.flTaskStatus.AutoScroll = true;
            this.flTaskStatus.BackColor = System.Drawing.Color.Transparent;
            this.flTaskStatus.Location = new System.Drawing.Point(3, 52);
            this.flTaskStatus.Name = "flTaskStatus";
            this.flTaskStatus.Size = new System.Drawing.Size(698, 331);
            this.flTaskStatus.TabIndex = 4;
            // 
            // grpBoxProjects
            // 
            this.grpBoxProjects.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxProjects.Controls.Add(this.projectMenu);
            this.grpBoxProjects.Controls.Add(this.flProjects);
            this.grpBoxProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxProjects.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxProjects.Location = new System.Drawing.Point(23, 63);
            this.grpBoxProjects.Name = "grpBoxProjects";
            this.grpBoxProjects.Size = new System.Drawing.Size(243, 397);
            this.grpBoxProjects.TabIndex = 3;
            this.grpBoxProjects.TabStop = false;
            this.grpBoxProjects.Text = "Panolar";
            // 
            // projectMenu
            // 
            this.projectMenu.BackColor = System.Drawing.Color.Transparent;
            this.projectMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectMenu});
            this.projectMenu.Location = new System.Drawing.Point(3, 18);
            this.projectMenu.Name = "projectMenu";
            this.projectMenu.Size = new System.Drawing.Size(237, 24);
            this.projectMenu.TabIndex = 5;
            this.projectMenu.Text = "Project Menu";
            // 
            // newProjectMenu
            // 
            this.newProjectMenu.BackColor = System.Drawing.Color.White;
            this.newProjectMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newProjectMenu.Name = "newProjectMenu";
            this.newProjectMenu.Size = new System.Drawing.Size(71, 20);
            this.newProjectMenu.Text = "Yeni Pano";
            this.newProjectMenu.Click += new System.EventHandler(this.newProjectMenu_Click);
            // 
            // flProjects
            // 
            this.flProjects.AutoScroll = true;
            this.flProjects.BackColor = System.Drawing.Color.Transparent;
            this.flProjects.Location = new System.Drawing.Point(6, 53);
            this.flProjects.Name = "flProjects";
            this.flProjects.Size = new System.Drawing.Size(231, 331);
            this.flProjects.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 490);
            this.Controls.Add(this.grpBoxTasks);
            this.Controls.Add(this.grpBoxProjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Work Model";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.grpBoxTasks.ResumeLayout(false);
            this.grpBoxTasks.PerformLayout();
            this.taskMenu.ResumeLayout(false);
            this.taskMenu.PerformLayout();
            this.grpBoxProjects.ResumeLayout(false);
            this.grpBoxProjects.PerformLayout();
            this.projectMenu.ResumeLayout(false);
            this.projectMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTasks;
        private System.Windows.Forms.FlowLayoutPanel flTaskStatus;
        private System.Windows.Forms.GroupBox grpBoxProjects;
        private System.Windows.Forms.FlowLayoutPanel flProjects;
        private System.Windows.Forms.MenuStrip projectMenu;
        private System.Windows.Forms.MenuStrip taskMenu;
        private System.Windows.Forms.ToolStripMenuItem newProjectMenu;
        private System.Windows.Forms.ToolStripMenuItem newTaskStatusMenu;
    }
}

