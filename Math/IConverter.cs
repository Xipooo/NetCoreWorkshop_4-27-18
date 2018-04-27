namespace NetCoreWorkshop_4_27_18.Math
{
    public interface IConverter<T>
    {
         T Result { get;}
         bool Success { get;}
    }
}