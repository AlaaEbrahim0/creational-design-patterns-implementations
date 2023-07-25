using Builder.GuitarExample.Enums;

namespace Builder.GuitarExample
{
    public interface IAcousticGuitarBuilder
    {
        // Properties of the guitar itself
        IAcousticGuitarBuilder SetBrand(GuitarBrand brand);

        // Properties for the body of the guitar
        IAcousticGuitarBuilder SetBodyWood(BodyWood bodyWood);
        IAcousticGuitarBuilder SetBodyShape(BodyShape bodyShape);
        IAcousticGuitarBuilder SetBodyFinish(BodyFinish bodyFinish);

        // Properties for the neck of the guitar
        IAcousticGuitarBuilder SetNeckWood(NeckWood neckWood);
        IAcousticGuitarBuilder SetNeckShape(NeckShape neckShape);
        IAcousticGuitarBuilder SetNumFrets(int numFrets);

        // Properties for the hardware of the guitar
        IAcousticGuitarBuilder SetBridgeType(BridgeType bridgeType);
        IAcousticGuitarBuilder SetPickupType(PickupType pickupType);
        IAcousticGuitarBuilder SetTuningMachineType(TuningMachineType tuningMachineType);

        // Properties for the strings of the guitar
        IAcousticGuitarBuilder SetStringType(StringType stringType);
        IAcousticGuitarBuilder SetNumStrings(int numStrings);

        // Properties for the electronics of the guitar
        IAcousticGuitarBuilder SetHasToneControls(bool hasToneControls);
        IAcousticGuitarBuilder SetHasVolumeControls(bool hasVolumeControls);
        IAcousticGuitarBuilder SetHasPickupSelector(bool hasPickupSelector);

        // Properties for the miscellaneous features of the guitar
        IAcousticGuitarBuilder SetHasCutaway(bool hasCutaway);

        // Properties specific to acoustic guitars
        IAcousticGuitarBuilder SetSoundholeType(SoundholeType soundholeType);
        IAcousticGuitarBuilder SetBracingType(BracingType bracingType);
        IAcousticGuitarBuilder SetTopWoodType(TopWoodType topWoodType);
        IAcousticGuitarBuilder SetSaddleType(SaddleType saddleType);

        // Build the guitar
        Guitar Build();
    }
}
