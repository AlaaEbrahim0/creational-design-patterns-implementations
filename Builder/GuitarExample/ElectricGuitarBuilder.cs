using Builder.GuitarExample.Enums;

namespace Builder.GuitarExample
{
    public class ElectricGuitarBuilder : IElectricGuitarBuilder
    {
        private ElectricGuitar guitar;

        public ElectricGuitarBuilder()
        {
            guitar = new ElectricGuitar();
        }

        public IElectricGuitarBuilder SetBrand(GuitarBrand brand)
        {
            guitar.Brand = brand;
            return this;
        }

        public IElectricGuitarBuilder SetBodyWood(BodyWood bodyWood)
        {
            guitar.BodyWood = bodyWood;
            return this;
        }

        public IElectricGuitarBuilder SetBodyShape(BodyShape bodyShape)
        {
            guitar.BodyShape = bodyShape;
            return this;
        }

        public IElectricGuitarBuilder SetBodyFinish(BodyFinish bodyFinish)
        {
            guitar.BodyFinish = bodyFinish;
            return this;
        }

        public IElectricGuitarBuilder SetNeckWood(NeckWood neckWood)
        {
            guitar.NeckWood = neckWood;
            return this;
        }

        public IElectricGuitarBuilder SetNeckShape(NeckShape neckShape)
        {
            guitar.NeckShape = neckShape;
            return this;
        }

        public IElectricGuitarBuilder SetNumFrets(int numFrets)
        {
            guitar.NumFrets = numFrets;
            return this;
        }

        public IElectricGuitarBuilder SetBridgeType(BridgeType bridgeType)
        {
            guitar.BridgeType = bridgeType;
            return this;
        }

        public IElectricGuitarBuilder SetPickupType(PickupType pickupType)
        {
            guitar.PickupType = pickupType;
            return this;
        }

        public IElectricGuitarBuilder SetTuningMachineType(TuningMachineType tuningMachineType)
        {
            guitar.TuningMachineType = tuningMachineType;
            return this;
        }

        public IElectricGuitarBuilder SetStringType(StringType stringType)
        {
            guitar.StringType = stringType;
            return this;
        }

        public IElectricGuitarBuilder SetNumStrings(int numStrings)
        {
            guitar.NumStrings = numStrings;
            return this;
        }

        public IElectricGuitarBuilder SetHasToneControls(bool hasToneControls)
        {
            guitar.HasToneControls = hasToneControls;
            return this;
        }

        public IElectricGuitarBuilder SetHasVolumeControls(bool hasVolumeControls)
        {
            guitar.HasVolumeControls = hasVolumeControls;
            return this;
        }

        public IElectricGuitarBuilder SetHasPickupSelector(bool hasPickupSelector)
        {
            guitar.HasPickupSelector = hasPickupSelector;
            return this;
        }

        public IElectricGuitarBuilder SetHasCutaway(bool hasCutaway)
        {
            guitar.HasCutaway = hasCutaway;
            return this;
        }

        public IElectricGuitarBuilder SetPickupConfiguration(PickupConfiguration pickupConfiguration)
        {
            guitar.PickupConfiguration = pickupConfiguration;
            return this;
        }

        public IElectricGuitarBuilder SetTremoloSystemType(TremoloSystemType tremoloSystemType)
        {
            guitar.TremoloSystemType = tremoloSystemType;
            return this;
        }

        public IElectricGuitarBuilder SetControlKnobType(ControlKnobType controlKnobType)
        {
            guitar.ControlKnobType = controlKnobType;
            return this;
        }

        public IElectricGuitarBuilder SetOutputJackType(OutputJackType outputJackType)
        {
            guitar.OutputJackType = outputJackType;
            return this;
        }

        public IElectricGuitarBuilder SetHasWhammyBar(bool hasWhammyBar)
        {
            guitar.HasWhammyBar = hasWhammyBar;
            return this;
        }

        public Guitar Build()
        {
            return guitar;
        }
    }
}
