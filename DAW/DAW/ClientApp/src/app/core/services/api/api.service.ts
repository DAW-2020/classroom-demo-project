import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../environments/environment';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private readonly apiUrl = environment.apiEndpointUrl;

  constructor(
    private readonly http: HttpClient
  ) {
  }

  get<T>(path: string, params = {}): Observable<any> {
    return this.http.get<T>(`${this.apiUrl}${path}`,
      {
        params
      });
  }

  put<T>(path: string, body: object = {}): Observable<any> {
    return this.http.put<T>(
      `${this.apiUrl}${path}`, body
    );
  }

  post<T>(path: string, body: object = {}): Observable<any> {
    return this.http.post<T>(
      `${this.apiUrl}${path}`, body
    );
  }

  delete<T>(path): Observable<any> {
    return this.http.delete<T>(
      `${this.apiUrl}${path}`
    );
  }
}
