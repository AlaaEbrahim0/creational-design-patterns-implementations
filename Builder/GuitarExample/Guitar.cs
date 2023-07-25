using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Builder.GuitarExample.Enums;

namespace Builder.GuitarExample
{
    public abstract class Guitar
    {
        // Properties of the guitar itself
        public GuitarBrand Brand { get; set; }
        // Properties for the body of the guitar
        public BodyWood BodyWood { get; set; }
        public BodyShape BodyShape { get; set; }
        public BodyFinish BodyFinish { get; set; }

        // Properties for the neck of the guitar
        public NeckWood NeckWood { get; set; }
        public NeckShape NeckShape { get; set; }
        public int NumFrets { get; set; }

        // Properties for the hardware of the guitar
        public BridgeType BridgeType { get; set; }
        public PickupType PickupType { get; set; }
        public TuningMachineType TuningMachineType { get; set; }

        // Properties for the strings of the guitar
        public StringType StringType { get; set; }
        public int NumStrings { get; set; }

        // Properties for the electronics of the guitar
        public bool HasToneControls { get; set; }
        public bool HasVolumeControls { get; set; }
        public bool HasPickupSelector { get; set; }

        // Properties for the miscellaneous features of the guitar
        public bool HasCutaway { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Brand: {Brand}");
            sb.AppendLine($"Body Wood: {BodyWood}");
            sb.AppendLine($"Body Shape: {BodyShape}");
            sb.AppendLine($"Body Finish: {BodyFinish}");
            sb.AppendLine($"Neck Wood: {NeckWood}");
            sb.AppendLine($"Neck Shape: {NeckShape}");
            sb.AppendLine($"Number of Frets: {NumFrets}");
            sb.AppendLine($"Bridge Type: {BridgeType}");
            sb.AppendLine($"Pickup Type: {PickupType}");
            sb.AppendLine($"Tuning Machine Type: {TuningMachineType}");
            sb.AppendLine($"String Type: {StringType}");
            sb.AppendLine($"Number of Strings: {NumStrings}");
            sb.AppendLine($"Has Tone Controls: {HasToneControls}");
            sb.AppendLine($"Has Volume Controls: {HasVolumeControls}");
            sb.AppendLine($"Has Pickup Selector: {HasPickupSelector}");
            sb.AppendLine($"Has Cutaway: {HasCutaway}");
            return sb.ToString();
        }
    }

    public class AcousticGuitar : Guitar
    {
        // Properties specific to acoustic guitars
        public SoundholeType SoundholeType { get; set; }
        public BracingType BracingType { get; set; }
        public TopWoodType TopWoodType { get; set; }
        public SaddleType SaddleType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Soundhole Type: {SoundholeType}");
            sb.AppendLine($"Bracing Type: {BracingType}");
            sb.AppendLine($"Top Wood Type: {TopWoodType}");
            sb.AppendLine($"Saddle Type: {SaddleType}");
            return sb.ToString();
        }
    }
    public class ElectricGuitar : Guitar
    {
        // Properties specific to electric guitars
        public PickupConfiguration PickupConfiguration { get; set; }
        public TremoloSystemType TremoloSystemType { get; set; }
        public ControlKnobType ControlKnobType { get; set; }
        public OutputJackType OutputJackType { get; set; }
        public bool HasWhammyBar { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Pickup Configuration: {PickupConfiguration}");
            sb.AppendLine($"Tremolo System Type: {TremoloSystemType}");
            sb.AppendLine($"Control Knob Type: {ControlKnobType}");
            sb.AppendLine($"Output Jack Type: {OutputJackType}");
            sb.AppendLine($"Has Whammy Bar: {HasWhammyBar}");
            return sb.ToString();
        }
    }

}
