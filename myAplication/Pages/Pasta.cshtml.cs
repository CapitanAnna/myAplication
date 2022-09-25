using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myAplication.Models;

namespace myAplication.Pages
{
    public class PastaModel : PageModel
    {
        public List<PastasModel> myPastaDB=new List<PastasModel>() 
        { 
            new PastasModel(){
                ImageTitle="bolognesePasta",
                PastaName="Bolognese",
                BasePrice=70,
                TomatoSauce=true, TotalPrice=90},
            new PastasModel(){
                ImageTitle="carbonaraPasta",
                PastaName="Carbonara",
                BasePrice=70,
                Cheese=true, TotalPrice=100},
            new PastasModel(){
                ImageTitle="chickenPasta",
                PastaName="Chicken",
                BasePrice=70,
                Cheese=true, TotalPrice=100},
            new PastasModel(){
                ImageTitle="hamPasta",
                PastaName="HamPasta",
                BasePrice=70,
                Ham=true,
                Cheese=true, TotalPrice=135},
            new PastasModel(){
                ImageTitle="mushroomPasta",
                PastaName="MushroomPasta",
                BasePrice=70,
                Mushroom=true, TotalPrice=90},
            new PastasModel(){
                ImageTitle="seafoodPsta",
                PastaName="SeafoodPasta",
                BasePrice=70,
                Tuna=true, TotalPrice=110},
            new PastasModel(){
                ImageTitle="shrimpPasta",
                PastaName="ShrimpPasta",
                BasePrice=70,
                TomatoSauce=true,
                Cheese=true, TotalPrice=120},
            new PastasModel(){
                ImageTitle="tomatoPasta",
                PastaName="TomatoPasta",
                BasePrice=70,
                TomatoSauce=true,
                Ham=true, TotalPrice=125},
            new PastasModel(){
                ImageTitle="vegetarianPasta",
                PastaName="Vegetarian",
                BasePrice=70,
                TomatoSauce=true, TotalPrice=90},
        };
        public void OnGet()
        {
        }
    }
}
