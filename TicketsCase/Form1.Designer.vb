<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTickets
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
        Me.btnPrize = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPrize
        '
        Me.btnPrize.Location = New System.Drawing.Point(28, 98)
        Me.btnPrize.Name = "btnPrize"
        Me.btnPrize.Size = New System.Drawing.Size(208, 23)
        Me.btnPrize.TabIndex = 0
        Me.btnPrize.Text = "Find me a cool prize!"
        Me.btnPrize.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(30, 23)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(208, 17)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "How many tickets did you earn?"
        '
        'txtTickets
        '
        Me.txtTickets.Location = New System.Drawing.Point(28, 56)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(208, 22)
        Me.txtTickets.TabIndex = 2
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 145)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnPrize)
        Me.Name = "frmTickets"
        Me.Text = "Prizes!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrize As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtTickets As TextBox
End Class
