namespace QLCHXe.Repository.Interface
{
    public interface IUpload
    {
        bool PostImage();

        string GetImage(string url);
    }
}