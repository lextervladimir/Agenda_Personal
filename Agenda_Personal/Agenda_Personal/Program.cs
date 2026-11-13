using System;
using System.Collections.Generic;
using System.Text;

public class Contact
{
    public int ContactId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int? Age { get; set; }
    public bool IsFavorite { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    // Propiedades calculadas
    public string FullName => $"{FirstName} {LastName}";

    // Constructor por defecto
    public Contact() { }

    // Constructor para nuevos contactos
    public Contact(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        IsFavorite = false;
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }
    // Constructor completo
    public Contact(int contactId, string firstName, string lastName,
                   string email, string phoneNumber, string address,
                   int? age, bool isFavorite)
    {
        ContactId = contactId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        Age = age;
        IsFavorite = isFavorite;
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{FullName} - {Email} - {(IsFavorite ? "⭐" : "")}";
    }
}
