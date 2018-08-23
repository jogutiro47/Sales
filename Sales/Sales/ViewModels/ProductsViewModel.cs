namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using Sales.Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;

        //Atributo privado
        private ObservableCollection<Product> products;



        //La propiedad pùblica
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
           // this.IsRefreshing = true;
            var response = await this.apiService.GetList<Product>("https://salesapijg.azurewebsites.net/", "/api","/Products");

            if (!response.IsSuccess)
            {
                //this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }


            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
        }

            
        }
    
}
