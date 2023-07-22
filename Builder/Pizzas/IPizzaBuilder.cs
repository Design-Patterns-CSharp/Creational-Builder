namespace Builder.Pizzas;

public interface IPizzaBuilder
{
	void SetName();

	void SetType();

	void IsSpicy();

	Pizza Get();
}
