<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceListBox
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
        Me.DiceRollsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'DiceRollsListBox
        '
        Me.DiceRollsListBox.FormattingEnabled = True
        Me.DiceRollsListBox.ItemHeight = 25
        Me.DiceRollsListBox.Location = New System.Drawing.Point(49, 44)
        Me.DiceRollsListBox.Name = "DiceRollsListBox"
        Me.DiceRollsListBox.Size = New System.Drawing.Size(766, 229)
        Me.DiceRollsListBox.TabIndex = 0
        '
        'RollOfTheDiceListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 507)
        Me.Controls.Add(Me.DiceRollsListBox)
        Me.Name = "RollOfTheDiceListBox"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DiceRollsListBox As ListBox
End Class
