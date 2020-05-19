Imports CapaNegocio
Imports CapaEntidades
Public Class FrmCliente
    Public Estado As Integer
    Private objNegocio As New Cls_Negocio
    Private objEnt As New Cls_Entidades
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub
    Sub ListarClientes()
        Dim dt As DataTable = objNegocio.N_ListarCiente
        DataGridView1.DataSource = dt
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Estado = 1
        Dim FrmAgCliente As New FrmAgregarCliente


        FrmAgCliente.ShowDialog()
        'FrmAgregarCliente.Show()

        ListarClientes()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Estado = 2
        Dim FrmAgCliente As New FrmAgregarCliente
        FrmAgCliente.ShowDialog()
        ListarClientes()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Desea eliminar el Cliente? " & DataGridView1.CurrentRow.Cells(1).Value.ToString, MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            objEnt.IdCliente = DataGridView1.CurrentRow.Cells(0).Value.ToString
            objNegocio.N_EliminarCliente(objEnt)
            ListarClientes()
            MsgBox("Cliente eliminado correctamente")
        End If
    End Sub

    Private Sub FrmCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class
