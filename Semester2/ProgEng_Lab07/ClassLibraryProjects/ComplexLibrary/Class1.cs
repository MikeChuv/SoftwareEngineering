using System;
using System.Numerics;

namespace UtilityLibraries
{
    public static class ComplexLibrary
    {

        public static bool IsReal(this Complex complex) {
            if (complex.Imaginary == 0) return true;
            else return false;
        }

        public static bool IsImaginary(this Complex complex)
        {
            if (complex.Real == 0) return true;
            else return false;
        }
    }
}