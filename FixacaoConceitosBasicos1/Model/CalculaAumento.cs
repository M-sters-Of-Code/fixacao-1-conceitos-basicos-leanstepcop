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

    public static int CalculaAluguel
}
