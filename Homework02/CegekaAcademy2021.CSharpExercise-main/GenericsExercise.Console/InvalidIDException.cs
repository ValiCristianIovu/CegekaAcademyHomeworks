using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console
{
    class InvalidIDException:Exception
    {
        public InvalidIDException()
        {
        }
        public InvalidIDException(string Id)
            : base(String.Format("Invalid ID ! The Id cannot be null!",Id))
        {
        }
        public InvalidIDException(int idLength)
           : base(String.Format("Invalid ID ! The Id  cannot have more than 10 characters, in this case we have {0} characters!", idLength))
        {
        }
        public InvalidIDException(char c)
            : base(String.Format("Invalid ID ! The Id should not contain the character : {0}", c))
        {
        }

        /*
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        */
    }
}
