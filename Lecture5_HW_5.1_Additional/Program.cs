using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Lecture5_HW_5._1_Additional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a C# program to manage a photo book using object-oriented programming.
            //To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.
            //The default constructor will create an album with 16 pages.There will be an additional constructor, with which we can specify the number of pages we want in the album.
            //There is also a BigPhotoBook class whose constructor will create an album with 64 pages.
            //Finally create a PhotoBookTest class to perform the following actions:
            //Create a default photo book and show the number of pages
            //Create a photo book with 24 pages and show the number of pages
            //Create a large photo book and show the number of pages

            var testClass = new PhotoBookTest();

            Console.WriteLine($"Default PhotoBook: {testClass.CreateDefaultPhotoBook()}");
            Console.WriteLine($"24 Pages PhotoBook: {testClass.Create24PagesPhotoBook()}");
            Console.WriteLine($"Big PhotoBook: {testClass.CreateBigPhotoBook()}");


        }
    }
}
