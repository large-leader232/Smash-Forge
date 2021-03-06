﻿namespace Smash_Forge
{
    partial class MeshList
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.polyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useAOAsSpecToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flipUVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipUVsHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothNormalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTanBitanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.detachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meshContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.belowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleBindToBoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.calculateNormalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeMetalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useAOAsSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addBlankMeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothNormalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTanBitanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateBoundingBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MCContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importFromDAEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsDAEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recalculateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recalculateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTanBitanToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.polyContextMenu.SuspendLayout();
            this.meshContextMenu.SuspendLayout();
            this.nudContextMenu.SuspendLayout();
            this.MCContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(187, 257);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(79, 286);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mesh Index";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(46, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Match To nud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // polyContextMenu
            // 
            this.polyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMaterialToolStripMenuItem,
            this.copyMaterialToolStripMenuItem,
            this.useAOAsSpecToolStripMenuItem1,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.toolStripSeparator2,
            this.flipUVsToolStripMenuItem,
            this.flipUVsHorizontalToolStripMenuItem,
            this.smoothNormalsToolStripMenuItem,
            this.generateTanBitanToolStripMenuItem1,
            this.toolStripSeparator3,
            this.detachToolStripMenuItem});
            this.polyContextMenu.Name = "polyContextMenu";
            this.polyContextMenu.Size = new System.Drawing.Size(183, 242);
            this.polyContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editMaterialToolStripMenuItem
            // 
            this.editMaterialToolStripMenuItem.Name = "editMaterialToolStripMenuItem";
            this.editMaterialToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editMaterialToolStripMenuItem.Text = "Edit Material";
            this.editMaterialToolStripMenuItem.Click += new System.EventHandler(this.editMaterialToolStripMenuItem_Click);
            // 
            // copyMaterialToolStripMenuItem
            // 
            this.copyMaterialToolStripMenuItem.Name = "copyMaterialToolStripMenuItem";
            this.copyMaterialToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.copyMaterialToolStripMenuItem.Text = "Copy Material";
            this.copyMaterialToolStripMenuItem.Click += new System.EventHandler(this.copyMaterialToolStripMenuItem_Click);
            // 
            // useAOAsSpecToolStripMenuItem1
            // 
            this.useAOAsSpecToolStripMenuItem1.Name = "useAOAsSpecToolStripMenuItem1";
            this.useAOAsSpecToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.useAOAsSpecToolStripMenuItem1.Text = "AO Spec/Ref Blend";
            this.useAOAsSpecToolStripMenuItem1.Click += new System.EventHandler(this.useAOAsSpecToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Visible = false;
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // flipUVsToolStripMenuItem
            // 
            this.flipUVsToolStripMenuItem.Name = "flipUVsToolStripMenuItem";
            this.flipUVsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.flipUVsToolStripMenuItem.Text = "Flip UVs (Vertical)";
            this.flipUVsToolStripMenuItem.Click += new System.EventHandler(this.flipUVsToolStripMenuItem_Click);
            // 
            // flipUVsHorizontalToolStripMenuItem
            // 
            this.flipUVsHorizontalToolStripMenuItem.Name = "flipUVsHorizontalToolStripMenuItem";
            this.flipUVsHorizontalToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.flipUVsHorizontalToolStripMenuItem.Text = "Flip UVs (Horizontal)";
            this.flipUVsHorizontalToolStripMenuItem.Click += new System.EventHandler(this.flipUVsHorizontalToolStripMenuItem_Click);
            // 
            // smoothNormalsToolStripMenuItem
            // 
            this.smoothNormalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recalculateToolStripMenuItem1,
            this.smoothToolStripMenuItem1});
            this.smoothNormalsToolStripMenuItem.Name = "smoothNormalsToolStripMenuItem";
            this.smoothNormalsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.smoothNormalsToolStripMenuItem.Text = "Normals";
            // 
            // generateTanBitanToolStripMenuItem1
            // 
            this.generateTanBitanToolStripMenuItem1.Name = "generateTanBitanToolStripMenuItem1";
            this.generateTanBitanToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.generateTanBitanToolStripMenuItem1.Text = "Generate Tan/Bitan";
            this.generateTanBitanToolStripMenuItem1.Click += new System.EventHandler(this.generateTanBitanToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // detachToolStripMenuItem
            // 
            this.detachToolStripMenuItem.Name = "detachToolStripMenuItem";
            this.detachToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.detachToolStripMenuItem.Text = "Detach";
            this.detachToolStripMenuItem.Click += new System.EventHandler(this.detachToolStripMenuItem_Click);
            // 
            // meshContextMenu
            // 
            this.meshContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.singleBindToBoneToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteToolStripMenuItem1,
            this.toolStripSeparator6,
            this.calculateNormalsToolStripMenuItem1,
            this.generateTanBitanToolStripMenuItem2});
            this.meshContextMenu.Name = "meshContextMenu";
            this.meshContextMenu.Size = new System.Drawing.Size(178, 170);
            // 
            // mergeToolStripMenuItem1
            // 
            this.mergeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboveToolStripMenuItem1,
            this.belowToolStripMenuItem1});
            this.mergeToolStripMenuItem1.Name = "mergeToolStripMenuItem1";
            this.mergeToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.mergeToolStripMenuItem1.Text = "Merge";
            // 
            // aboveToolStripMenuItem1
            // 
            this.aboveToolStripMenuItem1.Name = "aboveToolStripMenuItem1";
            this.aboveToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.aboveToolStripMenuItem1.Text = "Above";
            this.aboveToolStripMenuItem1.Click += new System.EventHandler(this.aboveToolStripMenuItem1_Click);
            // 
            // belowToolStripMenuItem1
            // 
            this.belowToolStripMenuItem1.Name = "belowToolStripMenuItem1";
            this.belowToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.belowToolStripMenuItem1.Text = "Below";
            this.belowToolStripMenuItem1.Click += new System.EventHandler(this.belowToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem1.Text = "Reposition";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // singleBindToBoneToolStripMenuItem
            // 
            this.singleBindToBoneToolStripMenuItem.Name = "singleBindToBoneToolStripMenuItem";
            this.singleBindToBoneToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.singleBindToBoneToolStripMenuItem.Text = "Single Bind to Bone";
            this.singleBindToBoneToolStripMenuItem.Click += new System.EventHandler(this.singleBindToBoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(174, 6);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(174, 6);
            // 
            // calculateNormalsToolStripMenuItem1
            // 
            this.calculateNormalsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recalculateToolStripMenuItem,
            this.smoothToolStripMenuItem});
            this.calculateNormalsToolStripMenuItem1.Name = "calculateNormalsToolStripMenuItem1";
            this.calculateNormalsToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.calculateNormalsToolStripMenuItem1.Text = "Normals";
            // 
            // recalculateToolStripMenuItem
            // 
            this.recalculateToolStripMenuItem.Name = "recalculateToolStripMenuItem";
            this.recalculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recalculateToolStripMenuItem.Text = "Recalculate";
            this.recalculateToolStripMenuItem.Click += new System.EventHandler(this.recalculateToolStripMenuItem_Click);
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smoothToolStripMenuItem.Text = "Smooth";
            this.smoothToolStripMenuItem.Click += new System.EventHandler(this.smoothToolStripMenuItem_Click);
            // 
            // nudContextMenu
            // 
            this.nudContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.makeMetalToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.toolStripSeparator4,
            this.addBlankMeshToolStripMenuItem,
            this.smoothNormalsToolStripMenuItem1,
            this.generateTanBitanToolStripMenuItem,
            this.generateBoundingBoxesToolStripMenuItem,
            this.openEditToolStripMenuItem});
            this.nudContextMenu.Name = "nudContextMenu";
            this.nudContextMenu.Size = new System.Drawing.Size(210, 186);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveToolStripMenuItem.Text = "Save as nud";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // makeMetalToolStripMenuItem
            // 
            this.makeMetalToolStripMenuItem.Name = "makeMetalToolStripMenuItem";
            this.makeMetalToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.makeMetalToolStripMenuItem.Text = "Make Metal";
            this.makeMetalToolStripMenuItem.Click += new System.EventHandler(this.makeMetalToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsXMLToolStripMenuItem,
            this.importFromXMLToolStripMenuItem,
            this.useAOAsSpecToolStripMenuItem});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // exportAsXMLToolStripMenuItem
            // 
            this.exportAsXMLToolStripMenuItem.Name = "exportAsXMLToolStripMenuItem";
            this.exportAsXMLToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportAsXMLToolStripMenuItem.Text = "Export as XML";
            this.exportAsXMLToolStripMenuItem.Click += new System.EventHandler(this.exportAsXMLToolStripMenuItem_Click);
            // 
            // importFromXMLToolStripMenuItem
            // 
            this.importFromXMLToolStripMenuItem.Name = "importFromXMLToolStripMenuItem";
            this.importFromXMLToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importFromXMLToolStripMenuItem.Text = "Import from XML";
            this.importFromXMLToolStripMenuItem.Click += new System.EventHandler(this.importFromXMLToolStripMenuItem_Click);
            // 
            // useAOAsSpecToolStripMenuItem
            // 
            this.useAOAsSpecToolStripMenuItem.Name = "useAOAsSpecToolStripMenuItem";
            this.useAOAsSpecToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.useAOAsSpecToolStripMenuItem.Text = "AO Spec/Ref Blend";
            this.useAOAsSpecToolStripMenuItem.Click += new System.EventHandler(this.useAOAsSpecToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // addBlankMeshToolStripMenuItem
            // 
            this.addBlankMeshToolStripMenuItem.Name = "addBlankMeshToolStripMenuItem";
            this.addBlankMeshToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addBlankMeshToolStripMenuItem.Text = "Add Blank Mesh";
            this.addBlankMeshToolStripMenuItem.Click += new System.EventHandler(this.addBlankMeshToolStripMenuItem_Click);
            // 
            // smoothNormalsToolStripMenuItem1
            // 
            this.smoothNormalsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recalculateToolStripMenuItem2,
            this.smoothToolStripMenuItem2});
            this.smoothNormalsToolStripMenuItem1.Name = "smoothNormalsToolStripMenuItem1";
            this.smoothNormalsToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.smoothNormalsToolStripMenuItem1.Text = "Normals";
            // 
            // generateTanBitanToolStripMenuItem
            // 
            this.generateTanBitanToolStripMenuItem.Name = "generateTanBitanToolStripMenuItem";
            this.generateTanBitanToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.generateTanBitanToolStripMenuItem.Text = "Generate Tan/Bitan";
            this.generateTanBitanToolStripMenuItem.Click += new System.EventHandler(this.generateTanBitanToolStripMenuItem_Click);
            // 
            // generateBoundingBoxesToolStripMenuItem
            // 
            this.generateBoundingBoxesToolStripMenuItem.Name = "generateBoundingBoxesToolStripMenuItem";
            this.generateBoundingBoxesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.generateBoundingBoxesToolStripMenuItem.Text = "Generate Bounding Boxes";
            this.generateBoundingBoxesToolStripMenuItem.Click += new System.EventHandler(this.generateBoundingBoxesToolStripMenuItem_Click);
            // 
            // openEditToolStripMenuItem
            // 
            this.openEditToolStripMenuItem.Enabled = false;
            this.openEditToolStripMenuItem.Name = "openEditToolStripMenuItem";
            this.openEditToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.openEditToolStripMenuItem.Text = "Open Edit";
            this.openEditToolStripMenuItem.Click += new System.EventHandler(this.openEditToolStripMenuItem_Click);
            // 
            // MCContextMenu
            // 
            this.MCContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromDAEToolStripMenuItem,
            this.exportAsDAEToolStripMenuItem,
            this.mergeToolStripMenuItem});
            this.MCContextMenu.Name = "MCContextMenu";
            this.MCContextMenu.Size = new System.Drawing.Size(167, 70);
            // 
            // importFromDAEToolStripMenuItem
            // 
            this.importFromDAEToolStripMenuItem.Name = "importFromDAEToolStripMenuItem";
            this.importFromDAEToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importFromDAEToolStripMenuItem.Text = "Import From DAE";
            this.importFromDAEToolStripMenuItem.Click += new System.EventHandler(this.importFromDAEToolStripMenuItem_Click);
            // 
            // exportAsDAEToolStripMenuItem
            // 
            this.exportAsDAEToolStripMenuItem.Name = "exportAsDAEToolStripMenuItem";
            this.exportAsDAEToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportAsDAEToolStripMenuItem.Text = "Export As DAE";
            this.exportAsDAEToolStripMenuItem.Click += new System.EventHandler(this.exportAsDAEToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belowToolStripMenuItem,
            this.aboveToolStripMenuItem});
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.mergeToolStripMenuItem.Text = "Merge";
            // 
            // belowToolStripMenuItem
            // 
            this.belowToolStripMenuItem.Name = "belowToolStripMenuItem";
            this.belowToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.belowToolStripMenuItem.Text = "Below";
            this.belowToolStripMenuItem.Click += new System.EventHandler(this.belowToolStripMenuItem_Click_1);
            // 
            // aboveToolStripMenuItem
            // 
            this.aboveToolStripMenuItem.Name = "aboveToolStripMenuItem";
            this.aboveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboveToolStripMenuItem.Text = "Above";
            this.aboveToolStripMenuItem.Click += new System.EventHandler(this.aboveToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model List";
            // 
            // recalculateToolStripMenuItem1
            // 
            this.recalculateToolStripMenuItem1.Name = "recalculateToolStripMenuItem1";
            this.recalculateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.recalculateToolStripMenuItem1.Text = "Recalculate";
            this.recalculateToolStripMenuItem1.Click += new System.EventHandler(this.recalculateToolStripMenuItem1_Click);
            // 
            // smoothToolStripMenuItem1
            // 
            this.smoothToolStripMenuItem1.Name = "smoothToolStripMenuItem1";
            this.smoothToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.smoothToolStripMenuItem1.Text = "Smooth";
            this.smoothToolStripMenuItem1.Click += new System.EventHandler(this.smoothToolStripMenuItem1_Click);
            // 
            // recalculateToolStripMenuItem2
            // 
            this.recalculateToolStripMenuItem2.Name = "recalculateToolStripMenuItem2";
            this.recalculateToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.recalculateToolStripMenuItem2.Text = "Recalculate";
            this.recalculateToolStripMenuItem2.Click += new System.EventHandler(this.recalculateToolStripMenuItem2_Click);
            // 
            // smoothToolStripMenuItem2
            // 
            this.smoothToolStripMenuItem2.Name = "smoothToolStripMenuItem2";
            this.smoothToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.smoothToolStripMenuItem2.Text = "Smooth";
            this.smoothToolStripMenuItem2.Click += new System.EventHandler(this.smoothToolStripMenuItem2_Click);
            // 
            // generateTanBitanToolStripMenuItem2
            // 
            this.generateTanBitanToolStripMenuItem2.Name = "generateTanBitanToolStripMenuItem2";
            this.generateTanBitanToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.generateTanBitanToolStripMenuItem2.Text = "Generate Tan/Bitan";
            this.generateTanBitanToolStripMenuItem2.Click += new System.EventHandler(this.generateTanBitanToolStripMenuItem2_Click);
            // 
            // MeshList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MeshList";
            this.Text = "Model List";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.polyContextMenu.ResumeLayout(false);
            this.meshContextMenu.ResumeLayout(false);
            this.nudContextMenu.ResumeLayout(false);
            this.MCContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip polyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipUVsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip meshContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singleBindToBoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip nudContextMenu;
        private System.Windows.Forms.ToolStripMenuItem makeMetalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smoothNormalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detachToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem belowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem flipUVsHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBlankMeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTanBitanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTanBitanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smoothNormalsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem useAOAsSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useAOAsSpecToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip MCContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsDAEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromDAEToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem generateBoundingBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem calculateNormalsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalculateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recalculateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generateTanBitanToolStripMenuItem2;
    }
}