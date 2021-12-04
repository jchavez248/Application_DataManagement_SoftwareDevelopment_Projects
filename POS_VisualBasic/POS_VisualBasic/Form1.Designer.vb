'Initializes a new instance of the compiler services for project to run properly
'Lines 3-20 are part of the default template used by Microsoft Visual Basic to compile, update and run the project successfully 
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

    'The creation of many of the user interface buttons, data grid views and panels are found below as well as their declarations 
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.keypadDecimal = New System.Windows.Forms.Button()
        Me.keypad0 = New System.Windows.Forms.Button()
        Me.keypadClear = New System.Windows.Forms.Button()
        Me.keypad3 = New System.Windows.Forms.Button()
        Me.keypad2 = New System.Windows.Forms.Button()
        Me.keypad1 = New System.Windows.Forms.Button()
        Me.keypad4 = New System.Windows.Forms.Button()
        Me.keypad5 = New System.Windows.Forms.Button()
        Me.keypad6 = New System.Windows.Forms.Button()
        Me.keypad9 = New System.Windows.Forms.Button()
        Me.keypad8 = New System.Windows.Forms.Button()
        Me.keypad7 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FRESHPIZZA = New System.Windows.Forms.Button()
        Me.SWEETDONUTS = New System.Windows.Forms.Button()
        Me.TASTYTACOS = New System.Windows.Forms.Button()
        Me.TASTYSAUCES = New System.Windows.Forms.Button()
        Me.MEXICANDISHES = New System.Windows.Forms.Button()
        Me.CINEMAFOOD = New System.Windows.Forms.Button()
        Me.BURRITOS = New System.Windows.Forms.Button()
        Me.FALAFEL = New System.Windows.Forms.Button()
        Me.TASTYMEAT = New System.Windows.Forms.Button()
        Me.SANDWICH = New System.Windows.Forms.Button()
        Me.QUESADILLA = New System.Windows.Forms.Button()
        Me.FRESHDRINKS = New System.Windows.Forms.Button()
        Me.ICECREAM = New System.Windows.Forms.Button()
        Me.SALADANDSAUSAGE = New System.Windows.Forms.Button()
        Me.BEERANDNACHOS = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ResetTransaction = New System.Windows.Forms.Button()
        Me.Payment = New System.Windows.Forms.Button()
        Me.PrintReceipt = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CustomerChange = New System.Windows.Forms.Label()
        Me.CustomerCashAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TransactionTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TransactionSubTotal = New System.Windows.Forms.Label()
        Me.MandatoryStoreTax = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RemoveItem = New System.Windows.Forms.Button()
        Me.TransactionTable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CalcTotals = New System.Windows.Forms.Button()
        Me.Invoice = New System.Drawing.Printing.PrintDocument()
        Me.PrintSetup = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.TransactionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.keypadDecimal)
        Me.Panel1.Controls.Add(Me.keypad0)
        Me.Panel1.Controls.Add(Me.keypadClear)
        Me.Panel1.Controls.Add(Me.keypad3)
        Me.Panel1.Controls.Add(Me.keypad2)
        Me.Panel1.Controls.Add(Me.keypad1)
        Me.Panel1.Controls.Add(Me.keypad4)
        Me.Panel1.Controls.Add(Me.keypad5)
        Me.Panel1.Controls.Add(Me.keypad6)
        Me.Panel1.Controls.Add(Me.keypad9)
        Me.Panel1.Controls.Add(Me.keypad8)
        Me.Panel1.Controls.Add(Me.keypad7)
        Me.Panel1.Location = New System.Drawing.Point(756, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 420)
        Me.Panel1.TabIndex = 0
        '
        'keypadDecimal
        '
        Me.keypadDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypadDecimal.Location = New System.Drawing.Point(187, 279)
        Me.keypadDecimal.Name = "keypadDecimal"
        Me.keypadDecimal.Size = New System.Drawing.Size(86, 86)
        Me.keypadDecimal.TabIndex = 0
        Me.keypadDecimal.Text = "."
        Me.keypadDecimal.UseVisualStyleBackColor = True
        '
        'keypad0
        '
        Me.keypad0.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad0.Location = New System.Drawing.Point(95, 279)
        Me.keypad0.Name = "keypad0"
        Me.keypad0.Size = New System.Drawing.Size(86, 86)
        Me.keypad0.TabIndex = 0
        Me.keypad0.Text = "0"
        Me.keypad0.UseVisualStyleBackColor = True
        '
        'keypadClear
        '
        Me.keypadClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypadClear.Location = New System.Drawing.Point(3, 279)
        Me.keypadClear.Name = "keypadClear"
        Me.keypadClear.Size = New System.Drawing.Size(86, 86)
        Me.keypadClear.TabIndex = 0
        Me.keypadClear.Text = "C"
        Me.keypadClear.UseVisualStyleBackColor = True
        '
        'keypad3
        '
        Me.keypad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad3.Location = New System.Drawing.Point(187, 3)
        Me.keypad3.Name = "keypad3"
        Me.keypad3.Size = New System.Drawing.Size(86, 86)
        Me.keypad3.TabIndex = 0
        Me.keypad3.Text = "3"
        Me.keypad3.UseVisualStyleBackColor = True
        '
        'keypad2
        '
        Me.keypad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad2.Location = New System.Drawing.Point(95, 3)
        Me.keypad2.Name = "keypad2"
        Me.keypad2.Size = New System.Drawing.Size(86, 86)
        Me.keypad2.TabIndex = 0
        Me.keypad2.Text = "2"
        Me.keypad2.UseVisualStyleBackColor = True
        '
        'keypad1
        '
        Me.keypad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad1.Location = New System.Drawing.Point(3, 3)
        Me.keypad1.Name = "keypad1"
        Me.keypad1.Size = New System.Drawing.Size(86, 86)
        Me.keypad1.TabIndex = 0
        Me.keypad1.Text = "1"
        Me.keypad1.UseVisualStyleBackColor = True
        '
        'keypad4
        '
        Me.keypad4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad4.Location = New System.Drawing.Point(3, 95)
        Me.keypad4.Name = "keypad4"
        Me.keypad4.Size = New System.Drawing.Size(86, 86)
        Me.keypad4.TabIndex = 0
        Me.keypad4.Text = "4"
        Me.keypad4.UseVisualStyleBackColor = True
        '
        'keypad5
        '
        Me.keypad5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad5.Location = New System.Drawing.Point(95, 95)
        Me.keypad5.Name = "keypad5"
        Me.keypad5.Size = New System.Drawing.Size(86, 86)
        Me.keypad5.TabIndex = 0
        Me.keypad5.Text = "5"
        Me.keypad5.UseVisualStyleBackColor = True
        '
        'keypad6
        '
        Me.keypad6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad6.Location = New System.Drawing.Point(187, 95)
        Me.keypad6.Name = "keypad6"
        Me.keypad6.Size = New System.Drawing.Size(86, 86)
        Me.keypad6.TabIndex = 0
        Me.keypad6.Text = "6"
        Me.keypad6.UseVisualStyleBackColor = True
        '
        'keypad9
        '
        Me.keypad9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad9.Location = New System.Drawing.Point(187, 187)
        Me.keypad9.Name = "keypad9"
        Me.keypad9.Size = New System.Drawing.Size(86, 86)
        Me.keypad9.TabIndex = 0
        Me.keypad9.Text = "9"
        Me.keypad9.UseVisualStyleBackColor = True
        '
        'keypad8
        '
        Me.keypad8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad8.Location = New System.Drawing.Point(95, 187)
        Me.keypad8.Name = "keypad8"
        Me.keypad8.Size = New System.Drawing.Size(86, 86)
        Me.keypad8.TabIndex = 0
        Me.keypad8.Text = "8"
        Me.keypad8.UseVisualStyleBackColor = True
        '
        'keypad7
        '
        Me.keypad7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad7.Location = New System.Drawing.Point(3, 187)
        Me.keypad7.Name = "keypad7"
        Me.keypad7.Size = New System.Drawing.Size(86, 86)
        Me.keypad7.TabIndex = 0
        Me.keypad7.Text = "7"
        Me.keypad7.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.FRESHPIZZA)
        Me.Panel2.Controls.Add(Me.SWEETDONUTS)
        Me.Panel2.Controls.Add(Me.TASTYTACOS)
        Me.Panel2.Controls.Add(Me.TASTYSAUCES)
        Me.Panel2.Controls.Add(Me.MEXICANDISHES)
        Me.Panel2.Controls.Add(Me.CINEMAFOOD)
        Me.Panel2.Controls.Add(Me.BURRITOS)
        Me.Panel2.Controls.Add(Me.FALAFEL)
        Me.Panel2.Controls.Add(Me.TASTYMEAT)
        Me.Panel2.Controls.Add(Me.SANDWICH)
        Me.Panel2.Controls.Add(Me.QUESADILLA)
        Me.Panel2.Controls.Add(Me.FRESHDRINKS)
        Me.Panel2.Controls.Add(Me.ICECREAM)
        Me.Panel2.Controls.Add(Me.SALADANDSAUSAGE)
        Me.Panel2.Controls.Add(Me.BEERANDNACHOS)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(739, 512)
        Me.Panel2.TabIndex = 1
        '
        'FRESHPIZZA
        '
        Me.FRESHPIZZA.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FRESHPIZZA.Image = CType(resources.GetObject("FRESHPIZZA.Image"), System.Drawing.Image)
        Me.FRESHPIZZA.Location = New System.Drawing.Point(585, 333)
        Me.FRESHPIZZA.Name = "FRESHPIZZA"
        Me.FRESHPIZZA.Size = New System.Drawing.Size(138, 159)
        Me.FRESHPIZZA.TabIndex = 0
        Me.FRESHPIZZA.UseVisualStyleBackColor = True
        '
        'SWEETDONUTS
        '
        Me.SWEETDONUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SWEETDONUTS.Image = CType(resources.GetObject("SWEETDONUTS.Image"), System.Drawing.Image)
        Me.SWEETDONUTS.Location = New System.Drawing.Point(585, 168)
        Me.SWEETDONUTS.Name = "SWEETDONUTS"
        Me.SWEETDONUTS.Size = New System.Drawing.Size(138, 159)
        Me.SWEETDONUTS.TabIndex = 0
        Me.SWEETDONUTS.UseVisualStyleBackColor = True
        '
        'TASTYTACOS
        '
        Me.TASTYTACOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TASTYTACOS.Image = CType(resources.GetObject("TASTYTACOS.Image"), System.Drawing.Image)
        Me.TASTYTACOS.Location = New System.Drawing.Point(585, 3)
        Me.TASTYTACOS.Name = "TASTYTACOS"
        Me.TASTYTACOS.Size = New System.Drawing.Size(138, 159)
        Me.TASTYTACOS.TabIndex = 0
        Me.TASTYTACOS.UseVisualStyleBackColor = True
        '
        'TASTYSAUCES
        '
        Me.TASTYSAUCES.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TASTYSAUCES.Image = CType(resources.GetObject("TASTYSAUCES.Image"), System.Drawing.Image)
        Me.TASTYSAUCES.Location = New System.Drawing.Point(441, 333)
        Me.TASTYSAUCES.Name = "TASTYSAUCES"
        Me.TASTYSAUCES.Size = New System.Drawing.Size(138, 159)
        Me.TASTYSAUCES.TabIndex = 0
        Me.TASTYSAUCES.UseVisualStyleBackColor = True
        '
        'MEXICANDISHES
        '
        Me.MEXICANDISHES.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEXICANDISHES.Image = CType(resources.GetObject("MEXICANDISHES.Image"), System.Drawing.Image)
        Me.MEXICANDISHES.Location = New System.Drawing.Point(441, 168)
        Me.MEXICANDISHES.Name = "MEXICANDISHES"
        Me.MEXICANDISHES.Size = New System.Drawing.Size(138, 159)
        Me.MEXICANDISHES.TabIndex = 0
        Me.MEXICANDISHES.UseVisualStyleBackColor = True
        '
        'CINEMAFOOD
        '
        Me.CINEMAFOOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CINEMAFOOD.Image = CType(resources.GetObject("CINEMAFOOD.Image"), System.Drawing.Image)
        Me.CINEMAFOOD.Location = New System.Drawing.Point(441, 3)
        Me.CINEMAFOOD.Name = "CINEMAFOOD"
        Me.CINEMAFOOD.Size = New System.Drawing.Size(138, 159)
        Me.CINEMAFOOD.TabIndex = 0
        Me.CINEMAFOOD.UseVisualStyleBackColor = True
        '
        'BURRITOS
        '
        Me.BURRITOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BURRITOS.Image = CType(resources.GetObject("BURRITOS.Image"), System.Drawing.Image)
        Me.BURRITOS.Location = New System.Drawing.Point(297, 333)
        Me.BURRITOS.Name = "BURRITOS"
        Me.BURRITOS.Size = New System.Drawing.Size(138, 159)
        Me.BURRITOS.TabIndex = 0
        Me.BURRITOS.UseVisualStyleBackColor = True
        '
        'FALAFEL
        '
        Me.FALAFEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FALAFEL.Image = CType(resources.GetObject("FALAFEL.Image"), System.Drawing.Image)
        Me.FALAFEL.Location = New System.Drawing.Point(297, 168)
        Me.FALAFEL.Name = "FALAFEL"
        Me.FALAFEL.Size = New System.Drawing.Size(138, 159)
        Me.FALAFEL.TabIndex = 0
        Me.FALAFEL.UseVisualStyleBackColor = True
        '
        'TASTYMEAT
        '
        Me.TASTYMEAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TASTYMEAT.Image = CType(resources.GetObject("TASTYMEAT.Image"), System.Drawing.Image)
        Me.TASTYMEAT.Location = New System.Drawing.Point(297, 3)
        Me.TASTYMEAT.Name = "TASTYMEAT"
        Me.TASTYMEAT.Size = New System.Drawing.Size(138, 159)
        Me.TASTYMEAT.TabIndex = 0
        Me.TASTYMEAT.UseVisualStyleBackColor = True
        '
        'SANDWICH
        '
        Me.SANDWICH.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SANDWICH.Image = CType(resources.GetObject("SANDWICH.Image"), System.Drawing.Image)
        Me.SANDWICH.Location = New System.Drawing.Point(9, 332)
        Me.SANDWICH.Name = "SANDWICH"
        Me.SANDWICH.Size = New System.Drawing.Size(138, 159)
        Me.SANDWICH.TabIndex = 0
        Me.SANDWICH.UseVisualStyleBackColor = True
        '
        'QUESADILLA
        '
        Me.QUESADILLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUESADILLA.Image = CType(resources.GetObject("QUESADILLA.Image"), System.Drawing.Image)
        Me.QUESADILLA.Location = New System.Drawing.Point(9, 168)
        Me.QUESADILLA.Name = "QUESADILLA"
        Me.QUESADILLA.Size = New System.Drawing.Size(138, 159)
        Me.QUESADILLA.TabIndex = 0
        Me.QUESADILLA.UseVisualStyleBackColor = True
        '
        'FRESHDRINKS
        '
        Me.FRESHDRINKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FRESHDRINKS.Image = CType(resources.GetObject("FRESHDRINKS.Image"), System.Drawing.Image)
        Me.FRESHDRINKS.Location = New System.Drawing.Point(153, 333)
        Me.FRESHDRINKS.Name = "FRESHDRINKS"
        Me.FRESHDRINKS.Size = New System.Drawing.Size(138, 159)
        Me.FRESHDRINKS.TabIndex = 0
        Me.FRESHDRINKS.UseVisualStyleBackColor = True
        '
        'ICECREAM
        '
        Me.ICECREAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICECREAM.Image = CType(resources.GetObject("ICECREAM.Image"), System.Drawing.Image)
        Me.ICECREAM.Location = New System.Drawing.Point(153, 168)
        Me.ICECREAM.Name = "ICECREAM"
        Me.ICECREAM.Size = New System.Drawing.Size(138, 159)
        Me.ICECREAM.TabIndex = 0
        Me.ICECREAM.UseVisualStyleBackColor = True
        '
        'SALADANDSAUSAGE
        '
        Me.SALADANDSAUSAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALADANDSAUSAGE.Image = CType(resources.GetObject("SALADANDSAUSAGE.Image"), System.Drawing.Image)
        Me.SALADANDSAUSAGE.Location = New System.Drawing.Point(153, 3)
        Me.SALADANDSAUSAGE.Name = "SALADANDSAUSAGE"
        Me.SALADANDSAUSAGE.Size = New System.Drawing.Size(138, 159)
        Me.SALADANDSAUSAGE.TabIndex = 0
        Me.SALADANDSAUSAGE.UseVisualStyleBackColor = True
        '
        'BEERANDNACHOS
        '
        Me.BEERANDNACHOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEERANDNACHOS.Image = CType(resources.GetObject("BEERANDNACHOS.Image"), System.Drawing.Image)
        Me.BEERANDNACHOS.Location = New System.Drawing.Point(9, 3)
        Me.BEERANDNACHOS.Name = "BEERANDNACHOS"
        Me.BEERANDNACHOS.Size = New System.Drawing.Size(138, 159)
        Me.BEERANDNACHOS.TabIndex = 0
        Me.BEERANDNACHOS.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 530)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1337, 207)
        Me.Panel3.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Info
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.ResetTransaction)
        Me.Panel6.Controls.Add(Me.Payment)
        Me.Panel6.Controls.Add(Me.PrintReceipt)
        Me.Panel6.Location = New System.Drawing.Point(514, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(402, 171)
        Me.Panel6.TabIndex = 5
        '
        'ResetTransaction
        '
        Me.ResetTransaction.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetTransaction.Location = New System.Drawing.Point(23, 87)
        Me.ResetTransaction.Name = "ResetTransaction"
        Me.ResetTransaction.Size = New System.Drawing.Size(358, 70)
        Me.ResetTransaction.TabIndex = 0
        Me.ResetTransaction.Text = "Reset Transaction"
        Me.ResetTransaction.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.Payment.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.Location = New System.Drawing.Point(23, 3)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(176, 77)
        Me.Payment.TabIndex = 0
        Me.Payment.Text = "Enter Payment"
        Me.Payment.UseVisualStyleBackColor = True
        '
        'PrintReceipt
        '
        Me.PrintReceipt.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintReceipt.Location = New System.Drawing.Point(205, 3)
        Me.PrintReceipt.Name = "PrintReceipt"
        Me.PrintReceipt.Size = New System.Drawing.Size(176, 77)
        Me.PrintReceipt.TabIndex = 0
        Me.PrintReceipt.Text = "Print Receipt"
        Me.PrintReceipt.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Info
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.CustomerChange)
        Me.Panel5.Controls.Add(Me.CustomerCashAmount)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.PaymentMethod)
        Me.Panel5.Location = New System.Drawing.Point(13, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(486, 171)
        Me.Panel5.TabIndex = 5
        '
        'CustomerChange
        '
        Me.CustomerChange.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CustomerChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerChange.Location = New System.Drawing.Point(298, 104)
        Me.CustomerChange.Name = "CustomerChange"
        Me.CustomerChange.Size = New System.Drawing.Size(181, 43)
        Me.CustomerChange.TabIndex = 1
        '
        'CustomerCashAmount
        '
        Me.CustomerCashAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CustomerCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCashAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerCashAmount.Location = New System.Drawing.Point(298, 57)
        Me.CustomerCashAmount.Name = "CustomerCashAmount"
        Me.CustomerCashAmount.Size = New System.Drawing.Size(181, 43)
        Me.CustomerCashAmount.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Customer Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cash Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payment Type"
        '
        'PaymentMethod
        '
        Me.PaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentMethod.FormattingEnabled = True
        Me.PaymentMethod.Location = New System.Drawing.Point(298, 13)
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.Size = New System.Drawing.Size(181, 41)
        Me.PaymentMethod.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Info
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.TransactionTotal)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.TransactionSubTotal)
        Me.Panel4.Controls.Add(Me.MandatoryStoreTax)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(922, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(402, 171)
        Me.Panel4.TabIndex = 4
        '
        'TransactionTotal
        '
        Me.TransactionTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TransactionTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TransactionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionTotal.Location = New System.Drawing.Point(182, 108)
        Me.TransactionTotal.Name = "TransactionTotal"
        Me.TransactionTotal.Size = New System.Drawing.Size(184, 43)
        Me.TransactionTotal.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 36)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tax"
        '
        'TransactionSubTotal
        '
        Me.TransactionSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TransactionSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TransactionSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionSubTotal.Location = New System.Drawing.Point(182, 13)
        Me.TransactionSubTotal.Name = "TransactionSubTotal"
        Me.TransactionSubTotal.Size = New System.Drawing.Size(184, 43)
        Me.TransactionSubTotal.TabIndex = 1
        '
        'MandatoryStoreTax
        '
        Me.MandatoryStoreTax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MandatoryStoreTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MandatoryStoreTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MandatoryStoreTax.Location = New System.Drawing.Point(182, 60)
        Me.MandatoryStoreTax.Name = "MandatoryStoreTax"
        Me.MandatoryStoreTax.Size = New System.Drawing.Size(184, 43)
        Me.MandatoryStoreTax.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 36)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Subtotal"
        '
        'RemoveItem
        '
        Me.RemoveItem.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveItem.Location = New System.Drawing.Point(10, 10)
        Me.RemoveItem.Name = "RemoveItem"
        Me.RemoveItem.Size = New System.Drawing.Size(176, 78)
        Me.RemoveItem.TabIndex = 0
        Me.RemoveItem.Text = "Remove Item"
        Me.RemoveItem.UseVisualStyleBackColor = True
        '
        'TransactionTable
        '
        Me.TransactionTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.TransactionTable.Location = New System.Drawing.Point(1045, 2)
        Me.TransactionTable.Name = "TransactionTable"
        Me.TransactionTable.Size = New System.Drawing.Size(313, 420)
        Me.TransactionTable.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Name "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Quantity"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Item Cost"
        Me.Column3.Name = "Column3"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.RemoveItem)
        Me.Panel7.Location = New System.Drawing.Point(1158, 428)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 100)
        Me.Panel7.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.CalcTotals)
        Me.Panel8.Location = New System.Drawing.Point(920, 428)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(232, 100)
        Me.Panel8.TabIndex = 5
        '
        'CalcTotals
        '
        Me.CalcTotals.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcTotals.Location = New System.Drawing.Point(10, 10)
        Me.CalcTotals.Name = "CalcTotals"
        Me.CalcTotals.Size = New System.Drawing.Size(207, 78)
        Me.CalcTotals.TabIndex = 0
        Me.CalcTotals.Text = "Calc./Update Totals"
        Me.CalcTotals.UseVisualStyleBackColor = True
        '
        'Invoice
        '
        '
        'PrintSetup
        '
        Me.PrintSetup.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintSetup.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintSetup.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintSetup.Document = Me.Invoice
        Me.PrintSetup.Enabled = True
        Me.PrintSetup.Icon = CType(resources.GetObject("PrintSetup.Icon"), System.Drawing.Icon)
        Me.PrintSetup.Name = "PrintPreviewDialog1"
        Me.PrintSetup.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TransactionTable)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TransactionTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    'refers to the buttons,columns,panels and combo boxes being accessible from the scope from which they are defined
    'and can utilize event call functionality

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TransactionTable As DataGridView
    Friend WithEvents BEERANDNACHOS As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents FRESHPIZZA As Button
    Friend WithEvents SWEETDONUTS As Button
    Friend WithEvents TASTYTACOS As Button
    Friend WithEvents TASTYSAUCES As Button
    Friend WithEvents MEXICANDISHES As Button
    Friend WithEvents CINEMAFOOD As Button
    Friend WithEvents BURRITOS As Button
    Friend WithEvents FALAFEL As Button
    Friend WithEvents TASTYMEAT As Button
    Friend WithEvents SANDWICH As Button
    Friend WithEvents QUESADILLA As Button
    Friend WithEvents FRESHDRINKS As Button
    Friend WithEvents ICECREAM As Button
    Friend WithEvents SALADANDSAUSAGE As Button
    Friend WithEvents keypad7 As Button
    Friend WithEvents keypadDecimal As Button
    Friend WithEvents keypad0 As Button
    Friend WithEvents keypadClear As Button
    Friend WithEvents keypad3 As Button
    Friend WithEvents keypad2 As Button
    Friend WithEvents keypad1 As Button
    Friend WithEvents keypad4 As Button
    Friend WithEvents keypad5 As Button
    Friend WithEvents keypad6 As Button
    Friend WithEvents keypad9 As Button
    Friend WithEvents keypad8 As Button
    Friend WithEvents Payment As Button
    Friend WithEvents ResetTransaction As Button
    Friend WithEvents RemoveItem As Button
    Friend WithEvents PrintReceipt As Button
    Friend WithEvents CustomerChange As Label
    Friend WithEvents CustomerCashAmount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PaymentMethod As ComboBox
    Friend WithEvents TransactionTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MandatoryStoreTax As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TransactionSubTotal As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents CalcTotals As Button
    Friend WithEvents Invoice As Printing.PrintDocument
    Friend WithEvents PrintSetup As PrintPreviewDialog
End Class
