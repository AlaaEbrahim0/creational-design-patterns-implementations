using Builder.GuitarExample.Enums;

namespace Builder.GuitarExample
{
    public class AcousticGuitarBuilder : IAcousticGuitarBuilder
    {
        private AcousticGuitar guitar;

        public AcousticGuitarBuilder()
        {
            guitar = new AcousticGuitar();
        }


        public IAcousticGuitarBuilder SetBrand(GuitarBrand brand)
        {
            guitar.Brand = brand;
            return this;
        }


        public IAcousticGuitarBuilder SetBodyWood(BodyWood bodyWood)
        {
            guitar.BodyWood = bodyWood;
            return this;
        }

        public IAcousticGuitarBuilder SetBodyShape(BodyShape bodyShape)
        {
            guitar.BodyShape = bodyShape;
            return this;
        }

        public IAcousticGuitarBuilder SetBodyFinish(BodyFinish bodyFinish)
        {
            guitar.BodyFinish = bodyFinish;
            return this;
        }

        public IAcousticGuitarBuilder SetNeckWood(NeckWood neckWood)
        {
            guitar.NeckWood = neckWood;
            return this;
        }

        public IAcousticGuitarBuilder SetNeckShape(NeckShape neckShape)
        {
            guitar.NeckShape = neckShape;
            return this;
        }

        public IAcousticGuitarBuilder SetNumFrets(int numFrets)
        {
            guitar.NumFrets = numFrets;
            return this;
        }

        public IAcousticGuitarBuilder SetBridgeType(BridgeType bridgeType)
        {
            guitar.BridgeType = bridgeType;
            return this;
        }

        public IAcousticGuitarBuilder SetPickupType(PickupType pickupType)
        {
            guitar.PickupType = pickupType;
            return this;
        }

        public IAcousticGuitarBuilder SetTuningMachineType(TuningMachineType tuningMachineType)
        {
            guitar.TuningMachineType = tuningMachineType;
            return this;
        }

        public IAcousticGuitarBuilder SetStringType(StringType stringType)
        {
            guitar.StringType = stringType;
            return this;
        }

        public IAcousticGuitarBuilder SetNumStrings(int numStrings)
        {
            guitar.NumStrings = numStrings;
            return this;
        }

        public IAcousticGuitarBuilder SetHasToneControls(bool hasToneControls)
        {
            guitar.HasToneControls = hasToneControls;
            return this;
        }

        public IAcousticGuitarBuilder SetHasVolumeControls(bool hasVolumeControls)
        {
            guitar.HasVolumeControls = hasVolumeControls;
            return this;
        }

        public IAcousticGuitarBuilder SetHasPickupSelector(bool hasPickupSelector)
        {
            guitar.HasPickupSelector = hasPickupSelector;
            return this;
        }

        public IAcousticGuitarBuilder SetHasCutaway(bool hasCutaway)
        {
            guitar.HasCutaway = hasCutaway;
            return this;
        }

        public IAcousticGuitarBuilder SetSoundholeType(SoundholeType soundholeType)
        {
            guitar.SoundholeType = soundholeType;
            return this;
        }

        public IAcousticGuitarBuilder SetBracingType(BracingType bracingType)
        {
            guitar.BracingType = bracingType;
            return this;
        }

        public IAcousticGuitarBuilder SetTopWoodType(TopWoodType topWoodType)
        {
            guitar.TopWoodType = topWoodType;
            return this;
        }

        public IAcousticGuitarBuilder SetSaddleType(SaddleType saddleType)
        {
            guitar.SaddleType = saddleType;
            return this;
        }

        public Guitar Build()
        {
            return guitar;
        }
    }
}
