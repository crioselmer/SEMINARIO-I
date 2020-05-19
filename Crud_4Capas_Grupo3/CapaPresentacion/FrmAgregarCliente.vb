Imports CapaNegocio
Imports CapaEntidades
Public Class FrmAgregarCliente
    Dim objNeg As New Cls_Negocio
    Dim objEnt As New Cls_Entidades
    Private Sub FrmAgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FrmCliente.Estado = 1 Then
            Me.Text = "Agregar Cliente"
        Else
            Me.Text = "Modificar Cliente"
            With FrmCliente.DataGridView1.CurrentRow
                objEnt.IdCliente = .Cells(0).Value.ToString
                TxtRazonSocial.Text = .Cells(1).Value.ToString
                TxtRuc.Text = .Cells(2).Value.ToString
                TxtDirecion.Text = .Cells(3).Value.ToString
                Txtcelular.Text = .Cells(4).Value.ToString
                TxtFijo.Text = .Cells(5).Value.ToString
                TxtZona.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub


    Public Sub TxtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRuc.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub Txtcelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcelular.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFijo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Len(TxtRazonSocial.Text.Trim) < 3 Then
            MsgBox("Ingrese razón social", MsgBoxStyle.Exclamation)
            'ElseIf TxtRuc.Text.Length <> 8 Or TxtRuc.Text.Length <> 11 Then
            '    MsgBox("RUC invalido", MsgBoxStyle.Exclamation)
        Else
            If FrmCliente.Estado = 1 Then
                objEnt.RazonSocialCli = TxtRazonSocial.Text
                objEnt.RucClie = TxtRuc.Text
                objEnt.DireccionClie = TxtDirecion.Text
                objEnt.CelularCli = Txtcelular.Text
                objEnt.FijoCli = TxtFijo.Text
                objEnt.ZonaCli = TxtZona.Text
                objNeg.N_InsertarCliente(objEnt)
                MsgBox("Cliente registrado correctamente", MsgBoxStyle.Information)
                Me.Close()
            Else

                objEnt.RazonSocialCli = TxtRazonSocial.Text
                objEnt.RucClie = TxtRuc.Text
                objEnt.DireccionClie = TxtDirecion.Text
                objEnt.CelularCli = Txtcelular.Text
                objEnt.FijoCli = TxtFijo.Text
                objEnt.ZonaCli = TxtZona.Text
                objNeg.N_ModificarCliente(objEnt)
                MsgBox("Cliente modificado correctamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub
End Class