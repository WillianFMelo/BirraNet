import { Component, Input, OnInit, Output } from '@angular/core';
import { Cerveja } from './cerveja.model';

@Component({
  selector: 'app-cerveja',
  templateUrl: './cerveja.component.html',
})
export class CervejaComponent implements OnInit {

  @Input() cerveja: Cerveja;

  constructor() { }

  ngOnInit() {
  }

}
