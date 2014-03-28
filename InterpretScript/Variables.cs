using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    class INT
    {
        private int value { get; set; }

        public INT() { this.value = 0; }

        public INT(int val) { this.value = val; }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public static INT operator +(INT a, INT b) { return new INT(a.Value + b.Value); }

        public static INT operator -(INT a, INT b) { return new INT(a.Value - b.Value); }

        public static INT operator *(INT a, INT b) { return new INT(a.Value * b.Value); }

        public static INT operator/(INT a, INT b) { return new INT(a.Value / b.Value); }
    }

    public class BOOL
    {
        private bool value { get; set; }

        public BOOL() { this.value = false; }

        public BOOL(bool val) { this.value = val; }

        public bool Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    public class FLOAT
    {
        private float value { get; set; }

        public FLOAT() { this.value = 0; }

        public FLOAT(float val) { this.value = val; }

        public float Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public static FLOAT operator +(FLOAT a, FLOAT b) { return new FLOAT(a.Value + b.Value); }

        public static FLOAT operator -(FLOAT a, FLOAT b) { return new FLOAT(a.Value - b.Value); }

        public static FLOAT operator *(FLOAT a, FLOAT b) { return new FLOAT(a.Value * b.Value); }

        public static FLOAT operator/(FLOAT a, FLOAT b) { return new FLOAT(a.Value / b.Value); }
    }
}
