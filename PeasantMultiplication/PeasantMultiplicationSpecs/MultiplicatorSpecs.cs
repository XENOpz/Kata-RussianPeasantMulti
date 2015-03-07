namespace PeasantMultiplicationSpecs
{
    using Machine.Fakes;
    using Machine.Specifications;

    using PeasantMultiplication;

    [Subject(typeof(Multiplicator))]
    public class Multiplying_minus3_by_minus15 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(-3, -15);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(-45);
    }

    [Subject(typeof(Multiplicator))]
    public class Multiplying_minus13_by_4 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(-13, 4);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(-52);
    }

    [Subject(typeof(Multiplicator))]
    public class Multiplying_0_by_700 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(0, 700);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(0);
    }

    [Subject(typeof(Multiplicator))]
    public class Multiplying_1_by_1 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(1, 1);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(1);
    }

    [Subject(typeof(Multiplicator))]
    public class Multiplying_1_by_378 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(1, 378);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(378);
    }

    [Subject(typeof(Multiplicator))]
    public class Multiplying_2_by_2 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(2, 2);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(4);
    }

    [Subject(typeof(Multiplicator))]
    public class Multiplying_123_by_789 : WithSubject<Multiplicator>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => result = Subject.Multiply(123, 789);

        private It shouldResultInCorrectAnswer = () => result.ShouldEqual(97047);
    }
}
