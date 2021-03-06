﻿using Xamarin.Forms;

namespace EntryUITest
{
    public class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
    {
        public BaseContentPage(in string title)
        {
            BindingContext = ViewModel;
            Title = title;
        }

        protected TViewModel ViewModel { get; } = new TViewModel();
    }
}
