using BCrypt.Net;
using System;

namespace HashingPassword
{
    public class HashPassword
    {
        public string Hash(string password)
        {
            try
            {
                return BCrypt.Net.BCrypt.HashPassword(password);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public bool Verify(string password, string hash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hash);
            } catch (BCrypt.Net.BcryptAuthenticationException authEx) 
            {
                Console.WriteLine($"Authentication failed: {authEx.Message}");
                return false;
            }
            catch (SaltParseException saltEx)
            {
                Console.WriteLine($"Invalid salt version: {saltEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
