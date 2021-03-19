import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { BIRRA_API } from "../app.api";
import { IMensagem, Mensagem } from "./mensagem.model";

@Injectable()
export class MensagemService {


  constructor(private http: HttpClient) {

  }

  mensagens(): Observable<Mensagem[]>{
    return this.http.get<Mensagem[]>(`${BIRRA_API}/mensagens`);
  }

  enviarMensagem(mensagem: Mensagem): Observable<number> {
    return this.http.post<IMensagem>(`${BIRRA_API}/mensagens`, mensagem)
          .pipe(
            map(msg => msg.id)
          );
  }

  obterPerguntaPorId(id: number): Observable<IMensagem> {
    return this.http.get<IMensagem>(`${BIRRA_API}/perguntas/${id}`);
  }

  obterProximaPergunta(idPerguntaPai: number, respostaPai: string): Observable<IMensagem> {
    return this.http.get<IMensagem>(`${BIRRA_API}/perguntas/buscarproximapergunta/${idPerguntaPai}/${respostaPai}`);
  }

}
