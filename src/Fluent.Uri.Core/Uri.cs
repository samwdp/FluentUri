using System;
namespace Fluent.Uri.Core
{
    public class Uri : IAddParameter, ISection, IFragment
    {
        private UriBuilder ub;

        private Uri(string baseUri, bool isSecure)
        {
            if (baseUri.Contains("https://") || baseUri.Contains("http://"))
                ub = new System.UriBuilder(baseUri);
            else
            {
                string uri = isSecure ? $"https://{baseUri}" : $"http://{baseUri}";
                ub = new System.UriBuilder(uri);
            }
        }

        public static Uri Create(string baseUri, bool isSecure) => new Uri(baseUri, isSecure);

        public IFragment AddFragment(string fragment)
        {
            ub.Fragment = fragment;
            return this;
        }

        public IAddParameter AddParameter(string param, string value)
        {
            if (ub.Query.Length > 0)
            {

                ub.Query = ub.Query + $"&{param}={value}";
            }
            else
            {

                ub.Query = $"{param}={value}";
            }
            return this;
        }

        public ISection AddSection(string value)
        {
            ub.Path = ub.Path + value;
            return this;
        }

        public string AsString()
        {
            return ub.Uri.ToString();
        }

        public System.Uri AsUri()
        {
            return ub.Uri;
        }
    }
}
