<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1113523)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Spreadsheet for ASP.NET Core - How to use AJAX requests to update document content

You can use AJAX requests to modify the Spreadsheet control's content. In this example, the control sends a POST request after a click on an external button. In response to this request, the control creates a document and edits its cells.

![ASP.NET Core Spreadsheet update the control's content](/images/update-spreadsheet-document.gif)

## Overview

Follow the steps below to update the Spreadsheet control's document content once a user clicks a button.

### 1. Send a POST request to the server

Place the [Spreadsheet](https://docs.devexpress.com/AspNetCore/400375/spreadsheet) control in a partial view and reference the view in a markup page. Add a [button](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/button) to this page. In the button's [click](https://developer.mozilla.org/en-US/docs/Web/API/Element/click_event) event handler, get the Spreadsheet's [client state](https://docs.devexpress.com/AspNetCore/js-DevExpress.AspNetCore.Spreadsheet.Spreadsheet?p=netframework#js_devexpress_aspnetcore_spreadsheet_spreadsheet_getspreadsheetstate) and send it with a POST request to the server.

### 2. Process the request on the server

On the server, get the server-side [Spreadsheet](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet?p=netframework) object from the client state. Call the object's [New](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet.New?p=netframework) method to create an empty document. Use the following properties to access and edit the new document's structural elements:

* [Document](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet.Document)  
Returns the currently opened [workbook](https://docs.devexpress.com/OfficeFileAPI/14921/spreadsheet-document-api/spreadsheet-document/workbook).

* [Worksheets](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.IWorkbook.Worksheets)  
Returns the collection of [worksheets](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet) in a workbook.

* [Rows](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Rows)  
Returns the collection of [rows](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Row) in a worksheet.

* [Columns](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Columns)  
Returns the collection of [columns](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Column) in a worksheet.

* [Cells](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Cells)  
Returns the collection of [cells](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Cell) in a worksheet.

* [Range](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Range)  
Returns the [range of cells](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange) in a worksheet.

### 3. Send a response back to the client

A new document has an empty identifier. The control cannot save such a document and loses its content when you open or create another document. Generate a unique string identifier for this document to be able to save pending changes.

Call the [SaveCopy](https://docs.devexpress.com/AspNet/DevExpress.Web.Office.SpreadsheetDocumentInfo.SaveCopy?p=netframework) method to export the document content to a byte array. Write the generated identifier and the byte array to a document model. Pass this model to the [PartialView](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.controller.partialview?view=aspnet-mvc-5.2) method to create an object that renders the Spreadsheet. Send this object back to the client as a response.

## Files to Look At

- [Index.cshtml](./CS/UpdateDocumentUsingAJAX/Views/Home/Index.cshtml)
- [HomeController.cs](./CS/UpdateDocumentUsingAJAX/Controllers/HomeController.cs)
- [SpreadsheetDocumentContent.cs](./CS/UpdateDocumentUsingAJAX/Models/SpreadsheetDocumentContent.cs)
- [SpreadsheetPartialView.cshtml](./CS/UpdateDocumentUsingAJAX/Views/Home/SpreadsheetPartialView.cshtml)

## Documentation

- [Spreadsheet](https://docs.devexpress.com/AspNetCore/400375/spreadsheet)

## More Examples

- [How to Dockerize an Office File API Application](https://github.com/DevExpress-Examples/dockerize-office-file-api-app)
