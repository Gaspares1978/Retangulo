﻿using System;


namespace Retangulo
{
    class Retangulo
    {
        
        
            public double largura, altura;

        public double Area()
        {
            return largura * altura;

        }
        public double Perimetro()
        {
            return 2.0 *( largura + altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);

        }


    }
}

