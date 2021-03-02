using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RMotownFestival.Api.Domain
{
    public class Festival
    {
        [Key]
        public int Id { get; set; }
        public Schedule LineUp { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Stage> Stages { get; set; }

        public Festival()
        {
            LineUp = new Schedule();
            Artists = Enumerable.Empty<Artist>();
            Stages = Enumerable.Empty<Stage>();
        }
    }
}
