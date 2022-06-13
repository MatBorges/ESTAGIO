using System.Data;

namespace escolaNc.Interfaces
{
    public interface IAcessoBD
    {
        public DataTable ExecutaProc(string Procedure);
    }
}
