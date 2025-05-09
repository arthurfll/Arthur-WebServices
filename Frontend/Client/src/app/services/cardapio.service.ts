import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardapioService {
  private apiUrl = "http://localhost:5190/api/Pizza/Menu"
  constructor(private http: HttpClient) { }

  getCardapio(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
