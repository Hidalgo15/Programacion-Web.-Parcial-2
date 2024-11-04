//Emmanuel Perez Ramirez Mat: 2023-1003

using Microsoft.EntityFrameworkCore;
public class Servicio{
    private readonly visitaContext context;
    public Servicio(visitaContext context)
    {
        this.context = context;
    }
    public async Task AgregarVisitaAsync (Visita visita)
    {
        await context.AddAsync(visita);
        await context.SaveChangesAsync();
    }
}