namespace ViktorDraganov_employees.Common
{
    public abstract class BaseException : Exception
    {
        private string? error;

        public string Error
        {
            get => this.error ?? base.Message;
            set => this.error = value;
        }
    }
}
