namespace ViktorDraganov_employees.Models.Exceptions
{
    using Common;

    public class LineNotValidException : BaseException
    {
        public LineNotValidException()
        {

        }

        public LineNotValidException(string error)
        {
            this.Error = error;

        }
    }
}
