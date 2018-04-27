namespace NetCoreWorkshop_4_27_18.Math
{
    public class StringToIntConverter : IConverter<int>
    {
        public int Result { get; }
        public bool Success { get; }
        public StringToIntConverter(string stringToConvert)
        {
            int resultingInt;
            Success = System.Int32.TryParse(stringToConvert, out resultingInt);
            Result = resultingInt;
        }
    }
}