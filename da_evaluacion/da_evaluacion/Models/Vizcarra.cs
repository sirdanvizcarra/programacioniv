﻿namespace da_evaluacion.Models
{
    public class Vizcarra
    {

        public int daId { get; set; }
        public string? dvName { get; set; }
        public int dvEdad { get; set; }
        public decimal dvEstatura { get; set; }
        public bool dvActivo { get; set; }
        
        public List<Materia>? Materia { get; set; }


    }

}
