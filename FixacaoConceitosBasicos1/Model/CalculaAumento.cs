using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CalculaAumento
{
    public static double CalculaAument(double sal, double aumet)
    {
        return sal + aumet;
    }

    public static double CalculaDesconto(double valor)
    {
        double desconto = valor * 0.2;
        double newValor = desconto;

        return valor - desconto;
    }

    public static double CalculaAluguel(int dias, int kmIni, int kmFin)
    {
        double pricePerKm = 0.4;
        double dailyPrice = 80;

        double totalKm = kmIni - kmFin;

        double totalPrice = (dias * dailyPrice) + (pricePerKm * totalKm);

        return totalPrice;

    }


}
//olá