Imports CapaDatos
Imports CapaEntidades
Public Class Cls_Negocio
    Private objDatos As New Cls_Datos
    Public Function N_ListarCiente() As DataTable
        Return objDatos.D_ListarCliente
    End Function
    Public Sub N_InsertarCliente(enti As Cls_Entidades)
        objDatos.D_InsertarCliente(enti)
    End Sub
    Public Sub N_ModificarCliente(enti As Cls_Entidades)
        objDatos.D_ModificarCliente(enti)
    End Sub
    Public Sub N_EliminarCliente(enti As Cls_Entidades)
        objDatos.D_EliminarCliente(enti)
    End Sub
End Class
