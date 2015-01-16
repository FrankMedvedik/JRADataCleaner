namespace JRAMelissaWrapper
{
    public interface IInputStreetAddress
    {
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string City { get; set; }
        string CompanyName { get; set; }
        string Country { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string FullName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string PostalCode { get; set; }
        string State { get; set; }
        string ToString();
    }
}