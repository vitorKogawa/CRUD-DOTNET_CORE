namespace CRUD_usuario.Business
{
    public class Curso
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodigoUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
