using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Net;
using Linkhub;

namespace Jusolink
{
    public class JusolinkService
    {
        private const string ServiceID = "JUSOLINK";
        private const String ServiceURL = "https://juso.linkhub.co.kr";
        private const String APIVersion = "1.0";
        private const String CRLF = "\r\n";

        private Token token;
        private Authority _LinkhubAuth;
        private List<String> _Scopes = new List<string>();
        
        public JusolinkService(String LinkID, String SecretKey)
        {
            _LinkhubAuth = new Authority(LinkID, SecretKey);
            _Scopes.Add("200");
        }
              
        public Double GetBalance()
        {
            try
            {
                return _LinkhubAuth.getPartnerBalance(getSession_Token(), ServiceID);
            }
            catch (LinkhubException le)
            {
                throw new JusolinkException(le);
            }
        }

        public Single GetUnitCost()
        {
            UnitCostResponse response = httpget<UnitCostResponse>("/Search/UnitCost", null, null);

            return response.unitCost;
        }

        public SearchResult search(String index, int? PageNum, int? PerPage, bool noSuggest, bool noDiff)
        {
            String url;
            if (PerPage != null)
            {
                if (PerPage < 0) PerPage = 20;
            }

            if (index == null)
            {
                throw new JusolinkException(99999999, "검색어가 입력되지 않았습니다");
            }
            url = "/Search?Searches=" + index;

            if (PageNum != null)
            {
                url = url + "&PageNum=" + PageNum;
            }

            if (PerPage != null)
            {
                url = url + "&PerPage=" + PerPage;
            }

            if (noSuggest)
            {
                url = url + "&noSuggest=true";
            }

            if (noDiff)
            {
                url = url + "&noDifferential=true";
            }

            SearchResult response = httpget<SearchResult>(url, null, null);

            return response;
        }

       


        #region protected

        protected String toJsonString(Object graph)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(graph.GetType());
                ser.WriteObject(ms, graph);
                ms.Seek(0, SeekOrigin.Begin);
                return new StreamReader(ms).ReadToEnd();
            }
        }
        protected T fromJson<T>(Stream jsonStream)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            return (T)ser.ReadObject(jsonStream);
        }

        private String getSession_Token()
        {
            Token _token = null;

            if (token != null)
            {
                _token = token;
            }

            bool expired = true;
            if (_token != null)
            {
                DateTime expiration = DateTime.Parse(_token.expiration);
                DateTime now = DateTime.Parse(_LinkhubAuth.getTime());
                expired = expiration < now;
            }

            if (expired)
            {
                try
                {
                    _token = _LinkhubAuth.getToken(ServiceID, null, _Scopes);

                    
                    token = _token;
                }
                catch (LinkhubException le)
                {
                    throw new JusolinkException(le);
                }
            }

            return _token.session_token;
        }

        protected T httpget<T>(String url, String CorpNum, String UserID)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ServiceURL + url);

            String bearerToken = getSession_Token();
            request.Headers.Add("Authorization", "Bearer" + " " + bearerToken);
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            request.Headers.Add("x-api-version", APIVersion);

            request.Method = "GET";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stReadData = response.GetResponseStream())
                    {
                        return fromJson<T>(stReadData);
                    }
                }
            }
            catch (Exception we)
            {
                if (we is WebException && ((WebException)we).Response != null)
                {
                    using (Stream stReadData = ((WebException)we).Response.GetResponseStream())
                    {
                        Response t = fromJson<Response>(stReadData);
                        throw new JusolinkException(t.code, t.message);
                    }
                }
                throw new JusolinkException(-99999999, we.Message);
            }

        }

        #endregion

        [DataContract]
        public class UnitCostResponse
        {
            [DataMember]
            public Single unitCost;
        }
    }
}
