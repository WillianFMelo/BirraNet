import { Observable, of, pipe } from "rxjs";
import { map } from 'rxjs/operators';
import { Cerveja } from "./cerveja/cerveja.model";
import {HttpClient} from '@angular/common/http'
import { BIRRA_API } from "../app.api";
import { Injectable } from "@angular/core";

@Injectable()
export class CervejaServices {

constructor(private http: HttpClient) {}

  cervejas(): Observable<Cerveja[]> {
    return this.http.get<Cerveja[]>(`${BIRRA_API}/cervejas`);
  }

  cervejaPorId(id: string): Observable<Cerveja> {
    return this.http.get<Cerveja>(`${BIRRA_API}/cerveja/${id}`);
  }
}
