Public Class ConsultNotes
    Inherits System.Web.UI.Page

    Dim DC As New DCDataContext

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Accroche()
            Dim lis = DC.Matieres.ToList
            Dim listEns As New List(Of Object)


            For Each elt As Matiere In lis
                listEns.Add(New With {.Intitule = elt.Intitule, _
                            .Credit = elt.Credit, _
                            .Plan_Cour = elt.Plan_Cour, _
                            .Id_Enseignant = "Mr " & elt.Enseignant.Personne.Nom & " " & elt.Enseignant.Personne.Prenom})
                'If elt.Enseignant.Personne.Sexe = "Masculin" Then
                '    listEns.Add(New With {.Id_Enseignant = "Mr " & elt.Enseignant.Personne.Nom})
                'End If
            Next
            Gdv.DataSource = listEns
            Gdv.DataBind()

        End If
    End Sub
    Sub Accroche()

        Dim liste As New List(Of Object)
        For Each elt As Note In DC.Notes.ToList
            liste.Add(New With { _
                      .Matricule = elt.Etudiant.Personne.Matricule, _
                      .Nom = elt.Etudiant.Personne.Nom, _
                      .Prenom = elt.Etudiant.Personne.Prenom, _
                      .Cc1 = elt.CC1, _
                      .Trimestre = elt.Trimestre, _
                      .Cc2 = elt.CC2, _
                      .Exam = elt.Exam})
        Next
        GDV1.DataSource = liste
        GDV1.DataBind()

    End Sub
   
    Private Sub Gdv_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gdv.SelectedIndexChanged
        Dim liste As List(Of Note) = DC.Notes.ToList

        Dim query = From elt In liste Where elt.Matiere.Id = elt.Id_Matiere Select elt

        Dim i As Integer = 0

        If query.Count = 0 Then
            ' MsgBox("Aucune Note")
        Else
            Accroche()
            MVMatiere.ActiveViewIndex = 1
        End If



    End Sub
End Class