namespace Fluent.Uri.Standard
{
    public interface ISection : IOutput
    {
        ISection AddSection(string value);
        IAddParameter AddParameter(string param, string value);
    }

    public interface IAddParameter : IOutput
    {
        IAddParameter AddParameter(string param, string value);
        IFragment AddFragment(string fragment);
    }

    public interface IFragment : IOutput
    {

    }

    public interface IOutput
    {
        string AsString();
        System.Uri AsUri();
    }
}
