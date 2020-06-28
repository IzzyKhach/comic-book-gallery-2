using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commic_Book_Gallery_2.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            //by only defining a getter and not a setter, the variable is read only
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            //by only defining a getter and not a setter, the variable is read only
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}
