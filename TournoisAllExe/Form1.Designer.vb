<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bexecuter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LS = New System.Windows.Forms.Label()
        Me.LH = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(5, 70)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(349, 121)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTE DE DESTINATIONS DE SAUVEGARDES"
        '
        'bexecuter
        '
        Me.bexecuter.Location = New System.Drawing.Point(129, 196)
        Me.bexecuter.Name = "bexecuter"
        Me.bexecuter.Size = New System.Drawing.Size(104, 80)
        Me.bexecuter.TabIndex = 2
        Me.bexecuter.Text = "EXECUTER LES PROGRAMMES"
        Me.bexecuter.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 79)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "AJOUTER LIEU DE SAUVEGARDE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 79)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "SUPPRIMER LIEU DE SAUVEGARDE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "INTERVALLE SAUVEGARDE (MINUTES)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'LS
        '
        Me.LS.AutoSize = True
        Me.LS.Location = New System.Drawing.Point(291, 11)
        Me.LS.Name = "LS"
        Me.LS.Size = New System.Drawing.Size(63, 13)
        Me.LS.TabIndex = 7
        Me.LS.Text = "Avant Save"
        '
        'LH
        '
        Me.LH.AutoSize = True
        Me.LH.Location = New System.Drawing.Point(5, 11)
        Me.LH.Name = "LH"
        Me.LH.Size = New System.Drawing.Size(36, 13)
        Me.LH.TabIndex = 8
        Me.LH.Text = "Heure"
        '
        'Timer2
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "00:05:00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 281)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LH)
        Me.Controls.Add(Me.LS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bexecuter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(481, 404)
        Me.Name = "Form1"
        Me.Text = "TournoiAllExe 3.40"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bexecuter As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LS As Label
    Friend WithEvents LH As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
