<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceListBoxForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DiceRollsListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'DiceRollsListBox
        '
        Me.DiceRollsListBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiceRollsListBox.FormattingEnabled = True
        Me.DiceRollsListBox.ItemHeight = 28
        Me.DiceRollsListBox.Location = New System.Drawing.Point(49, 44)
        Me.DiceRollsListBox.Name = "DiceRollsListBox"
        Me.DiceRollsListBox.Size = New System.Drawing.Size(1027, 228)
        Me.DiceRollsListBox.TabIndex = 3
        Me.DiceRollsListBox.TabStop = False
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(49, 343)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(234, 139)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "&Roll"
        Me.ToolTip1.SetToolTip(Me.RollButton, "Display total number of rolls of each number.")
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(448, 343)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(234, 139)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear all data in the box above.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(837, 343)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(234, 139)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RollOfTheDiceListBox
        '
        Me.AcceptButton = Me.RollButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1131, 651)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.DiceRollsListBox)
        Me.Name = "RollOfTheDiceListBox"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DiceRollsListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
