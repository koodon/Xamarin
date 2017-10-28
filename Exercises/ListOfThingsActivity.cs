using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Exercises
{
    [Activity(Label = "ListOfThingsActivity")]
    public class ListOfThingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListOfThingsLayout);
            var ourList = FindViewById<ListView>(Resource.Id.listView1);

            //private List<Car> GenerateCars()
            //{
            //    var ListOfCars = new List<Car>();

            //    var car1 = new Car();
            //    car1.Name = "BMW";
            //    car1.Kw = "333";
            //    ListOfCars.Add(car1);

            //    var car2 = new Car();
            //    car2.Name = "Audi";
            //    car2.Kw = "322";
            //    ListOfCars.Add(car1);

            //    var car3 = new Car();
            //    car3.Name = "Lada";
            //    car3.Kw = "236";
            //    ListOfCars.Add(car1);

            //    var car4 = new Car();
            //    car4.Name = "Volvo";
            //    car4.Kw = "134";
            //    ListOfCars.Add(car1);

            //    var car5 = new Car();
            //    car5.Name = "Mercedes";
            //    car5.Kw = "357";
            //    ListOfCars.Add(car1);
            //}
            
            var items = new string[] { "Audi", "BMW", "Mercedes", "Lada", "Volvo" };
            ourList.Adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
            ourList.ItemClick += OurList_ItemClick;
        }

        private void OurList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Android.Widget.Toast.MakeText(this, "Vajutasid", Android.Widget.ToastLength.Short).Show();
        }
    }
}