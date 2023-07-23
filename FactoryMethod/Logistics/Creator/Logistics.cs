public abstract class Logistics
{
	public void PlanDelivery()
	{
		ITransport transport = CreateTransport();
		transport.Deliver();
	}

	protected abstract ITransport CreateTransport();
}


