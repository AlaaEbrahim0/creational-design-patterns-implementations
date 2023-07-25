using Builder.GuitarExample.Enums;

namespace Builder.GuitarExample
{
    public interface IElectricGuitarBuilder
    {
        // Properties of the guitar itself
        IElectricGuitarBuilder SetBrand(GuitarBrand brand);
        // Properties for the body of the guitar
        IElectricGuitarBuilder SetBodyWood(BodyWood bodyWood);
        IElectricGuitarBuilder SetBodyShape(BodyShape bodyShape);
        IElectricGuitarBuilder SetBodyFinish(BodyFinish bodyFinish);

        // Properties for the neck of the guitar
        IElectricGuitarBuilder SetNeckWood(NeckWood neckWood);
        IElectricGuitarBuilder SetNeckShape(NeckShape neckShape);
        IElectricGuitarBuilder SetNumFrets(int numFrets);

        // Properties for the hardware of the guitar
        IElectricGuitarBuilder SetBridgeType(BridgeType bridgeType);
        IElectricGuitarBuilder SetPickupType(PickupType pickupType);
        IElectricGuitarBuilder SetTuningMachineType(TuningMachineType tuningMachineType);

        // Properties for the strings of the guitar
        IElectricGuitarBuilder SetStringType(StringType stringType);
        IElectricGuitarBuilder SetNumStrings(int numStrings);

        // Properties for the electronics of the guitar
        IElectricGuitarBuilder SetHasToneControls(bool hasToneControls);
        IElectricGuitarBuilder SetHasVolumeControls(bool hasVolumeControls);
        IElectricGuitarBuilder SetHasPickupSelector(bool hasPickupSelector);

        // Properties for the miscellaneous features of the guitar
        IElectricGuitarBuilder SetHasCutaway(bool hasCutaway);

        // Properties specific to electric guitars
        IElectricGuitarBuilder SetPickupConfiguration(PickupConfiguration pickupConfiguration);
        IElectricGuitarBuilder SetTremoloSystemType(TremoloSystemType tremoloSystemType);
        IElectricGuitarBuilder SetControlKnobType(ControlKnobType controlKnobType);
        IElectricGuitarBuilder SetOutputJackType(OutputJackType outputJackType);
        IElectricGuitarBuilder SetHasWhammyBar(bool hasWhammyBar);

        // Build the guitar
        Guitar Build();
    }
}
