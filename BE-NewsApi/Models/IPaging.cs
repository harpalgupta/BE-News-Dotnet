namespace BE_NewsApi.Models
{
    public interface IPaging
    {
        int PageSize { get; set; }

        int StartAtPosition { get; set; }
    }
}