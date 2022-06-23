using InternalAPI.Content;
using System;
using System.Linq;

namespace InternalAPI.Content
{
    public class Token
    {
        public string strToken { get; set; }
        public bool bError { get; set; }
        public string Descripcion { get; set; }

        public void GenerateToken()
        {
            try
            {
                Utilities ut = new Utilities();

                byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                byte[] key = Guid.NewGuid().ToByteArray();
                strToken = Convert.ToBase64String(time.Concat(key).ToArray());                
                strToken = ut.CleanInput(strToken);
                bError = false;
                Descripcion = "Token Generated";

            }
            catch (Exception)
            {
                bError = true;
                Descripcion = "Error in Token Generated";
                strToken = String.Empty;
            }
        }

    }
}
