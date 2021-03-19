export interface IMensagem {
  id: number;
  mensagem: string;
  ordem: number;
  idPerguntaPai: number;
  respostaPai: string;
  idChat: number;
  ehPergunta: boolean;
  ehSugestao: boolean;
}

export class Mensagem implements IMensagem {
  id: number;
  mensagem: string;
  ordem: number;
  idPerguntaPai: number;
  respostaPai: string;
  idChat: number;
  ehPergunta: boolean;
  ehSugestao: boolean;
}
