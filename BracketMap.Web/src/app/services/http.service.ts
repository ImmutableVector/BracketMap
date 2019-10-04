import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private httpClient: HttpClient) { }

  delete<T>(url: string, params: { [param: string]: string | string[] } = {}): Observable<HttpResponse<T>> {
    return this.httpClient.delete<T>(
      `${environment.apiUrl}${url}`,
      {
        params: new HttpParams({ fromObject: params }),
        observe: 'response'
      }
    );
  }

  get<T>(url: string, params: { [param: string]: string | string[] } = {}): Observable<HttpResponse<T>> {
    return this.httpClient.get<T>(
      `${environment.apiUrl}${url}`,
      {
        params: new HttpParams({ fromObject: params }),
        observe: 'response'
      }
    );
  }

  put<T>(url: string, body: any): Observable<HttpResponse<T>> {
    return this.httpClient.put<T>(
      `${environment.apiUrl}${url}`,
      body,
      { observe: 'response' }
    );
  }

  post<T>(url: string, body: any): Observable<HttpResponse<T>> {
    return this.httpClient.post<T>(
      `${environment.apiUrl}${url}`,
      body,
      { observe: 'response' }
    );
  }
}
