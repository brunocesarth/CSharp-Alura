namespace bytebank_GeradorChavePix
{
    /// <summary>
    ///  Classe que gera chaves Pix usando o formato Guid.
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Método que retorna uma chave aleatória de Pix
        /// </summary>
        /// <returns>Retorna uma chave PIX no formato String</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves PIX.
        /// </summary>
        /// <param name="numeroDeChaves"> Quantidade de chaves a serem geradas.</param>
        /// <returns>Lista de strings de chaves Pix.</returns>
        public static List<string> GetChavesPix(int numeroDeChaves)
        {
            if (numeroDeChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroDeChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
