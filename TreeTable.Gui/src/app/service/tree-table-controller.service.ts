import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TreeTableControllerService {

  private serverUrl:string="";

  constructor(private httpClient:HttpClient) { 
    this.serverUrl ="https://localhost:7048/api/TreeTable/regions";  
  }

  getTreeTable()
  {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    this.httpClient.get<Node>(this.serverUrl, { headers }).pipe(
      tap((response) => {
        console.log("Entered");
        if (response ) {
        //if (response && response.rooms) {
          console.log("Response rooms:", response);
          // const updatedRooms = [...this._roomsSubkzzkcject.value, ...response.rooms];
        }
      })
    ).subscribe();
  }
}
