<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TaskListbox = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GetTaskInput = New System.Windows.Forms.TextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.removeSelectedBtn = New System.Windows.Forms.Button()
        Me.Additionals = New System.Windows.Forms.TabPage()
        Me.removeAllBtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Additionals.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskListbox
        '
        Me.TaskListbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TaskListbox.FormattingEnabled = True
        Me.TaskListbox.Items.AddRange(New Object() {"Dummy Tasks", "Remove Them", "By Clicking", "'Remove All Tasks'", "Button :)"})
        Me.TaskListbox.Location = New System.Drawing.Point(12, 12)
        Me.TaskListbox.Name = "TaskListbox"
        Me.TaskListbox.Size = New System.Drawing.Size(331, 598)
        Me.TaskListbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a task to add in list:"
        '
        'GetTaskInput
        '
        Me.GetTaskInput.Location = New System.Drawing.Point(353, 36)
        Me.GetTaskInput.Name = "GetTaskInput"
        Me.GetTaskInput.Size = New System.Drawing.Size(209, 26)
        Me.GetTaskInput.TabIndex = 2
        '
        'addBtn
        '
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Location = New System.Drawing.Point(353, 68)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(209, 32)
        Me.addBtn.TabIndex = 3
        Me.addBtn.Text = "Add Task!"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'removeSelectedBtn
        '
        Me.removeSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeSelectedBtn.Location = New System.Drawing.Point(6, 16)
        Me.removeSelectedBtn.Name = "removeSelectedBtn"
        Me.removeSelectedBtn.Size = New System.Drawing.Size(189, 32)
        Me.removeSelectedBtn.TabIndex = 4
        Me.removeSelectedBtn.Text = "Remove Selected Tasks"
        Me.removeSelectedBtn.UseVisualStyleBackColor = True
        '
        'Additionals
        '
        Me.Additionals.Controls.Add(Me.removeAllBtn)
        Me.Additionals.Controls.Add(Me.removeSelectedBtn)
        Me.Additionals.Location = New System.Drawing.Point(4, 29)
        Me.Additionals.Name = "Additionals"
        Me.Additionals.Padding = New System.Windows.Forms.Padding(3)
        Me.Additionals.Size = New System.Drawing.Size(201, 99)
        Me.Additionals.TabIndex = 0
        Me.Additionals.Text = "Additionals"
        Me.Additionals.UseVisualStyleBackColor = True
        '
        'removeAllBtn
        '
        Me.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeAllBtn.Location = New System.Drawing.Point(6, 54)
        Me.removeAllBtn.Name = "removeAllBtn"
        Me.removeAllBtn.Size = New System.Drawing.Size(189, 32)
        Me.removeAllBtn.TabIndex = 5
        Me.removeAllBtn.Text = "Remove All Tasks"
        Me.removeAllBtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Additionals)
        Me.TabControl1.Location = New System.Drawing.Point(353, 117)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(209, 132)
        Me.TabControl1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 624)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.GetTaskInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TaskListbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(596, 680)
        Me.MinimumSize = New System.Drawing.Size(596, 680)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Sure You Complete Your Tasks!"
        Me.Additionals.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaskListbox As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GetTaskInput As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents removeSelectedBtn As Button
    Friend WithEvents Additionals As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents removeAllBtn As Button
End Class
