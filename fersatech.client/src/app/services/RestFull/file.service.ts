import { HttpClient, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UtilConfigService } from '../Utils/util-config.service';
import { ResponseFile } from '../../interfaces/ApiResponse/response-file';

@Injectable({
  providedIn: 'root'
})
export class FileService {

  constructor(private httpClient: HttpClient,
    private utilConfig: UtilConfigService) { }

  /*
  https://localhost:7202/FileManager

  multipart/form-data; boundary=----WebKitFormBoundaryccM53GwiMAceVcnQ

  */
  UploadFile(file: File) {
    let urlApi = `${this.utilConfig.UrlAPI}FileManager`;
    const formData: FormData = new FormData();
    formData.append('file', file);
    const req = new HttpRequest('POST', urlApi, formData, {
      responseType: 'json'
    });

    return this.httpClient.request(req);
  }
}
