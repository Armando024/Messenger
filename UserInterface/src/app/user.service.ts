import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {User} from './user'

const httpOptions = {
    headers:new HttpHeaders({'Content-Type':'application/json'})
};

@Injectable({ providedIn: 'root' })
export class UserService{
    private usersUrl='http://localhost:5000/api/Values/1'
    
    constructor(
        private http:HttpClient){ }

    getUsers (): Observable<User[]>{
        return this.http.get<User[]>(this.usersUrl)
        /*.pipe(
                tap(_=>this.log('fetch')),
                catchError(this.handleError('getUsers',[]))
            );
         */
    } 
}


