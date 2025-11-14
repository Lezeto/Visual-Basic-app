Public Class frmPrincipal
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim lado As Double
        Dim perimetro As Double
        Dim area As Double

        If String.IsNullOrWhiteSpace(txtLado.Text) Then
            MessageBox.Show("Ingrese el valor del lado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLado.Focus()
            Return
        End If

        If Not Double.TryParse(txtLado.Text.Trim(), lado) Then
            MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLado.SelectAll()
            txtLado.Focus()
            Return
        End If

        If lado < 0 Then
            MessageBox.Show("El lado no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLado.SelectAll()
            txtLado.Focus()
            Return
        End If

        perimetro = 4 * lado
        area = lado * lado

        txtPerimetro.Text = perimetro.ToString("G")
        txtArea.Text = area.ToString("G")
    End Sub

End Class
