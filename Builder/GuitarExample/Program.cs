using Builder.GuitarExample.Enums;

namespace Builder.GuitarExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acousticGuitarBuilder = new AcousticGuitarBuilder();
            acousticGuitarBuilder
                .SetBrand(GuitarBrand.GIBSON)
                .SetBodyFinish(BodyFinish.BLACK)
                .SetBodyShape(BodyShape.IBANEZ_RG)
                .SetBodyWood(BodyWood.MAHOGANY)
                .SetNeckShape(NeckShape.U)
                .SetNeckWood(NeckWood.MAHOGANY)
                .SetStringType(StringType.NYLON)
                .SetBracingType(BracingType.LADDER)
                .SetBridgeType(BridgeType.FIXED)
                .SetSaddleType(SaddleType.NONE)
                .SetHasCutaway(true)
                .SetHasToneControls(true)
                .SetHasVolumeControls(true)
                .SetHasPickupSelector(false)
                .SetNumFrets(20)
                .SetNumStrings(6);

            var electricGuitarBuilder = new ElectricGuitarBuilder();
            electricGuitarBuilder
				.SetBrand(GuitarBrand.GIBSON)
				.SetBodyFinish(BodyFinish.BLACK)
				.SetBodyShape(BodyShape.IBANEZ_RG)
				.SetBodyWood(BodyWood.MAHOGANY)
				.SetNeckShape(NeckShape.U)
				.SetNeckWood(NeckWood.MAHOGANY)
				.SetStringType(StringType.NYLON)
				.SetBridgeType(BridgeType.FIXED)
				.SetHasCutaway(true)
				.SetHasToneControls(true)
				.SetHasVolumeControls(true)
				.SetHasPickupSelector(false)
				.SetNumFrets(20)
                .SetOutputJackType(OutputJackType.STEREO)
                .SetTremoloSystemType(TremoloSystemType.FLOYD_ROSE)
                .SetPickupConfiguration(PickupConfiguration.SINGLE)
                .SetHasWhammyBar(true)  
				.SetNumStrings(6);


			var AcousticGuitar = acousticGuitarBuilder.Build();
			var ElectricGuitar = electricGuitarBuilder.Build();

            Console.WriteLine("Acoustic Guitar\n");
            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine(AcousticGuitar);

			Console.WriteLine("Electric Guitar\n");
			Console.WriteLine("----------------------------------------------\n");
			Console.WriteLine(ElectricGuitar);
        }
    }
}