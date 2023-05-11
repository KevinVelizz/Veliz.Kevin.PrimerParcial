using System.Xml.Serialization;

public enum EnumVuelosInternacionales
{
    [XmlEnum ("Recife")]
    Recife,
    Roma,
    Acapulco,
    Miami,
}

public enum EnumVuelosNacionales
{
    [XmlEnum("Santa Rosa")]
    Santa_Rosa,
    Bariloche,
    Corrientes,
    Cordoba,
    Jujuy,
    Medonza,
    Neuquen,
    Posadas,
    Iguazu,
    Salta,
    Santiago_Del_Estero,
    Trelew,
    Tucuman,
    Puerto_Madryn,
    Ushuaia,
    Buenos_Aires,
}

public enum EnumEquipaje
{
    De_Mano,
    De_Bodega,
}

public enum EnumClase
{
    Turista,
    Premium,
}