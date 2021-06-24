namespace ForUBS.Pages
{
    public abstract class BaseActions
    {
        protected readonly WebElements WebElements;

        protected BaseActions(WebElements webElements)
        {
            this.WebElements = webElements;
        }
    }
}