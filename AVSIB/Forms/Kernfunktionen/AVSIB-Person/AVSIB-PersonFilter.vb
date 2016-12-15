Public Class AVSIB_PersonFilter
    Private Sub AVSIB_PersonFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBName_CheckStateChanged(sender As Object, e As EventArgs) Handles CBName.CheckStateChanged
        If CBName.Checked = True Then
            LFirstName.Visible = True
            LLastName.Visible = True
            LCity.Visible = False
            LZIP.Visible = False
            LStreet.Visible = False
            ComboBox3.Visible = False
            ComboBox3.Text = Nothing
            CBAdress.Checked = False
        End If
    End Sub

    Private Sub CBAdress_CheckStateChanged(sender As Object, e As EventArgs) Handles CBAdress.CheckStateChanged
        If CBAdress.Checked = True Then
            LFirstName.Visible = False
            LLastName.Visible = False
            LCity.Visible = True
            LZIP.Visible = True
            LStreet.Visible = True
            ComboBox3.Visible = True
            CBName.Checked = False
        End If
    End Sub
End Class