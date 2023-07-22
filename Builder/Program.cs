using Builder.Pizzas;

namespace Builder;

internal class Program
{
	static void Main(string[] args)
	{
		//Peperoni
		Chef chef = new Chef(pizzaBuilder: new Peperoni());

		var peperoniPizza = chef.MakePizza();

		Console.WriteLine(peperoniPizza.ToString() + Environment.NewLine);

		//Chano

		chef = new Chef(pizzaBuilder: new Chano());

		var chanoPizza = chef.MakePizza();

		Console.WriteLine(chanoPizza.ToString());
	}
}

/*
 * برای جلوگیری از داشتن حالات زیاد برای کانستراکتور
 * با ورودی های مختلف و جلوگیری از به وجود آمدن آنتی پترن 
 * که با داشتن حالات زیاد کانستراکتور به وجود می آید
 * ورودی ها در یک کلاس مبنا به عنوان پراپرتی مقدار دهی میشوند و حالات مختلف به
 * صورت کلاس های مجزا ساخته میشوند
 * که نهایتا در کلاسی که به عنوان بیلدر در نظر گرفته میشود٬ حالت های مختلف را 
 * ست میکنیم و در کلاس دیگر که عهده دار ساخت این کلاس ها میباشد با کانستراکتر ورودی از جنس اینترفیس این کلاس ها پراپرتی ها را
 * با ترتیب مورد نظر ست میکنیم
 */