namespace ContactBookApp
{
    public class Contact
    {
        public string contactName { get; private set; }
        public string contactEmail { get; private set; }

        public Contact(string contactName, string contactEmail)
        {
            this.contactName = contactName;
            this.contactEmail = contactEmail;
        }
    }
}