using BookStoreApi.Helper;

namespace BookStoreApi.Service
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
