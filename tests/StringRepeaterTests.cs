
using AutoFixture;
using FluentAssertions;
using Xunit;

namespace DotnetFluentStringRepeater.Test
{
    public class StringExtensionTests
    {
        public class RepeatShould
        {
            [Fact]
            public void ReturnTheStringBeingActedUpon_TheNumberOfTimesProvidedByTheTimesParameter()
            {
                var fixture = new Fixture();

                var str = fixture.Create<string>();
                var repeatTimes = fixture.Create<int>();
                var expectedOutput = RepeatString(str, repeatTimes);

                var result = StringRepeater.Repeat(str, repeatTimes);

                result.Should().Be(expectedOutput);

                string RepeatString(string str, int times)
                {
                    var result = "";
                    for (int i = 0; i < times; i++) result += str;
                    return result;
                }
            }
        }
    }
}
