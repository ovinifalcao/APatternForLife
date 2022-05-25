using Decorator;
using Decorator.Decorators;
using System;
using System.Collections.Generic;
using Xunit;

namespace APatternForLifeTests.Decorator
{
    public class DecoratorTests
    {

        [Theory]
        [MemberData(nameof(TestData))]
        public void ItShouldPrintTheRightMenssageForEachPlatform(NotificatorDecorator decorator, string expectedMessage)
        {
            Assert.Contains(expectedMessage, decorator.SendMessage());
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] {new SlackNotificator(new Notificador()), "Slack"},
                new object[] {new TeamsNotificator(new Notificador()), "Teams"},
                new object[] {new HangoutNotificator(new Notificador()), "Hangout"},
            };

    }
}
