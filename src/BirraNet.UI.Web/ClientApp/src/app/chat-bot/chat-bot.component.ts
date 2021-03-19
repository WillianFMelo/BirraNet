import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IMensagem, Mensagem } from '../mensagem/mensagem.model';
import { MensagemService } from '../mensagem/mensagem.service';
import { IPergunta } from './pergunta.model';

@Component({
  selector: 'app-chat-bot',
  templateUrl: './chat-bot.component.html',
})
export class ChatBotComponent implements OnInit {

  mensagens: IMensagem[];
  chatForm: FormGroup;
  chatId: number;
  perguntaAtual: IMensagem;

  constructor(private mensagemServices: MensagemService,
              private fb: FormBuilder) { }

  ngOnInit() {
    this.mensagens = [];
    this.chatId = Math.random();
    this.obterMensagemInicial();

    this.chatForm = this.fb.group({
      mensagem: this.fb.control('', [Validators.required])
    });
  }

  enviarMensagem(mensagem: IMensagem) {

    if(!this.temPermissao()) { return; }

    if (mensagem.mensagem) {
      this.chatForm.reset();
      const mensagemNova = this.criarMensagem(mensagem.mensagem);
      this.mensagens.push(mensagemNova);

      this.obterProximaPergunta(mensagemNova.mensagem);
      // this.mensagemServices.enviarMensagem(mensagemNova);
      // .subscribe((mensagemId: number) => {
      //   console.log(mensagemId);
      // });
    }
  }

   criarMensagem(mensagem: string): IMensagem{
      const mensagemNova = new Mensagem();
      mensagemNova.mensagem = mensagem;
      mensagemNova.idChat = this.chatId;
      mensagemNova.ehPergunta = false;
      mensagemNova.id = Math.random();

      return mensagemNova;
   }

   obterUltimaPergunta(): IMensagem {
      const perguntas = this.mensagens.length === 0
      ? null
      : this.mensagens.filter(msg => msg.ehPergunta);
      const pergunta = perguntas[perguntas.length - 1];
      return pergunta as IMensagem;
   }

   obterMensagemInicial() {
      this.mensagemServices.obterPerguntaPorId(1)
        .subscribe(msg => {
          this.perguntaAtual = msg;
          this.mensagens.push(msg);
        });
   }

   obterProximaPergunta(resposta: string) {
     const mensagem = this.obterUltimaPergunta();

      this.mensagemServices.obterProximaPergunta(mensagem.id, resposta)
      .subscribe(pergunta => {
        if (pergunta != null) {
          this.perguntaAtual = pergunta;
          this.mensagens.push(pergunta);
        }
      });
   }

   temPermissao(): boolean {
     return !this.perguntaAtual || !this.perguntaAtual.ehSugestao;
   }

   enviarMensagemPorEnter(evento) {
     if(evento.keyCode === 13) {
       const mensagem = this.chatForm.value as IMensagem;
       this.enviarMensagem(mensagem);
     }
   }

}
