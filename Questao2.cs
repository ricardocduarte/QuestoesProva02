public void Questao02(string brackets)
        {
			Console.WriteLine("Expressão Balanceada: "  + VerificarBracets(brackets);
        }

public static bool VerificarBracets(string expression)
        {

            Stack<string> stack = new Stack<string>();
            string[] splitExpression = expression.ToCharArray().Select(s => s.ToString()).ToArray();

            if (string.IsNullOrEmpty(expression))
            {
                return false;
            }

            for (int i = 0; i < splitExpression.Length; i++)
            {
                string caracter = splitExpression[i];
                if (caracter.Equals("(") || caracter.Equals("{") || caracter.Equals("["))
                {
                    stack.Push(caracter.ToString());
                    continue;
                }

                string lastCaracter = null;
                switch (caracter)
                {
                    case ")":
                        lastCaracter = (stack.Any() ? stack.Pop() : null);
                        if (string.IsNullOrEmpty(lastCaracter) || lastCaracter.Equals("{") || lastCaracter.Equals("["))
                        {
                            return false;
                        }
                        break;

                    case "}":
                        lastCaracter = (stack.Any() ? stack.Pop() : null);
                        if (string.IsNullOrEmpty(lastCaracter) || lastCaracter.Equals("(") || lastCaracter.Equals("["))
                        {
                            return false;
                        }
                        break;

                    case "]":
                        lastCaracter = (stack.Any() ? stack.Pop() : null);
                        if (string.IsNullOrEmpty(lastCaracter) || lastCaracter.Equals("{") || lastCaracter.Equals("("))
                        {
                            return false;
                        }
                        break;
                }
            }

            return !stack.Any();
        }
