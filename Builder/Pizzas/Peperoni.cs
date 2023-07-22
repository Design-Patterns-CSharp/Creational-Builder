namespace Builder.Pizzas;

public class Peperoni : IPizzaBuilder
{
	private readonly Pizza pizza;

	public Peperoni()
	{
		pizza = new Pizza();
	}

	public Pizza Get()
	{
		return pizza;
	}

	public void IsSpicy()
	{
		pizza.IsSpicy = true;
		Console.WriteLine("IsSpicy set in peproni");
	}

	public void SetName()
	{
		pizza.Name = "Peperoni";
		Console.WriteLine("Name set in peperoni");
	}

	public void SetType()
	{
		pizza.Type = PizzaType.American;
		Console.WriteLine("Type set in peperoni");
	}
}
