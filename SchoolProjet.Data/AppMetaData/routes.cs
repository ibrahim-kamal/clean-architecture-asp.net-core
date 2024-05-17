using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjet.Data.AppMetaData
{
    public static class routes
    {

        public const string ROOT = "Api/";
        public const string VERSION = "V1/";
        public const string BASEPATH = ROOT+VERSION;

        public class studentRoute {

            public const string PERFIX = "student/";
            public const string LIST = PERFIX+"list";
            public const string profile = PERFIX+"profile/{id}";
            public const string CREATE = PERFIX+"create";
        }


    }
}
