namespace SOLIDS
{
    interface IRegistrable
    {
        public void Register(string email, string password);
        public abstract bool ValidateEmail(string email);
    }
}
