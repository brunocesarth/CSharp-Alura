namespace bytebank_GeradorChavePix
{
    public static class GeradorPix
    {
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        public static List<object> GetList()
        {
            return new List<object>();
        }

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
