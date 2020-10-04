namespace Paster_for_windows
{
    partial class TaskIcon
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskIcon));
            this.pasterIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pasterIconClickedMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EnablePasterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DisablePasterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitPasterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pasterIconClickedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pasterIcon
            // 
            this.pasterIcon.ContextMenuStrip = this.pasterIconClickedMenu;
            this.pasterIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("pasterIcon.Icon")));
            this.pasterIcon.Text = "Paster";
            this.pasterIcon.Visible = true;
            // 
            // pasterIconClickedMenu
            // 
            this.pasterIconClickedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnablePasterButton,
            this.DisablePasterButton,
            this.ExitPasterButton});
            this.pasterIconClickedMenu.Name = "pasterIconClickedMenu";
            this.pasterIconClickedMenu.Size = new System.Drawing.Size(113, 70);
            // 
            // EnablePasterButton
            // 
            this.EnablePasterButton.Name = "EnablePasterButton";
            this.EnablePasterButton.Size = new System.Drawing.Size(112, 22);
            this.EnablePasterButton.Text = "Enable";
            // 
            // DisablePasterButton
            // 
            this.DisablePasterButton.Name = "DisablePasterButton";
            this.DisablePasterButton.Size = new System.Drawing.Size(112, 22);
            this.DisablePasterButton.Text = "Disable";
            // 
            // ExitPasterButton
            // 
            this.ExitPasterButton.Name = "ExitPasterButton";
            this.ExitPasterButton.Size = new System.Drawing.Size(112, 22);
            this.ExitPasterButton.Text = "Exit";
            // 
            // TaskIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "TaskIcon";
            this.Text = "Form1";
            this.pasterIconClickedMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon pasterIcon;
        private System.Windows.Forms.ContextMenuStrip pasterIconClickedMenu;
        private System.Windows.Forms.ToolStripMenuItem EnablePasterButton;
        private System.Windows.Forms.ToolStripMenuItem DisablePasterButton;
        private System.Windows.Forms.ToolStripMenuItem ExitPasterButton;
    }
}

