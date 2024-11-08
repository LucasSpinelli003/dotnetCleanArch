namespace CP3.Domain.Interfaces.Dtos
{
    public interface IBarcoDto
    {
        int? Id { get; set; }
        string Nome { get; set; }
        int Ano { get; set; }
        string Estado { get; set; }
        double  Preco { get; set; }
        void Validate();
    }
}
