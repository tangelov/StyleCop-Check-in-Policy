﻿// <auto-generated/>
namespace Winnster.CheckInPolicies.SourceAnalysis.UI.Forms
{
    partial class EditExclusionDialog
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
            this.ExclusionsControl = new Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ExclusionManagerControl();
            this.ValueColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.ExclusionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(310, 251);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(391, 251);
            // 
            // ExclusionsControl
            // 
            this.ExclusionsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExclusionsControl.Location = new System.Drawing.Point(12, 25);
            this.ExclusionsControl.Name = "ExclusionsControl";
            this.ExclusionsControl.Size = new System.Drawing.Size(454, 184);
            this.ExclusionsControl.TabIndex = 4;
            this.ExclusionsControl.AddingItem += new System.EventHandler<Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ItemEventArgs>(this.ExclusionsControl_AddingItem);
            this.ExclusionsControl.RemovedItem += new System.EventHandler<System.EventArgs>(this.ExclusionsControl_RemovedItem);
            this.ExclusionsControl.SelectedIndexChanged += new System.EventHandler<Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.EnableButtonsEventArgs>(this.ExclusionsControl_SelectedIndexChanged);
            this.ExclusionsControl.RemovingItem += new System.EventHandler<Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ItemEventArgs>(this.ExclusionsControl_RemovingItem);
            this.ExclusionsControl.EnablingItem += new System.EventHandler<Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ItemEventArgs>(this.ExclusionsControl_EnablingItem);
            this.ExclusionsControl.AddedItem += new System.EventHandler<System.EventArgs>(this.ExclusionsControl_AddedItem);
            this.ExclusionsControl.EditingItem += new System.EventHandler<Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ItemEventArgs>(this.ExclusionsControl_EditingItem);
            this.ExclusionsControl.DisablingItem += new System.EventHandler<Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ItemEventArgs>(this.ExclusionsControl_DisablingItem);
            this.ExclusionsControl.Columns.Add(this.ValueColumnHeader);
            // 
            // ValueColumnHeader
            // 
            this.ValueColumnHeader.Text = "Value";
            this.ValueColumnHeader.Width = 325;
            // 
            // ExclusionsLabel
            // 
            this.ExclusionsLabel.AutoSize = true;
            this.ExclusionsLabel.Location = new System.Drawing.Point(12, 9);
            this.ExclusionsLabel.Name = "ExclusionsLabel";
            this.ExclusionsLabel.Size = new System.Drawing.Size(60, 13);
            this.ExclusionsLabel.TabIndex = 5;
            this.ExclusionsLabel.Text = "Exclusions:";
            // 
            // EditExclusionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(478, 290);
            this.Controls.Add(this.ExclusionsLabel);
            this.Controls.Add(this.ExclusionsControl);
            this.Name = "EditExclusionDialog";
            this.Text = "Manage Exclusions";
            this.Load += new System.EventHandler(this.ManageExclusionDialog_Load);
            this.Controls.SetChildIndex(this.ExclusionsControl, 0);
            this.Controls.SetChildIndex(this.SubmitButton, 0);
            this.Controls.SetChildIndex(this.AbortButton, 0);
            this.Controls.SetChildIndex(this.ExclusionsLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Winnster.CheckInPolicies.SourceAnalysis.UI.Controls.ExclusionManagerControl ExclusionsControl;
        private System.Windows.Forms.Label ExclusionsLabel;
        private System.Windows.Forms.ColumnHeader ValueColumnHeader;
    }
}
