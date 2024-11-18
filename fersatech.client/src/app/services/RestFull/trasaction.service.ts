import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UtilConfigService } from '../Utils/util-config.service';
import { Transacciones } from '../../interfaces/transacciones';
import { Observable } from 'rxjs';
import { Detail } from '../../interfaces/detail';

@Injectable({
  providedIn: 'root'
})
export class TrasactionService {

  constructor(private httpClient: HttpClient,
    private utilConfig: UtilConfigService
  ) { }

  GetTransactions(): Observable<Transacciones[]> {
    return this.httpClient.get<Transacciones[]>(this.utilConfig.UrlAPI + "Transacciones");
  }

  GetTransactionDetails(trasactionId: number): Observable<Detail[]> {
    return this.httpClient.get<Detail[]>(this.utilConfig.UrlAPI + "Transacciones/Detalle/"+trasactionId);
  }
}
