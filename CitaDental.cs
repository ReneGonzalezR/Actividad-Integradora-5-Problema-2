namespace Actividad_Integradora_5_Problema_2
{
    class CitaDental:ICitaDental
    {
        public CitaDental(double valor, int extraccion, int limpieza, int endodoncia, int radiologia, int puente)
        {
            SumaConsultorio = valor;
            Extracciones = extraccion;
            Limpieza = limpieza;
            Endodoncia = endodoncia;
            Radiologia = radiologia;
            PuenteDental = puente;
        }
        public int Extracciones { get; set; }
        public int Limpieza { get; set; }
        public int Endodoncia { get; set; }
        public int Radiologia { get; set; }
        public int PuenteDental { get; set; }


        public double SumaConsultorio { get; set; }
        public void CitaExtracciones()
        {
            SumaConsultorio = SumaConsultorio + 350;
            Extracciones++;
        }
        public void CitaLimpieza()
        {
            SumaConsultorio = SumaConsultorio + 200;
            Limpieza++;
        }
        public void CitaEndodoncia()
        {
            SumaConsultorio = SumaConsultorio + 280;
            Endodoncia++;
        }
        public void CitaRadiologia()
        {
            SumaConsultorio = SumaConsultorio + 100;
            Radiologia++;
        }
        public void CitaPuenteDental()
        {
            SumaConsultorio = SumaConsultorio + 420;
            PuenteDental++;
        }
        public double getSumaConsultorio()
        {
            return SumaConsultorio;
        }
    }
}
