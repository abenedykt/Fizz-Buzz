using System.Globalization;
using FizzBuzzApplication;
using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Tests
{
    public class FizzBuzzTests
    {
	    private readonly FizzBuzzApp _game;

	    public FizzBuzzTests()
	    {
		    _game = new FizzBuzzApp();
	    }

	    [Fact]
	    public void Test_environment_is_up_and_running()
	    {
		    true.Should().BeTrue();
	    }

	    [Theory]
		[InlineData(3)]
		[InlineData(6)]
		[InlineData(9)]
		[InlineData(12)]
	    public void Numbers_that_divide_3_are_returned_as_fizz(int value)
		{
			_game.PlayOne(value).Should().Be("Fizz");
		}

	    [Theory]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(20)]
		[InlineData(25)]
	    public void Numbers_that_divide_5_are_returned_as_buzz(int value)
		{
			_game.PlayOne(value).Should().Be("Buzz");
		}


	    [Theory]
		[InlineData(15)]
		[InlineData(30)]
		[InlineData(45)]
	    public void Numbers_that_divide_3_and_5_are_returned_as_fizz_buzz(int value)
		{
			_game.PlayOne(value).Should().Be("Fizz Buzz");
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(4)]
		[InlineData(7)]
		public void Others_returns_just_a_number(int value)
		{
			_game.PlayOne(value).Should().Be(value.ToString(CultureInfo.InvariantCulture));
		}

	    [Fact]
	    public void For_range_of_numbers_it_returns_all_consequent_values()
	    {
		    _game.Play(5).Should().Equal(new[]
		    {
				"1",
				"2",
				"Fizz",
				"4",
				"Buzz"
		    });
	    }
    }
}
