using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_HW_5._1_Additional
{
    internal class PhotoBook
    {
        private int numPages {  get; set; }

        public PhotoBook() 
        {
            this.numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
