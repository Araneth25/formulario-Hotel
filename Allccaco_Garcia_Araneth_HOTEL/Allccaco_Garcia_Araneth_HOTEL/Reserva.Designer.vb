<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reserva
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reserva))
        Me.p1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.p0 = New System.Windows.Forms.Panel()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.calendarioMonth = New System.Windows.Forms.MonthCalendar()
        Me.calendarioDay = New System.Windows.Forms.DateTimePicker()
        Me.cbHuespedes = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbHabitaciones = New System.Windows.Forms.ComboBox()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.lblSRoyal = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblHDoble = New System.Windows.Forms.Label()
        Me.lblHSimple = New System.Windows.Forms.Label()
        Me.rbSRoyal = New System.Windows.Forms.RadioButton()
        Me.rbSuite = New System.Windows.Forms.RadioButton()
        Me.rbHDoble = New System.Windows.Forms.RadioButton()
        Me.rbHSimple = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CmdCaptura = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.rbNO = New System.Windows.Forms.RadioButton()
        Me.rbSI = New System.Windows.Forms.RadioButton()
        Me.lblPregunt = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.cmdCupones = New System.Windows.Forms.Button()
        Me.cmdHabitacion = New System.Windows.Forms.Button()
        Me.cmdDatos = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbcupon = New System.Windows.Forms.PictureBox()
        Me.p3 = New System.Windows.Forms.Panel()
        Me.rb75 = New System.Windows.Forms.RadioButton()
        Me.rb50 = New System.Windows.Forms.RadioButton()
        Me.rb25 = New System.Windows.Forms.RadioButton()
        Me.p5 = New System.Windows.Forms.Panel()
        Me.p4 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.p1.SuspendLayout()
        Me.p0.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcupon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p3.SuspendLayout()
        Me.p5.SuspendLayout()
        CType(Me.p4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.Black
        Me.p1.Controls.Add(Me.CheckBox1)
        Me.p1.Controls.Add(Me.txtEmail)
        Me.p1.Controls.Add(Me.Label27)
        Me.p1.Controls.Add(Me.txtMovil)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.txtApellidos)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Controls.Add(Me.lblNombre)
        Me.p1.Controls.Add(Me.txtNombre)
        Me.p1.Location = New System.Drawing.Point(229, 251)
        Me.p1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(928, 105)
        Me.p1.TabIndex = 0
        Me.p1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(643, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(266, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Enviar confirmación de mi reserva por SMS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(266, 62)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEmail.MaxLength = 35
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(331, 24)
        Me.txtEmail.TabIndex = 9
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(30, 64)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(234, 18)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Dirección de correo electrónico: "
        '
        'txtMovil
        '
        Me.txtMovil.Location = New System.Drawing.Point(699, 25)
        Me.txtMovil.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtMovil.MaxLength = 9
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(167, 24)
        Me.txtMovil.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(640, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Móvil:"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(412, 25)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtApellidos.MaxLength = 20
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(203, 24)
        Me.txtApellidos.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(328, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apellidos:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(29, 26)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 18)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(102, 24)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(198, 24)
        Me.txtNombre.TabIndex = 0
        '
        'p0
        '
        Me.p0.BackColor = System.Drawing.Color.DarkGray
        Me.p0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p0.Controls.Add(Me.txtDias)
        Me.p0.Controls.Add(Me.Label7)
        Me.p0.Controls.Add(Me.Label13)
        Me.p0.Controls.Add(Me.txtFin)
        Me.p0.Controls.Add(Me.Label12)
        Me.p0.Controls.Add(Me.txtInicio)
        Me.p0.Controls.Add(Me.Label11)
        Me.p0.Controls.Add(Me.txtFecha)
        Me.p0.Controls.Add(Me.calendarioMonth)
        Me.p0.Controls.Add(Me.calendarioDay)
        Me.p0.Controls.Add(Me.cbHuespedes)
        Me.p0.Controls.Add(Me.PictureBox2)
        Me.p0.Controls.Add(Me.Label6)
        Me.p0.Controls.Add(Me.Label5)
        Me.p0.Controls.Add(Me.cbHabitaciones)
        Me.p0.Location = New System.Drawing.Point(301, 14)
        Me.p0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.p0.Name = "p0"
        Me.p0.Size = New System.Drawing.Size(837, 230)
        Me.p0.TabIndex = 8
        '
        'txtDias
        '
        Me.txtDias.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDias.Location = New System.Drawing.Point(340, 178)
        Me.txtDias.MaxLength = 3
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(59, 24)
        Me.txtDias.TabIndex = 27
        Me.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(338, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Dias"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(682, 117)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 23)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Huéspedes"
        '
        'txtFin
        '
        Me.txtFin.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFin.Location = New System.Drawing.Point(511, 126)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.Size = New System.Drawing.Size(144, 24)
        Me.txtFin.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(508, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Salida"
        '
        'txtInicio
        '
        Me.txtInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtInicio.Location = New System.Drawing.Point(341, 124)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(144, 24)
        Me.txtInicio.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(337, 99)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 23)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Entrada"
        '
        'txtFecha
        '
        Me.txtFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFecha.Location = New System.Drawing.Point(339, 56)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(232, 24)
        Me.txtFecha.TabIndex = 18
        '
        'calendarioMonth
        '
        Me.calendarioMonth.Location = New System.Drawing.Point(44, 56)
        Me.calendarioMonth.Name = "calendarioMonth"
        Me.calendarioMonth.TabIndex = 17
        '
        'calendarioDay
        '
        Me.calendarioDay.Location = New System.Drawing.Point(16, 24)
        Me.calendarioDay.MinDate = New Date(2022, 11, 20, 0, 0, 0, 0)
        Me.calendarioDay.Name = "calendarioDay"
        Me.calendarioDay.Size = New System.Drawing.Size(270, 24)
        Me.calendarioDay.TabIndex = 16
        '
        'cbHuespedes
        '
        Me.cbHuespedes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHuespedes.FormattingEnabled = True
        Me.cbHuespedes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbHuespedes.Location = New System.Drawing.Point(689, 141)
        Me.cbHuespedes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbHuespedes.Name = "cbHuespedes"
        Me.cbHuespedes.Size = New System.Drawing.Size(62, 23)
        Me.cbHuespedes.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources.calendar
        Me.PictureBox2.Location = New System.Drawing.Point(251, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 49)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(337, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha de reserva"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(682, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Habitaciones"
        '
        'cbHabitaciones
        '
        Me.cbHabitaciones.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHabitaciones.FormattingEnabled = True
        Me.cbHabitaciones.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbHabitaciones.Location = New System.Drawing.Point(687, 74)
        Me.cbHabitaciones.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbHabitaciones.Name = "cbHabitaciones"
        Me.cbHabitaciones.Size = New System.Drawing.Size(64, 23)
        Me.cbHabitaciones.TabIndex = 0
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.Color.DarkGray
        Me.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p2.Controls.Add(Me.lblSRoyal)
        Me.p2.Controls.Add(Me.lblS)
        Me.p2.Controls.Add(Me.lblHDoble)
        Me.p2.Controls.Add(Me.lblHSimple)
        Me.p2.Controls.Add(Me.rbSRoyal)
        Me.p2.Controls.Add(Me.rbSuite)
        Me.p2.Controls.Add(Me.rbHDoble)
        Me.p2.Controls.Add(Me.rbHSimple)
        Me.p2.Location = New System.Drawing.Point(229, 365)
        Me.p2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(543, 61)
        Me.p2.TabIndex = 8
        Me.p2.Visible = False
        '
        'lblSRoyal
        '
        Me.lblSRoyal.AutoSize = True
        Me.lblSRoyal.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRoyal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSRoyal.Location = New System.Drawing.Point(418, 30)
        Me.lblSRoyal.Name = "lblSRoyal"
        Me.lblSRoyal.Size = New System.Drawing.Size(50, 23)
        Me.lblSRoyal.TabIndex = 7
        Me.lblSRoyal.Text = "469€"
        Me.lblSRoyal.Visible = False
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblS.Location = New System.Drawing.Point(419, 6)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(50, 23)
        Me.lblS.TabIndex = 6
        Me.lblS.Text = "375€"
        Me.lblS.Visible = False
        '
        'lblHDoble
        '
        Me.lblHDoble.AutoSize = True
        Me.lblHDoble.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHDoble.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHDoble.Location = New System.Drawing.Point(210, 30)
        Me.lblHDoble.Name = "lblHDoble"
        Me.lblHDoble.Size = New System.Drawing.Size(50, 23)
        Me.lblHDoble.TabIndex = 5
        Me.lblHDoble.Text = "220€"
        Me.lblHDoble.Visible = False
        '
        'lblHSimple
        '
        Me.lblHSimple.AutoSize = True
        Me.lblHSimple.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSimple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHSimple.Location = New System.Drawing.Point(211, 7)
        Me.lblHSimple.Name = "lblHSimple"
        Me.lblHSimple.Size = New System.Drawing.Size(50, 23)
        Me.lblHSimple.TabIndex = 4
        Me.lblHSimple.Text = "119€"
        Me.lblHSimple.Visible = False
        '
        'rbSRoyal
        '
        Me.rbSRoyal.AutoSize = True
        Me.rbSRoyal.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSRoyal.ForeColor = System.Drawing.Color.Black
        Me.rbSRoyal.Location = New System.Drawing.Point(299, 30)
        Me.rbSRoyal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rbSRoyal.Name = "rbSRoyal"
        Me.rbSRoyal.Size = New System.Drawing.Size(97, 24)
        Me.rbSRoyal.TabIndex = 3
        Me.rbSRoyal.TabStop = True
        Me.rbSRoyal.Text = "Suite Royal"
        Me.rbSRoyal.UseVisualStyleBackColor = True
        '
        'rbSuite
        '
        Me.rbSuite.AutoSize = True
        Me.rbSuite.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSuite.ForeColor = System.Drawing.Color.Black
        Me.rbSuite.Location = New System.Drawing.Point(299, 9)
        Me.rbSuite.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rbSuite.Name = "rbSuite"
        Me.rbSuite.Size = New System.Drawing.Size(59, 24)
        Me.rbSuite.TabIndex = 2
        Me.rbSuite.TabStop = True
        Me.rbSuite.Text = "Suite"
        Me.rbSuite.UseVisualStyleBackColor = True
        '
        'rbHDoble
        '
        Me.rbHDoble.AutoSize = True
        Me.rbHDoble.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHDoble.ForeColor = System.Drawing.Color.Black
        Me.rbHDoble.Location = New System.Drawing.Point(56, 32)
        Me.rbHDoble.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rbHDoble.Name = "rbHDoble"
        Me.rbHDoble.Size = New System.Drawing.Size(131, 24)
        Me.rbHDoble.TabIndex = 1
        Me.rbHDoble.TabStop = True
        Me.rbHDoble.Text = "Habitación doble"
        Me.rbHDoble.UseVisualStyleBackColor = True
        '
        'rbHSimple
        '
        Me.rbHSimple.AutoSize = True
        Me.rbHSimple.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHSimple.ForeColor = System.Drawing.Color.Black
        Me.rbHSimple.Location = New System.Drawing.Point(56, 9)
        Me.rbHSimple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rbHSimple.Name = "rbHSimple"
        Me.rbHSimple.Size = New System.Drawing.Size(137, 24)
        Me.rbHSimple.TabIndex = 0
        Me.rbHSimple.TabStop = True
        Me.rbHSimple.Text = "Habitación simple"
        Me.rbHSimple.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.CmdCaptura)
        Me.Panel4.Controls.Add(Me.lblCode)
        Me.Panel4.Controls.Add(Me.rbNO)
        Me.Panel4.Controls.Add(Me.rbSI)
        Me.Panel4.Controls.Add(Me.lblPregunt)
        Me.Panel4.Controls.Add(Me.txtCode)
        Me.Panel4.Controls.Add(Me.cmdCupones)
        Me.Panel4.Controls.Add(Me.cmdHabitacion)
        Me.Panel4.Controls.Add(Me.cmdDatos)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 113)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(195, 703)
        Me.Panel4.TabIndex = 9
        '
        'CmdCaptura
        '
        Me.CmdCaptura.BackColor = System.Drawing.Color.SlateGray
        Me.CmdCaptura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCaptura.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCaptura.ForeColor = System.Drawing.Color.White
        Me.CmdCaptura.Location = New System.Drawing.Point(29, 82)
        Me.CmdCaptura.Name = "CmdCaptura"
        Me.CmdCaptura.Size = New System.Drawing.Size(166, 39)
        Me.CmdCaptura.TabIndex = 25
        Me.CmdCaptura.Text = "CAPTURAR FECHA"
        Me.CmdCaptura.UseVisualStyleBackColor = False
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial Nova Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.White
        Me.lblCode.Location = New System.Drawing.Point(25, 499)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(60, 23)
        Me.lblCode.TabIndex = 24
        Me.lblCode.Text = "CODE:"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCode.Visible = False
        '
        'rbNO
        '
        Me.rbNO.AutoSize = True
        Me.rbNO.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNO.ForeColor = System.Drawing.Color.White
        Me.rbNO.Location = New System.Drawing.Point(76, 459)
        Me.rbNO.Name = "rbNO"
        Me.rbNO.Size = New System.Drawing.Size(46, 24)
        Me.rbNO.TabIndex = 23
        Me.rbNO.TabStop = True
        Me.rbNO.Text = "NO"
        Me.rbNO.UseVisualStyleBackColor = True
        Me.rbNO.Visible = False
        '
        'rbSI
        '
        Me.rbSI.AutoSize = True
        Me.rbSI.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSI.ForeColor = System.Drawing.Color.White
        Me.rbSI.Location = New System.Drawing.Point(77, 424)
        Me.rbSI.Name = "rbSI"
        Me.rbSI.Size = New System.Drawing.Size(39, 24)
        Me.rbSI.TabIndex = 22
        Me.rbSI.TabStop = True
        Me.rbSI.Text = "SI"
        Me.rbSI.UseVisualStyleBackColor = True
        Me.rbSI.Visible = False
        '
        'lblPregunt
        '
        Me.lblPregunt.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunt.ForeColor = System.Drawing.Color.White
        Me.lblPregunt.Location = New System.Drawing.Point(15, 394)
        Me.lblPregunt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPregunt.Name = "lblPregunt"
        Me.lblPregunt.Size = New System.Drawing.Size(184, 32)
        Me.lblPregunt.TabIndex = 11
        Me.lblPregunt.Text = "¿Desea obtener cupones?"
        Me.lblPregunt.Visible = False
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Arial Nova Cond", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(96, 500)
        Me.txtCode.MaxLength = 5
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(83, 26)
        Me.txtCode.TabIndex = 21
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCode.Visible = False
        '
        'cmdCupones
        '
        Me.cmdCupones.BackColor = System.Drawing.Color.SlateGray
        Me.cmdCupones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCupones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCupones.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCupones.ForeColor = System.Drawing.Color.White
        Me.cmdCupones.Location = New System.Drawing.Point(28, 342)
        Me.cmdCupones.Name = "cmdCupones"
        Me.cmdCupones.Size = New System.Drawing.Size(166, 39)
        Me.cmdCupones.TabIndex = 20
        Me.cmdCupones.Text = "CUPONES"
        Me.cmdCupones.UseVisualStyleBackColor = False
        '
        'cmdHabitacion
        '
        Me.cmdHabitacion.BackColor = System.Drawing.Color.SlateGray
        Me.cmdHabitacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHabitacion.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHabitacion.ForeColor = System.Drawing.Color.White
        Me.cmdHabitacion.Location = New System.Drawing.Point(28, 260)
        Me.cmdHabitacion.Name = "cmdHabitacion"
        Me.cmdHabitacion.Size = New System.Drawing.Size(166, 39)
        Me.cmdHabitacion.TabIndex = 19
        Me.cmdHabitacion.Text = "HABITACIÓN"
        Me.cmdHabitacion.UseVisualStyleBackColor = False
        '
        'cmdDatos
        '
        Me.cmdDatos.BackColor = System.Drawing.Color.SlateGray
        Me.cmdDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDatos.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatos.ForeColor = System.Drawing.Color.White
        Me.cmdDatos.Location = New System.Drawing.Point(28, 177)
        Me.cmdDatos.Name = "cmdDatos"
        Me.cmdDatos.Size = New System.Drawing.Size(166, 39)
        Me.cmdDatos.TabIndex = 18
        Me.cmdDatos.Text = "DATOS PERSONALES"
        Me.cmdDatos.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-3, 581)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 10)
        Me.Label8.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 10)
        Me.Label2.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources._1_3_1
        Me.PictureBox1.Location = New System.Drawing.Point(803, 377)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(362, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1149, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "0"
        Me.Label4.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(205, 436)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(582, 10)
        Me.Label9.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(205, 648)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(960, 10)
        Me.Label10.TabIndex = 18
        '
        'pbcupon
        '
        Me.pbcupon.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pbcupon.Image = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources.cupon31
        Me.pbcupon.Location = New System.Drawing.Point(107, 0)
        Me.pbcupon.Name = "pbcupon"
        Me.pbcupon.Size = New System.Drawing.Size(436, 182)
        Me.pbcupon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcupon.TabIndex = 19
        Me.pbcupon.TabStop = False
        Me.pbcupon.Visible = False
        '
        'p3
        '
        Me.p3.BackColor = System.Drawing.Color.DarkGray
        Me.p3.Controls.Add(Me.rb75)
        Me.p3.Controls.Add(Me.rb50)
        Me.p3.Controls.Add(Me.pbcupon)
        Me.p3.Controls.Add(Me.rb25)
        Me.p3.Location = New System.Drawing.Point(229, 455)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(543, 180)
        Me.p3.TabIndex = 20
        Me.p3.Visible = False
        '
        'rb75
        '
        Me.rb75.AutoSize = True
        Me.rb75.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb75.ForeColor = System.Drawing.Color.Black
        Me.rb75.Location = New System.Drawing.Point(22, 114)
        Me.rb75.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rb75.Name = "rb75"
        Me.rb75.Size = New System.Drawing.Size(53, 24)
        Me.rb75.TabIndex = 20
        Me.rb75.TabStop = True
        Me.rb75.Text = "50%"
        Me.rb75.UseVisualStyleBackColor = True
        '
        'rb50
        '
        Me.rb50.AutoSize = True
        Me.rb50.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb50.ForeColor = System.Drawing.Color.Black
        Me.rb50.Location = New System.Drawing.Point(22, 72)
        Me.rb50.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rb50.Name = "rb50"
        Me.rb50.Size = New System.Drawing.Size(56, 24)
        Me.rb50.TabIndex = 5
        Me.rb50.TabStop = True
        Me.rb50.Text = "25%"
        Me.rb50.UseVisualStyleBackColor = True
        '
        'rb25
        '
        Me.rb25.AutoSize = True
        Me.rb25.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb25.ForeColor = System.Drawing.Color.Black
        Me.rb25.Location = New System.Drawing.Point(22, 30)
        Me.rb25.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rb25.Name = "rb25"
        Me.rb25.Size = New System.Drawing.Size(56, 24)
        Me.rb25.TabIndex = 4
        Me.rb25.TabStop = True
        Me.rb25.Text = "10%"
        Me.rb25.UseVisualStyleBackColor = True
        '
        'p5
        '
        Me.p5.BackColor = System.Drawing.Color.DarkGray
        Me.p5.Controls.Add(Me.p4)
        Me.p5.Location = New System.Drawing.Point(214, 455)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(543, 180)
        Me.p5.TabIndex = 21
        Me.p5.Visible = False
        '
        'p4
        '
        Me.p4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.p4.Image = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources.promociones
        Me.p4.Location = New System.Drawing.Point(38, -2)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(466, 182)
        Me.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p4.TabIndex = 19
        Me.p4.TabStop = False
        Me.p4.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Nova Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(991, 682)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 39)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "FACTURA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allccaco_Garcia_Araneth_HOTEL.My.Resources.Resources.res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1188, 762)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p0)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.p5)
        Me.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p0.ResumeLayout(False)
        Me.p0.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcupon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        Me.p5.ResumeLayout(False)
        CType(Me.p4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents p1 As Panel
    Friend WithEvents txtMovil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents p0 As Panel
    Friend WithEvents p2 As Panel
    Friend WithEvents rbHDoble As RadioButton
    Friend WithEvents rbHSimple As RadioButton
    Friend WithEvents cbHabitaciones As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rbSRoyal As RadioButton
    Friend WithEvents rbSuite As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pbcupon As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents rbNO As RadioButton
    Friend WithEvents rbSI As RadioButton
    Friend WithEvents lblPregunt As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents cmdCupones As Button
    Friend WithEvents cmdHabitacion As Button
    Friend WithEvents cmdDatos As Button
    Friend WithEvents p3 As Panel
    Friend WithEvents rb75 As RadioButton
    Friend WithEvents rb50 As RadioButton
    Friend WithEvents rb25 As RadioButton
    Friend WithEvents cbHuespedes As ComboBox
    Friend WithEvents calendarioMonth As MonthCalendar
    Friend WithEvents calendarioDay As DateTimePicker
    Friend WithEvents CmdCaptura As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtFin As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtInicio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblSRoyal As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblHDoble As Label
    Friend WithEvents lblHSimple As Label
    Friend WithEvents p5 As Panel
    Friend WithEvents p4 As PictureBox
    Friend WithEvents txtDias As TextBox
    Friend WithEvents Label7 As Label
End Class
