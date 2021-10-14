using FluentAssertions;
using Xunit;

namespace Fluent.Uri.Tests
{
    public class StandardTests
    {
        [Fact]
        public void StringTest()
        {
            string output = Standard.Uri.Create("baseuri", true).AsString();
            output.Should().NotBeNull();
            output.Should().Be("https://baseuri/");

        }

        [Fact]
        public void UriTest()
        {
            System.Uri output = Standard.Uri.Create("baseuri", true).AsUri();
            output.Should().NotBeNull();
            output.Should().Be(new System.Uri("https://baseuri"));
        }

        [Fact]
        public void AddSection()
        {
            string output = Standard.Uri.Create("baseuri", true)
                .AddSection("testsection")
                .AsString();
            output.Should().NotBeNull();
            output.Should().Be("https://baseuri/testsection");
        }

        [Fact]
        public void AddParameter()
        {
            string output = Standard.Uri.Create("baseuri/a", true)
                .AddParameter("param", "value").AsString();
            output.Should().NotBeNull();
            output.Should().Be("https://baseuri/a?param=value");
        }

        [Fact]
        public void AddMultipleParameter()
        {
            string output = Standard.Uri.Create("baseuri", true)
                .AddSection("testsection")
                .AddParameter("param", "value")
                .AddParameter("param2", "value2").AsString();
            output.Should().NotBeNull();
            output.Should().Be("https://baseuri/testsection?param=value&param2=value2");
        }

        [Fact]
        public void AddFragment()
        {
            string output = Standard.Uri.Create("baseuri", true)
               .AddSection("testsection")
               .AddParameter("param", "value")
               .AddParameter("param2", "value2")
               .AddFragment("frag")
               .AsString();

            output.Should().NotBeNull();
            output.Should().Be("https://baseuri/testsection?param=value&param2=value2#frag");
        }
    }
}
