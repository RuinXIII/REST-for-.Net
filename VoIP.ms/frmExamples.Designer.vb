<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamples
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
        Me.btnGetIPAddress = New System.Windows.Forms.Button()
        Me.btnGetBalance = New System.Windows.Forms.Button()
        Me.btnGetServers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetIPAddress
        '
        Me.btnGetIPAddress.Location = New System.Drawing.Point(34, 23)
        Me.btnGetIPAddress.Name = "btnGetIPAddress"
        Me.btnGetIPAddress.Size = New System.Drawing.Size(111, 23)
        Me.btnGetIPAddress.TabIndex = 0
        Me.btnGetIPAddress.Text = "Get IP Address"
        Me.btnGetIPAddress.UseVisualStyleBackColor = True
        '
        'btnGetBalance
        '
        Me.btnGetBalance.Location = New System.Drawing.Point(151, 23)
        Me.btnGetBalance.Name = "btnGetBalance"
        Me.btnGetBalance.Size = New System.Drawing.Size(111, 23)
        Me.btnGetBalance.TabIndex = 1
        Me.btnGetBalance.Text = "Get Balance"
        Me.btnGetBalance.UseVisualStyleBackColor = True
        '
        'btnGetServers
        '
        Me.btnGetServers.Location = New System.Drawing.Point(98, 61)
        Me.btnGetServers.Name = "btnGetServers"
        Me.btnGetServers.Size = New System.Drawing.Size(111, 23)
        Me.btnGetServers.TabIndex = 2
        Me.btnGetServers.Text = "Get CAN Servers"
        Me.btnGetServers.UseVisualStyleBackColor = True
        '
        'frmExamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 110)
        Me.Controls.Add(Me.btnGetServers)
        Me.Controls.Add(Me.btnGetBalance)
        Me.Controls.Add(Me.btnGetIPAddress)
        Me.Name = "frmExamples"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examples REST for .Net"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetIPAddress As Button
    Friend WithEvents btnGetBalance As Button
    Friend WithEvents btnGetServers As Button
End Class
