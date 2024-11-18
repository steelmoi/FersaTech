import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class UtilConfigService {
  public UrlAPI: string = environment.URL_API
  constructor() { }
}
