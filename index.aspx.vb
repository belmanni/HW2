
Partial Class index
    Inherits System.Web.UI.Page




    Protected Sub CalculateButton_Click(sender As Object, e As System.EventArgs) Handles CalculateButton.Click

        Dim hours As Decimal = HoursTextBox.Text
        Dim wage As Decimal = WageTextBox.Text
        Dim pretax As Decimal = PreTaxTextBox.Text / 100
        Dim aftertax As Decimal = AfterTaxTextBox.Text / 100
        Dim result As Decimal =  ((hours * wage) * (1 - pretax)) * (1 - aftertax)

        ResultLabel.Text = "Your salary payment for this week is $" & result.ToString("#,###.##")



    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As System.EventArgs) Handles ClearButton.Click
        HoursTextBox.Text = " "
        WageTextBox.Text = " "
        PreTaxTextBox.Text = " "
        AfterTaxTextBox.Text = " "
        ResultLabel.Text = " "


    End Sub
End Class
