using Android.App;
using Android.Widget;
using Android.OS;

namespace teine
{
    [Activity(Label = "teine", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var firstEditText = FindViewById<EditText>(Resource.Id.firstNumberEditText);
            var secondEditText = FindViewById<EditText>(Resource.Id.secondNumberEditText);
            var multiplicationButton = FindViewById<Button>(Resource.Id.multiplicationButton);
            var divideButton = FindViewById<Button>(Resource.Id.divideButton);
            var addButton = FindViewById<Button>(Resource.Id.addButton);
            var subtractButton = FindViewById<Button>(Resource.Id.subtractButton);
            var resultTextView = FindViewById<TextView>(Resource.Id.resultsTextView);
            //firstEditText.Text = "blah";

            subtractButton.Click += delegate
            {
                double allText = double.Parse(firstEditText.Text) - double.Parse(secondEditText.Text);
                resultTextView.Text = allText.ToString();
            };

            divideButton.Click += delegate
            {
                double allText = double.Parse(firstEditText.Text) / double.Parse(secondEditText.Text);
                resultTextView.Text = allText.ToString();
            };

            addButton.Click += delegate
            {
                double allText = double.Parse(firstEditText.Text) + double.Parse(secondEditText.Text);
                resultTextView.Text = allText.ToString();
            };

            multiplicationButton.Click += delegate
            {
                double allText = double.Parse(firstEditText.Text) * double.Parse(secondEditText.Text);
                resultTextView.Text = allText.ToString();
            };
        }
    }
}

