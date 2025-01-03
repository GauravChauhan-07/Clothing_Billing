Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Customer Id"
        Label2.Text = "Name"
        Label3.Text = "Address"
        Label4.Text = "Email"
        Label5.Text = "Phone No"
        Label6.Text = "Product Name"
        Label7.Text = "Quantity"
        Label8.Text = "Catoegory"
        Label9.Text = "Mrp"
        Label10.Text = "Gst"
        Label11.Text = "Discount"
        Label12.Text = "Bill Generation"
        Label12.Font = New Font("Arial", 26, FontStyle.Bold)
        Label13.Text = "Bill No"
        Label14.Text = ""
        Label15.Text = "Emp Id"
        Label16.Text = ""
        Label17.Text = "Date :"

        Label19.Text = "Time :"
        ' Display current date
        Label18.Text = DateTime.Now.ToShortDateString()

        ' Display current time
        Label20.Text = DateTime.Now.ToLongTimeString()

        Button1.Text = "Add"
        Button2.Text = "Modify"
        Button3.Text = "Delete"
        Button4.Text = "Cancel"


        Label21.Text = "Total Gst :"
        Label23.Text = "Items :"
        Label24.Text = "Total Quantity :"
        Label25.Text = "Amount :"
        Label26.Text = "Total Discount :"
        Label27.Text = "Total Amount :"






        ListView1.Columns.Add("Name", 190, HorizontalAlignment.Center)
        ListView1.Columns.Add("Category", 190, HorizontalAlignment.Center)
        ListView1.Columns.Add("Quantity", 170, HorizontalAlignment.Center)
        ListView1.Columns.Add("Discount", 140, HorizontalAlignment.Center)
        ListView1.Columns.Add("GST", 140, HorizontalAlignment.Center)
        ListView1.Columns.Add("MRP", 140, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total Amount", 190, HorizontalAlignment.Center)

    End Sub


End Class