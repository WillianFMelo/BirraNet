import { Component, OnInit } from '@angular/core';
import { CervejaServices } from './cerveja.service';
import { Cerveja } from './cerveja/cerveja.model';

@Component({
  selector: 'app-cervejas',
  templateUrl: './cervejas.component.html',
})
export class CervejasComponent implements OnInit {

  cervejas: Cerveja[];

  constructor(private cervejaServices: CervejaServices ) { }

  ngOnInit() {
    this.cervejaServices.cervejas()
    .subscribe(res => this.cervejas = res);
  }

}
