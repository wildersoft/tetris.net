Public Class frmTetrix
    Inherits System.Windows.Forms.Form
    Dim PuntoX As Integer
    Dim PuntoY As Integer
    Dim Matriz(9, 19) As Integer
    Dim Filas As Integer
    Dim Columnas As Integer
    Dim w As Single
    Dim h As Single
    Dim ColorDark As System.Drawing.Color
    Dim ColorLight As System.Drawing.Color
    Dim ColorPen As System.Drawing.Color
    Dim PenAncho As Single
    Dim Forma As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 427)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(72, 431)
        Me.TrackBar1.Maximum = 15
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(183, 45)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.Value = 1
        '
        'TrackBar2
        '
        Me.TrackBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar2.Location = New System.Drawing.Point(72, 462)
        Me.TrackBar2.Maximum = 16
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(183, 45)
        Me.TrackBar2.TabIndex = 2
        Me.TrackBar2.Value = 8
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(8, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Empezar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nivel"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Velocidad"
        '
        'frmTetrix
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(272, 512)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.Name = "frmTetrix"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tetrix.Net (WilderSoft)"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Sub Publicidad()
        Dim f As New Font("Verdana", 20)
        Dim b As New Drawing2D.LinearGradientBrush(ClientRectangle, Color.Yellow, Color.Red, Drawing2D.LinearGradientMode.Horizontal)
        PictureBox1.CreateGraphics.DrawString("Developed", f, b, 50, 80)
        PictureBox1.CreateGraphics.DrawString("by", f, b, 80, 120)
        PictureBox1.CreateGraphics.DrawString("WilderSoft", f, b, 50, 160)
        PictureBox1.CreateGraphics.DrawString("Tetrix.Net v.1.1", f, b, 10, 220)
    End Sub
    Sub Cuadro(ByVal Px As Integer, ByVal Py As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Dim pic As Graphics
        Dim rec As New System.Drawing.Rectangle()
        Dim recf As New System.Drawing.RectangleF()
        pic = Me.PictureBox1.CreateGraphics
        Dim PuntoX As Single, PuntoY As Single
        PuntoX = Px * w
        PuntoY = Py * h
        If Relleno = True Then
            Dim lapizF As New SolidBrush(Color)
            recf.X = PuntoX
            recf.Y = PuntoY
            recf.Width = w
            recf.Height = h
            pic.FillRectangle(lapizF, recf)
            pic.Dispose()
        Else
            Dim lapiz As New Pen(Color, PenAncho)
            rec.X = PuntoX
            rec.Y = PuntoY
            rec.Width = w
            rec.Height = h
            pic.DrawRectangle(lapiz, rec)
            pic.Dispose()
        End If
    End Sub

    Sub EscA1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 2, Color, Relleno)
    End Sub

    Sub EscA2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X - 1, Y, Color, Relleno)
        Cuadro(X - 1, Y + 1, Color, Relleno)
        Cuadro(X - 2, Y + 1, Color, Relleno)
    End Sub

    Sub EscB1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
        Cuadro(X + 2, Y + 1, Color, Relleno)
    End Sub

    Sub EscB2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X - 1, Y + 1, Color, Relleno)
        Cuadro(X - 1, Y + 2, Color, Relleno)
    End Sub

    Sub T1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X - 1, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
    End Sub

    Sub T2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X - 1, Y + 1, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X, Y + 2, Color, Relleno)
    End Sub

    Sub T3(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X - 1, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
    End Sub

    Sub T4(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
        Cuadro(X, Y + 2, Color, Relleno)
    End Sub

    Sub Cuadrado(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
    End Sub

    Sub Guion1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
    End Sub

    Sub Guion2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
    End Sub

    Sub GuionLargo1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X, Y + 2, Color, Relleno)
        Cuadro(X, Y + 3, Color, Relleno)
    End Sub

    Sub GuionLargo2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X + 2, Y, Color, Relleno)
        Cuadro(X + 3, Y, Color, Relleno)
    End Sub

    Sub EleA1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X, Y + 2, Color, Relleno)
        Cuadro(X + 1, Y + 2, Color, Relleno)
    End Sub

    Sub EleA2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X + 2, Y, Color, Relleno)
    End Sub

    Sub EleA3(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 2, Color, Relleno)
    End Sub

    Sub EleA4(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X - 1, Y + 1, Color, Relleno)
        Cuadro(X - 2, Y + 1, Color, Relleno)
    End Sub

    Sub EleB1(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X, Y + 2, Color, Relleno)
        Cuadro(X - 1, Y + 2, Color, Relleno)
    End Sub

    Sub EleB2(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X + 1, Y + 1, Color, Relleno)
        Cuadro(X + 2, Y + 1, Color, Relleno)
    End Sub

    Sub EleB3(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X, Y + 1, Color, Relleno)
        Cuadro(X, Y + 2, Color, Relleno)
    End Sub

    Sub EleB4(ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Cuadro(X, Y, Color, Relleno)
        Cuadro(X + 1, Y, Color, Relleno)
        Cuadro(X + 2, Y, Color, Relleno)
        Cuadro(X + 2, Y + 1, Color, Relleno)
    End Sub

    Sub DrawForma(ByVal Forma As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal Color As System.Drawing.Color, ByVal Relleno As Boolean)
        Select Case Forma
            Case 0
                Cuadro(X, Y, Color, Relleno)
            Case 1
                EscA1(X, Y, Color, Relleno)
            Case 2
                EscA2(X, Y, Color, Relleno)
            Case 3
                EscB1(X, Y, Color, Relleno)
            Case 4
                EscB2(X, Y, Color, Relleno)
            Case 5
                T1(X, Y, Color, Relleno)
            Case 6
                T2(X, Y, Color, Relleno)
            Case 7
                T3(X, Y, Color, Relleno)
            Case 8
                T4(X, Y, Color, Relleno)
            Case 9
                Cuadrado(X, Y, Color, Relleno)
            Case 10
                Guion1(X, Y, Color, Relleno)
            Case 11
                Guion2(X, Y, Color, Relleno)
            Case 12
                GuionLargo1(X, Y, Color, Relleno)
            Case 13
                GuionLargo2(X, Y, Color, Relleno)
            Case 14
                EleA1(X, Y, Color, Relleno)
            Case 15
                EleA2(X, Y, Color, Relleno)
            Case 16
                EleA3(X, Y, Color, Relleno)
            Case 17
                EleA4(X, Y, Color, Relleno)
            Case 18
                EleB1(X, Y, Color, Relleno)
            Case 19
                EleB2(X, Y, Color, Relleno)
            Case 20
                EleB3(X, Y, Color, Relleno)
            Case 21
                EleB4(X, Y, Color, Relleno)
        End Select
    End Sub

    Sub LlenarMatrizForma(ByVal Forma As Integer, ByVal x As Integer, ByVal y As Integer)
        Select Case Forma
            Case 0
                LlenarMatriz(x, y, 10)
            Case 1
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x + 1, y + 1, 10)
                LlenarMatriz(x + 1, y + 2, 10)
            Case 2
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x - 1, y, 10)
                LlenarMatriz(x - 1, y + 1, 10)
                LlenarMatriz(x - 2, y + 1, 10)
            Case 3
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x + 1, y + 1, 10)
                LlenarMatriz(x + 2, y + 1, 10)
            Case 4
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x - 1, y + 1, 10)
                LlenarMatriz(x - 1, y + 2, 10)
            Case 5
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x - 1, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x, y + 1, 10)
            Case 6
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x - 1, y + 1, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x, y + 2, 10)
            Case 7
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x - 1, y + 1, 10)
                LlenarMatriz(x + 1, y + 1, 10)
                LlenarMatriz(x, y + 1, 10)
            Case 8
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x + 1, y + 1, 10)
                LlenarMatriz(x, y + 2, 10)
            Case 9
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x + 1, y + 1, 10)
            Case 10
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
            Case 11
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
            Case 12
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x, y + 2, 10)
                LlenarMatriz(x, y + 3, 10)
            Case 13
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x + 2, y, 10)
                LlenarMatriz(x + 3, y, 10)
            Case 14
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x, y + 2, 10)
                LlenarMatriz(x + 1, y + 2, 10)
            Case 15
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x + 2, y, 10)
            Case 16
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x + 1, y + 1, 10)
                LlenarMatriz(x + 1, y + 2, 10)
            Case 17
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x - 1, y + 1, 10)
                LlenarMatriz(x - 2, y + 1, 10)
            Case 18
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x, y + 2, 10)
                LlenarMatriz(x - 1, y + 2, 10)
            Case 19
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x + 1, y + 1, 10)
                LlenarMatriz(x + 2, y + 1, 10)
            Case 20
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x, y + 1, 10)
                LlenarMatriz(x, y + 2, 10)
            Case 21
                LlenarMatriz(x, y, 10)
                LlenarMatriz(x + 1, y, 10)
                LlenarMatriz(x + 2, y, 10)
                LlenarMatriz(x + 2, y + 1, 10)
        End Select
        Drawing()
        If y = 0 Then
            Me.Timer1.Enabled = False
            Beep()
            If MsgBox("Ya fuiste!!!, Deseas Intentarlo de Nuevo", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Je je...") = MsgBoxResult.Yes Then
                PictureBox1.CreateGraphics.Clear(PictureBox1.BackColor)
                PuntoY = 0
                Empezar()
                Liberar()
                Grilla()
                Me.Timer1.Interval = (17 - Me.TrackBar2.Value) * 10
                Me.Timer1.Enabled = True
            Else
                Me.Close()
            End If
        End If
    End Sub

    Function VerificarForma(ByVal Forma As Integer, ByVal x As Integer, ByVal y As Integer) As Boolean
        Select Case Forma
            Case 0
                If VerXY(x, y) Then 'si los margenes estan bien
                    VerificarForma = Verificar(x, y)
                Else
                    VerificarForma = False
                End If
            Case 1
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x + 1, y + 1) And VerXY(x + 1, y + 2) Then 'si los margenes estan bien
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x + 1, y + 1) And Verificar(x + 1, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 2
                If VerXY(x, y) And VerXY(x - 1, y) And VerXY(x - 1, y + 1) And VerXY(x - 2, y + 1) Then 'si los margenes estan bien
                    VerificarForma = Verificar(x, y) And Verificar(x - 1, y) And Verificar(x - 1, y + 1) And Verificar(x - 2, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 3
                If VerXY(x, y) And VerXY(x + 1, y) And VerXY(x + 1, y + 1) And VerXY(x + 2, y + 1) Then 'si los margenes estan bien
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y) And Verificar(x + 1, y + 1) And Verificar(x + 2, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 4
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x - 1, y + 1) And VerXY(x - 1, y + 2) Then 'si los margenes estan bien
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x - 1, y + 1) And Verificar(x - 1, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 5
                If VerXY(x, y) And VerXY(x - 1, y) And VerXY(x + 1, y) And VerXY(x, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x - 1, y) And Verificar(x + 1, y) And Verificar(x, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 6
                If VerXY(x, y) And VerXY(x - 1, y + 1) And VerXY(x, y + 1) And VerXY(x, y + 2) Then
                    VerificarForma = Verificar(x, y) And Verificar(x - 1, y + 1) And Verificar(x, y + 1) And Verificar(x, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 7
                If VerXY(x, y) And VerXY(x - 1, y + 1) And VerXY(x + 1, y + 1) And VerXY(x, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x - 1, y + 1) And Verificar(x + 1, y + 1) And Verificar(x, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 8
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x + 1, y + 1) And VerXY(x, y + 2) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x + 1, y + 1) And Verificar(x, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 9
                If VerXY(x, y) And VerXY(x + 1, y) And VerXY(x, y + 1) And VerXY(x + 1, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y) And Verificar(x, y + 1) And Verificar(x + 1, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 10
                If VerXY(x, y) And VerXY(x + 1, y) Then
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y)
                Else
                    VerificarForma = False
                End If
            Case 11
                If VerXY(x, y) And VerXY(x, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 12
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x, y + 2) And VerXY(x, y + 3) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x, y + 2) And Verificar(x, y + 3)
                Else
                    VerificarForma = False
                End If
            Case 13
                If VerXY(x, y) And VerXY(x + 1, y) And VerXY(x + 2, y) And VerXY(x + 3, y) Then
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y) And Verificar(x + 2, y) And Verificar(x + 3, y)
                Else
                    VerificarForma = False
                End If
            Case 14
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x, y + 2) And VerXY(x + 1, y + 2) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x, y + 2) And Verificar(x + 1, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 15
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x + 1, y) And VerXY(x + 2, y) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x + 1, y) And Verificar(x + 2, y)
                Else
                    VerificarForma = False
                End If
            Case 16
                If VerXY(x, y) And VerXY(x + 1, y) And VerXY(x + 1, y + 1) And VerXY(x + 1, y + 2) Then
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y) And Verificar(x + 1, y + 1) And Verificar(x + 1, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 17
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x - 1, y + 1) And VerXY(x - 2, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x - 1, y + 1) And Verificar(x - 2, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 18
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x, y + 2) And VerXY(x - 1, y + 2) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x, y + 2) And Verificar(x - 1, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 19
                If VerXY(x, y) And VerXY(x, y + 1) And VerXY(x + 1, y + 1) And VerXY(x + 2, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x, y + 1) And Verificar(x + 1, y + 1) And Verificar(x + 2, y + 1)
                Else
                    VerificarForma = False
                End If
            Case 20
                If VerXY(x, y) And VerXY(x + 1, y) And VerXY(x, y + 1) And VerXY(x, y + 2) Then
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y) And Verificar(x, y + 1) And Verificar(x, y + 2)
                Else
                    VerificarForma = False
                End If
            Case 21
                If VerXY(x, y) And VerXY(x + 1, y) And VerXY(x + 2, y) And VerXY(x + 2, y + 1) Then
                    VerificarForma = Verificar(x, y) And Verificar(x + 1, y) And Verificar(x + 2, y) And Verificar(x + 2, y + 1)
                Else
                    VerificarForma = False
                End If
        End Select
    End Function

    Sub Drawing()
        PictureBox1.CreateGraphics.Clear(PictureBox1.BackColor)
        Grilla()
        Dim x As Integer
        Dim y As Integer
        For x = 0 To Columnas
            For y = 0 To Filas
                If Matriz(x, y) = 10 Then
                    Cuadro(x, y, ColorDark, True)
                End If
            Next
        Next
        Publicidad()
    End Sub

    Sub Liberar()
        ReDim Matriz(Columnas, Filas)
    End Sub

    Function VerXY(ByVal x As Integer, ByVal y As Integer) As Boolean
        VerXY = (x >= 0 And x < (Columnas + 1)) And (y >= 0 And y < (Filas + 1))
    End Function

    Function Verificar(ByVal PuntoX As Integer, ByVal PuntoY As Integer) As Boolean
        Verificar = Matriz(PuntoX, PuntoY) = 0
    End Function

    Sub Empezar()
        Randomize()
        PuntoX = Int(Rnd() * 4) + 3
        Forma = Int(Rnd() * 22) '5
    End Sub

    Sub Limpiar()
        DrawForma(Forma, PuntoX, PuntoY, Me.PictureBox1.BackColor, True)
        DrawForma(Forma, PuntoX, PuntoY, ColorPen, False)
    End Sub

    Sub MoverMatriz(ByVal PosY As Integer)
        Dim x As Integer
        Dim y As Integer
        For y = PosY To 1 Step -1
            For x = 0 To Columnas
                Matriz(x, y) = Matriz(x, y - 1)
            Next
        Next
        For x = 0 To Columnas
            Matriz(x, 0) = 0
        Next
        Drawing()
    End Sub

    Sub Grilla()
        Dim pictur As Graphics
        Dim lapicito As Pen
        Dim x As Integer
        lapicito = New Pen(ColorPen, PenAncho)
        pictur = Me.PictureBox1.CreateGraphics()
        For x = 0 To Columnas
            pictur.DrawLine(lapicito, x * w, 0, x * w, Me.PictureBox1.Height)
        Next
        For x = 0 To Filas
            pictur.DrawLine(lapicito, 0, x * h, Me.PictureBox1.Width, x * h)
        Next
        pictur.Dispose()
        lapicito.Dispose()
    End Sub

    Sub LlenarMatriz(ByVal x As Integer, ByVal y As Integer, ByVal Valor As Integer)
        Matriz(x, y) = Valor
    End Sub

    Sub VerificarFilaLlena()
        Dim x As Integer
        Dim y As Integer
        Dim cnt As Integer
        For y = 0 To Filas
            cnt = 0
            For x = 0 To Columnas
                If Matriz(x, y) = 10 Then
                    cnt = cnt + 1
                End If
            Next
            If cnt = Columnas + 1 Then ' toda la fila esta llena(tetrix)
                MoverMatriz(y)
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ColorPen = System.Drawing.Color.Beige
        ColorDark = System.Drawing.Color.Chocolate
        ColorLight = System.Drawing.Color.YellowGreen
        PenAncho = 2
        Filas = 29 '+1
        Columnas = 14 '+1
        Liberar()
        w = Me.PictureBox1.Width / (Columnas + 1)
        h = Me.PictureBox1.Height / (Filas + 1)
        MsgBox("Developed by WilderSoft", MsgBoxStyle.Information, "Tetrix.Net")
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Limpiar()
        Select Case e.KeyCode
            Case 27 'escape
                Button1.Enabled = True
                Me.Timer1.Enabled = False
                Me.TrackBar1.Enabled = True
                Me.TrackBar2.Enabled = True
                Drawing() ' no se puede por que el boton llama a empezar y elige una posicion aleatoria
            Case 37 '<
                If PuntoX > 0 And VerificarForma(Forma, PuntoX - 1, PuntoY) Then
                    PuntoX = PuntoX - 1
                End If
            Case 38 '^
                If PuntoY > 0 And VerificarForma(Forma, PuntoX, PuntoY - 1) Then
                    PuntoY = PuntoY - 1
                End If
            Case 39 '>
                If PuntoX < Columnas And VerificarForma(Forma, PuntoX + 1, PuntoY) Then
                    PuntoX = PuntoX + 1
                End If
            Case 40 'v
                If PuntoY < Filas Then
                    Me.Timer1.Interval = 1
                End If
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Grilla()
        Drawing()
        Me.Timer1.Interval = (17 - Me.TrackBar2.Value) * 10
        Me.Timer1.Enabled = True
        Button1.Enabled = False
        Me.TrackBar1.Enabled = False
        Me.TrackBar2.Enabled = False
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        Me.Timer1.Interval = (17 - Me.TrackBar2.Value) * 10
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Limpiar()
        If VerificarForma(Forma, PuntoX, PuntoY + 1) Then 'prueba si Sigue Avanzando
            DrawForma(Forma, PuntoX, PuntoY + 1, ColorLight, True)
            PuntoY = PuntoY + 1
        Else 'sino Guardar Posicion y Reinicia
            LlenarMatrizForma(Forma, PuntoX, PuntoY)
            VerificarFilaLlena()
            PuntoY = 0
            Empezar()
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer
        Timer1.Enabled = False
        Liberar()
        If Me.TrackBar1.Value > 1 Then
            For y = Filas To Filas - Me.TrackBar1.Value Step -1
                For n = 0 To Filas / 2
                    x = Int(Rnd() * (Columnas + 1))
                    Matriz(x, y) = 10
                Next
            Next
        End If
        Drawing()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        w = Me.PictureBox1.Width / Columnas
        h = Me.PictureBox1.Height / Filas
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
        Drawing()
        MsgBox("WilderSoft", MsgBoxStyle.Information, "Gracias por usar Tetrix.Net")
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case 37

            Case 38

            Case 39

            Case 40
                Me.Timer1.Interval = (17 - Me.TrackBar2.Value) * 10
        End Select
    End Sub

End Class