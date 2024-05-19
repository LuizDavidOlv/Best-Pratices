﻿namespace src.SOLID._3_LiskovSubstitution.SqlFilesExample.LspViolation
{
    public class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            /* Code to read text from sql file */
            return "Text sucessfully loaded.";
        }
        public string SaveText()
        {
            /* Code to save text into sql file */
            return "Text sucessfully saved.";
        }
    }
}
