namespace SOLIDS
{
    public class Mail
    {
        readonly string Email;
        readonly string Subject;
        private string Sender;

        public Mail(string v, string email)
        {
            this.Sender = v;
            this.Email = email;
        }
    }
}
