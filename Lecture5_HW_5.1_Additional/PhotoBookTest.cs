using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_HW_5._1_Additional
{
    internal class PhotoBookTest
    {
        public int CreateDefaultPhotoBook()
        {
            var book = new PhotoBook();
            return book.GetNumberPages();
        }

        public int Create24PagesPhotoBook()
        {
            var book = new PhotoBook(24);
            return book.GetNumberPages();
        }

        public int CreateBigPhotoBook()
        {
            var book = new BigPhotoBook();
            return book.GetNumberPages();
        }

    }
}
