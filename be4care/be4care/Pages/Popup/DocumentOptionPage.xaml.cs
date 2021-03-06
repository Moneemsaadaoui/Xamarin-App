using be4care.Models;
using be4care.PageModels;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace be4care.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DocumentOptionPage : PopupPage
    {
		public DocumentOptionPage (Document d)
		{
			InitializeComponent ();
            BindingContext = new DocumentOptionPageModel(d);
		}
	}
}