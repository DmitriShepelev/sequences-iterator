using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace SequencesTask
{
    /// <summary>
    /// Generator of the sequences.
    /// </summary>
    public static class SequenceGenerator
    {
        /// <summary>
        /// Generates the Fibonacci sequence.
        /// </summary>
        /// <param name="count">Sequence length.</param>
        /// <returns>The Fibonacci sequence of <paramref name="count"/> first numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="count"/> is less than 1.</exception>
        public static IEnumerable<BigInteger> GetFibonacciNumbers(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Count of elements cannot be less than one.");
            }
            return Fibonacci(count);

            static IEnumerable<BigInteger> Fibonacci(int count)
            {
                BigInteger prev = 0;
                BigInteger curr = 1;
                for (int i = 0; i < count; i++)
                {
                    yield return prev;
                    BigInteger tmp = prev + curr;
                    prev = curr;
                    curr = tmp;
                }
            }

        }



        /// <summary>
        /// Generates the sequence of prime numbers.
        /// </summary>
        /// <param name="count">Sequence length.</param>
        /// <returns>A sequence of <paramref name="count"/> first prime numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="count"/> is less than 1.</exception>
        public static IEnumerable<int> GetPrimeNumbers(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Count of elements cannot be less than one.");
            }
            return Prime(count);

            static IEnumerable<int> Prime(int count)
            {
                int found = 0;
                for (int i = 2; found < count; i++)
                {
                    int limit = (int)Math.Sqrt(i);
                    bool IsPrime = true;
                    for (int j = 2; j <= limit; j++)
                    {
                        if (i % j == 0)
                        {
                            IsPrime = false;
                            break;
                        }
                    }
                    if (IsPrime)
                    {
                        yield return i;
                        found++;
                    }
                }

            }
        }

    }
}