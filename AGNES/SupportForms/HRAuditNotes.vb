Public Class HRAuditNotes
    Public Property CatNum As Byte
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ct1 As Byte
        If btnSave.Text = "Save" Then
            HRAudit.auditnotes(CatNum) = rtxtNotes.Text
            If rtxtNotes.Text = "" Then
                HRAudit.auditnotes(CatNum) = "None"
                For ct1 = 0 To 15
                    If HRAudit.auditnotes(ct1) = "None" Then
                        HRAudit.sslblNotes.Text = ""
                        HRAudit.sslblNotes.Visible = False
                    Else
                        HRAudit.sslblNotes.Text = ""
                        HRAudit.sslblNotes.Visible = False
                    End If
                Next ct1
                HRAudit.panAudit.Controls("pbxCat" & CatNum + 1).Visible = False
                HRAudit.ChangesMade = True
                HRAudit.sslblSaveStatus.Text = "Not saved"
            Else
                With HRAudit
                    .auditnotes(CatNum) = rtxtNotes.Text
                    .sslblNotes.Text = "Notes are present"
                    .sslblNotes.Visible = True
                    .panAudit.Controls("pbxCat" & CatNum + 1).Visible = True
                End With
            End If
        End If
        Close()
    End Sub
End Class