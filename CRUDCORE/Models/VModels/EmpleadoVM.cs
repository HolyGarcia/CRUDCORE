using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDCORE.Models.VModels
{
    public class EmpleadoVM
    {
        public Empleado oEmpleado { get; set; }
        public List<SelectListItem> oListaCargo { get; set; }
    }
}
