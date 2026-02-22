namespace Basic.Application.ParamCollection
{
    public class ValidateService
    {
        public bool ValidateAll_Old(params string[] values)
        {
            if(values == null || values.Length == 0)
                return false;

            return values.All(v => !string.IsNullOrWhiteSpace(v));
        }

        public bool ValidateAll(params ReadOnlySpan<string> values)
        {
            if( values.Length == 0)
                return false;
            foreach(var v in values)           
                if(string.IsNullOrWhiteSpace(v)) 
                return false;
            return true;
        }
    }
}