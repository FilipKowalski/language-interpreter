using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    class INT
    {
        private string name { get; set; }
        private int value { get; set; }

        public INT(string name) { this.value = 0; this.name = name; }

        public INT(string name, int val) { this.value = val; this.name = name; }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string Name
        {
            get { return name; }
        }

        public static INT operator +(INT a, INT b) { return new INT(a.name, a.Value + b.Value); }

        public static INT operator -(INT a, INT b) { return new INT(a.name, a.Value - b.Value); }

        public static INT operator *(INT a, INT b) { return new INT(a.name, a.Value * b.Value); }

        public static INT operator/(INT a, INT b) { return new INT(a.name, a.Value / b.Value); }
    }

    public class BOOL
    {
        private string name { get; set; }
        private bool value { get; set; }

        public BOOL(string name) { this.value = false; this.name = name; }

        public BOOL(string name, bool val) { this.value = val; this.name = name; }

        public bool Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    public class FLOAT
    {
        private string name { get; set; }
        private float value { get; set; }

        public FLOAT(string name) { this.value = 0; this.name = name; }

        public FLOAT(string name, float val) { this.value = val; this.name = name; }

        public float Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public static FLOAT operator +(FLOAT a, FLOAT b) { return new FLOAT(a.name, a.Value + b.Value); }

        public static FLOAT operator -(FLOAT a, FLOAT b) { return new FLOAT(a.name, a.Value - b.Value); }

        public static FLOAT operator *(FLOAT a, FLOAT b) { return new FLOAT(a.name, a.Value * b.Value); }

        public static FLOAT operator/(FLOAT a, FLOAT b) { return new FLOAT(a.name, a.Value / b.Value); }
    }
}
