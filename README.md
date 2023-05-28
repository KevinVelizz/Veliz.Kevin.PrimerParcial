# Veliz.Kevin.PrimerParcial
Primer Parcial laboratorio-II

# Aerolinea Veliz

### Mi nombre es Kevin Veliz y este trabajo fue un desafío con pro y contras a lo largo de su implementanción. No se me fue fácil, pero aprendí demasiado.

### La aplicación cuenta con un login en el que iniciara sesión cualquier susuario, una vez iniciada la sesión en el programa principal dependiendo el tipo de usuario se les mostrará la información que le corresponda para sus funcionalides desarrolladas para cada tipo.

### **Fucionalidad**
* Podrá agregar, eliminar y modificar pasajero, vuelo y aeronave.

* Podrá ver los pasajeros de cada vuelo.

* Podrá ver una sección de estadistica en cuanto a los vuelos realizados.

## Temas:
Contiene una class library con las entidades y ciertas funcionalidades para el programa.

Utilice varias clases estáticas con el fin de poder utilizar sus metodos sin una necesidad de generar una instancia de la misma ya que solo generan una única utilidad, por ejemplo serializar o deseralizar, login, etc.

```` C#
public static class Archivos
{
    public static void SerealizarDatosUser(Usuario usuario)
    {
        if (usuario != null)
        {
            using TextWriter writer = new StreamWriter(Archivos.pathDataUsuario, true);
            writer.Write($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")} - {usuario}");
        }
    }
}
````
---
### **Sobrecargas.**


**Constructor.**

Utilice una sobrecarga de constructores para poder instanciar dos tipos de pasajeros, uno con atributo de **Vacunado** para realizar los vuelos y otra sin ese atributo.

```` C#
public Pasajero(string nombre, string apellido, int dni, int edad, List<Equipaje> equipajes, bool premium, bool equipajeDeMano) : base(nombre,apellido)
        {
            this.dni = dni; 
            this.edad = edad;
            this.equipajes = equipajes;
            this.premium = premium;
            this.equipajeDeMano = equipajeDeMano;
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, List<Equipaje> equipajes, bool premium, bool equipajeDeMano, bool vacunado) : this(nombre, apellido, dni, edad, equipajes, premium, equipajeDeMano)
        {
            this.vacunado = vacunado;
        }
````
---

**Método.**

Utilice una sobrecarga en la clase **Pasajero** que su funcionalidad es agregar un nuevo equipaje en caso que lo desee y se permita de dos maneras, con el objeto Equipaje o su tipo de equipaje y su peso.

```` C#
public void AgregarEquipaje(Equipaje equipaje)
{
    if (this.equipajes != null)
    {
        this.equipajes.Add(equipaje);
    }
}

public void AgregarEquipaje(string descripcion, double peso)
{
    Equipaje equipaje = new Equipaje(descripcion, peso);
    if (this.equipajes != null)
    {
        this.equipajes.Add(equipaje);
    }
}
````
---

Utilice una clase **ABSTRACTA** denominada **Persona** que es la clase **padre** de **Usuario**  y de **Pasajero** para reutilizar algunas propiedades. Contiene un **metódo abstracto** **Informacion** que tendrá que ser implementada en sus hijas en caso de no ser abstractas. Además posee un método **virtual** que podrá ser sobreescrito por sus hijas.

**Polimorfismo, abstracción y herencia**
```` C# 
public abstract class Persona
{
    protected abstract string      Informacion();

        protected virtual string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.Append($"Apellido: {this.apellido}");
            return mensaje.ToString();
        }
}
````
---
### Colecciones.
Utilice 2 tipos de colecciones, un diccionario y varias listas. El diccionario es para mostrar las estadisticas de destino y su monto para luego poder realizar un sort de manera decreciente y las listas para los pasajeros de un vuelo, aeronaves dentro de la aerolinea, etc.

````C#
Dictionary<string, double> recaudacionDestino;

this.recaudacionDestino.Add(auxDestino, this.acumuladorDineroPorDestino);

Dictionary<string,double> diccionarioOrdenado = this.recaudacionDestino.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
````

### **Contras**

* Al momento de que un vuelo este este en el estado de "en vuelo" o en "realizado" se necesitará volver a presionar en el strip de "Vuelos", para recargar su información.




