namespace EjemploPOO
{
    internal class Program
    {
        //EL VOID ES UN MÉTODO
        static void Main(string[] args)
        {
            //Instancias, esto crea un nuevo objeto
            OperacionesBasicas basicas = new OperacionesBasicas();

            int resultadoSuma = basicas.Sumar(5, 5);
            Console.WriteLine(resultadoSuma);

            int otraSuma = basicas.Sumar(14, 8);
            Console.WriteLine(otraSuma);



        }
    }
}
