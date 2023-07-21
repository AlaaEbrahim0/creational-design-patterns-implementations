using System;
public abstract class Logistics
{
	public void PlanDelivery()
	{
		ITransport transport = CreateTransport();
		transport.Deliver();
	}

	//Factory Method
	protected abstract ITransport CreateTransport();
}


