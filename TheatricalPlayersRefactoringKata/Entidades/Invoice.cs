using System.Collections.Generic;

namespace TheatricalPlayers.Domain.Entidades;

public class Invoice
{
    public string Customer {  get; private set; }
    public List<Performance> Performances { get; private set; }

    public Invoice(string customer, List<Performance> performance)
    {
        Customer = customer;
        Performances = performance;
    }

}
