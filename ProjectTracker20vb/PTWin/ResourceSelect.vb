Imports System.Windows.Forms

Public Class ResourceSelect

  Private mResourceId As String
  Public ReadOnly Property ResourceId() As String
    Get
      Return mResourceId
    End Get
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

    mResourceId = CType(Me.ResourceListListBox.SelectedValue, ResourceList.ResourceInfo).Id
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()

  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()

  End Sub

  Private Sub ResourceSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Me.ResourceListBindingSource.DataSource = ResourceList.GetResourceList

  End Sub

End Class
