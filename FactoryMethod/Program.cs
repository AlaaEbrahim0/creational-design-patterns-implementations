using FactoryMethod.CrossPlatformUI;

public class Program
{
	private static void Main(string[] args)
	{

		//Logistics Part
		var logisticsByRoad = new RoadLogistics();
		logisticsByRoad.PlanDelivery();

		var logisticsBySea = new SeaLogistics();
		logisticsBySea.PlanDelivery();

		//UIPart
		var app = new App01();
		app.dialog.Render();



    }
}

