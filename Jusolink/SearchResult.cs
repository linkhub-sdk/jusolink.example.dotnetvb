using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Jusolink
{
    [DataContract]
    public class SearchResult
    {
        [DataMember]
        public String searches;
        [DataMember]
        public String suggest;
        [DataMember]
        public int? numFound;
        [DataMember]
        public int? listSize;
        [DataMember]
        public int? totalPage;
        [DataMember]
        public int? page;
        [DataMember]
        public bool? chargeYN;
        [DataMember]
        public SidoCount sidoCount;
        [DataMember]
        public List<String> deletedWord;
        [DataMember]
        public List<JusoInfo> juso;
    }
}
