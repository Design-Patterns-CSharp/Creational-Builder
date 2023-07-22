using Builder.Pizzas;

namespace Builder;

public class Chef
{
	private readonly IPizzaBuilder pizzaBuilder;
	public Chef(IPizzaBuilder pizzaBuilder)
	{
		this.pizzaBuilder = pizzaBuilder;
	}

	public Pizza MakePizza()
	{
		pizzaBuilder.SetName();

		pizzaBuilder.SetType();

		pizzaBuilder.IsSpicy();

		var pizza = pizzaBuilder.Get();

		return pizza;
	}

}
