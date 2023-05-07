using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace MVCMessageWall.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string Message { get; set; }
    }
}
