using SistemasWeb2.Data;

namespace SistemasWeb2.Servicios
{
    public class LCategorias
    {
        private ApplicationDbContext context;

        public LCategorias(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
