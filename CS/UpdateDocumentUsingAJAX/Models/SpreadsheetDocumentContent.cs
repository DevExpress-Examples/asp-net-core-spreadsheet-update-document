using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdateDocumentUsingAJAX.Models
{
    public class SpreadsheetDocumentContent
    {
        public string DocumentId { get; set; }
        public Func<byte[]> ContentAccessorByBytes { get; set; }
        public DocumentFormat DocumentFormat { get; set; } = DocumentFormat.Xlsx;

        public SpreadsheetDocumentContent(string documentId) {
            DocumentId = documentId;
        }
        
        public SpreadsheetDocumentContent(string documentId, Func<byte[]> contentAccessorByBytes) {
            DocumentId = documentId;
            ContentAccessorByBytes = contentAccessorByBytes;
        }

    }
}
