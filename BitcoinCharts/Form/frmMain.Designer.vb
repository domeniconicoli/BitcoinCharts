<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.gbHistoryDateFilter = New System.Windows.Forms.GroupBox()
        Me.btnHistoryDownload = New System.Windows.Forms.Button()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.MainChart = New LiveCharts.WinForms.CartesianChart()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tpHistory.SuspendLayout()
        Me.gbHistoryDateFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.IsSplitterFixed = True
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Margin = New System.Windows.Forms.Padding(4)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.tcMain)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.MainChart)
        Me.scMain.Size = New System.Drawing.Size(1311, 770)
        Me.scMain.SplitterDistance = 114
        Me.scMain.SplitterWidth = 5
        Me.scMain.TabIndex = 0
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpHistory)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Location = New System.Drawing.Point(0, 0)
        Me.tcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1311, 114)
        Me.tcMain.TabIndex = 0
        '
        'tpHistory
        '
        Me.tpHistory.Controls.Add(Me.gbHistoryDateFilter)
        Me.tpHistory.Location = New System.Drawing.Point(4, 25)
        Me.tpHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Padding = New System.Windows.Forms.Padding(4)
        Me.tpHistory.Size = New System.Drawing.Size(1303, 85)
        Me.tpHistory.TabIndex = 1
        Me.tpHistory.Text = "History"
        Me.tpHistory.UseVisualStyleBackColor = True
        '
        'gbHistoryDateFilter
        '
        Me.gbHistoryDateFilter.Controls.Add(Me.btnHistoryDownload)
        Me.gbHistoryDateFilter.Controls.Add(Me.dtpEndDate)
        Me.gbHistoryDateFilter.Controls.Add(Me.lblTo)
        Me.gbHistoryDateFilter.Controls.Add(Me.lblFrom)
        Me.gbHistoryDateFilter.Controls.Add(Me.dtpStartDate)
        Me.gbHistoryDateFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbHistoryDateFilter.Location = New System.Drawing.Point(4, 4)
        Me.gbHistoryDateFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.gbHistoryDateFilter.Name = "gbHistoryDateFilter"
        Me.gbHistoryDateFilter.Padding = New System.Windows.Forms.Padding(4)
        Me.gbHistoryDateFilter.Size = New System.Drawing.Size(1295, 77)
        Me.gbHistoryDateFilter.TabIndex = 8
        Me.gbHistoryDateFilter.TabStop = False
        Me.gbHistoryDateFilter.Text = "Date Filters"
        '
        'btnHistoryDownload
        '
        Me.btnHistoryDownload.Image = CType(resources.GetObject("btnHistoryDownload.Image"), System.Drawing.Image)
        Me.btnHistoryDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistoryDownload.Location = New System.Drawing.Point(499, 23)
        Me.btnHistoryDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHistoryDownload.Name = "btnHistoryDownload"
        Me.btnHistoryDownload.Size = New System.Drawing.Size(199, 39)
        Me.btnHistoryDownload.TabIndex = 12
        Me.btnHistoryDownload.Text = "Download"
        Me.btnHistoryDownload.UseVisualStyleBackColor = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(322, 35)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndDate.MaxDate = New Date(2018, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(138, 22)
        Me.dtpEndDate.TabIndex = 11
        Me.dtpEndDate.Value = New Date(2018, 12, 31, 0, 0, 0, 0)
        '
        'lblTo
        '
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(268, 32)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(48, 29)
        Me.lblTo.TabIndex = 10
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(20, 32)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(72, 29)
        Me.lblFrom.TabIndex = 9
        Me.lblFrom.Text = "From:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = ""
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(100, 35)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate.MaxDate = New Date(2018, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(138, 22)
        Me.dtpStartDate.TabIndex = 8
        Me.dtpStartDate.Value = New Date(2018, 12, 31, 0, 0, 0, 0)
        '
        'MainChart
        '
        Me.MainChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainChart.Location = New System.Drawing.Point(0, 0)
        Me.MainChart.Margin = New System.Windows.Forms.Padding(4)
        Me.MainChart.Name = "MainChart"
        Me.MainChart.Size = New System.Drawing.Size(1311, 651)
        Me.MainChart.TabIndex = 0
        Me.MainChart.Text = "MainChart"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 770)
        Me.Controls.Add(Me.scMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Bitcoin Charts"
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.tcMain.ResumeLayout(False)
        Me.tpHistory.ResumeLayout(False)
        Me.gbHistoryDateFilter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scMain As SplitContainer
    Friend WithEvents MainChart As LiveCharts.WinForms.CartesianChart
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents gbHistoryDateFilter As GroupBox
    Friend WithEvents btnHistoryDownload As Button
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpStartDate As DateTimePicker
End Class
