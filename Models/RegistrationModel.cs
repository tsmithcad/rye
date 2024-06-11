// RegistrationModel.cs
using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm Password is required.")]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    // Function to clear the registration form
    public void Clear()
    {
        Email = string.Empty;
        Password = string.Empty;
        ConfirmPassword = string.Empty;
    }

    // Function to validate the registration model
    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password) && Password == ConfirmPassword;
    }

    // Function to perform user registration
    public bool RegisterUser()
    {
        // Implement user registration logic here
        // Return true if registration is successful, false otherwise
        return false;
    }
}
