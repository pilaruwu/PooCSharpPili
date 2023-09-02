using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPoo
{
    public abstract class Appliances
    {
        public double _base { get; set; }
        public String _color { get; set; }
        public String _ConsumoELec { get; set; }
        public double _peso { get; set; }

        public Appliances()
        {
            _base = 100;
            _color = "Blanco";
            _ConsumoELec = "F";
            _peso = 5;
        }

        public Appliances(double @base, double peso)
        {
            _base = @base;
            _peso = peso;
        }

        public Appliances(double @base, string color, string consumoELec, double peso)
        {
            _base = @base;
            _color = color;
            _ConsumoELec = consumoELec;
            _peso = peso;
        }

        private string comprobarConsumoEnergetico(char letra)
        {
            string result = "";
            if (letra != 'F' || letra != 'f' || letra != 'A' || letra != 'a')
            {
                result = "F";
            }
            else
            {
                result = _ConsumoELec;
            }
            return result;
        }
        private string comprobarColor(string color)
        {
            string result;
            color = _color;
            if (color == "BLANCO" || color == "blanco" || color == "Blanco")
            {
                result = "Color blanco seleccionado.";
            }
            else if (color == "negro" || color == "NEGRO" || color == "Negro")
            {
                result = "Color negro seleccionado.";
            }
            else if (color == "rojo" || color == "ROJO" || color == "Rojo")
            {
                result = "Color rojo seleccionado.";
            }
            else if (color == "azul" || color == "AZUL" || color == "Azul")
            {
                result = "Color azul seleccionado.";
            }
            else if (color == "GRIS" || color == "gris" || color == "Gris")
            {
                result = "Color gris seleccionado.";
            }
            else
            {
                result = "Color seleccionado no disponible";
            }
            return result;
        }
        public abstract double precioFinal();


    }
    public class Lavadora : Appliances
    {
        public int _carga { get; set; }
        public double _base { get; set; }
        public double _peso { get; set; }
        public string _color { get; set; }
        public string _ConsumoElec { get; set; }

        public Lavadora(int carga)
        {
            _carga = 5;
        }
        public Lavadora(double @base, double peso, string ConsumoElec, string color)
        {
            _base = @base;
            _peso = peso;
            _color = "Blanco";
            _ConsumoElec = "F";
        }
        public Lavadora(int carga, Appliances electrodomestico)
        {
            _carga = carga;

        }

        public override double precioFinal()
        {

            {
                double result = 0;
                if (_ConsumoELec == "A" || _ConsumoELec == "a")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 110;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 150;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 180;
                    }
                    else if (_peso >= 80)
                    {
                        result = 200;
                    }
                }
                else if (_ConsumoELec == "B" || _ConsumoELec == "b")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 90;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 130;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 160;
                    }
                    else if (_peso >= 80)
                    {
                        result = 180;
                    }
                }
                else if (_ConsumoELec == "C" || _ConsumoELec == "c")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 70;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 110;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 140;
                    }
                    else if (_peso >= 80)
                    {
                        result = 160;
                    }
                }
                else if (_ConsumoELec == "D" || _ConsumoELec == "d")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 70;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 110;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 140;
                    }
                    else if (_peso >= 80)
                    {
                        result = 160;
                    }
                }
                else if (_ConsumoELec == "E" || _ConsumoELec == "e")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 40;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 80;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 110;
                    }
                    else if (_peso >= 80)
                    {
                        result = 130;
                    }
                }
                else if (_ConsumoELec == "F" || _ConsumoELec == "f")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 20;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 60;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 90;
                    }
                    else if (_peso >= 80)
                    {
                        result = 110;
                    }
                }
                if (_carga > 30)
                {
                    result += 50;
                }
                return result;
            }

        }

    }
    public class Television : Appliances
    {
        double _base { get; set; }
        string _color { get; set; }
        string _consumoELec { get; set; }
        double _peso { get; set; }
        int _pulgadas { get; set; }
        Boolean _tdt { get; set; }

        public Television()
        {
            _base = 100;
            _color = "Blanco";
            _ConsumoELec = "F";
            _peso = 5;
            _pulgadas = 20;
            _tdt = false;
        }

        public Television(double @base, double peso)
        {
            _base = @base;
            _peso = peso;
        }

        public Television(double @base, string color, string consumoELec, double peso, int pulgadas, bool tdt)
        {
            _base = @base;
            _color = color;
            _consumoELec = consumoELec;
            _peso = peso;
            _pulgadas = pulgadas;
            _tdt = tdt;
        }
        public override double precioFinal()
        {

            {
                double result = 0;
                if (_ConsumoELec == "A" || _ConsumoELec == "a")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 110;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 150;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 180;
                    }
                    else if (_peso >= 80)
                    {
                        result = 200;
                    }
                }
                else if (_ConsumoELec == "B" || _ConsumoELec == "b")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 90;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 130;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 160;
                    }
                    else if (_peso >= 80)
                    {
                        result = 180;
                    }
                }
                else if (_ConsumoELec == "C" || _ConsumoELec == "c")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 70;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 110;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 140;
                    }
                    else if (_peso >= 80)
                    {
                        result = 160;
                    }
                }
                else if (_ConsumoELec == "D" || _ConsumoELec == "d")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 70;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 110;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 140;
                    }
                    else if (_peso >= 80)
                    {
                        result = 160;
                    }
                }
                else if (_ConsumoELec == "E" || _ConsumoELec == "e")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 40;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 80;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 110;
                    }
                    else if (_peso >= 80)
                    {
                        result = 130;
                    }
                }
                else if (_ConsumoELec == "F" || _ConsumoELec == "f")
                {
                    if (_peso >= 0 && _peso <= 19)
                    {
                        result = 20;
                    }
                    else if (_peso >= 20 && _peso <= 49)
                    {
                        result = 60;
                    }
                    else if (_peso >= 50 && _peso <= 79)
                    {
                        result = 90;
                    }
                    else if (_peso >= 80)
                    {
                        result = 110;
                    }
                }
                if (_pulgadas > 40)
                {
                    double increment = result * 0.3;
                    result += increment;
                }
                return result;
            }

        }
    }
}

