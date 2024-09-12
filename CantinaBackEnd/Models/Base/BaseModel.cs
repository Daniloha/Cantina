using System.ComponentModel.DataAnnotations.Schema;

namespace CantinaBackEnd.Models.Base
{
    public class BaseModel
    {
        [Column("id")]
        public long BaseId { get; set; }

    }
}
