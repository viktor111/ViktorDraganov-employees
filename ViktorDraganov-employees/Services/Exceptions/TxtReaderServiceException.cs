namespace ViktorDraganov_employees.Services.Exceptions
{
    using Common;

    internal class TxtReaderServiceException : BaseException
    {
        public TxtReaderServiceException()
        {

        }

        public TxtReaderServiceException(string error)
        {
            this.Error = error;
        }
    }
}
