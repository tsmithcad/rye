// LoginModel.cs
using System.ComponentModel.DataAnnotations;

public class LoginModel
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public bool RememberMe { get; set; }

    // Function to clear the login form
    public void Clear()
    {
        Email = string.Empty;
        Password = string.Empty;
        RememberMe = false;
    }

    // Function to validate the login model
    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password);
    }

    // Function to perform additional login-related logic (e.g., custom validation)
    public bool PerformLogin()
    {
        // Implement your custom login logic here
        // Return true if login is successful, false otherwise
        return false;
    }
}

