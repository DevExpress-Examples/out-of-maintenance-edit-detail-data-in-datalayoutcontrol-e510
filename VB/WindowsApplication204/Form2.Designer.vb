Namespace WindowsApplication204
	Partial Public Class Form2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.suppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.SupplierIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.ItemForSupplierID = New DevExpress.XtraLayout.LayoutControlItem()
			Me.CompanyNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForCompanyName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ContactNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForContactName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ContactTitleTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForContactTitle = New DevExpress.XtraLayout.LayoutControlItem()
			Me.AddressTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
			Me.CityTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForCity = New DevExpress.XtraLayout.LayoutControlItem()
			Me.RegionTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForRegion = New DevExpress.XtraLayout.LayoutControlItem()
			Me.PostalCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForPostalCode = New DevExpress.XtraLayout.LayoutControlItem()
			Me.CountryTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForCountry = New DevExpress.XtraLayout.LayoutControlItem()
			Me.PhoneTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForPhone = New DevExpress.XtraLayout.LayoutControlItem()
			Me.FaxTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForFax = New DevExpress.XtraLayout.LayoutControlItem()
			Me.HomePageTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.ItemForHomePage = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dataLayoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.suppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SupplierIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForSupplierID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ContactTitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForContactTitle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.RegionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForRegion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PostalCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForPhone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.HomePageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForHomePage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataLayoutControl1
			' 
			Me.dataLayoutControl1.Controls.Add(Me.simpleButton1)
			Me.dataLayoutControl1.Controls.Add(Me.SupplierIDSpinEdit)
			Me.dataLayoutControl1.Controls.Add(Me.CompanyNameTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.ContactNameTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.ContactTitleTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.AddressTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.CityTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.RegionTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.PostalCodeTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.CountryTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.PhoneTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.FaxTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.HomePageTextEdit)
			Me.dataLayoutControl1.DataSource = Me.suppliersBindingSource
			Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.dataLayoutControl1.Name = "dataLayoutControl1"
			Me.dataLayoutControl1.Root = Me.layoutControlGroup1
			Me.dataLayoutControl1.Size = New System.Drawing.Size(354, 444)
			Me.dataLayoutControl1.TabIndex = 0
			Me.dataLayoutControl1.Text = "dataLayoutControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "Root"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForSupplierID, Me.ItemForCompanyName, Me.ItemForContactName, Me.ItemForContactTitle, Me.ItemForAddress, Me.ItemForCity, Me.ItemForRegion, Me.ItemForPostalCode, Me.ItemForCountry, Me.ItemForPhone, Me.ItemForFax, Me.ItemForHomePage, Me.simpleSeparator1, Me.layoutControlItem1, Me.emptySpaceItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(354, 444)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' SupplierIDSpinEdit
			' 
			Me.SupplierIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "SupplierID", True))
			Me.SupplierIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.SupplierIDSpinEdit.Location = New System.Drawing.Point(84, 7)
			Me.SupplierIDSpinEdit.Name = "SupplierIDSpinEdit"
			Me.SupplierIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.SupplierIDSpinEdit.Size = New System.Drawing.Size(264, 20)
			Me.SupplierIDSpinEdit.StyleController = Me.dataLayoutControl1
			Me.SupplierIDSpinEdit.TabIndex = 4
			' 
			' ItemForSupplierID
			' 
			Me.ItemForSupplierID.Control = Me.SupplierIDSpinEdit
			Me.ItemForSupplierID.CustomizationFormText = "SupplierID"
			Me.ItemForSupplierID.Location = New System.Drawing.Point(0, 0)
			Me.ItemForSupplierID.Name = "ItemForSupplierID"
			Me.ItemForSupplierID.Size = New System.Drawing.Size(352, 31)
			Me.ItemForSupplierID.Text = "SupplierID"
			Me.ItemForSupplierID.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForSupplierID.TextSize = New System.Drawing.Size(72, 20)
			' 
			' CompanyNameTextEdit
			' 
			Me.CompanyNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "CompanyName", True))
			Me.CompanyNameTextEdit.Location = New System.Drawing.Point(84, 38)
			Me.CompanyNameTextEdit.Name = "CompanyNameTextEdit"
			Me.CompanyNameTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.CompanyNameTextEdit.StyleController = Me.dataLayoutControl1
			Me.CompanyNameTextEdit.TabIndex = 5
			' 
			' ItemForCompanyName
			' 
			Me.ItemForCompanyName.Control = Me.CompanyNameTextEdit
			Me.ItemForCompanyName.CustomizationFormText = "CompanyName"
			Me.ItemForCompanyName.Location = New System.Drawing.Point(0, 31)
			Me.ItemForCompanyName.Name = "ItemForCompanyName"
			Me.ItemForCompanyName.Size = New System.Drawing.Size(352, 31)
			Me.ItemForCompanyName.Text = "CompanyName"
			Me.ItemForCompanyName.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForCompanyName.TextSize = New System.Drawing.Size(72, 20)
			' 
			' ContactNameTextEdit
			' 
			Me.ContactNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "ContactName", True))
			Me.ContactNameTextEdit.Location = New System.Drawing.Point(84, 69)
			Me.ContactNameTextEdit.Name = "ContactNameTextEdit"
			Me.ContactNameTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.ContactNameTextEdit.StyleController = Me.dataLayoutControl1
			Me.ContactNameTextEdit.TabIndex = 6
			' 
			' ItemForContactName
			' 
			Me.ItemForContactName.Control = Me.ContactNameTextEdit
			Me.ItemForContactName.CustomizationFormText = "ContactName"
			Me.ItemForContactName.Location = New System.Drawing.Point(0, 62)
			Me.ItemForContactName.Name = "ItemForContactName"
			Me.ItemForContactName.Size = New System.Drawing.Size(352, 31)
			Me.ItemForContactName.Text = "ContactName"
			Me.ItemForContactName.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForContactName.TextSize = New System.Drawing.Size(72, 20)
			' 
			' ContactTitleTextEdit
			' 
			Me.ContactTitleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "ContactTitle", True))
			Me.ContactTitleTextEdit.Location = New System.Drawing.Point(84, 100)
			Me.ContactTitleTextEdit.Name = "ContactTitleTextEdit"
			Me.ContactTitleTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.ContactTitleTextEdit.StyleController = Me.dataLayoutControl1
			Me.ContactTitleTextEdit.TabIndex = 7
			' 
			' ItemForContactTitle
			' 
			Me.ItemForContactTitle.Control = Me.ContactTitleTextEdit
			Me.ItemForContactTitle.CustomizationFormText = "ContactTitle"
			Me.ItemForContactTitle.Location = New System.Drawing.Point(0, 93)
			Me.ItemForContactTitle.Name = "ItemForContactTitle"
			Me.ItemForContactTitle.Size = New System.Drawing.Size(352, 31)
			Me.ItemForContactTitle.Text = "ContactTitle"
			Me.ItemForContactTitle.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForContactTitle.TextSize = New System.Drawing.Size(72, 20)
			' 
			' AddressTextEdit
			' 
			Me.AddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "Address", True))
			Me.AddressTextEdit.Location = New System.Drawing.Point(84, 131)
			Me.AddressTextEdit.Name = "AddressTextEdit"
			Me.AddressTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.AddressTextEdit.StyleController = Me.dataLayoutControl1
			Me.AddressTextEdit.TabIndex = 8
			' 
			' ItemForAddress
			' 
			Me.ItemForAddress.Control = Me.AddressTextEdit
			Me.ItemForAddress.CustomizationFormText = "Address"
			Me.ItemForAddress.Location = New System.Drawing.Point(0, 124)
			Me.ItemForAddress.Name = "ItemForAddress"
			Me.ItemForAddress.Size = New System.Drawing.Size(352, 31)
			Me.ItemForAddress.Text = "Address"
			Me.ItemForAddress.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForAddress.TextSize = New System.Drawing.Size(72, 20)
			' 
			' CityTextEdit
			' 
			Me.CityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "City", True))
			Me.CityTextEdit.Location = New System.Drawing.Point(84, 162)
			Me.CityTextEdit.Name = "CityTextEdit"
			Me.CityTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.CityTextEdit.StyleController = Me.dataLayoutControl1
			Me.CityTextEdit.TabIndex = 9
			' 
			' ItemForCity
			' 
			Me.ItemForCity.Control = Me.CityTextEdit
			Me.ItemForCity.CustomizationFormText = "City"
			Me.ItemForCity.Location = New System.Drawing.Point(0, 155)
			Me.ItemForCity.Name = "ItemForCity"
			Me.ItemForCity.Size = New System.Drawing.Size(352, 31)
			Me.ItemForCity.Text = "City"
			Me.ItemForCity.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForCity.TextSize = New System.Drawing.Size(72, 20)
			' 
			' RegionTextEdit
			' 
			Me.RegionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "Region", True))
			Me.RegionTextEdit.Location = New System.Drawing.Point(84, 193)
			Me.RegionTextEdit.Name = "RegionTextEdit"
			Me.RegionTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.RegionTextEdit.StyleController = Me.dataLayoutControl1
			Me.RegionTextEdit.TabIndex = 10
			' 
			' ItemForRegion
			' 
			Me.ItemForRegion.Control = Me.RegionTextEdit
			Me.ItemForRegion.CustomizationFormText = "Region"
			Me.ItemForRegion.Location = New System.Drawing.Point(0, 186)
			Me.ItemForRegion.Name = "ItemForRegion"
			Me.ItemForRegion.Size = New System.Drawing.Size(352, 31)
			Me.ItemForRegion.Text = "Region"
			Me.ItemForRegion.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForRegion.TextSize = New System.Drawing.Size(72, 20)
			' 
			' PostalCodeTextEdit
			' 
			Me.PostalCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "PostalCode", True))
			Me.PostalCodeTextEdit.Location = New System.Drawing.Point(84, 224)
			Me.PostalCodeTextEdit.Name = "PostalCodeTextEdit"
			Me.PostalCodeTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.PostalCodeTextEdit.StyleController = Me.dataLayoutControl1
			Me.PostalCodeTextEdit.TabIndex = 11
			' 
			' ItemForPostalCode
			' 
			Me.ItemForPostalCode.Control = Me.PostalCodeTextEdit
			Me.ItemForPostalCode.CustomizationFormText = "PostalCode"
			Me.ItemForPostalCode.Location = New System.Drawing.Point(0, 217)
			Me.ItemForPostalCode.Name = "ItemForPostalCode"
			Me.ItemForPostalCode.Size = New System.Drawing.Size(352, 31)
			Me.ItemForPostalCode.Text = "PostalCode"
			Me.ItemForPostalCode.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForPostalCode.TextSize = New System.Drawing.Size(72, 20)
			' 
			' CountryTextEdit
			' 
			Me.CountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "Country", True))
			Me.CountryTextEdit.Location = New System.Drawing.Point(84, 255)
			Me.CountryTextEdit.Name = "CountryTextEdit"
			Me.CountryTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.CountryTextEdit.StyleController = Me.dataLayoutControl1
			Me.CountryTextEdit.TabIndex = 12
			' 
			' ItemForCountry
			' 
			Me.ItemForCountry.Control = Me.CountryTextEdit
			Me.ItemForCountry.CustomizationFormText = "Country"
			Me.ItemForCountry.Location = New System.Drawing.Point(0, 248)
			Me.ItemForCountry.Name = "ItemForCountry"
			Me.ItemForCountry.Size = New System.Drawing.Size(352, 31)
			Me.ItemForCountry.Text = "Country"
			Me.ItemForCountry.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForCountry.TextSize = New System.Drawing.Size(72, 20)
			' 
			' PhoneTextEdit
			' 
			Me.PhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "Phone", True))
			Me.PhoneTextEdit.Location = New System.Drawing.Point(84, 286)
			Me.PhoneTextEdit.Name = "PhoneTextEdit"
			Me.PhoneTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.PhoneTextEdit.StyleController = Me.dataLayoutControl1
			Me.PhoneTextEdit.TabIndex = 13
			' 
			' ItemForPhone
			' 
			Me.ItemForPhone.Control = Me.PhoneTextEdit
			Me.ItemForPhone.CustomizationFormText = "Phone"
			Me.ItemForPhone.Location = New System.Drawing.Point(0, 279)
			Me.ItemForPhone.Name = "ItemForPhone"
			Me.ItemForPhone.Size = New System.Drawing.Size(352, 31)
			Me.ItemForPhone.Text = "Phone"
			Me.ItemForPhone.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForPhone.TextSize = New System.Drawing.Size(72, 20)
			' 
			' FaxTextEdit
			' 
			Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "Fax", True))
			Me.FaxTextEdit.Location = New System.Drawing.Point(84, 317)
			Me.FaxTextEdit.Name = "FaxTextEdit"
			Me.FaxTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.FaxTextEdit.StyleController = Me.dataLayoutControl1
			Me.FaxTextEdit.TabIndex = 14
			' 
			' ItemForFax
			' 
			Me.ItemForFax.Control = Me.FaxTextEdit
			Me.ItemForFax.CustomizationFormText = "Fax"
			Me.ItemForFax.Location = New System.Drawing.Point(0, 310)
			Me.ItemForFax.Name = "ItemForFax"
			Me.ItemForFax.Size = New System.Drawing.Size(352, 31)
			Me.ItemForFax.Text = "Fax"
			Me.ItemForFax.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForFax.TextSize = New System.Drawing.Size(72, 20)
			' 
			' HomePageTextEdit
			' 
			Me.HomePageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.suppliersBindingSource, "HomePage", True))
			Me.HomePageTextEdit.Location = New System.Drawing.Point(84, 348)
			Me.HomePageTextEdit.Name = "HomePageTextEdit"
			Me.HomePageTextEdit.Size = New System.Drawing.Size(264, 20)
			Me.HomePageTextEdit.StyleController = Me.dataLayoutControl1
			Me.HomePageTextEdit.TabIndex = 15
			' 
			' ItemForHomePage
			' 
			Me.ItemForHomePage.Control = Me.HomePageTextEdit
			Me.ItemForHomePage.CustomizationFormText = "HomePage"
			Me.ItemForHomePage.Location = New System.Drawing.Point(0, 341)
			Me.ItemForHomePage.Name = "ItemForHomePage"
			Me.ItemForHomePage.Size = New System.Drawing.Size(352, 31)
			Me.ItemForHomePage.Text = "HomePage"
			Me.ItemForHomePage.TextLocation = DevExpress.Utils.Locations.Left
			Me.ItemForHomePage.TextSize = New System.Drawing.Size(72, 20)
			' 
			' simpleSeparator1
			' 
			Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
			Me.simpleSeparator1.Location = New System.Drawing.Point(0, 407)
			Me.simpleSeparator1.Name = "simpleSeparator1"
			Me.simpleSeparator1.Size = New System.Drawing.Size(352, 2)
			Me.simpleSeparator1.Text = "simpleSeparator1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(7, 416)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(341, 22)
			Me.simpleButton1.StyleController = Me.dataLayoutControl1
			Me.simpleButton1.TabIndex = 16
			Me.simpleButton1.Text = "Accept"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.simpleButton1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 409)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(352, 33)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 372)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(352, 35)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(354, 444)
			Me.Controls.Add(Me.dataLayoutControl1)
			Me.Name = "Form2"
			Me.Text = "Form2"
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dataLayoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.suppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SupplierIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForSupplierID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ContactTitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForContactTitle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.RegionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForRegion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PostalCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForPhone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.HomePageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForHomePage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		'private nwindDataSet nwindDataSet;
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private suppliersBindingSource As System.Windows.Forms.BindingSource
		Private SupplierIDSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private CompanyNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private ContactNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private ContactTitleTextEdit As DevExpress.XtraEditors.TextEdit
		Private AddressTextEdit As DevExpress.XtraEditors.TextEdit
		Private CityTextEdit As DevExpress.XtraEditors.TextEdit
		Private RegionTextEdit As DevExpress.XtraEditors.TextEdit
		Private PostalCodeTextEdit As DevExpress.XtraEditors.TextEdit
		Private CountryTextEdit As DevExpress.XtraEditors.TextEdit
		Private PhoneTextEdit As DevExpress.XtraEditors.TextEdit
		Private FaxTextEdit As DevExpress.XtraEditors.TextEdit
		Private HomePageTextEdit As DevExpress.XtraEditors.TextEdit
		Private ItemForSupplierID As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForCompanyName As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForContactName As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForContactTitle As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForAddress As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForCity As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForRegion As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForPostalCode As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForCountry As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForPhone As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForFax As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForHomePage As DevExpress.XtraLayout.LayoutControlItem
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace