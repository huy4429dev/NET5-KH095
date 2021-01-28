using System;

namespace KH095.ViewModels
{
    public class PostIndexViewModel
    {

         public int Id {get;set;}
         public string Title {get;set;}
         public string Thumbnail {get;set;}
         public string Description {get;set;}
         public string Author{get;set;}
         public DateTime CreatedAt{get;set;}
    }
}