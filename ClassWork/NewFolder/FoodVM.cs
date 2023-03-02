using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Compatibility;
using ClassWork.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.NewFolder
{
    public partial class FoodVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Food> foods;

        public FoodVM ()
        {
          Foods = new ObservableCollection<Food>();
            Food f = new Food();
            f.Price = 200.0m;
            f.Name = "Amala";
            f.Picture = "amalaandewedu";
            Foods.Add(f);

            Food A = new Food();
            A.Price = 150.0m;
            A.Name = "Tuwo";
            A.Picture = "tuwoandegusi";
            Foods.Add(A);

            Food M = new Food();
            M.Price = 250.0m;
            M.Name = "Jollof Rice";
            M.Picture = "jollof.jfif";
            Foods.Add(M);

            Food B = new Food();
            B.Price = 155.0m;
            B.Name = "Garri and Fish";
            B.Picture = "garriAndfish";
            Foods.Add(B);


            Food C = new Food();
            C.Price = 199.9m;
            C.Name = "Yam and Egg";
            C.Picture = "yam and egg";
            Foods.Add(C);

            Food D = new Food();
            D.Price = 230.0m;
            D.Name = "Bread And Beans";
            D.Picture = "breadAndbeans";
            Foods.Add(D);

            Food E = new Food();
            E.Price = 250.0m;
            E.Name = "Fried Rice";
            E.Picture = "friedrice";
            Foods.Add(E);

            Food G = new Food();
            G.Price = 350.0m;
            G.Name = "Poundedyam & Ogbono";
            G.Picture = "poundedandogbono";
            Foods.Add(G);

            Food H = new Food();
            H.Price = 280.0m;
            H.Name = "Semo & Vegetables";
            H.Picture = "semoveandgetables";
            Foods.Add(H);

            Food I = new Food();
            I.Price = 280.0m;
            I.Name = "Eba & Egusi";
            I.Picture = "ebaegusi";
            Foods.Add(I);

            Food J = new Food();
            J.Price = 300.0m;
            J.Name = "Pizza";
            J.Picture = "pizza";
            Foods.Add(J);

            Food K = new Food();
            K.Price = 150.0m;
            K.Name = "Tuwoshinkafa";
            K.Picture = "tuwondegusi";
            Foods.Add(K);

            Food L = new Food();
            L.Price = 250.0m;
            L.Name = "Garri & Bean";
            L.Picture = "garribean";
            Foods.Add(L);

            Food N = new Food();
            N.Price = 350.0m;
            N.Name = "Amala & Abula";
            N.Picture = "amalabula";
            Foods.Add(N);

            //   Food O = new Food();
            //  Foods.Add(O);
        }

    }
    
}
