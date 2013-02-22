
Partial Class index
    Inherits System.Web.UI.Page


    Protected Sub CalculateButton_Click(sender As Object, e As System.EventArgs) Handles CalculateButton.Click

        'Declare variables'
            Dim hours As Decimal = HoursTextBox.Text
            Dim wage As Decimal = WageTextBox.Text
            Dim pretax As Decimal = PreTaxTextBox.Text / 100
        Dim aftertax As Decimal = AfterTaxTextBox.Text / 100

        'Declare result variable and calculate result'
            Dim result As Decimal = ((hours * wage) * (1 - pretax)) * (1 - aftertax)

        'Display result in result label'
            ResultLabel.Text = "Your salary payment for this week is $" & result.ToString("#,###.##") & "!"

    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As System.EventArgs) Handles ClearButton.Click

        'Clear all textboxes plus the resultlabel'
        HoursTextBox.Text = " "
        WageTextBox.Text = " "
        PreTaxTextBox.Text = " "
        AfterTaxTextBox.Text = " "
        ResultLabel.Text = " "


    End Sub

    Private Function MessageBox() As Object
        Throw New NotImplementedException
    End Function

    Private Function MessageBoxButtons() As Object
        Throw New NotImplementedException
    End Function

    Private Function MessageBoxIcon() As Object
        Throw New NotImplementedException
    End Function

End Class
