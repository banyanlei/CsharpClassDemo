


using System.Net.NetworkInformation;
using System.Net;


class Program
{

    static void Main()
    {
        _dbRow rowData = new _dbRow();
        rowData._dbDataList = new List<string>();

        // Formats:
        // /RYT120148_1    char "0x451:paCtrl_1.0.0 0x18:paCtrl_2.0.0"
        // /RYT120120_5    char ["0x44", "rxCtrl_1.0.0"], ["0x18", "rxCtrl_2.0.0"], ["0x28", "rxCtrl_3.0.0"]
        // Quick and dirty solution to add first format. TODO: Rewirte wholw ComponentConfigId process.
        string row = "/filterType/SUPPLIERS/X61     char   \"ACE\"                   /* 2000050859    DONGGUAN ACE TECHNOLOGIES CO., LTD               */";
        string[] substrings = row.Split(new[] {" "}, 3, StringSplitOptions.RemoveEmptyEntries);
        rowData.Parameter = substrings[0].TrimStart('/').Trim();
        rowData.DataType = substrings[1].Trim();
    }



    public struct _dbRow
    {
        // Fields
        private string _parameter;
        private string _dataType;
        /// <summary>
        /// List of DB data.
        /// </summary>
        public List<string> _dbDataList;

        /// <summary>
        /// Parameter.
        /// </summary>
        public string Parameter
        {
            get
            {
                return _parameter;
            }
            set
            {
                _parameter = value;
            }
        }

        /// <summary>
        /// Data type.
        /// </summary>
        public string DataType
        {
            get
            {
                return _dataType;
            }
            set
            {
                _dataType = value;
            }
        }

        /// <summary>
        /// List with DB entries.
        /// </summary>
        public List<string> DbDataList
        {
            get
            {
                return _dbDataList;
            }
        }
        /// <summary>
        /// The row comment excluding start and stop comment /* and */ (supplier information is listed there for filters).
        /// </summary>
        public string Comment
        {
            get;
            set;
        }
    }
}