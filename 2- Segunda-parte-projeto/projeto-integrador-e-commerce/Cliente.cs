namespace projeto_integrador_e_commerce
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome  { get; set; }

        public Cliente() {}

         public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

   
}
