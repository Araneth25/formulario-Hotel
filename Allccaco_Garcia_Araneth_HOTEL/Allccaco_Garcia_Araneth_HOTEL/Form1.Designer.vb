<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdReservar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdReservar
        '
        Me.cmdReservar.BackColor = System.Drawing.Color.Black
        Me.cmdReservar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReservar.ForeColor = System.Drawing.Color.White
        Me.cmdReservar.Location = New System.Drawing.Point(488, 455)
        Me.cmdReservar.Name = "cmdReservar"
        Me.cmdReservar.Size = New System.Drawing.Size(123, 40)
        Me.cmdReservar.TabIndex = 0
        Me.cmdReservar.Text = "RESERVAR"
        Me.cmdReservar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources.portada
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 562)
        Me.Controls.Add(Me.cmdReservar)
        Me.Font = New System.Drawing.Font("Verdana Pro Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenidos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdReservar As Button
End Class
