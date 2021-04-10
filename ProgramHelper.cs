namespace Task11
{
    class ProgramHelper : ProgramConverter, IConvertible, ICodeChecker
    {
        public bool CheckCodeSyntax(string checkStr, string language)
        {
            if ((checkStr == "+" && language == "C#") || (checkStr == "+" && language == "VB"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
