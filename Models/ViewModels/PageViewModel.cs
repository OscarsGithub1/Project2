﻿using Project2.Models.Pages;
using Project2.Models.Pages;
using Project2.Models.ViewModels;

namespace Project2.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }

        public LayoutModel Layout { get; set; }

        public IContent Section { get; set; }
    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T page) where T : SitePageData => new(page);
    }
}