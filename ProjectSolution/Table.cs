﻿//keeps track of occupied, order, bill, customer

internal class Table
{
    int Number { get; set; }
    Customer Customer { get; set; }
    Order Order { get; set; }
    Bill Bill { get; set; }

    public Table(int n)
    {
        Number = n;
    }
}