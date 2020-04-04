using PrettyFaceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrettyFaceApp.ViewModels
{
    public class HomePageViewModel: BaseViewModel
    {
        public List<Face> Faces { get; set; } = new List<Face>();
        public List<Face> FacesInverted { get; set; } = new List<Face>();
        public bool menuInvisible = true;
        public bool MenuInvisible { get { return menuInvisible; }  set { SetProperty(ref menuInvisible, value); } }

        public HomePageViewModel()
        {
            Faces = new List<Face>() {
                 new Face
                 {
                     Title = "Face 1",
                     ImageUrl = "Face1.jpg"
                 },
                 new Face
                 {
                     Title = "Face 2",
                     ImageUrl = "Face2.jpg"
                 },
                 new Face
                 {
                     Title = "Face 3",
                     ImageUrl = "Face3.jpg"
                 },
                 new Face
                 {
                     Title = "Face 4",
                     ImageUrl = "Face4.jpg"
                 },
                 new Face
                 {
                     Title = "Face 5",
                     ImageUrl = "Face5.jpg"
                 },
                 new Face
                 {
                     Title = "Face 6",
                     ImageUrl = "Face6.jpg"
                 }
                };

            FacesInverted = Faces.OrderByDescending(f => f.Title).ToList();
        }
    }
}
