<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.lblPrecioHabitacion = New System.Windows.Forms.Label()
        Me.lblTipodeDescuento = New System.Windows.Forms.Label()
        Me.lblTotalHabitacion = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblTOTALPago = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantidadHab = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrecioHabitacion
        '
        Me.lblPrecioHabitacion.AutoSize = True
        Me.lblPrecioHabitacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioHabitacion.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioHabitacion.Location = New System.Drawing.Point(348, 265)
        Me.lblPrecioHabitacion.Name = "lblPrecioHabitacion"
        Me.lblPrecioHabitacion.Size = New System.Drawing.Size(20, 23)
        Me.lblPrecioHabitacion.TabIndex = 0
        Me.lblPrecioHabitacion.Text = "0"
        '
        'lblTipodeDescuento
        '
        Me.lblTipodeDescuento.AutoSize = True
        Me.lblTipodeDescuento.BackColor = System.Drawing.Color.Transparent
        Me.lblTipodeDescuento.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipodeDescuento.Location = New System.Drawing.Point(348, 294)
        Me.lblTipodeDescuento.Name = "lblTipodeDescuento"
        Me.lblTipodeDescuento.Size = New System.Drawing.Size(20, 23)
        Me.lblTipodeDescuento.TabIndex = 1
        Me.lblTipodeDescuento.Text = "0"
        '
        'lblTotalHabitacion
        '
        Me.lblTotalHabitacion.AutoSize = True
        Me.lblTotalHabitacion.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalHabitacion.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHabitacion.Location = New System.Drawing.Point(445, 265)
        Me.lblTotalHabitacion.Name = "lblTotalHabitacion"
        Me.lblTotalHabitacion.Size = New System.Drawing.Size(17, 20)
        Me.lblTotalHabitacion.TabIndex = 2
        Me.lblTotalHabitacion.Text = "0"
        Me.lblTotalHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.BackColor = System.Drawing.Color.Transparent
        Me.lblDescuento.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(445, 294)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(17, 20)
        Me.lblDescuento.TabIndex = 3
        Me.lblDescuento.Text = "0"
        Me.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "€"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(498, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "€"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "€"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(500, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "€"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "€"
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblImporteTotal.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.Location = New System.Drawing.Point(444, 342)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(17, 20)
        Me.lblImporteTotal.TabIndex = 9
        Me.lblImporteTotal.Text = "0"
        Me.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.BackColor = System.Drawing.Color.Transparent
        Me.lblIva.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(440, 376)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(17, 20)
        Me.lblIva.TabIndex = 10
        Me.lblIva.Text = "0"
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTOTALPago
        '
        Me.lblTOTALPago.AutoSize = True
        Me.lblTOTALPago.BackColor = System.Drawing.Color.Transparent
        Me.lblTOTALPago.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOTALPago.ForeColor = System.Drawing.Color.Black
        Me.lblTOTALPago.Location = New System.Drawing.Point(440, 407)
        Me.lblTOTALPago.Name = "lblTOTALPago"
        Me.lblTOTALPago.Size = New System.Drawing.Size(17, 20)
        Me.lblTOTALPago.TabIndex = 11
        Me.lblTOTALPago.Text = "0"
        Me.lblTOTALPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(306, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "21%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateGray
        Me.Label1.Location = New System.Drawing.Point(262, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CANTIDAD"
        '
        'lblCantidadHab
        '
        Me.lblCantidadHab.AutoSize = True
        Me.lblCantidadHab.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadHab.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadHab.Location = New System.Drawing.Point(294, 265)
        Me.lblCantidadHab.Name = "lblCantidadHab"
        Me.lblCantidadHab.Size = New System.Drawing.Size(20, 23)
        Me.lblCantidadHab.TabIndex = 14
        Me.lblCantidadHab.Text = "0"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources.factura1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(555, 690)
        Me.Controls.Add(Me.lblCantidadHab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTOTALPago)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblTotalHabitacion)
        Me.Controls.Add(Me.lblTipodeDescuento)
        Me.Controls.Add(Me.lblPrecioHabitacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrecioHabitacion As Label
    Friend WithEvents lblTipodeDescuento As Label
    Friend WithEvents lblTotalHabitacion As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblTOTALPago As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCantidadHab As Label
End Class
