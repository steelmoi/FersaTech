import { Injectable } from '@angular/core';
import { UtilConfigService } from '../Utils/util-config.service';
import { HttpClient } from '@angular/common/http';
import { Incident } from '../../interfaces/incident';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IncidentServiceService {

  constructor(private httpClient: HttpClient,
    private utilConfig: UtilConfigService) { }

  GetIncidents(TransactionId: number): Observable<Incident[]> {
    return this.httpClient.get<Incident[]>(this.utilConfig.UrlAPI + "Incidencias/" + TransactionId);
  }
}
