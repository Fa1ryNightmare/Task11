namespace Task11
{
    class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string str)
        {
            return $"{str} конвертировано в C#";
        }

        public string ConvertToVB(string str)
        {
            return $"{str} конвертировано в VB";
        }
    }
}
