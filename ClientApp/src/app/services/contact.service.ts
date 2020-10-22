import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
const baseUrl = 'https://localhost:44343/api/MoviesData';
@Injectable({
  providedIn: 'root'
})
export class ContactService {

  constructor(private _http: HttpClient) { }

  getAll(): Observable<any> {
    return this._http.get(baseUrl+"/GetMovies");
  } 

  findMoviesByYear(year): Observable<any> {  
    return this._http.get(`${baseUrl+"/FindMoviesByYear"}?year=${year}`);
  }
}