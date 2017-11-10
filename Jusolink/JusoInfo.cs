using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Jusolink
{
    [DataContract]
    public class JusoInfo
    {
        [DataMember]
        public String roadAddr1;
        [DataMember]
        public String roadAddr2;
        [DataMember]
        public String jibunAddr;
        [DataMember]
        public String zipcode;
        [DataMember]
        public String sectionNum;
        [DataMember]
        public String dongCode;
        [DataMember]
        public String streetCode;

        [DataMember]
        public List<String> detailBuildingName;
        [DataMember]
        public List<String> relatedJibun;
    }
}
