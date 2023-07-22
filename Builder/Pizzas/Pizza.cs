namespace Builder.Pizzas;

public class Pizza
{
	private string name;

	public string Name
	{
		set { name = value; }
	}

	private PizzaType type;

	public PizzaType Type
	{
		set { type = value; }
	}

	private bool isSpicy;

	public bool IsSpicy
	{
		set { isSpicy = value; }
	}

	public override string ToString()
	{
		var IsSpicyString =
			isSpicy ? "Yes" : "No";

		var result =
			$"Pizza: {name} - Type: {type} - IsSpicy: {IsSpicyString}";

		return result;
	}
}
