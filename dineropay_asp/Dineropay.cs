namespace dineropay;

public class Dineropay
{

    public Authorization authObjet;




    public Dineropay (Authorization obj)
    {
        this.authObjet.amt = obj.amt;

    }




    public static string genHash(string? data)
    {
        return data + "dfdf";

    }
    public static string print()
    {
        string name = "Hi";
        return name;

    }

}

