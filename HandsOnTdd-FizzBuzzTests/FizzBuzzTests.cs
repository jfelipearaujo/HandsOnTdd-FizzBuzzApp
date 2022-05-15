using FluentAssertions;

using HandsOnTdd_FizzBuzzApp;

using Xunit;

namespace HandsOnTdd_FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Deve_Validar_Numero_Fizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            var number = 3;

            // Act
            var result = fizzBuzz.IsFizz(number);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Deve_Validar_Numero_Buzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            var number = 5;

            // Act
            var result = fizzBuzz.IsBuzz(number);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Deve_Validar_Numero_FizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            var number = 15;

            // Act
            var result = fizzBuzz.IsFizzBuzz(number);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Deve_Imprimir_Numeros_FizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            var expectedResult = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";

            // Act
            var result = fizzBuzz.PrintFizzBuzz();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
