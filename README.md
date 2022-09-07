# Spreadsheet for ASP.NET Core - How to use AJAX requests to update document content

Use AJAX requests to modify the Spreadsheet control's content. In this example, the control creates a document and edits its cells after a user clicks an external button. 

![ASP.NET Core Spreadsheet update the control's content](/images/update-spreadsheet-document.gif)

## Overview

Follow the steps below to update the Spreadsheet's document content after a user clicks a button.

### 1. Send a POST request to the server

Place the [Spreadsheet](https://docs.devexpress.com/AspNetCore/400375/spreadsheet) control in a partial view and reference it in a markup page. Add a [button](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/button) to this page and handle its [click](https://developer.mozilla.org/en-US/docs/Web/API/Element/click_event) event. In the event handler, call the [getSpreadsheetState](https://docs.devexpress.com/AspNetCore/js-DevExpress.AspNetCore.Spreadsheet.Spreadsheet?p=netframework#js_devexpress_aspnetcore_spreadsheet_spreadsheet_getspreadsheetstate) method to get the Spreadsheet's client state, then send it with the POST request to the server.

### 2. Process the request on the server

On the server, get the server-side [Spreadsheet](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet?p=netframework) object from the control's client state. Call the [New](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet.New?p=netframework) method to create a document. Use the following properties to access and edit the new document's structural elements:

* [Document](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet.Document)  
Returns an open [workbook](https://docs.devexpress.com/OfficeFileAPI/14921/spreadsheet-document-api/spreadsheet-document/workbook).

* [Worksheets](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.IWorkbook.Worksheets)  
Returns the collection of [worksheets](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet) in a [workbook](https://docs.devexpress.com/OfficeFileAPI/14921/spreadsheet-document-api/spreadsheet-document/workbook).

* [Rows](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Rows)  
Returns the collection of [rows](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Row) in a [worksheet](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet).

* [Columns](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Columns)  
Returns the collection of [columns](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Column) in a [worksheet](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet).

* [Cells](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Cells)  
Returns the collection of [cells](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Cell) in a [worksheet](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet).

* [Range](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.Range)  
Returns the [range of cells](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange) in the [worksheet](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet).

### 3. Send a response back to the client

A new document has no identifier. The control cannot automatically save such a document and stores its content until you open or create another document.

Call the [SaveCopy](https://docs.devexpress.com/AspNet/DevExpress.Web.Office.SpreadsheetDocumentInfo.SaveCopy?p=netframework) method to save the document content to a byte array. Generate a unique string identifier and save it and the byte array to a document model. Pass this model to the [PartialView](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.controller.partialview?view=aspnet-mvc-5.2) method to create an object that renders the Spreadsheet. Send this object as a response back to the client.

## Files to Look At

- [Index.cshtml](./CS/UpdateDocumentUsingAJAX/Views/Home/Index.cshtml)
- [HomeController.cs](./CS/UpdateDocumentUsingAJAX/Controllers/HomeController.cs)
- [SpreadsheetDocumentContent.cs](./CS/UpdateDocumentUsingAJAX/Models/SpreadsheetDocumentContent.cs)
- [SpreadsheetPartialView.cshtml](./CS/UpdateDocumentUsingAJAX/Views/Home/SpreadsheetPartialView.cshtml)

## Documentation

- []()
- []()

## More Examples

- []()