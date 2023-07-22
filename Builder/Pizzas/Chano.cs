namespace Builder.Pizzas;

public class Chano : IPizzaBuilder
{
	private readonly Pizza pizza;

	public Chano()
	{
		pizza = new Pizza();
	}

	public Pizza Get()
	{
		return pizza;
	}

	public void IsSpicy()
	{
		pizza.IsSpicy = false;
		Console.WriteLine("IsSpicy set in chano");
	}

	public void SetName()
	{
		pizza.Name = "Chano";
		Console.WriteLine("Name set in chano");
	}

	public void SetType()
	{
		pizza.Type = PizzaType.Italian;
		Console.WriteLine("Type set in chano");
	}
}
