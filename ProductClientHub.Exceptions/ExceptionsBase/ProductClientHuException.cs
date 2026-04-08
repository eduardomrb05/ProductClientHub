namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public abstract class ProductClientHuException : SystemException
    {
        public ProductClientHuException(string errorMessage) : base(errorMessage)
        {
            
        }

        public abstract List<string> GetErrors();
    }
}
