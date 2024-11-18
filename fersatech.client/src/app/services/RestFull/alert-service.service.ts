import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UtilConfigService } from '../Utils/util-config.service';
import { Alert } from '../../interfaces/alert';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AlertServiceService {
  constructor(private httpClient: HttpClient,
  private utilConfig: UtilConfigService) { }

  GetAlerts(TransactionId: number): Observable<Alert[]> {
    return this.httpClient.get<Alert[]>(this.utilConfig.UrlAPI + "Alertas/" + TransactionId);
  }
}
