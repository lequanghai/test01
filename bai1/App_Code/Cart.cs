using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class Cart
{
    private List<CartItem> Items { get; set; }
    public Cart()
    {
        Items = new List<CartItem>();

    }

    private int ItemIndexOf(int ID)
    {
        foreach (CartItem item in Items)
        {
            if (item.ID == ID)
            {
                return Items.IndexOf(item);
            }
           
        }
        return -1;
    }
    public void Insert(CartItem item)
    {
        int index = ItemIndexOf(item.ID);
        if(index == -1)
        {
            Items.Add(item);
        } else
        {
            Items[index].Quanlyty++;
        }
    }
    public void Delete(int rowID)
    {
        Items.RemoveAt(rowID);
    }

    public void Update(int rowId, int Quantity)
    {
        if (Quantity > 0)
        {
            Items[rowId].Quanlyty = Quantity;
        }
        else
        {
            Delete(rowId);
        }
    }
    public double GrandTotal
    {
        get
        {
            if (Items == null)
            { return 0;
            }
            else
            {
                double grandTotal = 0;
                foreach(CartItem item in Items)
                {
                    grandTotal += item.Quanlyty * item.Price;
                }
                return grandTotal;
            }
        }
        
    }
}