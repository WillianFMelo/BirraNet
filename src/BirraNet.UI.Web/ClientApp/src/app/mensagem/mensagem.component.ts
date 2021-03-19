import { Component, Input, OnInit } from '@angular/core';
import { IMensagem } from './mensagem.model';

@Component({
  selector: 'app-mensagem',
  templateUrl: './mensagem.component.html',
})
export class MensagemComponent implements OnInit {

  @Input() mensagem: IMensagem;

  constructor() { }

  ngOnInit() {
  }

}
