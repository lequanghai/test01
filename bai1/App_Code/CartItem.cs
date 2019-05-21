using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Quanlyty { get; set; }
    public CartItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public CartItem(int ID, string Name, string Image, string Description , double Price)
    {
        this.ID = ID;
        this.Name = Name;
        this.Price = Price;
        this.Description = Description;
        this.Image = Image;
        this.Quanlyty = Quanlyty;
    }
}