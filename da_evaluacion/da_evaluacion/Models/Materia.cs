namespace da_evaluacion.Models
{
    public class Materia
    {
        public int materiaId { get; set; }
        public string? materiaName { get; set; }
        public DateTime fechaInscripcion { get; set; }

        public int dvId { get; set; }
        public Vizcarra Vizcarra { get; set; }

    }
}
