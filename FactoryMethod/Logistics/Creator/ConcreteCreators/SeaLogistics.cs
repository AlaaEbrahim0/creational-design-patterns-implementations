﻿
public class SeaLogistics : Logistics
{
	protected override ITransport CreateTransport()
	{
		return new Ship();
	}
}

