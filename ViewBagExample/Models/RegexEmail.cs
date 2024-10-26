using System.ComponentModel.DataAnnotations;

namespace ViewBagExample.Models
{
    public class RegexEmail
    {
        private const string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        
        [RegularExpression(pattern)]
        public required string Email { get; set; }
    }
}
