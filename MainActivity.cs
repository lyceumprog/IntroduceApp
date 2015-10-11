using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace IntroduceApp
{
	[Activity (Label = "IntroduceApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1; // Объявление числовой переменной

		protected override void OnCreate (Bundle bundle) // Функция, выполняющаяся при загрузке окна
		{
			base.OnCreate (bundle); // Запуск функции, которая совершает все необходимые при загрузке окна действия

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main); // Подключение к файлу интерфейса

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton); // Получение ссылки на элемент интерфейса (кнопку)
			TextView textview = FindViewById<TextView> (Resource.Id.textView1);

			button.Click += delegate {
				textview.Text = "First App!!!!!!!!!!!!!!!!!!!111111";
			};
		}
	}
}


