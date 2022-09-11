public class Usuario
{
    public int idUsuario;
    public string nombre;
    public string apellido;
    public int dni;
}

public class Producto
{
    public int id;
    public string nombreProducto;
    public int precioCompra;
    public int precioVenta;
    public int stock;
    public int idUsuario;
    private string categoria;
}

public class ProductoVendido
{
    public int id;
    public int idProducto;
    public int stock;
    public int idVenta;
}

public class Venta
{
    public int id;
    public string comentarios;
    public int idUsuario;
}