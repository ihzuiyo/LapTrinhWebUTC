using Microsoft.AspNetCore.Mvc;
using DangHuy_TH3_Step_by_Step.Models;

namespace DangHuy_TH3_Step_by_Step.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}
