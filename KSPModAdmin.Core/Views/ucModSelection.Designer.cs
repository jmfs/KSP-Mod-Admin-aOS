﻿using KSPModAdmin.Core.Properties;

namespace KSPModAdmin.Core.Views
{
    partial class ucModSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Mod Infos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("File Infos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Name",
            "KSP Mod Admin AnyOS"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Archive path",
            "None"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Version Control",
            "mactee.de"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ID",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Version",
            "1.0.0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "KSP Version",
            "0.25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Author",
            "BHeinrich"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Creation date",
            "27.05.2014"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Change date",
            "28.10.2014"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Outdated",
            "No"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Rating",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Downloads",
            "75k+"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Note",
            "KSP MA aOS is the mod managing tool for KSP on any OS."}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Name",
            "KSPModAdmin.exe"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Destination",
            "<No destination>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Conflicts",
            "None"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Installed",
            "Yes"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucModSelection));
            this.ttModSelection = new System.Windows.Forms.ToolTip(this.components);
            this.btnProceedAll = new System.Windows.Forms.Button();
            this.btnProceedHighlighted = new System.Windows.Forms.Button();
            this.cmsModSelectionOneMod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCmsDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsDestinationPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsSelectNewDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsResetDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsResetDestinations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsRedetectDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsOneModOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsOneModOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsRefreschCheckedState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsRefreshCheckedStateForHighlightedMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsEditModInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsCopyModInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsUpdatecheckMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsCheckHighlightedModsForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateHiglightedMods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsVisitVersionControlSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsVisitAdditionalLink = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsSolveConflicts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsProceedMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsProceedHighlightedMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsRemoveMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsRemoveHighlightedMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsCreateZip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelocateArchivePath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsOneModTreeViewOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvModSelection = new KSPModAdmin.Core.Utils.Controls.Aga.Controls.Tree.TreeViewAdv();
            this.cmsModSelectionAllMods = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCmsAddMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsAddModArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsImportExportModPack = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsScanForAlreadyInstalledMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenConflictSolver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsRemoveAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsProceedAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsUpdatecheckForAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateAllOutdatedMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsRefreshCheckedStateForAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsCheckAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsUncheckAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRelocateArchivePathAllMods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsTreeViewOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMod = new System.Windows.Forms.ToolStrip();
            this.tsbProceedMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModUpdateCheck = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateMod = new System.Windows.Forms.ToolStripButton();
            this.tssbVisitVersionControlSite = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiVisitVersionControlSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisitAdditionalLink = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditModInfos = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyModInfos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefreshCheckedState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbChangeDestination = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiChangeDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResetDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedetectDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCreateZip = new System.Windows.Forms.ToolStripButton();
            this.tsbRelocateArchivePath = new System.Windows.Forms.ToolStripButton();
            this.lvModSelection = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsModSelection = new System.Windows.Forms.ToolStrip();
            this.tssbAddMod = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiAddMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddModArchives = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveMod = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExImport = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiExImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdateCheckAllMods = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateAllOutdatedMods = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSolveConflicts = new System.Windows.Forms.ToolStripButton();
            this.tsbRefreshCheckedstateForAllMods = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckAllMods = new System.Windows.Forms.ToolStripButton();
            this.tsbUncheckAllMods = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tslBusy = new System.Windows.Forms.ToolStripLabel();
            this.tsbTreeViewOption = new System.Windows.Forms.ToolStripButton();
            this.tsbOverride = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmsModSelectionOneMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsModSelectionAllMods.SuspendLayout();
            this.tsMod.SuspendLayout();
            this.tsModSelection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProceedAll
            // 
            this.btnProceedAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProceedAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedAll.Image = global::KSPModAdmin.Core.Properties.Resources.components_gearwheel_24x24;
            this.btnProceedAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceedAll.Location = new System.Drawing.Point(369, 3);
            this.btnProceedAll.Name = "btnProceedAll";
            this.btnProceedAll.Size = new System.Drawing.Size(360, 44);
            this.btnProceedAll.TabIndex = 0;
            this.btnProceedAll.Text = "Process all mods";
            this.btnProceedAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttModSelection.SetToolTip(this.btnProceedAll, "Proceed all mods\r\nProceeds (installs/deinstalls) all mods in the selection tree.\r" +
        "\n(To install a part of a mod just check the checkbox next to it)");
            this.btnProceedAll.UseVisualStyleBackColor = true;
            this.btnProceedAll.Click += new System.EventHandler(this.btnProceedAll_Click);
            // 
            // btnProceedHighlighted
            // 
            this.btnProceedHighlighted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProceedHighlighted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedHighlighted.Image = global::KSPModAdmin.Core.Properties.Resources.component_gearwheel_24x24;
            this.btnProceedHighlighted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceedHighlighted.Location = new System.Drawing.Point(3, 3);
            this.btnProceedHighlighted.Name = "btnProceedHighlighted";
            this.btnProceedHighlighted.Size = new System.Drawing.Size(360, 44);
            this.btnProceedHighlighted.TabIndex = 1;
            this.btnProceedHighlighted.Text = "Process highlighted mods";
            this.btnProceedHighlighted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttModSelection.SetToolTip(this.btnProceedHighlighted, "Proceed highlighted mods\r\nProceeds (installs/deinstalls) the selected (blue highl" +
        "ighted) mod(s).\r\n(To install a part of a mod just check the checkbox next to it)" +
        "");
            this.btnProceedHighlighted.UseVisualStyleBackColor = true;
            this.btnProceedHighlighted.Click += new System.EventHandler(this.btnProceedHighlighted_Click);
            // 
            // cmsModSelectionOneMod
            // 
            this.cmsModSelectionOneMod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCmsDestination,
            this.tsmiCmsOneModOpenFolder,
            this.tsmiCmsOneModOpenFile,
            this.tsmiCmsRefreschCheckedState,
            this.tsmiCmsRefreshCheckedStateForHighlightedMods,
            this.toolStripSeparator18,
            this.tsmiCmsEditModInfos,
            this.tsmiCmsCopyModInfos,
            this.toolStripSeparator17,
            this.tsmiCmsUpdatecheckMod,
            this.tsmiCmsCheckHighlightedModsForUpdates,
            this.tsmiUpdateMod,
            this.tsmiUpdateHiglightedMods,
            this.tsmiCmsVisitVersionControlSite,
            this.tsmiCmsVisitAdditionalLink,
            this.toolStripSeparator10,
            this.tsmiCmsSolveConflicts,
            this.toolStripSeparator19,
            this.tsmiCmsProceedMod,
            this.tsmiCmsProceedHighlightedMods,
            this.toolStripSeparator13,
            this.tsmiCmsRemoveMod,
            this.tsmiCmsRemoveHighlightedMods,
            this.toolStripSeparator20,
            this.tsmiCmsCreateZip,
            this.tsmiRelocateArchivePath,
            this.toolStripSeparator14,
            this.tsmiCmsOneModTreeViewOptions});
            this.cmsModSelectionOneMod.Name = "cmsModSelection";
            this.cmsModSelectionOneMod.Size = new System.Drawing.Size(304, 508);
            this.cmsModSelectionOneMod.Opened += new System.EventHandler(this.cmsModSelectionOneMod_Opened);
            // 
            // tsmiCmsDestination
            // 
            this.tsmiCmsDestination.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCmsDestinationPath,
            this.tsmiCmsSelectNewDestination,
            this.tsmiCmsResetDestination,
            this.tsmiCmsResetDestinations,
            this.tsmiCmsRedetectDestination});
            this.tsmiCmsDestination.Name = "tsmiCmsDestination";
            this.tsmiCmsDestination.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsDestination.Text = "Destination";
            // 
            // tsmiCmsDestinationPath
            // 
            this.tsmiCmsDestinationPath.Enabled = false;
            this.tsmiCmsDestinationPath.Name = "tsmiCmsDestinationPath";
            this.tsmiCmsDestinationPath.Size = new System.Drawing.Size(248, 22);
            this.tsmiCmsDestinationPath.Text = "<No destination>";
            // 
            // tsmiCmsSelectNewDestination
            // 
            this.tsmiCmsSelectNewDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_gearwheel;
            this.tsmiCmsSelectNewDestination.Name = "tsmiCmsSelectNewDestination";
            this.tsmiCmsSelectNewDestination.Size = new System.Drawing.Size(248, 22);
            this.tsmiCmsSelectNewDestination.Text = "Select new destination";
            this.tsmiCmsSelectNewDestination.Click += new System.EventHandler(this.tsbChangeDestination_Click);
            // 
            // tsmiCmsResetDestination
            // 
            this.tsmiCmsResetDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_reset;
            this.tsmiCmsResetDestination.Name = "tsmiCmsResetDestination";
            this.tsmiCmsResetDestination.Size = new System.Drawing.Size(248, 22);
            this.tsmiCmsResetDestination.Text = "Reset destination";
            this.tsmiCmsResetDestination.Click += new System.EventHandler(this.tsmiResetDestination_Click);
            // 
            // tsmiCmsResetDestinations
            // 
            this.tsmiCmsResetDestinations.Image = global::KSPModAdmin.Core.Properties.Resources.components_folder_reset;
            this.tsmiCmsResetDestinations.Name = "tsmiCmsResetDestinations";
            this.tsmiCmsResetDestinations.Size = new System.Drawing.Size(248, 22);
            this.tsmiCmsResetDestinations.Text = "Reset destinations";
            // 
            // tsmiCmsRedetectDestination
            // 
            this.tsmiCmsRedetectDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_folder;
            this.tsmiCmsRedetectDestination.Name = "tsmiCmsRedetectDestination";
            this.tsmiCmsRedetectDestination.Size = new System.Drawing.Size(248, 22);
            this.tsmiCmsRedetectDestination.Text = "Redetect destination for the mod";
            this.tsmiCmsRedetectDestination.Click += new System.EventHandler(this.tsmiRedetectDestination_Click);
            // 
            // tsmiCmsOneModOpenFolder
            // 
            this.tsmiCmsOneModOpenFolder.Image = global::KSPModAdmin.Core.Properties.Resources.folder_up;
            this.tsmiCmsOneModOpenFolder.Name = "tsmiCmsOneModOpenFolder";
            this.tsmiCmsOneModOpenFolder.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsOneModOpenFolder.Text = "Open folder";
            this.tsmiCmsOneModOpenFolder.Click += new System.EventHandler(this.tsmiCmsOneModOpenFolder_Click);
            // 
            // tsmiCmsOneModOpenFile
            // 
            this.tsmiCmsOneModOpenFile.Image = global::KSPModAdmin.Core.Properties.Resources.folder_up;
            this.tsmiCmsOneModOpenFile.Name = "tsmiCmsOneModOpenFile";
            this.tsmiCmsOneModOpenFile.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsOneModOpenFile.Text = "Open file";
            this.tsmiCmsOneModOpenFile.Click += new System.EventHandler(this.tsmiCmsOneModOpenFile_Click);
            // 
            // tsmiCmsRefreschCheckedState
            // 
            this.tsmiCmsRefreschCheckedState.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_checkbox_checked;
            this.tsmiCmsRefreschCheckedState.Name = "tsmiCmsRefreschCheckedState";
            this.tsmiCmsRefreschCheckedState.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsRefreschCheckedState.Text = "Refresh checked state";
            this.tsmiCmsRefreschCheckedState.Click += new System.EventHandler(this.tsbRefreshCheckedState_Click);
            // 
            // tsmiCmsRefreshCheckedStateForHighlightedMods
            // 
            this.tsmiCmsRefreshCheckedStateForHighlightedMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_checkbox_unchecked;
            this.tsmiCmsRefreshCheckedStateForHighlightedMods.Name = "tsmiCmsRefreshCheckedStateForHighlightedMods";
            this.tsmiCmsRefreshCheckedStateForHighlightedMods.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsRefreshCheckedStateForHighlightedMods.Text = "Refresh checked state for highlighted mods";
            this.tsmiCmsRefreshCheckedStateForHighlightedMods.Click += new System.EventHandler(this.tsmiCmsRefreshCheckedStateForHighlightedMods_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsEditModInfos
            // 
            this.tsmiCmsEditModInfos.Image = global::KSPModAdmin.Core.Properties.Resources.component_scroll_edit;
            this.tsmiCmsEditModInfos.Name = "tsmiCmsEditModInfos";
            this.tsmiCmsEditModInfos.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsEditModInfos.Text = "Edit ModInfos";
            this.tsmiCmsEditModInfos.Click += new System.EventHandler(this.tsbEditModInfos_Click);
            // 
            // tsmiCmsCopyModInfos
            // 
            this.tsmiCmsCopyModInfos.Image = global::KSPModAdmin.Core.Properties.Resources.component_scroll_scroll;
            this.tsmiCmsCopyModInfos.Name = "tsmiCmsCopyModInfos";
            this.tsmiCmsCopyModInfos.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsCopyModInfos.Text = "Copy ModInfos";
            this.tsmiCmsCopyModInfos.Click += new System.EventHandler(this.tsbCopyModInfos_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsUpdatecheckMod
            // 
            this.tsmiCmsUpdatecheckMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_earth;
            this.tsmiCmsUpdatecheckMod.Name = "tsmiCmsUpdatecheckMod";
            this.tsmiCmsUpdatecheckMod.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsUpdatecheckMod.Text = "Check for update";
            this.tsmiCmsUpdatecheckMod.Click += new System.EventHandler(this.tsbModUpdateCheck_Click);
            // 
            // tsmiCmsCheckHighlightedModsForUpdates
            // 
            this.tsmiCmsCheckHighlightedModsForUpdates.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_earth;
            this.tsmiCmsCheckHighlightedModsForUpdates.Name = "tsmiCmsCheckHighlightedModsForUpdates";
            this.tsmiCmsCheckHighlightedModsForUpdates.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsCheckHighlightedModsForUpdates.Text = "Check highlighted mods for updates";
            this.tsmiCmsCheckHighlightedModsForUpdates.Click += new System.EventHandler(this.tsmiCmsCheckHighlightedModsForUpdates_Click);
            // 
            // tsmiUpdateMod
            // 
            this.tsmiUpdateMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_clock;
            this.tsmiUpdateMod.Name = "tsmiUpdateMod";
            this.tsmiUpdateMod.Size = new System.Drawing.Size(303, 22);
            this.tsmiUpdateMod.Text = "Update mod";
            this.tsmiUpdateMod.Click += new System.EventHandler(this.tsbUpdateMod_Click);
            // 
            // tsmiUpdateHiglightedMods
            // 
            this.tsmiUpdateHiglightedMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_clock;
            this.tsmiUpdateHiglightedMods.Name = "tsmiUpdateHiglightedMods";
            this.tsmiUpdateHiglightedMods.Size = new System.Drawing.Size(303, 22);
            this.tsmiUpdateHiglightedMods.Text = "Update highlighted mods";
            this.tsmiUpdateHiglightedMods.Click += new System.EventHandler(this.tsmiUpdateHiglightedMods_Click);
            // 
            // tsmiCmsVisitVersionControlSite
            // 
            this.tsmiCmsVisitVersionControlSite.Image = global::KSPModAdmin.Core.Properties.Resources.component_next_earth;
            this.tsmiCmsVisitVersionControlSite.Name = "tsmiCmsVisitVersionControlSite";
            this.tsmiCmsVisitVersionControlSite.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsVisitVersionControlSite.Text = "Visit version control URL";
            this.tsmiCmsVisitVersionControlSite.Click += new System.EventHandler(this.tssbVisitVersionControlSite_ButtonClick);
            // 
            // tsmiCmsVisitAdditionalLink
            // 
            this.tsmiCmsVisitAdditionalLink.Image = global::KSPModAdmin.Core.Properties.Resources.component_next_earth;
            this.tsmiCmsVisitAdditionalLink.Name = "tsmiCmsVisitAdditionalLink";
            this.tsmiCmsVisitAdditionalLink.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsVisitAdditionalLink.Text = "Visit additional link URL";
            this.tsmiCmsVisitAdditionalLink.Click += new System.EventHandler(this.tsmiVisitAdditionalLink_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsSolveConflicts
            // 
            this.tsmiCmsSolveConflicts.Image = global::KSPModAdmin.Core.Properties.Resources.component_warning;
            this.tsmiCmsSolveConflicts.Name = "tsmiCmsSolveConflicts";
            this.tsmiCmsSolveConflicts.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsSolveConflicts.Text = "Solve conflicts";
            this.tsmiCmsSolveConflicts.Click += new System.EventHandler(this.tsbSolveConflicts_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsProceedMod
            // 
            this.tsmiCmsProceedMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_gearwheel;
            this.tsmiCmsProceedMod.Name = "tsmiCmsProceedMod";
            this.tsmiCmsProceedMod.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsProceedMod.Text = "Proceed mod";
            this.tsmiCmsProceedMod.Click += new System.EventHandler(this.btnProceedMod_Click);
            // 
            // tsmiCmsProceedHighlightedMods
            // 
            this.tsmiCmsProceedHighlightedMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_gearwheel;
            this.tsmiCmsProceedHighlightedMods.Name = "tsmiCmsProceedHighlightedMods";
            this.tsmiCmsProceedHighlightedMods.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsProceedHighlightedMods.Text = "Proceed highlighted mods";
            this.tsmiCmsProceedHighlightedMods.Click += new System.EventHandler(this.btnProceedHighlighted_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsRemoveMod
            // 
            this.tsmiCmsRemoveMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_delete;
            this.tsmiCmsRemoveMod.Name = "tsmiCmsRemoveMod";
            this.tsmiCmsRemoveMod.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsRemoveMod.Text = "Remove mod";
            this.tsmiCmsRemoveMod.Click += new System.EventHandler(this.tsbRemoveMod_Click);
            // 
            // tsmiCmsRemoveHighlightedMods
            // 
            this.tsmiCmsRemoveHighlightedMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_delete;
            this.tsmiCmsRemoveHighlightedMods.Name = "tsmiCmsRemoveHighlightedMods";
            this.tsmiCmsRemoveHighlightedMods.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsRemoveHighlightedMods.Text = "Remove highlighted mods";
            this.tsmiCmsRemoveHighlightedMods.Click += new System.EventHandler(this.tsmiCmsRemoveHighlightedMods_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsCreateZip
            // 
            this.tsmiCmsCreateZip.Image = global::KSPModAdmin.Core.Properties.Resources.compress;
            this.tsmiCmsCreateZip.Name = "tsmiCmsCreateZip";
            this.tsmiCmsCreateZip.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsCreateZip.Text = "Create zip";
            this.tsmiCmsCreateZip.Click += new System.EventHandler(this.tsbCreateZip_Click);
            // 
            // tsmiRelocateArchivePath
            // 
            this.tsmiRelocateArchivePath.Image = global::KSPModAdmin.Core.Properties.Resources.compress_replace_folder_16x16;
            this.tsmiRelocateArchivePath.Name = "tsmiRelocateArchivePath";
            this.tsmiRelocateArchivePath.Size = new System.Drawing.Size(303, 22);
            this.tsmiRelocateArchivePath.Text = "Relocate mod archive path";
            this.tsmiRelocateArchivePath.Click += new System.EventHandler(this.tsbRelocateArchivePath_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(300, 6);
            // 
            // tsmiCmsOneModTreeViewOptions
            // 
            this.tsmiCmsOneModTreeViewOptions.Image = global::KSPModAdmin.Core.Properties.Resources.gears_preferences;
            this.tsmiCmsOneModTreeViewOptions.Name = "tsmiCmsOneModTreeViewOptions";
            this.tsmiCmsOneModTreeViewOptions.Size = new System.Drawing.Size(303, 22);
            this.tsmiCmsOneModTreeViewOptions.Text = "TreeView options";
            this.tsmiCmsOneModTreeViewOptions.Click += new System.EventHandler(this.tsmiCmsTreeViewOptions_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvModSelection);
            this.splitContainer1.Panel1MinSize = 315;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tsMod);
            this.splitContainer1.Panel2.Controls.Add(this.lvModSelection);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(732, 389);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvModSelection
            // 
            this.tvModSelection.AllowDrop = true;
            this.tvModSelection.BackColor = System.Drawing.SystemColors.Window;
            this.tvModSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvModSelection.ContextMenuStrip = this.cmsModSelectionAllMods;
            this.tvModSelection.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvModSelection.DefaultToolTipProvider = null;
            this.tvModSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvModSelection.DragDropMarkColor = System.Drawing.Color.Black;
            this.tvModSelection.FullRowSelect = true;
            this.tvModSelection.LineColor = System.Drawing.SystemColors.ControlDark;
            this.tvModSelection.Location = new System.Drawing.Point(0, 0);
            this.tvModSelection.Model = null;
            this.tvModSelection.Name = "tvModSelection";
            this.tvModSelection.SelectedNode = null;
            this.tvModSelection.SelectionMode = KSPModAdmin.Core.Utils.Controls.Aga.Controls.Tree.TreeSelectionMode.Multi;
            this.tvModSelection.ShowNodeToolTips = true;
            this.tvModSelection.Size = new System.Drawing.Size(364, 389);
            this.tvModSelection.TabIndex = 0;
            this.tvModSelection.Text = "treeViewAdv1";
            this.tvModSelection.UseColumns = true;
            this.tvModSelection.ColumnClicked += new System.EventHandler<KSPModAdmin.Core.Utils.Controls.Aga.Controls.Tree.TreeColumnEventArgs>(this.tvModSelection_ColumnClicked);
            this.tvModSelection.SelectionChanged += new System.EventHandler(this.tvModSelection_SelectionChanged);
            this.tvModSelection.DrawControl += new System.EventHandler<KSPModAdmin.Core.Utils.Controls.Aga.Controls.Tree.NodeControls.DrawEventArgs>(this.tvModSelection_DrawControl);
            this.tvModSelection.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvModSelection_DragDrop);
            this.tvModSelection.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvModSelection_DragEnter);
            this.tvModSelection.DoubleClick += new System.EventHandler(this.tvModSelection_DoubleClick);
            // 
            // cmsModSelectionAllMods
            // 
            this.cmsModSelectionAllMods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCmsAddMod,
            this.tsmiCmsAddModArchive,
            this.tsmiCmsImportExportModPack,
            this.tsmiCmsScanForAlreadyInstalledMods,
            this.toolStripSeparator22,
            this.tsmiOpenConflictSolver,
            this.toolStripSeparator16,
            this.tsmiCmsRemoveAllMods,
            this.toolStripSeparator23,
            this.tsmiCmsProceedAllMods,
            this.toolStripSeparator24,
            this.tsmiCmsUpdatecheckForAllMods,
            this.tsmiUpdateAllOutdatedMods,
            this.toolStripSeparator25,
            this.tsmiCmsRefreshCheckedStateForAllMods,
            this.tsmiCmsCheckAllMods,
            this.tsmiCmsUncheckAllMods,
            this.toolStripSeparator15,
            this.tsmiRelocateArchivePathAllMods,
            this.toolStripSeparator21,
            this.tsmiCmsTreeViewOptions});
            this.cmsModSelectionAllMods.Name = "cmsModSelectionAllMods";
            this.cmsModSelectionAllMods.Size = new System.Drawing.Size(282, 354);
            this.cmsModSelectionAllMods.Opened += new System.EventHandler(this.cmsModSelectionAllMods_Opened);
            // 
            // tsmiCmsAddMod
            // 
            this.tsmiCmsAddMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_add;
            this.tsmiCmsAddMod.Name = "tsmiCmsAddMod";
            this.tsmiCmsAddMod.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsAddMod.Text = "Add mod";
            this.tsmiCmsAddMod.Click += new System.EventHandler(this.tsbAddMod_Click);
            // 
            // tsmiCmsAddModArchive
            // 
            this.tsmiCmsAddModArchive.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_add;
            this.tsmiCmsAddModArchive.Name = "tsmiCmsAddModArchive";
            this.tsmiCmsAddModArchive.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsAddModArchive.Text = "Add mod archive";
            this.tsmiCmsAddModArchive.Click += new System.EventHandler(this.tsmiAddModArchives_Click);
            // 
            // tsmiCmsImportExportModPack
            // 
            this.tsmiCmsImportExportModPack.Image = global::KSPModAdmin.Core.Properties.Resources.component_package_replace;
            this.tsmiCmsImportExportModPack.Name = "tsmiCmsImportExportModPack";
            this.tsmiCmsImportExportModPack.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsImportExportModPack.Text = "Import/Export ModPack";
            this.tsmiCmsImportExportModPack.Click += new System.EventHandler(this.tsbExImport_Click);
            // 
            // tsmiCmsScanForAlreadyInstalledMods
            // 
            this.tsmiCmsScanForAlreadyInstalledMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_folder_view_24x24;
            this.tsmiCmsScanForAlreadyInstalledMods.Name = "tsmiCmsScanForAlreadyInstalledMods";
            this.tsmiCmsScanForAlreadyInstalledMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsScanForAlreadyInstalledMods.Text = "Scan for already installed mods";
            this.tsmiCmsScanForAlreadyInstalledMods.Click += new System.EventHandler(this.tsbScan_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiOpenConflictSolver
            // 
            this.tsmiOpenConflictSolver.Image = global::KSPModAdmin.Core.Properties.Resources.component_warning;
            this.tsmiOpenConflictSolver.Name = "tsmiOpenConflictSolver";
            this.tsmiOpenConflictSolver.Size = new System.Drawing.Size(281, 22);
            this.tsmiOpenConflictSolver.Text = "Solve conflicts";
            this.tsmiOpenConflictSolver.Click += new System.EventHandler(this.tsbSolveConflicts_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiCmsRemoveAllMods
            // 
            this.tsmiCmsRemoveAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_delete;
            this.tsmiCmsRemoveAllMods.Name = "tsmiCmsRemoveAllMods";
            this.tsmiCmsRemoveAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsRemoveAllMods.Text = "Remove all mods";
            this.tsmiCmsRemoveAllMods.Click += new System.EventHandler(this.tsbRemoveAll_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiCmsProceedAllMods
            // 
            this.tsmiCmsProceedAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_gearwheel;
            this.tsmiCmsProceedAllMods.Name = "tsmiCmsProceedAllMods";
            this.tsmiCmsProceedAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsProceedAllMods.Text = "Proceed all mods";
            this.tsmiCmsProceedAllMods.Click += new System.EventHandler(this.btnProceedAll_Click);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiCmsUpdatecheckForAllMods
            // 
            this.tsmiCmsUpdatecheckForAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_earth;
            this.tsmiCmsUpdatecheckForAllMods.Name = "tsmiCmsUpdatecheckForAllMods";
            this.tsmiCmsUpdatecheckForAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsUpdatecheckForAllMods.Text = "Updatecheck for all mods";
            this.tsmiCmsUpdatecheckForAllMods.Click += new System.EventHandler(this.tsbUpdateCheckAllMods_Click);
            // 
            // tsmiUpdateAllOutdatedMods
            // 
            this.tsmiUpdateAllOutdatedMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_clock;
            this.tsmiUpdateAllOutdatedMods.Name = "tsmiUpdateAllOutdatedMods";
            this.tsmiUpdateAllOutdatedMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiUpdateAllOutdatedMods.Text = "Update all outdated mods";
            this.tsmiUpdateAllOutdatedMods.ToolTipText = "Starts a updatecheck and updates all outdated mods.";
            this.tsmiUpdateAllOutdatedMods.Click += new System.EventHandler(this.tsbUpdateAllOutdatedMods_Click);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiCmsRefreshCheckedStateForAllMods
            // 
            this.tsmiCmsRefreshCheckedStateForAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_checkbox_checked;
            this.tsmiCmsRefreshCheckedStateForAllMods.Name = "tsmiCmsRefreshCheckedStateForAllMods";
            this.tsmiCmsRefreshCheckedStateForAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsRefreshCheckedStateForAllMods.Text = "Refresh checked state for all mods";
            this.tsmiCmsRefreshCheckedStateForAllMods.Click += new System.EventHandler(this.tsbRefreshCheckedstateForAllMods_Click);
            // 
            // tsmiCmsCheckAllMods
            // 
            this.tsmiCmsCheckAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_checkbox_checked;
            this.tsmiCmsCheckAllMods.Name = "tsmiCmsCheckAllMods";
            this.tsmiCmsCheckAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsCheckAllMods.Text = "Check all mods";
            this.tsmiCmsCheckAllMods.Click += new System.EventHandler(this.tsbCheckAllMods_Click);
            // 
            // tsmiCmsUncheckAllMods
            // 
            this.tsmiCmsUncheckAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_checkbox_unchecked;
            this.tsmiCmsUncheckAllMods.Name = "tsmiCmsUncheckAllMods";
            this.tsmiCmsUncheckAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsUncheckAllMods.Text = "Uncheck all mods";
            this.tsmiCmsUncheckAllMods.Click += new System.EventHandler(this.tsbUncheckAllMods_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiRelocateArchivePathAllMods
            // 
            this.tsmiRelocateArchivePathAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.compress_replace_folder_16x16;
            this.tsmiRelocateArchivePathAllMods.Name = "tsmiRelocateArchivePathAllMods";
            this.tsmiRelocateArchivePathAllMods.Size = new System.Drawing.Size(281, 22);
            this.tsmiRelocateArchivePathAllMods.Text = "Relocate mod archive path for all mods";
            this.tsmiRelocateArchivePathAllMods.Click += new System.EventHandler(this.tsmiRelocateArchivePathAllMods_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(278, 6);
            // 
            // tsmiCmsTreeViewOptions
            // 
            this.tsmiCmsTreeViewOptions.Image = global::KSPModAdmin.Core.Properties.Resources.gears_preferences;
            this.tsmiCmsTreeViewOptions.Name = "tsmiCmsTreeViewOptions";
            this.tsmiCmsTreeViewOptions.Size = new System.Drawing.Size(281, 22);
            this.tsmiCmsTreeViewOptions.Text = "TreeView options";
            this.tsmiCmsTreeViewOptions.Click += new System.EventHandler(this.tsmiCmsTreeViewOptions_Click);
            // 
            // tsMod
            // 
            this.tsMod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProceedMod,
            this.toolStripSeparator7,
            this.tsbModUpdateCheck,
            this.tsbUpdateMod,
            this.tssbVisitVersionControlSite,
            this.toolStripSeparator5,
            this.tsbEditModInfos,
            this.tsbCopyModInfos,
            this.toolStripSeparator6,
            this.tsbRefreshCheckedState,
            this.toolStripSeparator8,
            this.tssbChangeDestination,
            this.toolStripSeparator9,
            this.tsbCreateZip,
            this.tsbRelocateArchivePath});
            this.tsMod.Location = new System.Drawing.Point(0, 0);
            this.tsMod.Name = "tsMod";
            this.tsMod.Size = new System.Drawing.Size(364, 31);
            this.tsMod.TabIndex = 1;
            this.tsMod.Text = "toolStrip2";
            // 
            // tsbProceedMod
            // 
            this.tsbProceedMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProceedMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_gearwheel_24x24;
            this.tsbProceedMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProceedMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProceedMod.Name = "tsbProceedMod";
            this.tsbProceedMod.Size = new System.Drawing.Size(28, 28);
            this.tsbProceedMod.Text = "toolStripButton9";
            this.tsbProceedMod.ToolTipText = "Process mod\r\nInstalls/Uninstalles the checked(unchecked parts of the highlighted " +
    "mod.";
            this.tsbProceedMod.Click += new System.EventHandler(this.btnProceedHighlighted_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbModUpdateCheck
            // 
            this.tsbModUpdateCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModUpdateCheck.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_earth_24x24;
            this.tsbModUpdateCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModUpdateCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModUpdateCheck.Name = "tsbModUpdateCheck";
            this.tsbModUpdateCheck.Size = new System.Drawing.Size(28, 28);
            this.tsbModUpdateCheck.Text = "toolStripButton6";
            this.tsbModUpdateCheck.ToolTipText = "Mod update check\r\nChecks for mod updates if version control is active.";
            this.tsbModUpdateCheck.Click += new System.EventHandler(this.tsbModUpdateCheck_Click);
            // 
            // tsbUpdateMod
            // 
            this.tsbUpdateMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_clock_24x24;
            this.tsbUpdateMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdateMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateMod.Name = "tsbUpdateMod";
            this.tsbUpdateMod.Size = new System.Drawing.Size(28, 28);
            this.tsbUpdateMod.Text = "toolStripButton1";
            this.tsbUpdateMod.ToolTipText = "Update mod\r\nStarts a update check and updates the mod if it\'s outdated.\r\n";
            this.tsbUpdateMod.Click += new System.EventHandler(this.tsbUpdateMod_Click);
            // 
            // tssbVisitVersionControlSite
            // 
            this.tssbVisitVersionControlSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbVisitVersionControlSite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisitVersionControlSite,
            this.tsmiVisitAdditionalLink});
            this.tssbVisitVersionControlSite.Image = global::KSPModAdmin.Core.Properties.Resources.component_next_earth_24x24;
            this.tssbVisitVersionControlSite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbVisitVersionControlSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbVisitVersionControlSite.Name = "tssbVisitVersionControlSite";
            this.tssbVisitVersionControlSite.Size = new System.Drawing.Size(40, 28);
            this.tssbVisitVersionControlSite.Text = "toolStripSplitButton1";
            this.tssbVisitVersionControlSite.ToolTipText = "Visit version check site\r\nOpens the ModBrowser an navigates to the version check " +
    "site of the mod.";
            this.tssbVisitVersionControlSite.ButtonClick += new System.EventHandler(this.tssbVisitVersionControlSite_ButtonClick);
            // 
            // tsmiVisitVersionControlSite
            // 
            this.tsmiVisitVersionControlSite.Image = global::KSPModAdmin.Core.Properties.Resources.component_next_earth;
            this.tsmiVisitVersionControlSite.Name = "tsmiVisitVersionControlSite";
            this.tsmiVisitVersionControlSite.Size = new System.Drawing.Size(202, 22);
            this.tsmiVisitVersionControlSite.Text = "Visit version control URL";
            this.tsmiVisitVersionControlSite.ToolTipText = "Visit version check site\r\nOpens the ModBrowser an navigates to the version check " +
    "site of the mod.";
            this.tsmiVisitVersionControlSite.Click += new System.EventHandler(this.tssbVisitVersionControlSite_ButtonClick);
            // 
            // tsmiVisitAdditionalLink
            // 
            this.tsmiVisitAdditionalLink.Image = global::KSPModAdmin.Core.Properties.Resources.component_next_earth;
            this.tsmiVisitAdditionalLink.Name = "tsmiVisitAdditionalLink";
            this.tsmiVisitAdditionalLink.Size = new System.Drawing.Size(202, 22);
            this.tsmiVisitAdditionalLink.Text = "Visit additional link URL";
            this.tsmiVisitAdditionalLink.ToolTipText = "Visit additional link URL\r\nOpens the ModBrowser and navigates to the additional U" +
    "RL of the mod.";
            this.tsmiVisitAdditionalLink.Click += new System.EventHandler(this.tsmiVisitAdditionalLink_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbEditModInfos
            // 
            this.tsbEditModInfos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditModInfos.Image = global::KSPModAdmin.Core.Properties.Resources.component_edit_scroll_24x24;
            this.tsbEditModInfos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditModInfos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditModInfos.Name = "tsbEditModInfos";
            this.tsbEditModInfos.Size = new System.Drawing.Size(28, 28);
            this.tsbEditModInfos.Text = "toolStripButton7";
            this.tsbEditModInfos.ToolTipText = "Edit ModInfo\r\nOpens the ModInfo editor.";
            this.tsbEditModInfos.Click += new System.EventHandler(this.tsbEditModInfos_Click);
            // 
            // tsbCopyModInfos
            // 
            this.tsbCopyModInfos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopyModInfos.Image = global::KSPModAdmin.Core.Properties.Resources.component_scroll_scroll_24x24;
            this.tsbCopyModInfos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCopyModInfos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyModInfos.Name = "tsbCopyModInfos";
            this.tsbCopyModInfos.Size = new System.Drawing.Size(28, 28);
            this.tsbCopyModInfos.Text = "toolStripButton8";
            this.tsbCopyModInfos.ToolTipText = "Copy ModInfo\r\nCopies the ModInfo from this mod to another one.";
            this.tsbCopyModInfos.Click += new System.EventHandler(this.tsbCopyModInfos_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbRefreshCheckedState
            // 
            this.tsbRefreshCheckedState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshCheckedState.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_checkbox_checked_24x24;
            this.tsbRefreshCheckedState.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefreshCheckedState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshCheckedState.Name = "tsbRefreshCheckedState";
            this.tsbRefreshCheckedState.Size = new System.Drawing.Size(28, 28);
            this.tsbRefreshCheckedState.Text = "toolStripButton10";
            this.tsbRefreshCheckedState.ToolTipText = "Refresh checked state\r\nRefrashes the checked state of the mod.";
            this.tsbRefreshCheckedState.Click += new System.EventHandler(this.tsbRefreshCheckedState_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // tssbChangeDestination
            // 
            this.tssbChangeDestination.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbChangeDestination.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeDestination,
            this.tsmiResetDestination,
            this.tsmiRedetectDestination});
            this.tssbChangeDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_gearwheel_24x24;
            this.tssbChangeDestination.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbChangeDestination.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbChangeDestination.Name = "tssbChangeDestination";
            this.tssbChangeDestination.Size = new System.Drawing.Size(40, 28);
            this.tssbChangeDestination.Text = "toolStripSplitButton2";
            this.tssbChangeDestination.ToolTipText = "Select destination\r\nSelect a new install destination for the currently selected m" +
    "od file/folder.";
            this.tssbChangeDestination.ButtonClick += new System.EventHandler(this.tsbChangeDestination_Click);
            // 
            // tsmiChangeDestination
            // 
            this.tsmiChangeDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_gearwheel;
            this.tsmiChangeDestination.Name = "tsmiChangeDestination";
            this.tsmiChangeDestination.Size = new System.Drawing.Size(248, 22);
            this.tsmiChangeDestination.Text = "Select new destination";
            this.tsmiChangeDestination.ToolTipText = "Select destination\r\nSelect a new install destination for the currently selected m" +
    "od file/folder.\r\n";
            this.tsmiChangeDestination.Click += new System.EventHandler(this.tsbChangeDestination_Click);
            // 
            // tsmiResetDestination
            // 
            this.tsmiResetDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_reset;
            this.tsmiResetDestination.Name = "tsmiResetDestination";
            this.tsmiResetDestination.Size = new System.Drawing.Size(248, 22);
            this.tsmiResetDestination.Text = "Reset destination";
            this.tsmiResetDestination.ToolTipText = "Reset destination\r\nResets the destination for the currently selected mod file/fol" +
    "der.\r\n";
            this.tsmiResetDestination.Click += new System.EventHandler(this.tsmiResetDestination_Click);
            // 
            // tsmiRedetectDestination
            // 
            this.tsmiRedetectDestination.Image = global::KSPModAdmin.Core.Properties.Resources.component_replace_folder;
            this.tsmiRedetectDestination.Name = "tsmiRedetectDestination";
            this.tsmiRedetectDestination.Size = new System.Drawing.Size(248, 22);
            this.tsmiRedetectDestination.Text = "Redetect destination for the mod";
            this.tsmiRedetectDestination.ToolTipText = "Redetect destinations for the mod\r\nDeletes all destinations from the mod and \r\nan" +
    "d starts the auto destination detection for it.";
            this.tsmiRedetectDestination.Click += new System.EventHandler(this.tsmiRedetectDestination_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbCreateZip
            // 
            this.tsbCreateZip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCreateZip.Image = global::KSPModAdmin.Core.Properties.Resources.compress_24x24;
            this.tsbCreateZip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCreateZip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateZip.Name = "tsbCreateZip";
            this.tsbCreateZip.Size = new System.Drawing.Size(28, 28);
            this.tsbCreateZip.Text = "toolStripButton14";
            this.tsbCreateZip.ToolTipText = "Create zip archive\r\nCreate new zip archive of the mod.";
            this.tsbCreateZip.Click += new System.EventHandler(this.tsbCreateZip_Click);
            // 
            // tsbRelocateArchivePath
            // 
            this.tsbRelocateArchivePath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRelocateArchivePath.Image = global::KSPModAdmin.Core.Properties.Resources.compress_replace_folder_24x24;
            this.tsbRelocateArchivePath.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRelocateArchivePath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRelocateArchivePath.Name = "tsbRelocateArchivePath";
            this.tsbRelocateArchivePath.Size = new System.Drawing.Size(28, 28);
            this.tsbRelocateArchivePath.Text = "toolStripButton1";
            this.tsbRelocateArchivePath.Click += new System.EventHandler(this.tsbRelocateArchivePath_Click);
            // 
            // lvModSelection
            // 
            this.lvModSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvModSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvModSelection.FullRowSelect = true;
            listViewGroup1.Header = "Mod Infos";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "File Infos";
            listViewGroup2.Name = "listViewGroup2";
            this.lvModSelection.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvModSelection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup1;
            listViewItem8.Group = listViewGroup1;
            listViewItem9.Group = listViewGroup1;
            listViewItem10.Group = listViewGroup1;
            listViewItem11.Group = listViewGroup1;
            listViewItem12.Group = listViewGroup1;
            listViewItem13.Group = listViewGroup1;
            listViewItem14.Group = listViewGroup2;
            listViewItem15.Group = listViewGroup2;
            listViewItem16.Group = listViewGroup2;
            listViewItem17.Group = listViewGroup2;
            this.lvModSelection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17});
            this.lvModSelection.Location = new System.Drawing.Point(0, 3);
            this.lvModSelection.MultiSelect = false;
            this.lvModSelection.Name = "lvModSelection";
            this.lvModSelection.Size = new System.Drawing.Size(364, 386);
            this.lvModSelection.TabIndex = 0;
            this.lvModSelection.UseCompatibleStateImageBehavior = false;
            this.lvModSelection.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 244;
            // 
            // tsModSelection
            // 
            this.tsModSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbAddMod,
            this.toolStripSeparator2,
            this.tsbRemoveMod,
            this.tsbRemoveAll,
            this.toolStripSeparator3,
            this.tsbExImport,
            this.toolStripSeparator11,
            this.tsbScan,
            this.toolStripSeparator4,
            this.tsbUpdateCheckAllMods,
            this.tsbUpdateAllOutdatedMods,
            this.toolStripSeparator12,
            this.tsbSolveConflicts,
            this.tsbRefreshCheckedstateForAllMods,
            this.tsbCheckAllMods,
            this.tsbUncheckAllMods,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsbHelp,
            this.tsProgressBar,
            this.tslBusy,
            this.tsbTreeViewOption,
            this.tsbOverride});
            this.tsModSelection.Location = new System.Drawing.Point(0, 0);
            this.tsModSelection.Name = "tsModSelection";
            this.tsModSelection.Size = new System.Drawing.Size(732, 31);
            this.tsModSelection.TabIndex = 2;
            this.tsModSelection.Text = "toolStrip1";
            // 
            // tssbAddMod
            // 
            this.tssbAddMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbAddMod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddMod,
            this.tsmiAddModArchives});
            this.tssbAddMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_add_24x24;
            this.tssbAddMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbAddMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAddMod.Name = "tssbAddMod";
            this.tssbAddMod.Size = new System.Drawing.Size(40, 28);
            this.tssbAddMod.Text = "toolStripSplitButton1";
            this.tssbAddMod.ToolTipText = "Add mod dialog\r\nOpens the \"Add mod dialog\".";
            this.tssbAddMod.ButtonClick += new System.EventHandler(this.tsbAddMod_Click);
            // 
            // tsmiAddMod
            // 
            this.tsmiAddMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_add;
            this.tsmiAddMod.Name = "tsmiAddMod";
            this.tsmiAddMod.Size = new System.Drawing.Size(165, 22);
            this.tsmiAddMod.Text = "Add Dialog";
            this.tsmiAddMod.ToolTipText = "Add mod dialog\r\nOpens the \"Add mod dialog\".";
            this.tsmiAddMod.Click += new System.EventHandler(this.tsbAddMod_Click);
            // 
            // tsmiAddModArchives
            // 
            this.tsmiAddModArchives.Image = global::KSPModAdmin.Core.Properties.Resources.component_folder_add;
            this.tsmiAddModArchives.Name = "tsmiAddModArchives";
            this.tsmiAddModArchives.Size = new System.Drawing.Size(165, 22);
            this.tsmiAddModArchives.Text = "Add mod archive";
            this.tsmiAddModArchives.ToolTipText = "Add mod arichve\r\nOpens the \"FileBrowser dialog\" to add a mod archive.";
            this.tsmiAddModArchives.Click += new System.EventHandler(this.tsmiAddModArchives_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbRemoveMod
            // 
            this.tsbRemoveMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveMod.Image = global::KSPModAdmin.Core.Properties.Resources.component_delete_24x24;
            this.tsbRemoveMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemoveMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveMod.Name = "tsbRemoveMod";
            this.tsbRemoveMod.Size = new System.Drawing.Size(28, 28);
            this.tsbRemoveMod.Text = "toolStripButton2";
            this.tsbRemoveMod.ToolTipText = "Remove mod\r\nRemoves the highlighted mods.";
            this.tsbRemoveMod.Click += new System.EventHandler(this.tsmiCmsRemoveHighlightedMods_Click);
            // 
            // tsbRemoveAll
            // 
            this.tsbRemoveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveAll.Image = global::KSPModAdmin.Core.Properties.Resources.components_delete_24x24;
            this.tsbRemoveAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveAll.Name = "tsbRemoveAll";
            this.tsbRemoveAll.Size = new System.Drawing.Size(28, 28);
            this.tsbRemoveAll.Text = "toolStripButton3";
            this.tsbRemoveAll.ToolTipText = "Remove all mods\r\nRemoves all mods from the ModsSelection.";
            this.tsbRemoveAll.Click += new System.EventHandler(this.tsbRemoveAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbExImport
            // 
            this.tsbExImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExImport,
            this.tsmiExportAsText});
            this.tsbExImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExImport.Image")));
            this.tsbExImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExImport.Name = "tsbExImport";
            this.tsbExImport.Size = new System.Drawing.Size(40, 28);
            this.tsbExImport.Text = "toolStripButton4";
            this.tsbExImport.ToolTipText = "ModPack Import/Export\r\nOpens the Import/Export dialog for ModPacks.";
            this.tsbExImport.ButtonClick += new System.EventHandler(this.tsbExImport_Click);
            // 
            // tsmiExImport
            // 
            this.tsmiExImport.Image = global::KSPModAdmin.Core.Properties.Resources.components_package_replace;
            this.tsmiExImport.Name = "tsmiExImport";
            this.tsmiExImport.Size = new System.Drawing.Size(201, 22);
            this.tsmiExImport.Text = "ModPack Import/Export";
            this.tsmiExImport.ToolTipText = "ModPack Import/Export\r\nOpens the Import/Export dialog for ModPacks.";
            this.tsmiExImport.Click += new System.EventHandler(this.tsbExImport_Click);
            // 
            // tsmiExportAsText
            // 
            this.tsmiExportAsText.Image = global::KSPModAdmin.Core.Properties.Resources.components_scroll_out1;
            this.tsmiExportAsText.Name = "tsmiExportAsText";
            this.tsmiExportAsText.Size = new System.Drawing.Size(201, 22);
            this.tsmiExportAsText.Text = "Export as .txt";
            this.tsmiExportAsText.ToolTipText = "Export as .txt\r\nSave the current mod list as a text file.";
            this.tsmiExportAsText.Click += new System.EventHandler(this.tsmiExporText_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbScan
            // 
            this.tsbScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScan.Image = global::KSPModAdmin.Core.Properties.Resources.components_folder_view_24x24;
            this.tsbScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScan.Name = "tsbScan";
            this.tsbScan.Size = new System.Drawing.Size(28, 28);
            this.tsbScan.Text = "toolStripButton5";
            this.tsbScan.ToolTipText = "Scan GameData folder\r\nScans the KSP GameData folder for already installed mods an" +
    "d\r\nadds them if they are not listed in the ModSelection.";
            this.tsbScan.Click += new System.EventHandler(this.tsbScan_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbUpdateCheckAllMods
            // 
            this.tsbUpdateCheckAllMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateCheckAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_earth_24x24;
            this.tsbUpdateCheckAllMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdateCheckAllMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateCheckAllMods.Name = "tsbUpdateCheckAllMods";
            this.tsbUpdateCheckAllMods.Size = new System.Drawing.Size(28, 28);
            this.tsbUpdateCheckAllMods.Text = "toolStripButton1";
            this.tsbUpdateCheckAllMods.ToolTipText = "Updatecheck for all mods\r\nStarts the update check for all mods in the ModSelectio" +
    "n.";
            this.tsbUpdateCheckAllMods.Click += new System.EventHandler(this.tsbUpdateCheckAllMods_Click);
            // 
            // tsbUpdateAllOutdatedMods
            // 
            this.tsbUpdateAllOutdatedMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateAllOutdatedMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_clock_24x24;
            this.tsbUpdateAllOutdatedMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdateAllOutdatedMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateAllOutdatedMods.Name = "tsbUpdateAllOutdatedMods";
            this.tsbUpdateAllOutdatedMods.Size = new System.Drawing.Size(28, 28);
            this.tsbUpdateAllOutdatedMods.Text = "toolStripButton1";
            this.tsbUpdateAllOutdatedMods.ToolTipText = "Update all outdated mods\r\nStarts a updatecheck and updates all outdated mods.";
            this.tsbUpdateAllOutdatedMods.Click += new System.EventHandler(this.tsbUpdateAllOutdatedMods_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbSolveConflicts
            // 
            this.tsbSolveConflicts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSolveConflicts.Image = global::KSPModAdmin.Core.Properties.Resources.component_warning_24x24;
            this.tsbSolveConflicts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSolveConflicts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSolveConflicts.Name = "tsbSolveConflicts";
            this.tsbSolveConflicts.Size = new System.Drawing.Size(28, 28);
            this.tsbSolveConflicts.Text = "toolStripButton1";
            this.tsbSolveConflicts.ToolTipText = "Open conflic solver.\r\nOpens the conflict solver dialog.";
            this.tsbSolveConflicts.Click += new System.EventHandler(this.tsbSolveConflicts_Click);
            // 
            // tsbRefreshCheckedstateForAllMods
            // 
            this.tsbRefreshCheckedstateForAllMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshCheckedstateForAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_replace_checkbox_checked_24x24;
            this.tsbRefreshCheckedstateForAllMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefreshCheckedstateForAllMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshCheckedstateForAllMods.Name = "tsbRefreshCheckedstateForAllMods";
            this.tsbRefreshCheckedstateForAllMods.Size = new System.Drawing.Size(28, 28);
            this.tsbRefreshCheckedstateForAllMods.Text = "toolStripButton1";
            this.tsbRefreshCheckedstateForAllMods.ToolTipText = "Refresh checked state of all mods.\r\nChecks all ModNodes with a destination.";
            this.tsbRefreshCheckedstateForAllMods.Click += new System.EventHandler(this.tsbRefreshCheckedstateForAllMods_Click);
            // 
            // tsbCheckAllMods
            // 
            this.tsbCheckAllMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_checkbox_checked_24x24;
            this.tsbCheckAllMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCheckAllMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckAllMods.Name = "tsbCheckAllMods";
            this.tsbCheckAllMods.Size = new System.Drawing.Size(28, 28);
            this.tsbCheckAllMods.Text = "toolStripButton1";
            this.tsbCheckAllMods.ToolTipText = "Check all mods\r\nChecks all mods.";
            this.tsbCheckAllMods.Click += new System.EventHandler(this.tsbCheckAllMods_Click);
            // 
            // tsbUncheckAllMods
            // 
            this.tsbUncheckAllMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUncheckAllMods.Image = global::KSPModAdmin.Core.Properties.Resources.components_checkbox_unchecked_24x24;
            this.tsbUncheckAllMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUncheckAllMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUncheckAllMods.Name = "tsbUncheckAllMods";
            this.tsbUncheckAllMods.Size = new System.Drawing.Size(28, 28);
            this.tsbUncheckAllMods.Text = "toolStripButton1";
            this.tsbUncheckAllMods.ToolTipText = "Uncheck all mods\r\nUnchecks all mods.";
            this.tsbUncheckAllMods.Click += new System.EventHandler(this.tsbUncheckAllMods_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 28);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = global::KSPModAdmin.Core.Properties.Resources.help_earth;
            this.tsbHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(28, 28);
            this.tsbHelp.Text = "toolStripButton1";
            this.tsbHelp.ToolTipText = "Open help\r\nOpens the wiki on GitHup with your browser.";
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(150, 32);
            this.tsProgressBar.Visible = false;
            // 
            // tslBusy
            // 
            this.tslBusy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslBusy.AutoSize = false;
            this.tslBusy.Image = ((System.Drawing.Image)(resources.GetObject("tslBusy.Image")));
            this.tslBusy.Name = "tslBusy";
            this.tslBusy.Size = new System.Drawing.Size(22, 22);
            this.tslBusy.ToolTipText = "working ...";
            this.tslBusy.Visible = false;
            // 
            // tsbTreeViewOption
            // 
            this.tsbTreeViewOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTreeViewOption.Image = global::KSPModAdmin.Core.Properties.Resources.gears_preferences_24x24;
            this.tsbTreeViewOption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTreeViewOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTreeViewOption.Name = "tsbTreeViewOption";
            this.tsbTreeViewOption.Size = new System.Drawing.Size(28, 28);
            this.tsbTreeViewOption.Text = "toolStripButton1";
            this.tsbTreeViewOption.ToolTipText = "Open TreeView options\r\nOpens the TreeView options.";
            this.tsbTreeViewOption.Click += new System.EventHandler(this.tsmiCmsTreeViewOptions_Click);
            // 
            // tsbOverride
            // 
            this.tsbOverride.CheckOnClick = true;
            this.tsbOverride.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOverride.Image = global::KSPModAdmin.Core.Properties.Resources.component_delete_data_24x24;
            this.tsbOverride.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOverride.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOverride.Name = "tsbOverride";
            this.tsbOverride.Size = new System.Drawing.Size(28, 28);
            this.tsbOverride.Text = "Override";
            this.tsbOverride.ToolTipText = "Override files\r\nEnables/disables the override mode of files during installation o" +
    "f mods.";
            this.tsbOverride.CheckedChanged += new System.EventHandler(this.tsbOverride_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnProceedAll, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProceedHighlighted, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 420);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ucModSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsModSelection);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucModSelection";
            this.Size = new System.Drawing.Size(732, 470);
            this.Load += new System.EventHandler(this.ucModSelection_Load);
            this.cmsModSelectionOneMod.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsModSelectionAllMods.ResumeLayout(false);
            this.tsMod.ResumeLayout(false);
            this.tsMod.PerformLayout();
            this.tsModSelection.ResumeLayout(false);
            this.tsModSelection.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRemoveMod;
        private System.Windows.Forms.ToolStripButton tsbRemoveAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbModUpdateCheck;
        private System.Windows.Forms.ToolStripButton tsbEditModInfos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbCopyModInfos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbProceedMod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbRefreshCheckedState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbCreateZip;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.ToolStripLabel tslBusy;
        internal System.Windows.Forms.ToolStripButton tsbOverride;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnProceedAll;
        private System.Windows.Forms.Button btnProceedHighlighted;
        private System.Windows.Forms.ToolTip ttModSelection;
        private System.Windows.Forms.ContextMenuStrip cmsModSelectionOneMod;
        public System.Windows.Forms.ListView lvModSelection;
        public System.Windows.Forms.ToolStrip tsModSelection;
        public System.Windows.Forms.ToolStrip tsMod;
        public Utils.Controls.Aga.Controls.Tree.TreeViewAdv tvModSelection;
        private System.Windows.Forms.ToolStripSplitButton tssbAddMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddModArchives;
        private System.Windows.Forms.ToolStripSplitButton tssbChangeDestination;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeDestination;
        private System.Windows.Forms.ToolStripMenuItem tsmiResetDestination;
        private System.Windows.Forms.ToolStripSplitButton tssbVisitVersionControlSite;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisitVersionControlSite;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisitAdditionalLink;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRemoveMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsProceedMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsUpdatecheckMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsVisitVersionControlSite;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsVisitAdditionalLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsEditModInfos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsCopyModInfos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsSolveConflicts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsCreateZip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsDestination;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsDestinationPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsSelectNewDestination;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsResetDestination;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRedetectDestination;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedetectDestination;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsbUpdateCheckAllMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRefreschCheckedState;
        private System.Windows.Forms.ContextMenuStrip cmsModSelectionAllMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsAddMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsImportExportModPack;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsScanForAlreadyInstalledMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRemoveAllMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsProceedAllMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsUpdatecheckForAllMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRefreshCheckedStateForAllMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsUncheckAllMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsAddModArchive;
        private System.Windows.Forms.ToolStripButton tsbRefreshCheckedstateForAllMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsbUncheckAllMods;
        private System.Windows.Forms.ToolStripButton tsbCheckAllMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsCheckAllMods;
        private System.Windows.Forms.ToolStripButton tsbUpdateAllOutdatedMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateAllOutdatedMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateMod;
        private System.Windows.Forms.ToolStripButton tsbUpdateMod;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsProceedHighlightedMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRemoveHighlightedMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateHiglightedMods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsCheckHighlightedModsForUpdates;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsRefreshCheckedStateForHighlightedMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsOneModTreeViewOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsTreeViewOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsResetDestinations;
		private System.Windows.Forms.ToolStripSplitButton tsbExImport;
		private System.Windows.Forms.ToolStripMenuItem tsmiExportAsText;
		private System.Windows.Forms.ToolStripMenuItem tsmiExImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsOneModOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsOneModOpenFile;
        private System.Windows.Forms.ToolStripButton tsbTreeViewOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenConflictSolver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton tsbSolveConflicts;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelocateArchivePath;
        private System.Windows.Forms.ToolStripButton tsbRelocateArchivePath;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelocateArchivePathAllMods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
    }
}
