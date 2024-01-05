Imports System.IO

Public Class Form1

#Region " Propriedades da Classe "

    Private mhtAposta1 As New Hashtable
    Private mhtAposta2 As New Hashtable
    Private mhtAposta3 As New Hashtable
    Private mhtAposta4 As New Hashtable
    Private mhtAposta5 As New Hashtable
    Private mhtAposta6 As New Hashtable

    Private mhtAposta7 As New Hashtable
    Private mhtAposta8 As New Hashtable
    Private mhtAposta9 As New Hashtable
    Private mhtAposta10 As New Hashtable
    Private mhtAposta11 As New Hashtable
    Private mhtAposta12 As New Hashtable

    Private mhtAposta13 As New Hashtable
    Private mhtAposta14 As New Hashtable
    Private mhtAposta15 As New Hashtable
    Private mhtAposta16 As New Hashtable
    Private mhtAposta17 As New Hashtable
    Private mhtAposta18 As New Hashtable

    Private mhtAposta19 As New Hashtable
    Private mhtAposta20 As New Hashtable
    Private mhtAposta21 As New Hashtable
    Private mhtAposta22 As New Hashtable
    Private mhtAposta23 As New Hashtable
    Private mhtAposta24 As New Hashtable

    Private mhtAposta25 As New Hashtable
    Private mhtAposta26 As New Hashtable
    Private mhtAposta27 As New Hashtable
    Private mhtAposta28 As New Hashtable
    Private mhtAposta29 As New Hashtable
    Private mhtAposta30 As New Hashtable

    Private mhtAposta31 As New Hashtable
    Private mhtAposta32 As New Hashtable
    Private mhtAposta33 As New Hashtable
    Private mhtAposta34 As New Hashtable
    Private mhtAposta35 As New Hashtable
    Private mhtAposta36 As New Hashtable

    Private mhtHistorico As New Hashtable

#End Region

#Region " Eventos da Classe "

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = Application.ProductName & " V-" & Application.ProductVersion & " Build " & My.Application.Info.Version.Build
        ToolStripStatusLabel1.Text = Application.CompanyName & " " & My.Application.Info.Copyright & " " &
                                     IIf(Year(Now) > 2010, "-" & Year(Now), "")
        If File.Exists("MBHistorico.txt") Then
            CargaHistorico()
        End If
        If File.Exists("MBApostas.txt") Then
            CargaApostas()
        End If
        CargaTabelas()

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        'Duplo click no quadro
        '02/02/10
        '=====================
        Dim f As New frmAbout

        f.ShowDialog()

    End Sub

    Private Sub pctCofreFechado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCofreFechado.Click
        'Click no quadro
        '02/02/10
        '===============
        pctCofreFechado.Visible = False

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'Click no quadro
        '02/02/10
        '===============
        pctCofreFechado.Visible = True

    End Sub

#End Region

#Region " Eventos - Resultado "

    Private Sub r01_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles r01.GotFocus
        'Campo recebe o foco
        '27/01/10
        '===================
        CType(sender, TextBox).SelectAll()

    End Sub

    Private Sub r01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r01.TextChanged
        'Resultado 01
        '26/01/10
        '============
        If IsNumeric(sender.text) Then
            sender.text = CType(sender.text, Integer)
            Apuracao()
        End If

    End Sub

    Private Sub r02_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles r02.GotFocus
        'Campo recebe o foco
        '27/01/10
        '===================
        CType(sender, TextBox).SelectAll()

    End Sub

    Private Sub r02_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r02.TextChanged
        'Resultado 02
        '26/01/10
        '============
        If IsNumeric(sender.text) Then
            sender.text = CType(sender.text, Integer)
            Apuracao()
        End If

    End Sub

    Private Sub r03_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles r03.GotFocus
        'Campo recebe o foco
        '27/01/10
        '===================
        CType(sender, TextBox).SelectAll()

    End Sub

    Private Sub r03_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r03.TextChanged
        'Resultado 03
        '26/01/10
        '============
        If IsNumeric(sender.text) Then
            sender.text = CType(sender.text, Integer)
            Apuracao()
        End If

    End Sub

    Private Sub r04_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles r04.GotFocus
        'Campo recebe o foco
        '27/01/10
        '===================
        CType(sender, TextBox).SelectAll()

    End Sub

    Private Sub r04_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r04.TextChanged
        'Resultado 04
        '26/01/10
        '============
        If IsNumeric(sender.text) Then
            sender.text = CType(sender.text, Integer)
            Apuracao()
        End If

    End Sub

    Private Sub r05_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles r05.GotFocus
        'Campo recebe o foco
        '27/01/10
        '===================
        CType(sender, TextBox).SelectAll()

    End Sub

    Private Sub r05_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r05.TextChanged
        'Resultado 05
        '26/01/10
        '============
        If IsNumeric(sender.text) Then
            sender.text = CType(sender.text, Integer)
            Apuracao()
        End If

    End Sub

    Private Sub r06_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles r06.GotFocus
        'Campo recebe o foco
        '27/01/10
        '===================
        CType(sender, TextBox).SelectAll()

    End Sub

    Private Sub r06_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r06.TextChanged
        'Resultado 06
        '26/01/10
        '============
        If IsNumeric(sender.text) Then
            sender.text = CType(sender.text, Integer)
            Apuracao()
        End If

    End Sub

    Private Sub r01_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles r01.Validating
        'Validação do campo
        '28/01/10
        '==================
        Dim strRes As String = CType(sender, TextBox).Text

        e.Cancel = (strRes <> "")
        If strRes <> "" Then
            If IsNumeric(strRes) And (Not strRes.Contains(",")) And (Not strRes.Contains(",")) Then
                Dim intRes As Integer = Mid(CType(sender, TextBox).Name, 2)
                If (Not Repetido(strRes, intRes)) And (strRes >= 1) And (strRes <= 60) Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub r02_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles r02.Validating
        'Validação do campo
        '28/01/10
        '==================
        Dim strRes As String = CType(sender, TextBox).Text

        e.Cancel = (strRes <> "")
        If strRes <> "" Then
            If IsNumeric(strRes) And (Not strRes.Contains(",")) And (Not strRes.Contains(",")) Then
                Dim intRes As Integer = Mid(CType(sender, TextBox).Name, 2)
                If (Not Repetido(strRes, intRes)) And (strRes >= 1) And (strRes <= 60) Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub r03_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles r03.Validating
        'Validação do campo
        '28/01/10
        '==================
        Dim strRes As String = CType(sender, TextBox).Text

        e.Cancel = (strRes <> "")
        If strRes <> "" Then
            If IsNumeric(strRes) And (Not strRes.Contains(",")) And (Not strRes.Contains(",")) Then
                Dim intRes As Integer = Mid(CType(sender, TextBox).Name, 2)
                If (Not Repetido(strRes, intRes)) And (strRes >= 1) And (strRes <= 60) Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub r04_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles r04.Validating
        'Validação do campo
        '28/01/10
        '==================
        Dim strRes As String = CType(sender, TextBox).Text

        e.Cancel = (strRes <> "")
        If strRes <> "" Then
            If IsNumeric(strRes) And (Not strRes.Contains(",")) And (Not strRes.Contains(",")) Then
                Dim intRes As Integer = Mid(CType(sender, TextBox).Name, 2)
                If (Not Repetido(strRes, intRes)) And (strRes >= 1) And (strRes <= 60) Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub r05_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles r05.Validating
        'Validação do campo
        '28/01/10
        '==================
        Dim strRes As String = CType(sender, TextBox).Text

        e.Cancel = (strRes <> "")
        If strRes <> "" Then
            If IsNumeric(strRes) And (Not strRes.Contains(",")) And (Not strRes.Contains(",")) Then
                Dim intRes As Integer = Mid(CType(sender, TextBox).Name, 2)
                If (Not Repetido(strRes, intRes)) And (strRes >= 1) And (strRes <= 60) Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub r06_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles r06.Validating
        'Validação do campo
        '28/01/10
        '==================
        Dim strRes As String = CType(sender, TextBox).Text

        e.Cancel = (strRes <> "")
        If strRes <> "" Then
            If IsNumeric(strRes) And (Not strRes.Contains(",")) And (Not strRes.Contains(",")) Then
                Dim intRes As Integer = Mid(CType(sender, TextBox).Name, 2)
                If (Not Repetido(strRes, intRes)) And (strRes >= 1) And (strRes <= 60) Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        'Botão limpa
        '27/01/10-01/02/10
        '===========
        LimpaResultado()

    End Sub

    Private Sub txtTeste_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTeste.KeyPress
        'Tecla pressionada
        '28/01/10
        '=================
        e.Handled = ValiText(e.KeyChar, "0123456789")

    End Sub

#End Region

#Region " Eventos Apostas "
    Private Sub pr1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr01.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr02.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr03.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr04.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr5_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr05.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr6_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr06.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr07_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr07.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr08_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr08.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr09_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr09.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr10_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr10.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr11_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr11.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr12_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr12.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr13_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr13.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr14_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr14.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr15_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr15.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr16_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr16.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr17_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr17.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr18_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr18.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr19_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr19.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr20_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr20.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr21_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr21.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr22_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr22.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr23_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr23.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr24_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr24.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr25_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr25.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr26_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr26.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr27_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr27.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr28_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr28.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr29_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr29.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr30_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr30.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr31_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr31.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr32_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr32.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr33_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr33.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr34_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr34.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr35_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr35.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub pr36_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles pr36.Validated
        'Validação de texto
        '01/02/10
        '==================
        If IsNumeric(sender.text) Then
            sender.text = FormatNumber(sender.text, 2)
        End If
        CalculaPremio()

    End Sub

    Private Sub btnCargaAposta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaAposta.Click
        'Botão carrega arquivo aposta
        '02/02/10
        '============================
        With OpenFileDialog1
            .FileName = "MBApostas.txt"
            .Filter = "Texto (*.txt)|*.txt| Todos (*.*)|*.*"
            .Title = "Carga de Apostas"
            If .ShowDialog = DialogResult.OK Then
                CargaApostas(.FileName)
            End If
        End With

    End Sub

#End Region

#Region " Eventos Histórico "

    Private Sub lsvHistorico_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvHistorico.DoubleClick
        'Duplo click na linha da tabela
        '02/02/10
        '==============================
        btnCarga.PerformClick()

    End Sub

    Private Sub lsvHistorico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvHistorico.SelectedIndexChanged
        'Seleção de linha na tabela
        '02/02/10
        '==========================
        If lsvHistorico.SelectedItems.Count > 0 Then
            btnCarga.Enabled = True
        End If

    End Sub

    Private Sub btnCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarga.Click
        'Botão carga
        '28/01/10
        '===========
        Recarga()

    End Sub

    Private Sub btnGrava_Click_1(sender As Object, e As EventArgs) Handles btnGrava.Click
        'Botão grava
        '27/01/10
        '===========
        If Not mhtHistorico.ContainsKey(txtTeste.Text) Then
            GravaHistorico()
        Else
            Dim strMsg As String = "Teste " & txtTeste.Text & " já existe no histórico"
            MessageBox.Show(strMsg, "Megasena - Histórico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

#End Region

#Region " Eventos Gerador "

    Private Sub btnGerador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerador.Click
        'Botão gerador
        '02/02/10
        '=============
        Gerador()
        btnGerador.Enabled = False
        btnGrava.Enabled = True

    End Sub

    Private Sub btnGravaGerador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravaGerador.Click
        'Botão grava gerador
        '02/02/10
        '===================
        With SaveFileDialog1
            .FileName = "MBApostas.txt"
            .Filter = "Texto (*.txt)|*.txt| Todos (*.*)|*.*"
            .Title = "Gerador de Apostas"
            If .ShowDialog = DialogResult.OK Then
                GravaGerador(.FileName)
            End If
        End With

    End Sub

    Private Sub txtGerador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGerador.KeyPress
        'Tecla pressionada
        '02/02/10
        '=================
        e.Handled = ValiText(e.KeyChar, "0123456789")

    End Sub

    Private Sub txtGerador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGerador.TextChanged
        'Alteração no texto
        '02/02/10
        '==================
        btnGerador.Enabled = (txtGerador.Text.Length > 0)
        If btnGerador.Enabled Then
            btnGerador.Enabled = (txtGerador.Text >= 1) And (txtGerador.Text <= 36)
        End If

    End Sub

#End Region

#Region " Métodos da Classe"

    Private Sub Apuracao()

        Dim htResult As New Hashtable
        Dim intP(36) As Integer
        Dim intResult As Integer = 0

        For Each oItem As Integer In intP
            oItem = 0
        Next

        For Each oCnt As Control In grpResult.Controls
            If TypeOf (oCnt) Is TextBox Then
                If oCnt.Name Like "r??" Then
                    If oCnt.Text.Length > 0 Then
                        intResult += 1
                        If Not htResult.ContainsKey(oCnt.Text) Then
                            htResult.Add(oCnt.Text, 1)
                        End If
                    End If
                End If
            End If
        Next

        btnGrava.Enabled = (intResult = 6) And (IsNumeric(txtTeste.Text))
        pctCofreFechado.Visible = True
        pctMoedas.Visible = False

        For Each oKey As Object In htResult.Keys
            intP(1) += IIf(mhtAposta1.ContainsKey(oKey), 1, 0)
            intP(2) += IIf(mhtAposta2.ContainsKey(oKey), 1, 0)
            intP(3) += IIf(mhtAposta3.ContainsKey(oKey), 1, 0)
            intP(4) += IIf(mhtAposta4.ContainsKey(oKey), 1, 0)
            intP(5) += IIf(mhtAposta5.ContainsKey(oKey), 1, 0)
            intP(6) += IIf(mhtAposta6.ContainsKey(oKey), 1, 0)

            intP(7) += IIf(mhtAposta7.ContainsKey(oKey), 1, 0)
            intP(8) += IIf(mhtAposta8.ContainsKey(oKey), 1, 0)
            intP(9) += IIf(mhtAposta9.ContainsKey(oKey), 1, 0)
            intP(10) += IIf(mhtAposta10.ContainsKey(oKey), 1, 0)
            intP(11) += IIf(mhtAposta11.ContainsKey(oKey), 1, 0)
            intP(12) += IIf(mhtAposta12.ContainsKey(oKey), 1, 0)

            intP(13) += IIf(mhtAposta13.ContainsKey(oKey), 1, 0)
            intP(14) += IIf(mhtAposta14.ContainsKey(oKey), 1, 0)
            intP(15) += IIf(mhtAposta15.ContainsKey(oKey), 1, 0)
            intP(16) += IIf(mhtAposta16.ContainsKey(oKey), 1, 0)
            intP(17) += IIf(mhtAposta17.ContainsKey(oKey), 1, 0)
            intP(18) += IIf(mhtAposta18.ContainsKey(oKey), 1, 0)

            intP(19) += IIf(mhtAposta19.ContainsKey(oKey), 1, 0)
            intP(20) += IIf(mhtAposta20.ContainsKey(oKey), 1, 0)
            intP(21) += IIf(mhtAposta21.ContainsKey(oKey), 1, 0)
            intP(22) += IIf(mhtAposta22.ContainsKey(oKey), 1, 0)
            intP(23) += IIf(mhtAposta23.ContainsKey(oKey), 1, 0)
            intP(24) += IIf(mhtAposta24.ContainsKey(oKey), 1, 0)

            intP(25) += IIf(mhtAposta25.ContainsKey(oKey), 1, 0)
            intP(26) += IIf(mhtAposta26.ContainsKey(oKey), 1, 0)
            intP(27) += IIf(mhtAposta27.ContainsKey(oKey), 1, 0)
            intP(28) += IIf(mhtAposta28.ContainsKey(oKey), 1, 0)
            intP(29) += IIf(mhtAposta29.ContainsKey(oKey), 1, 0)
            intP(30) += IIf(mhtAposta30.ContainsKey(oKey), 1, 0)

            intP(31) += IIf(mhtAposta31.ContainsKey(oKey), 1, 0)
            intP(32) += IIf(mhtAposta32.ContainsKey(oKey), 1, 0)
            intP(33) += IIf(mhtAposta33.ContainsKey(oKey), 1, 0)
            intP(34) += IIf(mhtAposta34.ContainsKey(oKey), 1, 0)
            intP(35) += IIf(mhtAposta35.ContainsKey(oKey), 1, 0)
            intP(36) += IIf(mhtAposta36.ContainsKey(oKey), 1, 0)
        Next

        Dim intAcertos As Integer = 0

        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name Like "p??" Then
                oCnt.Text = intP(CType(Mid(oCnt.Name, 2), Integer))
                oCnt.ForeColor = IIf(oCnt.Text <> "0", Color.Red, Color.Black)
                intAcertos += IIf(oCnt.Text <> "0", 1, 0)
            End If
        Next

        Dim intPremios As Integer = 0

        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name Like "pr*" Then
                Dim i As Integer = CType(Mid(oCnt.Name, 3), Integer)
                oCnt.Text = Microsoft.VisualBasic.Switch(intP(i) < 4, "-", intP(i) = 4, "QUADRA", intP(i) = 5,
                                    "QUINA", intP(i) = 6, "* M E G A *")
                intPremios += IIf(oCnt.Text.Contains("A"), 1, 0)
            End If
        Next

        If (Trim(pr01.Text) & Trim(pr02.Text) & Trim(pr03.Text) & Trim(pr04.Text) & Trim(pr05.Text) &
            Trim(pr06.Text)).Contains("A") Then
            Beep()
            pctCofreFechado.Visible = False
            pctMoedas.Visible = True
        End If

        lblAcertos.Text = "Apostas com acertos: " & intAcertos & " - MÁX: " & AcertoMaximo()
        lblAcertos.Visible = (intAcertos > 0)
        lblPremios.Text = "Apostas com prêmio: " & intPremios
        lblPremios.Visible = (intPremios > 0)
        If intPremios > 0 Then
            Beep()
            pctCofreFechado.Visible = False
            pctMoedas.Visible = True
        End If
        CalculaPremio()

    End Sub

    Private Function AcertoMaximo() As Integer
        'Retorna o maior número de acertos em uma aposta entre todas
        '02/02/10
        '===========================================================
        Dim intMax As Integer = 0

        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name Like "p??" Then
                If CType(oCnt.Text, Integer) > intMax Then
                    intMax = oCnt.Text
                End If
            End If
        Next

        Return intMax

    End Function
    Private Sub CalculaPremio()
        'Cálculo do prêmio - se as caixas de texto forem preenchida com valores
        '01/02/10
        '======================================================================
        Dim decTot As Decimal = 0

        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name Like "pr*" Then
                If IsNumeric(oCnt.Text) Then
                    decTot += oCnt.Text
                End If
            End If
        Next

        txtTotal.Text = FormatNumber(decTot, 2)

    End Sub

    Private Sub CargaTabelas()
        'Carga das apostas em hashtables
        '01/02/10
        '===============================
        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name.StartsWith("a") And IsNumeric(oCnt.Text) Then
                If oCnt.Name Like "a01??" Then
                    mhtAposta1.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a02??" Then
                    mhtAposta2.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a03??" Then
                    mhtAposta3.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a04??" Then
                    mhtAposta4.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a05??" Then
                    mhtAposta5.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a06??" Then
                    mhtAposta6.Add(oCnt.Text, 1)

                ElseIf oCnt.Name Like "a07??" Then
                    mhtAposta7.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a08??" Then
                    mhtAposta8.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a09??" Then
                    mhtAposta9.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a10??" Then
                    mhtAposta10.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a11??" Then
                    mhtAposta11.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a12??" Then
                    mhtAposta12.Add(oCnt.Text, 1)

                ElseIf oCnt.Name Like "a13??" Then
                    mhtAposta13.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a14??" Then
                    mhtAposta14.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a15??" Then
                    mhtAposta15.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a16??" Then
                    mhtAposta16.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a17??" Then
                    mhtAposta17.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a18??" Then
                    mhtAposta18.Add(oCnt.Text, 1)

                ElseIf oCnt.Name Like "a19??" Then
                    mhtAposta19.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a20??" Then
                    mhtAposta20.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a21??" Then
                    mhtAposta21.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a22??" Then
                    mhtAposta22.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a23??" Then
                    mhtAposta23.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a24??" Then
                    mhtAposta24.Add(oCnt.Text, 1)

                ElseIf oCnt.Name Like "a25??" Then
                    mhtAposta25.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a26??" Then
                    mhtAposta26.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a27??" Then
                    mhtAposta27.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a28??" Then
                    mhtAposta28.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a29??" Then
                    mhtAposta29.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a30??" Then
                    mhtAposta30.Add(oCnt.Text, 1)

                ElseIf oCnt.Name Like "a31??" Then
                    mhtAposta31.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a32??" Then
                    mhtAposta32.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a33??" Then
                    mhtAposta33.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a34??" Then
                    mhtAposta34.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a35??" Then
                    mhtAposta35.Add(oCnt.Text, 1)
                ElseIf oCnt.Name Like "a36??" Then
                    mhtAposta36.Add(oCnt.Text, 1)

                End If
            End If
        Next

    End Sub

    Private Sub CargaHistorico()
        'Carga do histórico 
        '27/01/10-01/02/10
        '==================
        Dim stmHistorico As New StreamReader("MBHistorico.txt", System.Text.Encoding.Default)
        Dim strHistorico As String = stmHistorico.ReadLine
        Dim decPremio As Decimal = 0

        mhtHistorico.Clear()
        lsvHistorico.Items.Clear()

        While Not IsNothing(strHistorico)
            Dim split As String() = strHistorico.Split(New Char() {";"c})
            Dim oItem As New ListViewItem(split(0))

            oItem.SubItems.Add(split(1))    'Data
            oItem.SubItems.Add(split(2))    'Resultado 1
            oItem.SubItems.Add(split(3))    'Resultado 2
            oItem.SubItems.Add(split(4))    'Resultado 3
            oItem.SubItems.Add(split(5))    'Resultado 4
            oItem.SubItems.Add(split(6))    'Resultado 5
            oItem.SubItems.Add(split(7))    'Resultado 6

            'Guarda linha em mhtHistorico
            mhtHistorico.Add(split(0), strHistorico)

            If IsNumeric(split(8)) Then
                If split(8) <> "0.00" Then
                    oItem.SubItems.Add(split(8))   'Prêmio
                    decPremio += CType(split(8), Decimal)
                End If
            End If

            oItem.Tag = split(0)
            lsvHistorico.Items.AddRange(New ListViewItem() {oItem})
            strHistorico = stmHistorico.ReadLine
        End While

        lblTotalHist.Text = "Total de testes no histórico: " & lsvHistorico.Items.Count
        txtPremio.Text = FormatNumber(decPremio, 2)
        stmHistorico.Close()

    End Sub

    Private Sub GravaHistorico()
        'Grava o resultado no histórico
        '27/01/10-01/02/10
        '==============================
        Dim stmHistorico As New StreamWriter("MBHistorico.txt", True, System.Text.Encoding.Default)
        Dim strHistorico As String = txtTeste.Text & ";" & FormatDateTime(dtpTeste.Value, DateFormat.ShortDate) & ";"
        Dim strMsg As String = "Histórico gravado"

        strHistorico &= r01.Text & ";" & r02.Text & ";" & r03.Text & ";" & r04.Text & ";" & r05.Text & ";" & r06.Text & ";"
        strHistorico &= txtTotal.Text
        stmHistorico.WriteLine(strHistorico)
        stmHistorico.Close()
        CargaHistorico()
        btnGrava.Enabled = False
        MessageBox.Show(strMsg, "Megasena - Histórico", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Recarga()
        'Carga do jogo selecionado no grid de resultados
        '28/01/10
        '01/02/10
        '===============================================
        With lsvHistorico.SelectedItems(0)
            txtTeste.Text = .Text
            dtpTeste.Value = .SubItems(1).Text
            r01.Text = .SubItems(2).Text
            r02.Text = .SubItems(3).Text
            r03.Text = .SubItems(4).Text
            r04.Text = .SubItems(5).Text
            r05.Text = .SubItems(6).Text
            r06.Text = .SubItems(7).Text
        End With

    End Sub

    Private Function Repetido(ByVal intResult As Integer, ByVal intPos As Integer)
        'Retorna True se o número já foi digitado
        'intResult: um número resultado
        'intPos: posíção do número resultado no grid de resultados
        '28/01/10
        '=========================================================
        Dim blnRepetido As Boolean = False

        For Each oCnt As Control In grpResult.Controls
            If oCnt.Name Like "r??" Then
                If oCnt.Text.Length > 0 Then
                    blnRepetido = (CType(Mid(oCnt.Name, 2), Integer) <> intPos) And (CType(oCnt.Text, Integer) = intResult)
                    If blnRepetido Then
                        Exit For
                    End If
                End If
            End If
        Next

        Return blnRepetido

    End Function

    Public Shared Function ValiText(ByVal KeyIn As Char, ByVal ValidateString As String) As Boolean
        '20/04/04-29/04/04
        '03/03/05
        'USO no evento KeyPress de uma TextBox: 
        'e.Handled = pubValiText(e.KeyChar, "0123456789,.")
        '=======================================================
        Dim blnHandled As Boolean = True

        If Char.IsDigit(KeyIn) Or Char.IsPunctuation(KeyIn) Then
            blnHandled = Not (InStr(1, ValidateString, Char.ToUpper(KeyIn), 1) > 0)
        Else
            blnHandled = Not (Char.IsControl(KeyIn))
        End If

        Return blnHandled

    End Function

    Private Sub CargaApostas(Optional ByVal strFilename As String = "MBApostas.txt")
        'Carga das apostas a partir do arquivo MBApostas.txt
        '01/02/10
        '===================================================
        Dim stmApostas As New StreamReader(strFilename, System.Text.Encoding.Default)
        Dim strApostas As String = stmApostas.ReadLine
        Dim intLin As Integer = 0

        While Not IsNothing(strApostas)
            Dim split As String() = strApostas.Split(New Char() {";"c})

            intLin += 1

            For Each oCnt As Control In grpApostas.Controls
                If oCnt.Name Like "a" & Format(intLin, "00") & "*" Then
                    oCnt.Text = split(CType(Mid(oCnt.Name, 4), Integer) - 1)
                End If
            Next

            strApostas = stmApostas.ReadLine

        End While

        stmApostas.Close()

    End Sub

    Private Sub LimpaResultado()
        'Limpa os campos de resultado
        '02/02/10
        '============================
        txtTeste.Text = ""
        dtpTeste.Value = Now

        For Each oCnt As Control In grpResult.Controls
            If TypeOf (oCnt) Is TextBox Then
                If oCnt.Name Like "r??" Then
                    oCnt.Text = ""
                End If
            End If
        Next

        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name Like "pr??" Then
                oCnt.Text = "-"
            End If
            If oCnt.Name Like "p??" Then
                oCnt.Text = ""
            End If
        Next

        txtTotal.Text = "-"
        btnGrava.Enabled = False
        lblAcertos.Visible = False
        lblPremios.Visible = False
        pctCofreFechado.Visible = True
        pctMoedas.Visible = False
        txtTeste.Focus()

    End Sub

    Public Function RandomNumber(ByVal MaxNumber As Integer,
        Optional ByVal MinNumber As Integer = 0) As Integer
        'Gera um número aleatório entre dois valores MinNumber e MaxNumber
        '02/02/10
        '=================================================================
        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        'if passed incorrect arguments, swap them
        'can also throw exception or return 0

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function

    Private Sub Gerador()
        'Gera apostas aleatórias
        '02/02/10
        '=======================
        Dim strMsg As String = "Apostas geradas: " & txtGerador.Text
        Dim oCur As Cursor = Cursor
        Cursor = Cursors.WaitCursor
        btnLimpa.PerformClick()
        Application.DoEvents()
        LimpaTabelas()

        For i As Integer = 1 To CType(txtGerador.Text, Integer)
            Dim aGerador As New ArrayList

            For j As Integer = 1 To 6

                Dim k As Integer = RandomNumber(61, 1)

                While aGerador.Contains(k)
                    k = RandomNumber(60, 1)
                End While

                aGerador.Add(k)
            Next j

            aGerador.Sort()

            For Each oCnt As Control In grpApostas.Controls
                If oCnt.Name Like "a" & Format(i, "00") & "*" Then
                    oCnt.Text = aGerador(CType(Mid(oCnt.Name, 4), Integer) - 1)
                End If
            Next

        Next i

        CargaTabelas()
        btnGravaGerador.Enabled = True
        Cursor = oCur
        MessageBox.Show(strMsg, "MegaBolão - Gerador", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub LimpaTabelas()
        'Limpa as hashtables de apostas
        '02/02/10
        '==============================
        For Each oCnt As Control In grpApostas.Controls
            If oCnt.Name Like "a????" Then
                oCnt.Text = ""
            End If
        Next

        mhtAposta1.Clear()
        mhtAposta2.Clear()
        mhtAposta3.Clear()
        mhtAposta4.Clear()
        mhtAposta5.Clear()
        mhtAposta6.Clear()
        mhtAposta7.Clear()
        mhtAposta8.Clear()
        mhtAposta9.Clear()
        mhtAposta10.Clear()
        mhtAposta11.Clear()
        mhtAposta12.Clear()
        mhtAposta13.Clear()
        mhtAposta14.Clear()
        mhtAposta15.Clear()
        mhtAposta16.Clear()
        mhtAposta17.Clear()
        mhtAposta18.Clear()
        mhtAposta19.Clear()
        mhtAposta20.Clear()
        mhtAposta21.Clear()
        mhtAposta22.Clear()
        mhtAposta23.Clear()
        mhtAposta24.Clear()
        mhtAposta25.Clear()
        mhtAposta26.Clear()
        mhtAposta27.Clear()
        mhtAposta28.Clear()
        mhtAposta29.Clear()
        mhtAposta30.Clear()
        mhtAposta31.Clear()
        mhtAposta32.Clear()
        mhtAposta33.Clear()
        mhtAposta34.Clear()
        mhtAposta35.Clear()
        mhtAposta36.Clear()

    End Sub

    Private Sub GravaGerador(ByVal strFilename As String)
        'Grava as apostas geradas aleatoriamente
        '02/02/10
        '=======================================
        Dim stmApostas As New StreamWriter(strFilename, False, System.Text.Encoding.Default)
        Dim strMsg As String = "Apostas Geradas Gravadas"
        Dim intApostas As Integer = 0

        For i As Integer = 1 To CType(txtGerador.Text, Integer)
            Dim aApostas As New ArrayList

            For Each oCnt As Control In grpApostas.Controls
                If oCnt.Name Like "a????" And oCnt.Text.Length > 0 Then
                    If CType(Mid(oCnt.Name, 2, 2), Integer) = i Then
                        aApostas.Add(oCnt.Text)
                    End If
                End If
            Next oCnt

            If aApostas.Count > 0 Then
                aApostas.Sort()
                stmApostas.WriteLine(aApostas(0) & ";" & aApostas(1) & ";" & aApostas(2) & ";" & aApostas(3) & ";" &
                                     aApostas(4) & ";" & aApostas(5))
                intApostas += 1
            End If
        Next i

        stmApostas.Close()
        strMsg &= ": " & intApostas
        MessageBox.Show(strMsg, "MegaBolão - Gerador de Apostas", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

#End Region

End Class
