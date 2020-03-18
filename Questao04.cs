
public void Questao04(int[] amostra)
        {
            Console.WriteLine("Volume máximo: "  + CaluculaVolume(amostra);
        }


public static int CaluculaVolume(int[] chuva)
        {
            int n = chuva.Length;
            int[] maisEsquerda = new int[n], maisDireita = new int[n];

            int maiorEsquerdoAtual = 0;
            for (int i = 0; i < n; i++)
            {
                maisEsquerda[i] = maiorEsquerdoAtual;
                if (chuva[i] > maiorEsquerdoAtual) maiorEsquerdoAtual = chuva[i];
            }

            int maiorDireitodoAtual = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                maisDireita[i] = maiorDireitodoAtual;
                if (chuva[i] > maiorDireitodoAtual) maiorDireitodoAtual = chuva[i];
            }

            // totais
            int volume = 0;
            for (int i = 0; i < n; i++)
            {
                volume += Math.Max(0, Math.Min(maisEsquerda[i], maisDireita[i]) - chuva[i]);
            }
            return volume;
        }
