using System.Data;

namespace CSVDownload.Pages
{
    public class CsvCreator
    {
        public static DataTable createDataTable()
        {
            // this method creates a data table
            DataTable myDataTable = new DataTable();

            myDataTable.Columns.Add("DATE", typeof(string));
            myDataTable.Columns.Add("TITLE", typeof(string));
            myDataTable.Columns.Add("AUTHOR", typeof(string));

            myDataTable.Rows.Add("2020-12-29", "Gatsby Shadowing", "Ilyana");
            myDataTable.Rows.Add("2021-02-23", "This is a blog post", "Joe");
            myDataTable.Rows.Add("1957-03-05", "There and back again", "Bilbo Baggins");
            myDataTable.Rows.Add("2000-01-01", "That's no moon", "Obi-Wan Kenobi");

            return myDataTable;
        }
        
    }
}
