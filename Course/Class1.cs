﻿using System;

namespace Course {
    class Calculadora {

        static public double Pi = 3.14;

        static public double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static public double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
