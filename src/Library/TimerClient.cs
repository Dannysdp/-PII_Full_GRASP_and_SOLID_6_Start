namespace Full_GRASP_And_SOLID
{
    public class TimerClientI : TimerClient
    {
        public Recipe Receta{get;set;}
        public TimerClientI(Recipe recetaRecebida)
        {
            this.Receta = recetaRecebida;
        }
        void TimerClient.TimeOut()
        {
            Receta.cocinado();
        }
    }
}
