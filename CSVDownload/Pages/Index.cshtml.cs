using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSVDownload.Extensions;

namespace CSVDownload.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            DataTable dataTable = CsvCreator.createDataTable();

            string filePath = "BlogPostsList-" + DateTime.Today.ToString("yyyy-MM-dd") + ".csv";

            var output = dataTable.ToCsvByteArray();

            return new FileContentResult(output, "text/csv")
            {
                FileDownloadName = filePath
            };

        }
    }
}
