using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;

public class RolVsMaestroDto
{
    public int Id { get; set; }
    public DateOnly FechaCreacion { get; set; }
    public DateOnly FechaModificacion { get; set; }
    public int IdRol { get; set; }
    public int IdMaestro { get; set; }
}
