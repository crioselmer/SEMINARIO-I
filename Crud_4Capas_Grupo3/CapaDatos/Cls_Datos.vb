Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidades
Public Class Cls_Datos
    Public cn As New SqlConnection("Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=BDSeminarioI;Integrated Security=True")

    'Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("Proyecto").ConnectionString)
    'Funcion Mostrar Datos del cliente
    Public Function D_ListarCliente() As DataTable
        Dim cmd As New SqlCommand("select * from TblCliente", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub D_InsertarCliente(enti As Cls_Entidades)
        Dim cmd As New SqlCommand("Insert into tblCliente values(@RazonSocialCli, @RucClie, @DireccionClie, @CelularCli, @FijoCli, @ZonaCli)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@RazonSocialCli", enti.RazonSocialCli)
            .AddWithValue("@RucClie", enti.RucClie)
            .AddWithValue("@DireccionClie", enti.DireccionClie)
            .AddWithValue("@CelularCli", enti.CelularCli)
            .AddWithValue("@FijoCli", enti.FijoCli)
            .AddWithValue("@ZonaCli", enti.ZonaCli)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub
    Public Sub D_ModificarCliente(enti As Cls_Entidades)
        Dim cmd As New SqlCommand("Update tblCliente set RazonSocialCli=@RazonSocialCli, RucClie=@RucClie, DireccionClie= @DireccionClie, CelularCli=@CelularCli, FijoCli=@FijoCli,ZonaCli= @ZonaCli where IdCliente=@IdCliente", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@IdCliente", enti.IdCliente)
            .AddWithValue("@RazonSocialCli", enti.RazonSocialCli)
            .AddWithValue("@RucClie", enti.RucClie)
            .AddWithValue("@DireccionClie", enti.DireccionClie)
            .AddWithValue("@CelularCli", enti.CelularCli)
            .AddWithValue("@FijoCli", enti.FijoCli)
            .AddWithValue("@ZonaCli", enti.ZonaCli)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub
    Public Sub D_EliminarCliente(enti As Cls_Entidades)
        Dim cmd As New SqlCommand("delete tblCliente where IdCliente=@IdCliente", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@IdCliente", enti.IdCliente)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub
End Class
