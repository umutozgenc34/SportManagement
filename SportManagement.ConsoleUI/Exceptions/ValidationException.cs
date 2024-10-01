using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportManagement.ConsoleUI.Exceptions;

public class ValidationException(string massage) : Exception (massage)
{
}
